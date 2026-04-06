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
        List<Notification> FindAll();
        List<Notification> FindUnread();
        bool MarkAsRead(int notificationId);
        bool MarkAllAsRead();
    }
}
