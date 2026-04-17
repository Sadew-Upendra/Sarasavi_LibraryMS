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
    public partial class UserLoanDetailsForm : Form
    {
        private readonly ILoanService _loanService = new LoanServiceImpl();
        private readonly IReservationService _resService = new ReservationServiceImpl();
        private readonly string _currentUserId;

        public UserLoanDetailsForm(string userId)
        {
            InitializeComponent();
            this._currentUserId = userId;
            LoadAllUserData();
        }

        private void LoadAllUserData()
        {
            try
            {
                // 1. Load Active Loans
                var allLoans = _loanService.GetAllLoans();
                // filter login user
                dgvUserLoans.DataSource = allLoans.FindAll(l => l.UserID == _currentUserId && l.Status == "Issued");

                // 2. Load Return History
                dgvUserReturns.DataSource = allLoans.FindAll(l => l.UserID == _currentUserId && l.Status == "Returned");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading details: " + ex.Message);
            }
        }
    }
}
