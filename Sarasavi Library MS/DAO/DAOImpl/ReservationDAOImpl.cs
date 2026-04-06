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
    public class ReservationDAOImpl : IReservationDAO
    {
        public bool Save(Reservation res)
        {
            const string sql = @"INSERT INTO Reservations (UserID, BookID, ReservedDate, Status)
                                 VALUES (@UserID, @BookID, @ReservedDate, @Status)";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@UserID", res.UserID);
                cmd.Parameters.AddWithValue("@BookID", res.BookID);
                cmd.Parameters.AddWithValue("@ReservedDate", res.ReservedDate.Date);
                cmd.Parameters.AddWithValue("@Status", res.Status ?? "Active");
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public Reservation FindById(int id)
        {
            const string sql = "SELECT * FROM Reservations WHERE ReservationID=@ID";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                using (var r = cmd.ExecuteReader())
                    if (r.Read()) return MapRes(r);
            }
            return null;
        }

        public List<Reservation> FindByBookId(string bookId)
        {
            var list = new List<Reservation>();
            const string sql = "SELECT * FROM Reservations WHERE BookID=@BookID ORDER BY ReservedDate";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@BookID", bookId);
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) list.Add(MapRes(r));
            }
            return list;
        }

        public List<Reservation> FindByUserId(string userId)
        {
            var list = new List<Reservation>();
            const string sql = "SELECT * FROM Reservations WHERE UserID=@UserID ORDER BY ReservedDate DESC";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) list.Add(MapRes(r));
            }
            return list;
        }

        public List<Reservation> FindAllActive()
        {
            var list = new List<Reservation>();
            const string sql = "SELECT * FROM Reservations WHERE Status='Active' ORDER BY ReservedDate";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            using (var r = cmd.ExecuteReader())
                while (r.Read()) list.Add(MapRes(r));
            return list;
        }

        public List<Reservation> FindAll()
        {
            var list = new List<Reservation>();
            const string sql = "SELECT * FROM Reservations ORDER BY ReservedDate DESC";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            using (var r = cmd.ExecuteReader())
                while (r.Read()) list.Add(MapRes(r));
            return list;
        }

        public bool Delete(int id)
        {
            const string sql = "DELETE FROM Reservations WHERE ReservationID=@ID";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateStatus(int id, string status)
        {
            const string sql = "UPDATE Reservations SET Status=@Status WHERE ReservationID=@ID";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Status", status);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public Reservation FindOldestActiveByBookId(string bookId)
        {
            const string sql = @"SELECT TOP 1 * FROM Reservations
                                 WHERE BookID=@BookID AND Status='Active'
                                 ORDER BY ReservedDate ASC";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@BookID", bookId);
                using (var r = cmd.ExecuteReader())
                    if (r.Read()) return MapRes(r);
            }
            return null;
        }

        private static Reservation MapRes(SqlDataReader r) => new Reservation
        {
            ReservationID = (int)r["ReservationID"],
            UserID = r["UserID"].ToString(),
            BookID = r["BookID"].ToString(),
            ReservedDate = (DateTime)r["ReservedDate"],
            Status = r["Status"].ToString()
        };
    }
}
