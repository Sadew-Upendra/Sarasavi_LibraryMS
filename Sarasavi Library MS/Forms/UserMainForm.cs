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
    public partial class UserMainForm : Form
    {
        public UserMainForm()
        {
            InitializeComponent();
            MainFormOpen();
        }

        private void MainFormOpen()
        {
            btnDashboard.NormalBackground = Color.FromArgb(84, 95, 112);
            btnDashboard.HoverBackground = Color.FromArgb(84, 95, 112);
            lblTitle.Text = "Dashboard";
            LoadDashboard();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nStack Trace: {ex.StackTrace}");
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ButtonOff();
            btnDashboard.NormalBackground = Color.FromArgb(84, 95, 112);
            btnDashboard.HoverBackground = Color.FromArgb(84, 95, 112);
            lblTitle.Text = "Dashboard";

            LoadDashboard();
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            ButtonOff();
            btnInquiry.NormalBackground = Color.FromArgb(84, 95, 112);
            btnInquiry.HoverBackground = Color.FromArgb(84, 95, 112);
            lblTitle.Text = "Inquiry";

            try
            {
                InquiryForm inquiryForm = new InquiryForm();
                LoadForm(inquiryForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nStack Trace: {ex.StackTrace}");
            }
        }

        private void ButtonOff()
        {
            btnDashboard.NormalBackground = Color.Transparent;
            btnLoan.NormalBackground = Color.Transparent;
            btnReturn.NormalBackground = Color.Transparent;
            btnReservations.NormalBackground = Color.Transparent;
            btnProfile.NormalBackground = Color.Transparent;
            btnInquiry.NormalBackground = Color.Transparent;

            btnDashboard.HoverBackground = Color.FromArgb(32, 45, 64);
            btnLoan.HoverBackground = Color.FromArgb(32, 45, 64);
            btnReturn.HoverBackground = Color.FromArgb(32, 45, 64);
            btnReservations.HoverBackground = Color.FromArgb(32, 45, 64);
            btnInquiry.HoverBackground = Color.FromArgb(32, 45, 64);
            btnProfile.HoverBackground = Color.FromArgb(32, 45, 64);
        }



        private void LoadDashboard()
        {
            Dashboard dashboard = new Dashboard();
            LoadForm(dashboard);
        }

        private void LoadForm(Form f)
        {
            if (this.contentPanel.Controls.Count > 0)
                this.contentPanel.Controls.Clear();
            
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.contentPanel.Controls.Add(f);
            this.contentPanel.Tag = f;
            f.BringToFront();
            f.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ButtonOff();
            btnProfile.NormalBackground = Color.FromArgb(84, 95, 112);
            btnProfile.HoverBackground = Color.FromArgb(84, 95, 112);
            lblTitle.Text = "Profile";

            try
            {
                Profile profile = new Profile();
                LoadForm(profile);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nStack Trace: {ex.StackTrace}");
            }
        }
    }
}
