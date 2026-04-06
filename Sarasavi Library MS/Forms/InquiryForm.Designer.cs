namespace Sarasavi_Library_MS.Forms
{
    partial class InquiryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InquiryForm));
            SATAUiFramework.BorderRadius borderRadius1 = new SATAUiFramework.BorderRadius();
            this.btnSearch = new FrameworkTest.SATAButton();
            this.sataPanel1 = new SATAUiFramework.SATAPanel();
            this.txtDetails = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sataPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.ButtonText = "Search";
            this.btnSearch.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnSearch.CheckedForeColor = System.Drawing.Color.White;
            this.btnSearch.CheckedImageTint = System.Drawing.Color.White;
            this.btnSearch.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnSearch.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.HoverBackground = System.Drawing.Color.Yellow;
            this.btnSearch.HoverForeColor = System.Drawing.Color.Black;
            this.btnSearch.HoverImage = null;
            this.btnSearch.HoverImageTint = System.Drawing.Color.White;
            this.btnSearch.HoverOutline = System.Drawing.Color.Empty;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAutoCenter = true;
            this.btnSearch.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnSearch.ImageOffset = new System.Drawing.Point(-4, 0);
            this.btnSearch.ImageTint = System.Drawing.Color.White;
            this.btnSearch.IsToggleButton = false;
            this.btnSearch.IsToggled = false;
            this.btnSearch.Location = new System.Drawing.Point(816, 87);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NormalBackground = System.Drawing.Color.Gold;
            this.btnSearch.NormalForeColor = System.Drawing.Color.Black;
            this.btnSearch.NormalOutline = System.Drawing.Color.Empty;
            this.btnSearch.OutlineThickness = 2F;
            this.btnSearch.PressedBackground = System.Drawing.Color.Yellow;
            this.btnSearch.PressedForeColor = System.Drawing.Color.Black;
            this.btnSearch.PressedImageTint = System.Drawing.Color.White;
            this.btnSearch.PressedOutline = System.Drawing.Color.Empty;
            this.btnSearch.Rounding = new System.Windows.Forms.Padding(5);
            this.btnSearch.Size = new System.Drawing.Size(209, 43);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.TextAutoCenter = true;
            this.btnSearch.TextOffset = new System.Drawing.Point(4, 0);
            // 
            // sataPanel1
            // 
            this.sataPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.sataPanel1.BackColor2 = System.Drawing.Color.Ivory;
            this.sataPanel1.BorderColor = System.Drawing.Color.SkyBlue;
            borderRadius1.BottomLeft = 10;
            borderRadius1.BottomRight = 10;
            borderRadius1.TopLeft = 10;
            borderRadius1.TopRight = 10;
            this.sataPanel1.BorderRadius = borderRadius1;
            this.sataPanel1.BorderThickness = 2;
            this.sataPanel1.Controls.Add(this.txtDetails);
            this.sataPanel1.Controls.Add(this.label1);
            this.sataPanel1.Controls.Add(this.btnSearch);
            this.sataPanel1.Location = new System.Drawing.Point(22, 83);
            this.sataPanel1.Name = "sataPanel1";
            this.sataPanel1.Size = new System.Drawing.Size(1056, 156);
            this.sataPanel1.TabIndex = 17;
            // 
            // txtDetails
            // 
            this.txtDetails.BorderColor = System.Drawing.Color.LightGray;
            this.txtDetails.BorderRadius = 5;
            this.txtDetails.BorderThickness = 2;
            this.txtDetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDetails.DefaultText = "";
            this.txtDetails.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDetails.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDetails.FocusedState.BorderColor = System.Drawing.Color.CadetBlue;
            this.txtDetails.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.ForeColor = System.Drawing.Color.Black;
            this.txtDetails.HoverState.BorderColor = System.Drawing.Color.CadetBlue;
            this.txtDetails.Location = new System.Drawing.Point(28, 87);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDetails.PlaceholderText = "Search by Book ID, Title, or Author...";
            this.txtDetails.SelectedText = "";
            this.txtDetails.Size = new System.Drawing.Size(754, 43);
            this.txtDetails.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(470, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Book Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(501, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Search book availability by accession number, title, or author";
            // 
            // InquiryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1108, 660);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sataPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InquiryForm";
            this.Text = "InquiryForm";
            this.sataPanel1.ResumeLayout(false);
            this.sataPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FrameworkTest.SATAButton btnSearch;
        private SATAUiFramework.SATAPanel sataPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtDetails;
    }
}