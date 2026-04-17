using Sarasavi_Library_MS.DAO;
using Sarasavi_Library_MS.DAO.DAOImpl;
using Sarasavi_Library_MS.DTO;
using Sarasavi_Library_MS.Entity;
using Sarasavi_Library_MS.Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sarasavi_Library_MS.Service.ServiceImpl
{
    public class NotificationServiceImpl : INotificationService
    {
        private readonly INotificationDAO _notifDAO = new NotificationDAOImpl();

        public List<NotificationDTO> GetNotificationsForUser(string userId, string role)
        {
            var allEntities = _notifDAO.FindAll();

            // Logic: If user, only show their notifications. If admin/librarian, show all.
            var filtered = role.ToLower() == "admin"
                ? allEntities
                : allEntities.Where(n => n.UserID == userId || string.IsNullOrEmpty(n.UserID)).ToList();

            return filtered.Select(n => new NotificationDTO
            {
                NotificationID = n.NotificationID,
                Message = n.Message,
                CreatedDate = n.CreatedDate,
                IsRead = n.IsRead,
                UserID = n.UserID
            }).ToList();
        }

        public int GetUnreadCount(string userId, string role)
        {
            var unread = _notifDAO.FindUnread();
            if (role.ToLower() == "admin") return unread.Count;
            return unread.Count(n => n.UserID == userId || string.IsNullOrEmpty(n.UserID));
        }

        public bool MarkAsRead(int id) => _notifDAO.MarkAsRead(id);

        public bool ClearAllForUser(string userId, string role)
        {
            // Implementation logic to mark all as read or delete
            return _notifDAO.MarkAllAsRead();
        }
    }
}

/*using Sarasavi_Library_MS.DAO;
using Sarasavi_Library_MS.DAO.DAOImpl;
using Sarasavi_Library_MS.DTO;
using Sarasavi_Library_MS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sarasavi_Library_MS.Service.ServiceImpl
{
    public class NotificationServiceImpl : INotificationService
    {
        private readonly INotificationDAO _notifDAO = new NotificationDAOImpl();
        private readonly UserDAOImpl _userDAO = new UserDAOImpl();

        public bool SendNotification(string userId, string message)
        {
            var notification = new Notification
            {
                UserID = userId,
                Message = message,
                CreatedDate = DateTime.Now,
                IsRead = false
            };
            return _notifDAO.Save(notification);
        }

        public List<NotificationDTO> GetUserNotifications(string userId)
        {
            var allNotifications = _notifDAO.FindAll();
            var userNotifications = allNotifications.Where(n => n.UserID == userId).ToList();
            return ToDTOs(userNotifications);
        }

        public List<NotificationDTO> GetAllNotifications()
        {
            return ToDTOs(_notifDAO.FindAll());
        }

        

        public bool MarkAsRead(int notificationId)
        {
            return _notifDAO.MarkAsRead(notificationId);
        }

        public bool MarkAllAsRead()
        {
            return _notifDAO.MarkAllAsRead();
        }

        public int GetUnreadCount(string userId)
        {
            var allNotifications = _notifDAO.FindAll();
            return allNotifications.Count(n => n.UserID == userId && !n.IsRead);
        }

        public int GetUnreadCountForUser(string userId)
        {
            return GetUnreadCount(userId);
        }

        private List<NotificationDTO> ToDTOs(List<Notification> notifications)
        {
            var result = new List<NotificationDTO>();
            foreach (var n in notifications)
            {
                var user = _userDAO.FindById(n.UserID);
                result.Add(new NotificationDTO
                {
                    NotificationID = n.NotificationID,
                    UserID = n.UserID,
                    UserName = user?.FullName ?? n.UserID,
                    Message = n.Message,
                    CreatedDate = n.CreatedDate,
                    IsRead = n.IsRead
                });
            }
            return result.OrderByDescending(n => n.CreatedDate).ToList();
        }

        // Add to NotificationServiceImpl.cs
        public List<NotificationDTO> GetUnreadNotificationsForUser(string userId)
        {
            var allNotifications = _notifDAO.FindAll();
            var unreadNotifications = allNotifications
                .Where(n => n.UserID == userId && !n.IsRead)
                .OrderByDescending(n => n.CreatedDate)
                .ToList();
            return ToDTOs(unreadNotifications);
        }
    }
}
*/