using Sarasavi_Library_MS.DTO;
using Sarasavi_Library_MS.Service;
using Sarasavi_Library_MS.Service.ServiceImpl;
using System;
using System.Windows.Forms;

namespace Sarasavi_Library_MS.Forms
{
    public partial class UserForm : Form
    {
        private readonly IUserService userService = new UserServiceImpl();
        private string selectedUserId = null;

        public UserForm()
        {
            InitializeComponent();

            // Initialization
            SetupEvents();
            LoadUsers();
            ClearForm();
        }

        private void SetupEvents()
        {
            // Detach first to prevent double-subscription if already set in Designer
            dgvUserTable.CellClick -= dgvUserTable_CellClick;
            dgvUserTable.CellClick += dgvUserTable_CellClick;

            btnSave.Click -= btnSave_Click;
            btnSave.Click += btnSave_Click;

            btnUpdate.Click -= btnUpdate_Click;
            btnUpdate.Click += btnUpdate_Click;

            btnDelete.Click -= btnDelete_Click;
            btnDelete.Click += btnDelete_Click;

            btnClear.Click -= btnClear_Click;
            btnClear.Click += btnClear_Click;
        }

        private void LoadUsers()
        {
            try
            {
                var users = userService.GetAllUsers();
                dgvUserTable.DataSource = null;
                dgvUserTable.DataSource = users;

                if (dgvUserTable.Columns.Count > 0)
                {
                    ConfigureGridColumns();
                }

                // Ensure no row is highlighted after data bind
                dgvUserTable.ClearSelection();
                if (dgvUserTable.CurrentCell != null) dgvUserTable.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to load user data from the database.\n\n" +
                    $"Error: {ex.Message}",
                    "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUserTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvUserTable.Rows[e.RowIndex];
            selectedUserId = row.Cells["UserID"].Value?.ToString();

            if (string.IsNullOrEmpty(selectedUserId)) return;

            var user = userService.GetUserById(selectedUserId);
            if (user != null)
            {
                PopulateFields(user);
                SetFormMode(isEditing: true);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation happens ONCE here
            if (!ValidateInputs()) return;

            var dto = BuildDTOFromForm();

            try
            {
                if (userService.RegisterUser(dto))
                {
                    MessageBox.Show(
                        $"✓ User Registered Successfully!\n\n" +
                        $"User ID: {dto.UserID}\n" +
                        $"Name: {dto.FullName}\n" +
                        $"Default Password: {dto.NIC}",
                        "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset UI clears the form and reloads the table
                    ResetUI();
                }
                else
                {
                    MessageBox.Show("Failed to register the user.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred:\n\n{ex.Message}", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedUserId)) return;
            if (!ValidateInputs()) return;

            var dto = BuildDTOFromForm();
            dto.UserID = selectedUserId;

            try
            {
                if (userService.UpdateUser(dto))
                {
                    MessageBox.Show(
                        $"✓ User Updated Successfully!\n\nID: {dto.UserID}",
                        "User Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetUI();
                }
                else
                {
                    MessageBox.Show(
                        "Failed to update the user. Please try again.",
                        "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                /*
                MessageBox.Show(
                    $"An error occurred during update:\n\n{ex.Message}",
                    "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                */
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedUserId)) return;

            /*
            var confirm = MessageBox.Show(
                $"⚠ Are you sure you want to delete User ID: {_selectedUserId}?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            */

            var confirm = MessageBox.Show(
                $"⚠ Are you sure you want to delete this user?\n\n" +
                $"User ID: {selectedUserId}\n\n" +
                $"This action cannot be undone and will remove all associated data.",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                if (userService.DeleteUser(selectedUserId))
                {
                    //MessageBox.Show("✓ User Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(
                        $"✓ User Deleted Successfully!\n\n" +
                        $"User ID: {selectedUserId} has been removed from the system.",
                        "User Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    ResetUI();
                }
                else
                {
                    MessageBox.Show(
                        "Failed to delete the user. Please try again.",
                        "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Deletion Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                /*
                MessageBox.Show(
                    $"An error occurred during deletion:\n\n{ex.Message}",
                    "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                */
            }
        }

        private void ResetUI()
        {
            ClearForm(); // This sets isEditing to false
            LoadUsers(); // This refreshes the table
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtNIC.Clear();
            txtTelNo.Clear();
            txtAddress.Clear();

            if (cmbSex.Items.Count > 0) cmbSex.SelectedIndex = 0;
            if (cmbType.Items.Count > 0) cmbType.SelectedIndex = 0;

            selectedUserId = null;

            dgvUserTable.ClearSelection();
            if (dgvUserTable.CurrentCell != null) dgvUserTable.CurrentCell = null;

            SetFormMode(isEditing: false);
        }

        private void PopulateFields(UserDTO user)
        {
            txtName.Text = user.FullName;
            txtNIC.Text = user.NIC;
            txtTelNo.Text = user.TelephoneNo;
            txtAddress.Text = user.Address;
            cmbSex.Text = user.Sex;
            cmbType.Text = user.UserType;
        }

        private void SetFormMode(bool isEditing)
        {
            btnSave.Enabled = !isEditing;
            btnUpdate.Enabled = isEditing;
            btnDelete.Enabled = isEditing;

            this.Text = isEditing ? "User Management (Editing Mode)" : "User Management (Registration Mode)";
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show(
                    "Full Name is a required field.\n\nPlease enter the user's full name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNIC.Text))
            {
                MessageBox.Show(
                    "NIC (National ID) is a required field.\n\nPlease enter the user's NIC number.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNIC.Focus();
                return false;
            }
            return true;
        }

        private UserDTO BuildDTOFromForm() => new UserDTO
        {
            FullName = txtName.Text.Trim(),
            Sex = cmbSex.SelectedItem?.ToString(),
            NIC = txtNIC.Text.Trim(),
            TelephoneNo = txtTelNo.Text.Trim(),
            Address = txtAddress.Text.Trim(),
            UserType = cmbType.SelectedItem?.ToString()
        };

        private void ConfigureGridColumns()
        {
            SetColumnHeader("UserID", "User ID");
            SetColumnHeader("FullName", "Full Name");
            SetColumnHeader("NIC", "NIC Number");
            HideColumn("ActiveLoans");
            HideColumn("UserName");
            HideColumn("Password");
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearForm();

        private void SetColumnHeader(string name, string header)
        {
            if (dgvUserTable.Columns.Contains(name)) dgvUserTable.Columns[name].HeaderText = header;
        }

        private void HideColumn(string name)
        {
            if (dgvUserTable.Columns.Contains(name)) dgvUserTable.Columns[name].Visible = false;
        }
    }
}