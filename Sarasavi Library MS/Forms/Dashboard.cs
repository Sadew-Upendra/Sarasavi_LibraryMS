using Sarasavi_Library_MS.DAO.DAOImpl;
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
    public partial class Dashboard : Form
    {

        private readonly IBookService _bookService = new BookServiceImpl();
        private readonly IUserService _userService = new UserServiceImpl();
        private readonly ILoanService _loanService = new LoanServiceImpl();
        private readonly IReservationService _reservationService = new ReservationServiceImpl();
        private readonly NotificationDAOImpl _notifDAO = new NotificationDAOImpl();

        public Dashboard()
        {
            InitializeComponent();
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            try
            {
                // -- Book & Copy counts -------------------------
                var books = _bookService.GetAllBooks();
                var copies = new CopyDAOImpl().FindAll();

                lblTotalBooks.Text = books.Count.ToString();
                lblTotalCopies.Text = copies.Count.ToString();

                // -- Registered users ---------------------------
                var users = _userService.GetAllUsers();
                lblTotalUsers.Text = users.Count.ToString();

                // -- Loan stats ---------------------------------
                var (_, active, overdue) = _loanService.GetLoanStats();
                lblActiveLoans.Text = active.ToString();
                lblOverdueLoans.Text = overdue.ToString();

                // -- Reservations -------------------------------
                lblReservations.Text = _reservationService.GetReservationCount().ToString();

                // -- Notifications ------------------------------
                LoadNotifications();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadNotifications()
        {
            lstNotifications.Items.Clear();

            var notifications = _notifDAO.FindUnread();

            if (notifications.Count == 0)
            {
                lstNotifications.Items.Add("No new notifications");
                return;
            }

            foreach (var n in notifications)
            {
                string display = $"[{n.CreatedDate:dd/MM/yyyy HH:mm}]";
                if (!string.IsNullOrEmpty(n.UserID))
                    display += $" → {n.UserID}";
                display += $": {n.Message}";

                lstNotifications.Items.Add(display);
            }
        }

        // Wire to a "Mark All Read" button if you have one
        private void btnMarkAllRead_Click(object sender, EventArgs e)
        {
            _notifDAO.MarkAllAsRead();
            LoadNotifications();
        }

        // Wire to a Refresh button if you have one
        private void btnRefresh_Click(object sender, EventArgs e) => LoadDashboard();
    }
}
