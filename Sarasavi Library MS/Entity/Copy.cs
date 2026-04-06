using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasavi_Library_MS.Entity
{
    public class Copy
    {
        public string CopyID { get; set; }
        public string BookID { get; set; }
        public string CopyType { get; set; }  // Borrowable | Reference
        public string Status { get; set; }  // Available | Loaned | Reserved
    }
}
