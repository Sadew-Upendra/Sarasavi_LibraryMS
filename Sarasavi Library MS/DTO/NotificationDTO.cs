using System;

namespace Sarasavi_Library_MS.DTO
{
    public class NotificationDTO
    {
        public int NotificationID { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsRead { get; set; }
        public string UserID { get; set; }
    }
}