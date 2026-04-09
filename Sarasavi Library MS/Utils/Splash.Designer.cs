namespace Sarasavi_Library_MS.Utils
{
    partial class Splash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SATAUiFramework.BorderRadius borderRadius1 = new SATAUiFramework.BorderRadius();
            this.sataPanel1 = new SATAUiFramework.SATAPanel();
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.sataPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sataPanel1
            // 
            this.sataPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sataPanel1.BackColor2 = System.Drawing.Color.WhiteSmoke;
            this.sataPanel1.BorderColor = System.Drawing.Color.Black;
            borderRadius1.BottomLeft = 10;
            borderRadius1.BottomRight = 10;
            borderRadius1.TopLeft = 10;
            borderRadius1.TopRight = 10;
            this.sataPanel1.BorderRadius = borderRadius1;
            this.sataPanel1.BorderThickness = 0;
            this.sataPanel1.Controls.Add(this.guna2ProgressBar1);
            this.sataPanel1.Location = new System.Drawing.Point(12, 12);
            this.sataPanel1.Name = "sataPanel1";
            this.sataPanel1.Size = new System.Drawing.Size(776, 426);
            this.sataPanel1.TabIndex = 0;
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.FillColor = System.Drawing.Color.MidnightBlue;
            this.guna2ProgressBar1.Location = new System.Drawing.Point(151, 335);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.Size = new System.Drawing.Size(475, 16);
            this.guna2ProgressBar1.TabIndex = 0;
            this.guna2ProgressBar1.Text = "guna2ProgressBar1";
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sataPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.sataPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SATAUiFramework.SATAPanel sataPanel1;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
    }
}