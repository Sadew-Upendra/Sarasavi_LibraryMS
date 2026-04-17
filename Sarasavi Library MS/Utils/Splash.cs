using Sarasavi_Library_MS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarasavi_Library_MS.Utils
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100)
            {
                progressBar.Value += 1;
                lblLoader.Text = progressBar.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();

                try
                {
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();

                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}\n\nStack Trace: {ex.StackTrace}");
                }
            }
        }
    }
}
