using Org.BouncyCastle.Asn1.Cmp;
using Sarasavi_Library_MS.DTO;
using Sarasavi_Library_MS.Entity;
using Sarasavi_Library_MS.Service;
using Sarasavi_Library_MS.Service.ServiceImpl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Sarasavi_Library_MS.Forms
{
    public partial class UserForm1 : Form
    {
        //private readonly IUserService _userService = new UserServiceImpl();
        //private string _selectedUserId;

        // Accessing via the Service Implementation
        private readonly IUserService _userService = new UserServiceImpl();
        private string _selectedUserId = null;
        private bool _isClearing = false;

        public UserForm1()
        {
            InitializeComponent();
            //LoadUserData();
            LoadUsers();
            ClearForm(); // Start with a clean slate
        }

        private void LoadUserData()
        {
            try
            {
                // Temporarily disable event triggering to avoid loops
                _isClearing = true;

                List<UserDTO> users = _userService.GetAllUsers();
                dgvUserTable.DataSource = null;
                dgvUserTable.DataSource = users;

                // Fix: Ensure no row is auto-selected so the form stays in "Save Mode"
                dgvUserTable.ClearSelection();
                _selectedUserId = null;

                _isClearing = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _isClearing = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Fix: Better validation to handle empty strings and placeholder text
            if (string.IsNullOrWhiteSpace(txtName.Text) || txtName.Text == "Enter Full Name")
            {
                MessageBox.Show("Full name is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                UserDTO dto = new UserDTO
                {
                    FullName = txtName.Text.Trim(),
                    NIC = txtNIC.Text.Trim(),
                    TelephoneNo = txtTelNo.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    Sex = cmbSex.Text,
                    UserType = cmbType.Text
                };

                if (_userService.RegisterUser(dto))
                {
                    MessageBox.Show("User Registered successfully!");
                    ClearForm();
                    LoadUserData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            // Fix: Use the flag to prevent SelectionChanged from firing
            _isClearing = true;

            _selectedUserId = null;
            lblUserID.Text = "Auto-generated ID";

            txtName.Text = "";
            txtNIC.Text = "";
            txtTelNo.Text = "";
            txtAddress.Text = "";

            // Fix: Explicitly clearing custom ComboBoxes
            cmbSex.SelectedIndex = -1;
            cmbSex.Text = "";
            cmbType.SelectedIndex = -1;
            cmbType.Text = "";

            dgvUserTable.ClearSelection();
            SetFormMode(true); // Return to Save mode

            _isClearing = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedUserId)) return;

            UserDTO dto = new UserDTO
            {
                UserID = _selectedUserId,
                FullName = txtName.Text.Trim(),
                NIC = txtNIC.Text.Trim(),
                TelephoneNo = txtTelNo.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Sex = cmbSex.Text,
                UserType = cmbType.Text
            };

            if (_userService.UpdateUser(dto))
            {
                MessageBox.Show("User updated successfully!");
                ClearForm();
                LoadUserData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedUserId)) return;

            if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_userService.DeleteUser(_selectedUserId))
                {
                    ClearForm();
                    LoadUserData();
                }
            }
        }

        private void LoadUsers()
        {
            try
            {
                var users = _userService.GetAllUsers();
                dgvUserTable.DataSource = null;
                dgvUserTable.DataSource = users;

                if (dgvUserTable.Columns.Count > 0)
                {
                    SetColumnHeader("UserID", "User ID");
                    SetColumnHeader("FullName", "Full Name");
                    SetColumnHeader("Sex", "Sex");
                    SetColumnHeader("NIC", "NIC");
                    SetColumnHeader("TelephoneNo", "Telephone");
                    SetColumnHeader("Address", "Address");
                    SetColumnHeader("UserType", "User Type");
                    HideColumn("ActiveLoans");
                }
            }
            catch { }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            { ShowStatus("Full Name is required.", Color.OrangeRed); return false; }

            if (string.IsNullOrWhiteSpace(txtNIC.Text))
            { ShowStatus("NIC is required.", Color.OrangeRed); return false; }

            return true;
        }

        private UserDTO BuildDTOFromForm() => new UserDTO
        {
            FullName = txtName.Text.Trim(),
            Sex = cmbSex.SelectedItem?.ToString() ?? "Male",
            NIC = txtNIC.Text.Trim(),
            TelephoneNo = txtTelNo.Text.Trim(),
            Address = txtAddress.Text.Trim(),
            UserType = cmbType.SelectedItem?.ToString() ?? "Member"
        };

        private void SetFormMode(bool isSaveMode)
        {
            btnSave.Enabled = isSaveMode;
            btnUpdate.Enabled = !isSaveMode;
            btnDelete.Enabled = !isSaveMode;
        }

        private void ShowStatus(string msg, Color color)
        {
            lblStatus.Text = msg;
            lblStatus.ForeColor = color;
        }

        private void SetColumnHeader(string name, string header)
        {
            if (dgvUserTable.Columns.Contains(name))
                dgvUserTable.Columns[name].HeaderText = header;
        }

        private void HideColumn(string name)
        {
            if (dgvUserTable.Columns.Contains(name))
                dgvUserTable.Columns[name].Visible = false;
        }

        private void dgvUserTable_SelectionChanged(object sender, EventArgs e)
        {
            // Fix: Prevent loading data back into fields while we are trying to clear them
            if (_isClearing) return;

            if (dgvUserTable.SelectedRows.Count > 0)
            {
                var row = dgvUserTable.SelectedRows[0];

                // Ensure the column name matches your DTO property exactly
                _selectedUserId = row.Cells["UserID"].Value?.ToString();

                if (!string.IsNullOrEmpty(_selectedUserId))
                {
                    UserDTO user = _userService.GetUserById(_selectedUserId);
                    if (user != null)
                    {
                        // Load data to TextBoxes
                        lblUserID.Text = user.UserID;
                        txtName.Text = user.FullName;
                        txtNIC.Text = user.NIC;
                        txtTelNo.Text = user.TelephoneNo;
                        txtAddress.Text = user.Address;

                        // Fix: Using .Text for custom SATAComboBoxes
                        cmbSex.Text = user.Sex;
                        cmbType.Text = user.UserType;

                        SetFormMode(false); // Update/Delete mode
                    }
                }
            }
        }
    }
}
