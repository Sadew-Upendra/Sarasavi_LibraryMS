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
    public class UserDAOImpl : IUserDAO
    {
        public bool Save(User user)
        {
            const string sql = @"INSERT INTO Users (UserID, FullName, Sex, NIC, TelephoneNo, Address, UserType)
                                 VALUES (@UserID, @FullName, @Sex, @NIC, @TelephoneNo, @Address, @UserType)";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@UserID", user.UserID);
                cmd.Parameters.AddWithValue("@FullName", user.FullName);
                cmd.Parameters.AddWithValue("@Sex", user.Sex);
                cmd.Parameters.AddWithValue("@NIC", user.NIC);
                cmd.Parameters.AddWithValue("@TelephoneNo", (object)user.TelephoneNo ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Address", (object)user.Address ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@UserType", user.UserType);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public User FindById(string userId)
        {
            const string sql = "SELECT * FROM Users WHERE UserID=@UserID";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                using (var r = cmd.ExecuteReader())
                    if (r.Read()) return MapUser(r);
            }
            return null;
        }

        public List<User> FindAll()
        {
            var list = new List<User>();
            const string sql = "SELECT * FROM Users ORDER BY UserID";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            using (var r = cmd.ExecuteReader())
                while (r.Read()) list.Add(MapUser(r));
            return list;
        }

        public bool Update(User user)
        {
            const string sql = @"UPDATE Users SET FullName=@FullName, Sex=@Sex, NIC=@NIC,
                                 TelephoneNo=@TelephoneNo, Address=@Address, UserType=@UserType
                                 WHERE UserID=@UserID";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@UserID", user.UserID);
                cmd.Parameters.AddWithValue("@FullName", user.FullName);
                cmd.Parameters.AddWithValue("@Sex", user.Sex);
                cmd.Parameters.AddWithValue("@NIC", user.NIC);
                cmd.Parameters.AddWithValue("@TelephoneNo", (object)user.TelephoneNo ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Address", (object)user.Address ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@UserType", user.UserType);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(string userId)
        {
            using (var con = DBConnection.Instance.GetConnection())
            {
                // Remove login first
                using (var cmd = new SqlCommand("DELETE FROM LoginTbl WHERE Username=@Username", con))
                {
                    cmd.Parameters.AddWithValue("@Username", userId);
                    cmd.ExecuteNonQuery();
                }
                using (var cmd = new SqlCommand("DELETE FROM Users WHERE UserID=@UserID", con))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool ExistsByNic(string nic)
        {
            const string sql = "SELECT COUNT(1) FROM Users WHERE NIC=@NIC";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@NIC", nic);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public string GetNextUserId()
        {
            const string sql = @"SELECT ISNULL(MAX(CAST(SUBSTRING(UserID,3,4) AS INT)),0) FROM Users";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                int maxNum = (int)cmd.ExecuteScalar();
                return "U-" + (maxNum + 1).ToString("D4");
            }
        }

        public bool SaveLogin(string username, string password, string role)
        {
            const string sql = @"INSERT INTO LoginTbl (Username, Password, Role)
                                 VALUES (@Username, @Password, @Role)";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Role", role);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteLogin(string username)
        {
            const string sql = "DELETE FROM LoginTbl WHERE Username=@Username";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>Validates login credentials. Returns Role string or null if invalid.</summary>
        public string ValidateLogin(string username, string password)
        {
            const string sql = "SELECT Role FROM LoginTbl WHERE Username=@Username AND Password=@Password";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                var result = cmd.ExecuteScalar();
                return result?.ToString();
            }
        }

        private static User MapUser(SqlDataReader r) => new User
        {
            UserID = r["UserID"].ToString(),
            FullName = r["FullName"].ToString(),
            Sex = r["Sex"].ToString(),
            NIC = r["NIC"].ToString(),
            TelephoneNo = r["TelephoneNo"] == DBNull.Value ? null : r["TelephoneNo"].ToString(),
            Address = r["Address"] == DBNull.Value ? null : r["Address"].ToString(),
            UserType = r["UserType"].ToString()
        };
    }
}
