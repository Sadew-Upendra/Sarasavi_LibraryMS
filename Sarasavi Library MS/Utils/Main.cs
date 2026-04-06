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
    public partial class MainForm : Form
    {

        public MainForm()
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ButtonOff();
            btnDashboard.NormalBackground = Color.FromArgb(84, 95, 112);
            btnDashboard.HoverBackground = Color.FromArgb(84, 95, 112);
            //btnDashboard.NormalBackground = Color.RoyalBlue;
            //lblTitle.Text = btnDashboard.Text;
            lblTitle.Text = "Dashboard";

            LoadDashboard();
            
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            ButtonOff();
            btnLoan.NormalBackground = Color.FromArgb(84, 95, 112);
            btnLoan.HoverBackground = Color.FromArgb(84, 95, 112);
            lblTitle.Text = "Loan Process";

            try
            {
                LoanForm loanForm = new LoanForm();
                LoadForm(loanForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nStack Trace: {ex.StackTrace}");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ButtonOff();
            btnReturn.NormalBackground = Color.FromArgb(84, 95, 112);
            btnReturn.HoverBackground = Color.FromArgb(84, 95, 112);
            lblTitle.Text = "Return Process";

            try
            {
                ReturnForm returnForm = new ReturnForm();
                LoadForm(returnForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nStack Trace: {ex.StackTrace}");
            }
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            ButtonOff();
            btnReservations.NormalBackground = Color.FromArgb(84, 95, 112);
            btnReservations.HoverBackground = Color.FromArgb(84, 95, 112);
            lblTitle.Text = "Reservations";

            try
            {
                ReservationForm reserveForm = new ReservationForm();
                LoadForm(reserveForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nStack Trace: {ex.StackTrace}");
            }
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

        private void btnBook_Click(object sender, EventArgs e)
        {
            ButtonOff();
            btnBook.NormalBackground = Color.FromArgb(84, 95, 112);
            btnBook.HoverBackground = Color.FromArgb(84, 95, 112);
            lblTitle.Text = "Book Registration";

            try
            {
                BookForm bookForm = new BookForm();
                LoadForm(bookForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nStack Trace: {ex.StackTrace}");
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ButtonOff();
            btnUser.NormalBackground = Color.FromArgb(84, 95, 112);
            btnUser.HoverBackground = Color.FromArgb(84, 95, 112);
            lblTitle.Text = "Member Registration";

            try
            {
                UserForm userForm = new UserForm();
                LoadForm(userForm);
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
            btnBook.NormalBackground = Color.Transparent;
            btnUser.NormalBackground = Color.Transparent;
            btnInquiry.NormalBackground = Color.Transparent;

            btnDashboard.HoverBackground = Color.FromArgb(32, 45, 64);
            btnLoan.HoverBackground = Color.FromArgb(32, 45, 64);
            btnReturn.HoverBackground = Color.FromArgb(32, 45, 64);
            btnReservations.HoverBackground = Color.FromArgb(32, 45, 64);
            btnInquiry.HoverBackground = Color.FromArgb(32, 45, 64);
            btnBook.HoverBackground = Color.FromArgb(32, 45, 64);
            btnUser.HoverBackground = Color.FromArgb(32, 45, 64);
        }

        

        private void LoadDashboard()
        {
            Dashboard dashboard = new Dashboard();
            LoadForm(dashboard); 
        }


        /*
        private void LoadForm(Form f)
        {
            if (this.contentPanel.Controls.Count > 0)
                this.contentPanel.Controls.Clear();
            //Form f = new Form();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.contentPanel.Controls.Add(f);
            this.contentPanel.Tag = f;
            f.BringToFront();
            f.Show();
        }*/

        private void LoadForm(Form f)
        {
            // Clean up existing controls properly
            if (this.contentPanel.Controls.Count > 0)
            {
                foreach (Control ctrl in this.contentPanel.Controls)
                {
                    // If it's a form, we should close it to free resources
                    if (ctrl is Form oldForm)
                    {
                        oldForm.Close();
                        oldForm.Dispose();
                    }
                }
                this.contentPanel.Controls.Clear();
            }

            // Set child form properties
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill; // This is key for it to expand

            // Add to panel
            this.contentPanel.Controls.Add(f);
            this.contentPanel.Tag = f;

            f.Show();
            f.BringToFront();
        }
    }
}
