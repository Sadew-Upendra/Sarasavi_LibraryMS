using Sarasavi_Library_MS.DTO;
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
    /// <summary>
    /// LoanForm implements a two-step loan process:
    ///   Step 1 — Verify borrower (txtUserID + btnVerify)
    ///   Step 2 — Add copies to cart (txtCopyID + btnAdd) then Confirm Loan
    ///
    /// Designer controls expected:
    ///   txtUserID, btnVerify
    ///   lblBorrowerName, lblBorrowerType, lblActiveLoans   ← shown after verify
    ///   pnlStep2                                           ← hidden until verified
    ///   txtCopyID, btnAdd
    ///   lstCart  (ListBox or ListView)                     ← copy IDs to borrow
    ///   btnConfirmLoan, btnClearCart
    ///   dgvActiveLoans  (DataGridView)
    ///   lblStatus
    /// </summary>
   
    public partial class LoanForm : Form
    {
        private readonly ILoanService _loanService = new LoanServiceImpl();

        private UserDTO _verifiedUser;
        private readonly List<string> _cart = new List<string>();

        public LoanForm()
        {
            InitializeComponent();
            pnlStep2.Visible = false;
            pnlBorrowerInfo.Visible = false;
            lblHeader.Visible = false;
            lblStatus.Visible = false;
        }

        // -- Step 1: Verify Borrower -------------------------------------

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string userId = txtUserID.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(userId))
            {
                ShowStatus("Please enter a User ID.", Color.OrangeRed);
                return;
            }

            try
            {
                _verifiedUser = _loanService.VerifyBorrower(userId);

                if (_verifiedUser == null)
                {
                    ShowStatus("User not found. Please check the User ID.", Color.OrangeRed);
                    pnlBorrowerInfo.Visible = false;
                    pnlStep2.Visible = false;
                    return;
                }

                if (_verifiedUser.UserType == "Visitor")
                {
                    ShowStatus("Visitors cannot borrow books. Only registered Members can borrow.", Color.OrangeRed);
                    pnlBorrowerInfo.Visible = false;
                    pnlStep2.Visible = false;
                    return;
                }

                // Show borrower info
                lblBorrowerName.Text = _verifiedUser.FullName;
                lblBorrowerType.Text = _verifiedUser.UserType;
                lblActiveLoansCount.Text = $"{_verifiedUser.ActiveLoans} / 5";
                lblActiveLoansCount.ForeColor = _verifiedUser.ActiveLoans >= 5
                    ? Color.OrangeRed : Color.FromArgb(46, 204, 113);

                pnlBorrowerInfo.Visible = true;
                pnlStep2.Visible = true;
                lblHeader.Visible = true;
                ShowStatus("Borrower verified successfully.", Color.FromArgb(46, 204, 113));

                // Refresh active loans grid
                LoadActiveLoans();

                _cart.Clear();
                RefreshCart();
            }
            catch (Exception ex)
            {
                ShowStatus($"Error: {ex.Message}", Color.OrangeRed);
            }
        }

        // -- Step 2: Add Copies to Cart -----------------------------------

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string copyId = txtCopyID.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(copyId))
            {
                ShowStatus2("Please enter a Copy ID.", Color.OrangeRed);
                return;
            }

            if (_cart.Contains(copyId))
            {
                ShowStatus2($"Copy {copyId} is already in the cart.", Color.Orange);
                return;
            }

            if (_verifiedUser.ActiveLoans + _cart.Count >= 5)
            {
                ShowStatus2("Cannot add more copies. Maximum 5 active loans allowed.", Color.OrangeRed);
                return;
            }

            _cart.Add(copyId);
            txtCopyID.Clear();
            RefreshCart();
            ShowStatus2($"Copy {copyId} added to cart.", Color.FromArgb(46, 204, 113));
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (lstCart.SelectedIndex < 0) return;
            string selected = lstCart.SelectedItem?.ToString();
            if (selected != null)
            {
                _cart.Remove(selected);
                RefreshCart();
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            _cart.Clear();
            RefreshCart();
            ShowStatus2("Cart cleared.", Color.Gray);
        }

        // -- Confirm Loan --------------------------------------------

        private void btnConfirmLoan_Click(object sender, EventArgs e)
        {
            if (_verifiedUser == null)
            {
                ShowStatus("Please verify a borrower first.", Color.OrangeRed);
                return;
            }

            if (_cart.Count == 0)
            {
                ShowStatus2("Cart is empty. Add at least one copy.", Color.OrangeRed);
                return;
            }

            var confirm = MessageBox.Show(
                $"Issue {_cart.Count} book(s) to {_verifiedUser.FullName}?\n" +
                $"Due date: {DateTime.Today.AddDays(14):dd/MM/yyyy}",
                "Confirm Loan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            int success = 0;
            var errors = new System.Text.StringBuilder();

            foreach (string copyId in _cart)
            {
                string error = _loanService.IssueLoan(_verifiedUser.UserID, copyId);
                if (error == null)
                    success++;
                else
                    errors.AppendLine($"• {copyId}: {error}");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(
                    $"{success} loan(s) issued successfully.\n\nFailed:\n{errors}",
                    "Partial Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(
                    $"All {success} book(s) issued successfully!\nDue date: {DateTime.Today.AddDays(14):dd/MM/yyyy}",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Refresh
            _cart.Clear();
            RefreshCart();
            _verifiedUser = _loanService.VerifyBorrower(_verifiedUser.UserID);
            lblActiveLoansCount.Text = $"{_verifiedUser.ActiveLoans} / 5";
            lblActiveLoansCount.ForeColor = _verifiedUser.ActiveLoans >= 5
                ? Color.OrangeRed : Color.FromArgb(46, 204, 113);
            LoadActiveLoans();
            ShowStatus2($"{success} loan(s) confirmed.", Color.FromArgb(46, 204, 113));
        }

        // -- Helpers --------------------------------------------------

        private void LoadActiveLoans()
        {
            try
            {
                var loans = _loanService.GetAllActiveLoans();
                dgvActiveLoans.DataSource = null;
                dgvActiveLoans.DataSource = loans;

                // Rename columns for readability
                if (dgvActiveLoans.Columns.Count > 0)
                {
                    SetColumnHeader("LoanID", "Loan ID");
                    SetColumnHeader("UserID", "User");
                    SetColumnHeader("CopyID", "Copy ID");
                    SetColumnHeader("BookTitle", "Book Title");
                    SetColumnHeader("LoanDate", "Loan Date");
                    SetColumnHeader("DueDate", "Due Date");
                    SetColumnHeader("Status", "Status");

                    // Hide columns not needed in this view
                    HideColumn("UserName");
                    HideColumn("ReturnDate");
                    HideColumn("IsOverdue");
                }

                // Highlight overdue rows in red
                foreach (DataGridViewRow row in dgvActiveLoans.Rows)
                {
                    if (row.Cells["Status"]?.Value?.ToString() == "Overdue")
                        row.DefaultCellStyle.ForeColor = Color.OrangeRed;
                }
            }
            catch { /* Grid not ready yet */ }
        }

        private void RefreshCart()
        {
            lstCart.Items.Clear();
            foreach (var id in _cart)
                lstCart.Items.Add(id);

            btnConfirmLoan.Enabled = _cart.Count > 0;
            lblCartCount.Text = $"{_cart.Count} item(s) in cart";
        }

        private void ShowStatus(string msg, Color color)
        {
            lblStatus.Visible = true;
            lblStatus.Text = msg;
            lblStatus.ForeColor = color;
        }

        private void ShowStatus2(string msg, Color color)
        {
            lblStatus2.Visible = true;
            lblStatus2.Text = msg;
            lblStatus2.ForeColor = color;
        }

        private void SetColumnHeader(string name, string header)
        {
            if (dgvActiveLoans.Columns.Contains(name))
                dgvActiveLoans.Columns[name].HeaderText = header;
        }

        private void HideColumn(string name)
        {
            if (dgvActiveLoans.Columns.Contains(name))
                dgvActiveLoans.Columns[name].Visible = false;
        }

        // Allow pressing Enter in txtCopyID to add
        private void txtCopyID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnAdd_Click(sender, e);
        }

        // Allow pressing Enter in txtUserID to verify
        private void txtUserID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnVerify_Click(sender, e);
        }
    }
}
