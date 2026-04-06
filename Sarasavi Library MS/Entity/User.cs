using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasavi_Library_MS.Entity
{
    public class User
    {
        public string UserID { get; set; }
        public string FullName { get; set; }
        public string Sex { get; set; }
        public string NIC { get; set; }
        public string TelephoneNo { get; set; }
        public string Address { get; set; }
        public string UserType { get; set; }  // Member | Visitor
    }
}
