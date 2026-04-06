using Sarasavi_Library_MS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasavi_Library_MS.Service
{
    public interface IReservationService
    {
        /// <summary>Creates a reservation. Returns null on success or error message.</summary>
        string MakeReservation(string userId, string bookId);

        List<ReservationDTO> GetAllReservations();
        List<ReservationDTO> GetActiveReservations();
        bool CancelReservation(int reservationId);
        int GetReservationCount();
    }
}
