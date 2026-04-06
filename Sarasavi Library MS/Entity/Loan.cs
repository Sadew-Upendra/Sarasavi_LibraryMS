using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasavi_Library_MS.Entity
{
    public class Loan
    {
        public int LoanID { get; set; }
        public string UserID { get; set; }
        public string CopyID { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string Status { get; set; }  // Active | Returned | Overdue
    }
}
