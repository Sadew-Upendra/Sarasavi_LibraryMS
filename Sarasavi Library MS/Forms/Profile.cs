using Sarasavi_Library_MS.Entity;
using Sarasavi_Library_MS.Service;
using Sarasavi_Library_MS.Service.ServiceImpl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarasavi_Library_MS.Forms
{
    public partial class Profile : Form
    {
        private readonly IUserService _userService = new UserServiceImpl();
        private readonly string _currentUserId;

        public Profile(string userId)
        {
            InitializeComponent();
            this._currentUserId = userId;
            SetupUI();
            LoadUserDetails();
        }

        private void SetupUI()
        {
            pnlChangePassword.Visible = false;
        }

        private void LoadUserDetails()
        {
            try
            {
                var user = _userService.GetUserById(_currentUserId);

                if (user != null)
                {
                    lblName.Text = user.FullName;
                    lblUserID.Text = user.UserID;
                    lblAddress.Text = user.Address;
                    lblTelNo.Text = user.TelephoneNo;
                    lblNIC.Text = user.NIC;
                    lblUserName.Text = user.UserName;

                    txtUserName.Text = user.UserName;

                    lblPassword.Text = new string('*', user.Password.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            pnlChangePassword.Visible = true;
            pnlChangePassword.BringToFront();
            txtCurrentPassword.Clear();
            txtNewPassword.Clear();
            txtReEnterPassword.Clear();
            lblStatus.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pnlChangePassword.Visible = false;
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string currentPwd = txtCurrentPassword.Text;
            string newPwd = txtNewPassword.Text;
            string rePwd = txtReEnterPassword.Text;

            if (string.IsNullOrWhiteSpace(currentPwd) || string.IsNullOrWhiteSpace(newPwd))
            {
                lblStatus.Text = "Please fill all fields.";
                lblStatus.ForeColor = Color.Red;
                return;
            }

            if (newPwd != rePwd)
            {
                lblStatus.Text = "Passwords do not match!";
                lblStatus.ForeColor = Color.Red;
                return;
            }

            try
            {
                bool success = _userService.UpdatePassword(_currentUserId, currentPwd, newPwd);

                if (success)
                {
                    MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pnlChangePassword.Visible = false;
                }
                else
                {
                    lblStatus.Text = "Invalid current password.";
                    lblStatus.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating password: " + ex.Message);
            }
        }
    }
}
