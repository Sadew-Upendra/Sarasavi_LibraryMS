using Sarasavi_Library_MS.DAO.DAOImpl;
using Sarasavi_Library_MS.Entity;
using Sarasavi_Library_MS.Service;
using Sarasavi_Library_MS.Service.ServiceImpl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Sarasavi_Library_MS.Forms
{
    public partial class Dashboard : Form
    {
        // -- Services -----------------------------------------------
        private readonly IBookService _bookService = new BookServiceImpl();
        private readonly IUserService _userService = new UserServiceImpl();
        private readonly ILoanService _loanService = new LoanServiceImpl();
        private readonly IReservationService _reservationService = new ReservationServiceImpl();
        private readonly NotificationDAOImpl _notifDAO = new NotificationDAOImpl();

        private readonly string _loggedInUserId;

        // -- Tracks whether the notification panel is open ----------
        private bool _notifPanelOpen = false;

        // -- In-memory list of currently displayed notifications ----
        private List<Notification> _notifications = new List<Notification>();

        // ===========================================================
        // Constructors
        // ===========================================================

        public Dashboard() : this(null) { }

        public Dashboard(string loggedInUserId)
        {
            InitializeComponent();
            _loggedInUserId = loggedInUserId;

            SetupNotificationListBox();

            // Panel hidden until the button is pressed
            pnlNotifications.Visible = false;

            LoadDashboard();
        }

        // ===========================================================
        // Dashboard Load — statistics
        // ===========================================================

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
                lblTotalUsers.Text = _userService.GetAllUsers().Count.ToString();

                // -- Loan stats ---------------------------------
                var (_, active, overdue) = _loanService.GetLoanStats();
                lblActiveLoans.Text = active.ToString();
                lblOverdueLoans.Text = overdue.ToString();

                // -- Reservations -------------------------------
                lblReservations.Text = _reservationService.GetReservationCount().ToString();

                // Refresh the unread notification count badge
                RefreshNotificationCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===========================================================
        // lblNotifiCount — update the unread notification badge
        // ===========================================================

        private void RefreshNotificationCount()
        {
            int count = _loggedInUserId == null
                ? _notifDAO.CountUnread()                          // admin: all unread
                : _notifDAO.CountUnreadByUserId(_loggedInUserId);  // user: their own unread

            if (count == 0)
            {
                lblNotifiCount.Text = "No notifications";
                lblNotifiCount.ForeColor = Color.FromArgb(38, 49, 64);
            }
            else
            {
                lblNotifiCount.Text = count == 1
                    ? "1 notification"
                    : $"{count} notifications";
                lblNotifiCount.ForeColor = Color.FromArgb(192, 0, 0);  // red
            }
        }

        // ===========================================================
        // btnReadNotifications — toggle panel open / close
        // ===========================================================

        private void btnReadNotifications_Click(object sender, EventArgs e)
        {
            _notifPanelOpen = !_notifPanelOpen;
            pnlNotifications.Visible = _notifPanelOpen;

            if (_notifPanelOpen)
                LoadNotificationPanel();
        }

        // ===========================================================
        // Setup owner-drawn ListBox (call ONCE from constructor)
        // ===========================================================

        private void SetupNotificationListBox()
        {
            lstNotifications.DrawMode = DrawMode.OwnerDrawVariable;
            lstNotifications.ItemHeight = 54;  // base; overridden per item in MeasureItem

            lstNotifications.MeasureItem += LstNotifications_MeasureItem;
            lstNotifications.DrawItem += LstNotifications_DrawItem;
            lstNotifications.SelectedIndexChanged += LstNotifications_SelectedIndexChanged;
        }

        // ===========================================================
        // Load notification panel content from database
        // ===========================================================

        private void LoadNotificationPanel()
        {
            try
            {
                // Admin sees all; member sees their own + global (UserID IS NULL)
                _notifications = _loggedInUserId == null
                    ? _notifDAO.FindAllSorted()
                    : _notifDAO.FindByUserIdSorted(_loggedInUserId);

                lstNotifications.Items.Clear();

                if (_notifications.Count == 0)
                    lstNotifications.Items.Add("__EMPTY__");  // placeholder string
                else
                    foreach (var n in _notifications)
                        lstNotifications.Items.Add(n);        // store Notification objects

                RefreshNotificationCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading notifications: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===========================================================
        // MeasureItem — dynamic row height based on message length
        // ===========================================================

        private void LstNotifications_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= lstNotifications.Items.Count) return;

            var item = lstNotifications.Items[e.Index];
            if (item is string) { e.ItemHeight = 50; return; }

            var notif = (Notification)item;

            // Fixed: Using traditional using block instead of using declaration
            using (var font = new Font("Segoe UI", 9f, notif.IsRead ? FontStyle.Regular : FontStyle.Bold))
            {
                int usableWidth = lstNotifications.ClientSize.Width - 50;
                SizeF measured = e.Graphics.MeasureString(notif.Message, font, new SizeF(usableWidth, 300));

                // 8 top pad + 18 header line + measured message + 8 bottom pad
                e.ItemHeight = Math.Max(54, (int)measured.Height + 34);
            }
        }

        // ===========================================================
        // DrawItem — custom rendering for each notification row
        // ===========================================================

        private void LstNotifications_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= lstNotifications.Items.Count) return;

            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            var item = lstNotifications.Items[e.Index];

            if (item is string)
            {
                g.FillRectangle(new SolidBrush(Color.FromArgb(248, 249, 250)), rect);
                using (var ph = new Font("Segoe UI", 9f, FontStyle.Italic)) // Fixed
                {
                    g.DrawString("  No notifications to display.", ph, Brushes.DarkGray, rect.X + 8, rect.Y + (rect.Height - 16) / 2);
                }
                return;
            }

            var notif = (Notification)item;
            bool isUnread = !notif.IsRead;
            bool selected = (e.State & DrawItemState.Selected) != 0;

            // Background and Accents... (keep your existing logic)
            Color bg = selected ? Color.FromArgb(207, 226, 255) : isUnread ? Color.FromArgb(232, 244, 255) : Color.FromArgb(250, 250, 250);
            g.FillRectangle(new SolidBrush(bg), rect);

            Color accentColor = isUnread ? Color.FromArgb(41, 128, 185) : Color.FromArgb(200, 200, 200);
            g.FillRectangle(new SolidBrush(accentColor), new Rectangle(rect.X, rect.Y, 5, rect.Height));
            g.DrawLine(new Pen(Color.FromArgb(220, 220, 220)), rect.X + 5, rect.Bottom - 1, rect.Right, rect.Bottom - 1);

            int textLeft = rect.X + 14;
            int textTop = rect.Y + 6;
            int textW = rect.Width - textLeft - 8;

            // Header Drawing
            string dot = isUnread ? "●" : "○";
            string timestamp = notif.CreatedDate.ToString("dd MMM yyyy   HH:mm");
            string userTag = notif.UserID != null ? $"   ›  {notif.UserID}" : "   ›  Librarian";

            using (var headerFont = new Font("Segoe UI", 7.5f, isUnread ? FontStyle.Bold : FontStyle.Regular)) // Fixed
            {
                Color dotColor = isUnread ? Color.FromArgb(41, 128, 185) : Color.FromArgb(160, 160, 160);
                Color metaColor = isUnread ? Color.FromArgb(52, 73, 94) : Color.FromArgb(150, 150, 150);

                g.DrawString(dot, headerFont, new SolidBrush(dotColor), textLeft, textTop);
                g.DrawString(timestamp + userTag, headerFont, new SolidBrush(metaColor), textLeft + 14, textTop);
            }

            // Message Drawing
            using (var msgFont = new Font("Segoe UI", 9f, isUnread ? FontStyle.Bold : FontStyle.Regular)) // Fixed
            {
                Color msgColor = isUnread ? Color.FromArgb(20, 20, 20) : Color.FromArgb(100, 100, 100);
                int msgTop = textTop + 18;
                g.DrawString(notif.Message, msgFont, new SolidBrush(msgColor),
                    new RectangleF(textLeft, msgTop, textW, rect.Height - msgTop - 4));
            }
        }

        // ===========================================================
        // SelectedIndexChanged — mark item as read on click
        // ===========================================================

        private void LstNotifications_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = lstNotifications.SelectedIndex;
            if (idx < 0 || idx >= lstNotifications.Items.Count) return;

            if (!(lstNotifications.Items[idx] is Notification notif)) return;

            if (!notif.IsRead)
            {
                _notifDAO.MarkAsRead(notif.NotificationID);
                notif.IsRead = true;             // update in-memory object
                lstNotifications.Invalidate();   // trigger redraw of the whole list
                RefreshNotificationCount();      // update the count badge
            }
        }

        // ===========================================================
        // btnRefresh (inside pnlNotifications)
        // ===========================================================

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadNotificationPanel();
        }

        // ===========================================================
        // btnClear (inside pnlNotifications) — mark all as read
        // ===========================================================

        private void btnClear_Click(object sender, EventArgs e)
        {
            bool anyUnread = _notifications.Exists(n => !n.IsRead);

            if (!anyUnread)
            {
                MessageBox.Show("All notifications are already read.",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show(
                "Mark all notifications as read?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            _notifDAO.MarkAllAsRead();
            LoadNotificationPanel();
        }

        // ===========================================================
        // btnRefreshDashboard (main dashboard refresh button)
        // ===========================================================

        /*
        private void btnRefreshDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboard();
            if (_notifPanelOpen)
                LoadNotificationPanel();
        }
        */

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

    }
}