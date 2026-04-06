using Sarasavi_Library_MS.Database;
using Sarasavi_Library_MS.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Sarasavi_Library_MS.DAO.DAOImpl
{
    public class BookDAOImpl : IBookDAO
    {
        public bool Save(Book book)
        {
            const string sql = @"INSERT INTO Books (BookID, Classification, Title, Author, Publisher, ISBN)
                                 VALUES (@BookID, @Classification, @Title, @Author, @Publisher, @ISBN)";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@BookID", book.BookID);
                cmd.Parameters.AddWithValue("@Classification", book.Classification.ToString());
                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@Author", book.Author);
                cmd.Parameters.AddWithValue("@Publisher", (object)book.Publisher ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ISBN", (object)book.ISBN ?? DBNull.Value);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public Book FindById(string bookId)
        {
            const string sql = "SELECT * FROM Books WHERE BookID = @BookID";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@BookID", bookId);
                using (var reader = cmd.ExecuteReader())
                    if (reader.Read()) return MapBook(reader);
            }
            return null;
        }

        public List<Book> FindAll()
        {
            var list = new List<Book>();
            const string sql = "SELECT * FROM Books ORDER BY BookID";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            using (var reader = cmd.ExecuteReader())
                while (reader.Read()) list.Add(MapBook(reader));
            return list;
        }

        public bool Update(Book book)
        {
            const string sql = @"UPDATE Books SET Classification=@Classification, Title=@Title,
                                 Author=@Author, Publisher=@Publisher, ISBN=@ISBN WHERE BookID=@BookID";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@BookID", book.BookID);
                cmd.Parameters.AddWithValue("@Classification", book.Classification.ToString());
                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@Author", book.Author);
                cmd.Parameters.AddWithValue("@Publisher", (object)book.Publisher ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ISBN", (object)book.ISBN ?? DBNull.Value);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(string bookId)
        {
            using (var con = DBConnection.Instance.GetConnection())
            {
                // Delete copies first
                using (var cmd = new SqlCommand("DELETE FROM Copies WHERE BookID=@BookID", con))
                {
                    cmd.Parameters.AddWithValue("@BookID", bookId);
                    cmd.ExecuteNonQuery();
                }
                using (var cmd = new SqlCommand("DELETE FROM Books WHERE BookID=@BookID", con))
                {
                    cmd.Parameters.AddWithValue("@BookID", bookId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool ExistsById(string bookId)
        {
            const string sql = "SELECT COUNT(1) FROM Books WHERE BookID=@BookID";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@BookID", bookId);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public string GetNextBookId(char classification)
        {
            const string sql = @"SELECT ISNULL(MAX(CAST(SUBSTRING(BookID,2,4) AS INT)),0)
                                 FROM Books WHERE Classification=@Classification";
            using (var con = DBConnection.Instance.GetConnection())
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Classification", classification.ToString());
                int maxNum = (int)cmd.ExecuteScalar();
                return classification + (maxNum + 1).ToString("D4");
            }
        }

        private static Book MapBook(SqlDataReader r) => new Book
        {
            BookID = r["BookID"].ToString(),
            Classification = r["Classification"].ToString()[0],
            Title = r["Title"].ToString(),
            Author = r["Author"].ToString(),
            Publisher = r["Publisher"] == DBNull.Value ? null : r["Publisher"].ToString(),
            ISBN = r["ISBN"] == DBNull.Value ? null : r["ISBN"].ToString()
        };
    }
}