using Sarasavi_Library_MS.DAO;
using Sarasavi_Library_MS.DAO.DAOImpl;
using Sarasavi_Library_MS.DTO;
using Sarasavi_Library_MS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasavi_Library_MS.Service.ServiceImpl
{
    public class ReturnServiceImpl : IReturnService
    {
        private readonly ICopyDAO _copyDAO = new CopyDAOImpl();
        private readonly ILoanDAO _loanDAO = new LoanDAOImpl();
        private readonly IReservationDAO _resDAO = new ReservationDAOImpl();
        private readonly INotificationDAO _notifDAO = new NotificationDAOImpl();
        private readonly IBookDAO _bookDAO = new BookDAOImpl();

        public string ProcessReturn(string copyId)
        {
            var copy = _copyDAO.FindById(copyId);
            if (copy == null) return "Copy not found.";

            var activeLoans = _loanDAO.FindActiveLoansByCopyId(copyId);
            if (activeLoans.Count == 0) return "No active loan found for this copy.";

            var loan = activeLoans[0];

            // Mark loan as returned
            _loanDAO.UpdateStatus(loan.LoanID, "Returned", DateTime.Today);

            // Check for oldest active reservation on this book
            var oldestRes = _resDAO.FindOldestActiveByBookId(copy.BookID);
            if (oldestRes != null)
            {
                // Notify the member and remove the reservation
                var book = _bookDAO.FindById(copy.BookID);
                string bookTitle = book?.Title ?? copy.BookID;

                _notifDAO.Save(new Notification
                {
                    UserID = oldestRes.UserID,
                    Message = $"The book '{bookTitle}' (Copy: {copyId}) is now available for you. " +
                                  $"Please collect it from the library counter. Your reservation has been fulfilled.",
                    CreatedDate = DateTime.Now
                });

                _resDAO.Delete(oldestRes.ReservationID);
                _copyDAO.UpdateStatus(copyId, "Reserved");

                return $"Return processed successfully.\n\nNOTICE: This copy has been set aside for member " +
                       $"{oldestRes.UserID} who had a reservation. A notification has been sent.";
            }

            _copyDAO.UpdateStatus(copyId, "Available");
            return "Return processed successfully. Copy is now available.";
        }

        public List<LoanDTO> GetReturnHistory()
        {
            var loans = _loanDAO.FindAll().Where(l => l.Status == "Returned").ToList();
            var result = new List<LoanDTO>();
            var userDAO = new UserDAOImpl();
            var copyDAO = new CopyDAOImpl();
            var bookDAO = new BookDAOImpl();

            foreach (var l in loans)
            {
                var user = userDAO.FindById(l.UserID);
                var copy = copyDAO.FindById(l.CopyID);
                var book = copy != null ? bookDAO.FindById(copy.BookID) : null;
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
                    Status = l.Status
                });
            }
            return result;
        }
    }
}
