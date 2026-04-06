using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasavi_Library_MS.Entity
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public string UserID { get; set; }
        public string BookID { get; set; }
        public DateTime ReservedDate { get; set; }
        public string Status { get; set; }  // Active | Fulfilled | Cancelled
    }
}
