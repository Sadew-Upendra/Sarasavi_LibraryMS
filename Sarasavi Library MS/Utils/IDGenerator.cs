using Sarasavi_Library_MS.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasavi_Library_MS.Utils
{
    public interface IDGenerator
    {
        /*
        public static string GenerateID(string prefix, string table, string column)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = $"SELECT TOP 1 {column} FROM {table} ORDER BY {column} DESC";
                SqlCommand cmd = new SqlCommand(query, con);
                var result = cmd.ExecuteScalar();

                if (result == null)
                    return prefix + "0001";

                int num = int.Parse(result.ToString().Split('-')[1]);
                return prefix + (num + 1).ToString("D4");
            }
        }*/
    }
}
