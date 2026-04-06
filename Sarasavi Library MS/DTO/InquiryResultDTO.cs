using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasavi_Library_MS.DTO
{
    public class InquiryResultDTO
    {
        public string BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }
        public int TotalCopies { get; set; }
        public int AvailableCopies { get; set; }
        public int LoanedCopies { get; set; }
        public int ReferenceCopies { get; set; }
        public int ReservedCopies { get; set; }
        public string AvailabilityStatus { get; set; }
    }
}
