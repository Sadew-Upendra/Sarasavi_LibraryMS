using Sarasavi_Library_MS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasavi_Library_MS.DAO
{
    public interface IReservationDAO
    {
        bool Save(Reservation reservation);
        Reservation FindById(int reservationId);
        List<Reservation> FindByBookId(string bookId);
        List<Reservation> FindByUserId(string userId);
        List<Reservation> FindAllActive();
        List<Reservation> FindAll();
        bool Delete(int reservationId);
        bool UpdateStatus(int reservationId, string status);
        Reservation FindOldestActiveByBookId(string bookId);
    }
}
