using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasavi_Library_MS.DTO
{
    public class ReservationDTO
    {
        public int ReservationID { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string BookID { get; set; }
        public string BookTitle { get; set; }
        public DateTime ReservedDate { get; set; }
        public string Status { get; set; }
    }
}
