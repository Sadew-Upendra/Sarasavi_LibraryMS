using Org.BouncyCastle.Asn1.Cmp;
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
    /// ReservationForm — make new reservations and view/cancel existing ones.
    ///
    /// Designer controls expected:
    ///   txtUserID       — user ID input for new reservation
    ///   txtBookID       — book ID input for new reservation
    ///   btnReserveBook  — creates the reservation
    ///   dgvReservations — DataGridView showing all reservations
    ///   btnCancelRes    — cancels selected reservation
    ///   lblStatus
    /// </summary>
    
    public partial class ReservationForm : Form
    {
        private readonly IReservationService _reservationService = new ReservationServiceImpl();

        public ReservationForm()
        {
            InitializeComponent();
            LoadReservations();
        }

        // -- New Reservation ----------------------------------------

        private void btnReserveBook_Click(object sender, EventArgs e)
        {
            string userId = txtUserID.Text.Trim().ToUpper();
            string bookId = txtBookID.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(bookId))
            {
                ShowStatus("Please enter both User ID and Book ID.", Color.OrangeRed);
                return;
            }

            try
            {
                string error = _reservationService.MakeReservation(userId, bookId);

                if (error != null)
                {
                    ShowStatus(error, Color.OrangeRed);
                    return;
                }

                MessageBox.Show($"Reservation created successfully for User {userId} on Book {bookId}.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtUserID.Clear();
                txtBookID.Clear();
                ShowStatus("Reservation created.", Color.FromArgb(46, 204, 113));
                LoadReservations();
            }
            catch (Exception ex)
            {
                ShowStatus($"Error: {ex.Message}", Color.OrangeRed);
            }
        }

        // -- Cancel Selected Reservation ----------------------------

        private void btnCancelRes_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count == 0)
            {
                ShowStatus("Please select a reservation to cancel.", Color.OrangeRed);
                return;
            }

            var selectedRow = dgvReservations.SelectedRows[0];
            int resId = Convert.ToInt32(selectedRow.Cells["ReservationID"].Value);

            string status = selectedRow.Cells["Status"].Value?.ToString();
            if (status != "Active")
            {
                ShowStatus("Only active reservations can be cancelled.", Color.OrangeRed);
                return;
            }

            var confirm = MessageBox.Show(
                $"Cancel reservation #{resId}?",
                "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                if (_reservationService.CancelReservation(resId))
                {
                    ShowStatus("Reservation cancelled.", Color.FromArgb(46, 204, 113));
                    LoadReservations();
                }
                else
                {
                    ShowStatus("Failed to cancel reservation.", Color.OrangeRed);
                }
            }
            catch (Exception ex)
            {
                ShowStatus($"Error: {ex.Message}", Color.OrangeRed);
            }
        }

        // -- Load Grid ----------------------------------------------

        private void LoadReservations()
        {
            try
            {
                var reservations = _reservationService.GetAllReservations();
                dgvReservations.DataSource = null;
                dgvReservations.DataSource = reservations;

                if (dgvReservations.Columns.Count > 0)
                {
                    SetColumnHeader("ReservationID", "Res. ID");
                    SetColumnHeader("UserID", "User ID");
                    SetColumnHeader("UserName", "Member Name");
                    SetColumnHeader("BookID", "Book ID");
                    SetColumnHeader("BookTitle", "Book Title");
                    SetColumnHeader("ReservedDate", "Reserved Date");
                    SetColumnHeader("Status", "Status");
                }

                // Color-code by status
                foreach (DataGridViewRow row in dgvReservations.Rows)
                {
                    string s = row.Cells["Status"]?.Value?.ToString();
                    row.DefaultCellStyle.ForeColor = s == "Active"
                        ? Color.FromArgb(46, 204, 113)
                        : Color.Gray;
                }
            }
            catch { }
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
            if (dgvReservations.Columns.Contains(name))
                dgvReservations.Columns[name].HeaderText = header;
        }
    }
}
