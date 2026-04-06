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
    public class ReservationServiceImpl : IReservationService
    {
        private readonly IReservationDAO _resDAO = new ReservationDAOImpl();
        private readonly UserDAOImpl _userDAO = new UserDAOImpl();
        private readonly IBookDAO _bookDAO = new BookDAOImpl();

        public string MakeReservation(string userId, string bookId)
        {
            var user = _userDAO.FindById(userId);
            if (user == null) return "User not found.";
            if (user.UserType == "Visitor") return "Visitors cannot make reservations.";

            if (!_bookDAO.ExistsById(bookId)) return "Book not found.";

            // Check if user already has an active reservation for this book
            var existing = _resDAO.FindByUserId(userId)
                .FirstOrDefault(r => r.BookID == bookId && r.Status == "Active");
            if (existing != null)
                return "User already has an active reservation for this book.";

            var res = new Reservation
            {
                UserID = userId,
                BookID = bookId,
                ReservedDate = DateTime.Today,
                Status = "Active"
            };

            return _resDAO.Save(res) ? null : "Failed to save reservation.";
        }

        public List<ReservationDTO> GetAllReservations() => ToDTOs(_resDAO.FindAll());
        public List<ReservationDTO> GetActiveReservations() => ToDTOs(_resDAO.FindAllActive());
        public bool CancelReservation(int id) => _resDAO.Delete(id);
        public int GetReservationCount() => _resDAO.FindAllActive().Count;

        private List<ReservationDTO> ToDTOs(List<Reservation> list)
        {
            var result = new List<ReservationDTO>();
            foreach (var r in list)
            {
                var user = _userDAO.FindById(r.UserID);
                var book = _bookDAO.FindById(r.BookID);
                result.Add(new ReservationDTO
                {
                    ReservationID = r.ReservationID,
                    UserID = r.UserID,
                    UserName = user?.FullName ?? r.UserID,
                    BookID = r.BookID,
                    BookTitle = book?.Title ?? r.BookID,
                    ReservedDate = r.ReservedDate,
                    Status = r.Status
                });
            }
            return result;
        }
    }
}
