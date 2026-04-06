using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasavi_Library_MS.DTO
{
    public class LoanDTO
    {
        public int LoanID { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string CopyID { get; set; }
        public string BookTitle { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string Status { get; set; }
        public bool IsOverdue => Status == "Active" && DueDate < DateTime.Today;
    }
}
