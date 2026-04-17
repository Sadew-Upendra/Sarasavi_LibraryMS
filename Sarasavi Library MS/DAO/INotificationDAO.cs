using Sarasavi_Library_MS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasavi_Library_MS.DAO
{
    public interface INotificationDAO
    {
        
        bool Save(Notification notification);

        /// <summary>All notifications — unread first, then read. Both ordered by date DESC.</summary>
        List<Notification> FindAllSorted();

        /// <summary>All notifications for a specific user — unread first.</summary>
        List<Notification> FindByUserIdSorted(string userId);

        List<Notification> FindAll();
        List<Notification> FindUnread();
        bool MarkAsRead(int notificationId);
        bool MarkAllAsRead();
        int CountUnread();

        /// <summary>Counts unread notifications scoped to a specific user.</summary>
        int CountUnreadByUserId(string userId);
        
    }
}
