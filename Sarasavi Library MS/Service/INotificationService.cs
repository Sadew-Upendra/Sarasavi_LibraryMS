using Sarasavi_Library_MS.DTO;
using System.Collections.Generic;

namespace Sarasavi_Library_MS.Service
{
    public interface INotificationService
    {
        List<NotificationDTO> GetNotificationsForUser(string userId, string role);
        int GetUnreadCount(string userId, string role);
        bool MarkAsRead(int notificationId);
        bool ClearAllForUser(string userId, string role);
    }
}