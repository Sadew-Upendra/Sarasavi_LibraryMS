using Sarasavi_Library_MS.DAO;
using Sarasavi_Library_MS.DAO.DAOImpl;
using Sarasavi_Library_MS.DTO;
using Sarasavi_Library_MS.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasavi_Library_MS.Service.ServiceImpl
{
    public class LoanServiceImpl : ILoanService
    {
        private static readonly int MaxLoans = int.Parse(ConfigurationManager.AppSettings["MaxLoansPerUser"] ?? "5");
        private static readonly int LoanDays = int.Parse(ConfigurationManager.AppSettings["LoanPeriodDays"] ?? "14");

        private readonly UserDAOImpl _userDAO = new UserDAOImpl();
        private readonly ICopyDAO _copyDAO = new CopyDAOImpl();
        private readonly ILoanDAO _loanDAO = new LoanDAOImpl();
        private readonly IBookDAO _bookDAO = new BookDAOImpl();

        public UserDTO VerifyBorrower(string userId)
        {
            var user = _userDAO.FindById(userId);
            if (user == null) return null;
            return new UserDTO
            {
                UserID = user.UserID,
                FullName = user.FullName,
                Sex = user.Sex,
                NIC = user.NIC,
                TelephoneNo = user.TelephoneNo,
                Address = user.Address,
                UserType = user.UserType,
                ActiveLoans = _loanDAO.CountActiveByUserId(userId)
            };
        }

        public string IssueLoan(string userId, string copyId)
        {
            var user = _userDAO.FindById(userId);
            if (user == null) return "User not found.";
            if (user.UserType == "Visitor") return "Visitors cannot borrow books.";

            int activeLoans = _loanDAO.CountActiveByUserId(userId);
            if (activeLoans >= MaxLoans)
                return $"User has reached the maximum limit of {MaxLoans} active loans. Please return some books first.";

            var copy = _copyDAO.FindById(copyId);
            if (copy == null) return "Copy not found.";
            if (copy.CopyType == "Reference") return "This copy is for reference only and cannot be borrowed.";
            if (copy.Status != "Available") return $"This copy is currently {copy.Status} and not available for loan.";

            var loan = new Loan
            {
                UserID = userId,
                CopyID = copyId,
                LoanDate = DateTime.Today,
                DueDate = DateTime.Today.AddDays(LoanDays),
                Status = "Active"
            };

            if (!_loanDAO.Save(loan)) return "Failed to create loan record.";

            _copyDAO.UpdateStatus(copyId, "Loaned");
            return null; // null = success
        }

        public List<LoanDTO> GetActiveLoansByUser(string userId)
        {
            var loans = _loanDAO.FindByUserId(userId).Where(l => l.Status == "Active").ToList();
            return ToLoanDTOs(loans);
        }

        public List<LoanDTO> GetAllActiveLoans() => ToLoanDTOs(_loanDAO.FindAllActive());

        public List<LoanDTO> GetAllLoans() => ToLoanDTOs(_loanDAO.FindAll());

        public (int total, int active, int overdue) GetLoanStats()
        {
            var all = _loanDAO.FindAll();
            int total = all.Count;
            int active = all.Count(l => l.Status == "Active");
            int overdue = all.Count(l => l.Status == "Active" && l.DueDate < DateTime.Today);
            return (total, active, overdue);
        }

        private List<LoanDTO> ToLoanDTOs(List<Loan> loans)
        {
            var result = new List<LoanDTO>();
            foreach (var l in loans)
            {
                var user = _userDAO.FindById(l.UserID);
                var copy = _copyDAO.FindById(l.CopyID);
                var book = copy != null ? _bookDAO.FindById(copy.BookID) : null;
                result.Add(new LoanDTO
                {
                    LoanID = l.LoanID,
                    UserID = l.UserID,
                    UserName = user?.FullName ?? l.UserID,
                    CopyID = l.CopyID,
                    BookTitle = book?.Title ?? "",
                    LoanDate = l.LoanDate,
                    DueDate = l.DueDate,
                    ReturnDate = l.ReturnDate,
                    Status = (l.Status == "Active" && l.DueDate < DateTime.Today) ? "Overdue" : l.Status
                });
            }
            return result;
        }
    }
}
