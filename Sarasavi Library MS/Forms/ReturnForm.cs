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
    /// ReturnForm — processes book returns and auto-checks reservations.
    ///
    /// Designer controls expected:
    ///   txtCopyID        — Copy ID input
    ///   btnProcessReturn — trigger return
    ///   dgvReturnHistory — DataGridView showing past returns
    ///   lblStatus        — feedback label
    /// </summary>
    
    public partial class ReturnForm : Form
    {
        private readonly IReturnService _returnService = new ReturnServiceImpl();

        public ReturnForm()
        {
            InitializeComponent();
            LoadReturnHistory();
        }

        // -- Process Return ------------------------------------------

        private void btnProcessReturn_Click(object sender, EventArgs e)
        {
            string copyId = txtCopyID.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(copyId))
            {
                ShowStatus("Please enter a Copy ID.", Color.OrangeRed);
                return;
            }

            try
            {
                string result = _returnService.ProcessReturn(copyId);

                // The service returns a message in all cases — error messages
                // start with known prefixes; everything else is success.
                bool isError = result.StartsWith("No active loan") ||
                               result.StartsWith("Copy not found");

                if (isError)
                {
                    ShowStatus(result, Color.OrangeRed);
                    return;
                }

                // Success — show detailed result (may include reservation notice)
                MessageBox.Show(result, "Return Processed",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCopyID.Clear();
                ShowStatus("Return processed successfully.", Color.FromArgb(46, 204, 113));
                LoadReturnHistory();
            }
            catch (Exception ex)
            {
                ShowStatus($"Error: {ex.Message}", Color.OrangeRed);
            }
        }

        // -- Return History Grid -----------------------------------

        private void LoadReturnHistory()
        {
            try
            {
                var history = _returnService.GetReturnHistory();
                dgvReturnHistory.DataSource = null;
                dgvReturnHistory.DataSource = history;

                if (dgvReturnHistory.Columns.Count > 0)
                {
                    SetColumnHeader("LoanID", "Loan ID");
                    SetColumnHeader("UserID", "User ID");
                    SetColumnHeader("UserName", "Member Name");
                    SetColumnHeader("CopyID", "Copy ID");
                    SetColumnHeader("BookTitle", "Book Title");
                    SetColumnHeader("LoanDate", "Loan Date");
                    SetColumnHeader("DueDate", "Due Date");
                    SetColumnHeader("ReturnDate", "Return Date");
                    SetColumnHeader("Status", "Status");
                    HideColumn("IsOverdue");
                }
            }
            catch { /* Grid not ready yet */ }
        }

        // -- Helpers ------------------------------------------------

        private void ShowStatus(string msg, Color color)
        {
            lblStatus.Visible = true;
            lblStatus.Text = msg;
            lblStatus.ForeColor = color;
        }

        private void SetColumnHeader(string name, string header)
        {
            if (dgvReturnHistory.Columns.Contains(name))
                dgvReturnHistory.Columns[name].HeaderText = header;
        }

        private void HideColumn(string name)
        {
            if (dgvReturnHistory.Columns.Contains(name))
                dgvReturnHistory.Columns[name].Visible = false;
        }

        private void txtCopyID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnProcessReturn_Click(sender, e);
        }
    }
}
