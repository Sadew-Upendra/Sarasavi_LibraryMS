using Sarasavi_Library_MS.Database;
using Sarasavi_Library_MS.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasavi_Library_MS.DAO.DAOImpl
{
    public class NotificationDAOImpl : INotificationDAO
    {
        public bool Save(Notification n)
        {
            const string sql = @"INSERT INTO Notifications (UserID, Message, CreatedDate, IsRead)
                                 VALUES (@UserID, @Message, @CreatedDate, 0)";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@UserID", (object)n.UserID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Message", n.Message);
                cmd.Parameters.AddWithValue("@CreatedDate", n.CreatedDate == default ? DateTime.Now : n.CreatedDate);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<Notification> FindAll()
        {
            var list = new List<Notification>();
            const string sql = "SELECT * FROM Notifications ORDER BY CreatedDate DESC";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            using (var r = cmd.ExecuteReader())
                while (r.Read()) list.Add(MapNotif(r));
            return list;
        }

        public List<Notification> FindUnread()
        {
            var list = new List<Notification>();
            const string sql = "SELECT * FROM Notifications WHERE IsRead=0 ORDER BY CreatedDate DESC";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            using (var r = cmd.ExecuteReader())
                while (r.Read()) list.Add(MapNotif(r));
            return list;
        }

        public bool MarkAsRead(int id)
        {
            const string sql = "UPDATE Notifications SET IsRead=1 WHERE NotificationID=@ID";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool MarkAllAsRead()
        {
            const string sql = "UPDATE Notifications SET IsRead=1 WHERE IsRead=0";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
                return cmd.ExecuteNonQuery() >= 0;
        }

        private static Notification MapNotif(SqlDataReader r) => new Notification
        {
            NotificationID = (int)r["NotificationID"],
            UserID = r["UserID"] == DBNull.Value ? null : r["UserID"].ToString(),
            Message = r["Message"].ToString(),
            CreatedDate = (DateTime)r["CreatedDate"],
            IsRead = (bool)r["IsRead"]
        };
    }
}
