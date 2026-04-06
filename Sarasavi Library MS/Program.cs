using Sarasavi_Library_MS.Database;
using Sarasavi_Library_MS.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarasavi_Library_MS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Test DB connection before launching
            if (!DBConnection.Instance.TestConnection())
            {
                MessageBox.Show(
                    "Cannot connect to the database.\n\n" +
                    "Please check:\n" +
                    "• SQL Server is running\n" +
                    "• 'SarasaviLibraryDB' database exists\n" +
                    "• Connection string in App.config is correct\n\n" +
                    "Default: Data Source=.;Initial Catalog=SarasaviLibraryDB;Integrated Security=True",
                    "Database Connection Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Application.Run(new LoginForm());
            //Application.Run(new MainForm());
            //Application.Run(new UserMainForm());
        }
    }
}
