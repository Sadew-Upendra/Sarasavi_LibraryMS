//using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sarasavi_Library_MS.Database
{
    /// <summary>
    /// Provides SQL Server connection management.
    /// Each call to GetConnection() opens a fresh connection — close it after use.
    /// </summary>
    public class DBConnection
    {
        private static DBConnection _instance;
        private static readonly object _lock = new object();
        private readonly string _connectionString;

        private DBConnection()
        {
            var configString = ConfigurationManager.ConnectionStrings["SarasaviDB"]?.ConnectionString;

            if (string.IsNullOrEmpty(configString))
            {
                // Update this fallback to your specific SQLEXPRESS instance name
                _connectionString = @"Data Source=DESKTOP-6MNBNUH\SQLEXPRESS;Initial Catalog=SarasaviLibraryDB;Integrated Security=True;";
            }
            else
            {
                _connectionString = configString;
            }
        }

        public static DBConnection Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new DBConnection();
                    return _instance;
                }
            }
        }

        public SqlConnection GetConnection()
        {
            // The using block in your DAO will handle closing this
            var connection = new SqlConnection(_connectionString);
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            return connection;
        }

        public bool TestConnection()
        {
            try
            {
                using (var con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    return con.State == System.Data.ConnectionState.Open;
                }
            }
            catch (Exception ex)
            {
                // Useful for debugging why the connection failed
                //Console.WriteLine("Connection Error: " + ex.Message);
                //return false;
                MessageBox.Show("Actual Error: " + ex.Message);
                return false;
            }
        }
    }

    /*
    public static class DBConnection
    {
        /*
        private static string connectionString =
            "Data Source=DESKTOP-6MNBNUH\\SQLEXPRESS;Initial Catalog=SarasaviLibraryDB;Integrated Security=True;Trust Server Certificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
        ==================

        private const string Server = "localhost";
        private const string DbName = "SarasaviLibraryDB";
        private const string UserId = "root";
        private const string Password = "1234";

        private static string ConnectionString =>
            $"Server={Server};Database={DbName};Uid={UserId};Pwd={Password};CharSet=utf8;";

        public static MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }

        public static bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    return conn.State == System.Data.ConnectionState.Open;
                }    
            }
            catch { return false; }
        }
    }
    */
}

