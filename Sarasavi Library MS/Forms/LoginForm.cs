using Sarasavi_Library_MS;
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
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService = new UserServiceImpl();

        public LoginForm()
        {
            InitializeComponent();
            SetupLoginForm();
        }

        private void SetupLoginForm()
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*
            string validUserName = "admin";
            string validPassword = "admin123";

            string enteredUserName = txtUser.Text.Trim();
            string enteredPassword = txtPassword.Text;

            if (enteredUserName == validUserName && enteredPassword == validPassword) 
            { 

                try
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();

                    this.Hide();
                }
                catch (Exception ex) 
                { 
                    MessageBox.Show($"Error: {ex.Message}\n\nStack Trace: {ex.StackTrace}");
                }
                
            }
            else 
            {
                MessageBox.Show(
                    "Invalid User Name or Password. Please try again.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                ClearLoginForm();
            }
            */

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string role = _userService.ValidateLogin(username, password);

                if (role == null)
                {
                    MessageBox.Show("Invalid username or password. Please try again.",
                        "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearLoginForm();
                    return;
                }

                if (role == "admin")
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    /*
                    // Placeholder for future user/member view
                    MessageBox.Show($"Welcome, {username}!\n\nMember portal is coming soon.",
                        "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    */

                    UserMainForm userMainForm = new UserMainForm();
                    userMainForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearLoginForm();
            }
        }

        private void ClearLoginForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                SignupForm form = new SignupForm();
                form.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nStack Trace: {ex.StackTrace}");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
