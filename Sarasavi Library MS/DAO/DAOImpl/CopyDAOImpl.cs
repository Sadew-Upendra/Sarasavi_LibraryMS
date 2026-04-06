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
    public class CopyDAOImpl : ICopyDAO
    {
        public bool Save(Copy copy)
        {
            const string sql = @"INSERT INTO Copies (CopyID, BookID, CopyType, Status)
                                 VALUES (@CopyID, @BookID, @CopyType, @Status)";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@CopyID", copy.CopyID);
                cmd.Parameters.AddWithValue("@BookID", copy.BookID);
                cmd.Parameters.AddWithValue("@CopyType", copy.CopyType);
                cmd.Parameters.AddWithValue("@Status", copy.Status ?? "Available");
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public Copy FindById(string copyId)
        {
            const string sql = "SELECT * FROM Copies WHERE CopyID=@CopyID";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@CopyID", copyId);
                using (var r = cmd.ExecuteReader())
                    if (r.Read()) return MapCopy(r);
            }
            return null;
        }

        public List<Copy> FindByBookId(string bookId)
        {
            var list = new List<Copy>();
            const string sql = "SELECT * FROM Copies WHERE BookID=@BookID ORDER BY CopyID";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@BookID", bookId);
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) list.Add(MapCopy(r));
            }
            return list;
        }

        public List<Copy> FindAll()
        {
            var list = new List<Copy>();
            const string sql = "SELECT * FROM Copies ORDER BY CopyID";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            using (var r = cmd.ExecuteReader())
                while (r.Read()) list.Add(MapCopy(r));
            return list;
        }

        public bool UpdateStatus(string copyId, string status)
        {
            const string sql = "UPDATE Copies SET Status=@Status WHERE CopyID=@CopyID";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@CopyID", copyId);
                cmd.Parameters.AddWithValue("@Status", status);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(string copyId)
        {
            const string sql = "DELETE FROM Copies WHERE CopyID=@CopyID";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@CopyID", copyId);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public int CountByBookId(string bookId)
        {
            const string sql = "SELECT COUNT(1) FROM Copies WHERE BookID=@BookID";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@BookID", bookId);
                return (int)cmd.ExecuteScalar();
            }
        }

        private static Copy MapCopy(SqlDataReader r) => new Copy
        {
            CopyID = r["CopyID"].ToString(),
            BookID = r["BookID"].ToString(),
            CopyType = r["CopyType"].ToString(),
            Status = r["Status"].ToString()
        };
    }
}
