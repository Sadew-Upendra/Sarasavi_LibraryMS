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
    public class LoanDAOImpl : ILoanDAO
    {
        public bool Save(Loan loan)
        {
            const string sql = @"INSERT INTO Loans (UserID, CopyID, LoanDate, DueDate, Status)
                                 VALUES (@UserID, @CopyID, @LoanDate, @DueDate, @Status)";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@UserID", loan.UserID);
                cmd.Parameters.AddWithValue("@CopyID", loan.CopyID);
                cmd.Parameters.AddWithValue("@LoanDate", loan.LoanDate.Date);
                cmd.Parameters.AddWithValue("@DueDate", loan.DueDate.Date);
                cmd.Parameters.AddWithValue("@Status", loan.Status ?? "Active");
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public Loan FindById(int loanId)
        {
            const string sql = "SELECT * FROM Loans WHERE LoanID=@LoanID";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@LoanID", loanId);
                using (var r = cmd.ExecuteReader())
                    if (r.Read()) return MapLoan(r);
            }
            return null;
        }

        public List<Loan> FindByUserId(string userId)
        {
            var list = new List<Loan>();
            const string sql = "SELECT * FROM Loans WHERE UserID=@UserID ORDER BY LoanDate DESC";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) list.Add(MapLoan(r));
            }
            return list;
        }

        public List<Loan> FindActiveLoansByCopyId(string copyId)
        {
            var list = new List<Loan>();
            const string sql = "SELECT * FROM Loans WHERE CopyID=@CopyID AND Status='Active'";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@CopyID", copyId);
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) list.Add(MapLoan(r));
            }
            return list;
        }

        public List<Loan> FindAllActive()
        {
            var list = new List<Loan>();
            const string sql = "SELECT * FROM Loans WHERE Status='Active' ORDER BY DueDate";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            using (var r = cmd.ExecuteReader())
                while (r.Read()) list.Add(MapLoan(r));
            return list;
        }

        public List<Loan> FindAll()
        {
            var list = new List<Loan>();
            const string sql = "SELECT * FROM Loans ORDER BY LoanDate DESC";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            using (var r = cmd.ExecuteReader())
                while (r.Read()) list.Add(MapLoan(r));
            return list;
        }

        public bool UpdateStatus(int loanId, string status, DateTime? returnDate)
        {
            const string sql = @"UPDATE Loans SET Status=@Status,
                                 ReturnDate=@ReturnDate WHERE LoanID=@LoanID";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@LoanID", loanId);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@ReturnDate", returnDate.HasValue
                    ? (object)returnDate.Value.Date : DBNull.Value);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public int CountActiveByUserId(string userId)
        {
            const string sql = "SELECT COUNT(1) FROM Loans WHERE UserID=@UserID AND Status='Active'";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                return (int)cmd.ExecuteScalar();
            }
        }

        public bool IsOverdue(int loanId)
        {
            const string sql = @"SELECT COUNT(1) FROM Loans
                                 WHERE LoanID=@LoanID AND Status='Active'
                                 AND DueDate < CAST(GETDATE() AS DATE)";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@LoanID", loanId);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        private static Loan MapLoan(SqlDataReader r) => new Loan
        {
            LoanID = (int)r["LoanID"],
            UserID = r["UserID"].ToString(),
            CopyID = r["CopyID"].ToString(),
            LoanDate = (DateTime)r["LoanDate"],
            DueDate = (DateTime)r["DueDate"],
            ReturnDate = r["ReturnDate"] == DBNull.Value ? (DateTime?)null : (DateTime)r["ReturnDate"],
            Status = r["Status"].ToString()
        };
    }
}
