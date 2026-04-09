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
            SATAUiFramework.BorderRadius borderRadius2 = new SATAUiFramework.BorderRadius();
            this.btnSearch = new FrameworkTest.SATAButton();
            this.sataPanel1 = new SATAUiFramework.SATAPanel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDetail = new SATAUiFramework.SATAPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCopy10 = new System.Windows.Forms.Label();
            this.lblCopy9 = new System.Windows.Forms.Label();
            this.lblCopy8 = new System.Windows.Forms.Label();
            this.lblCopy6 = new System.Windows.Forms.Label();
            this.lblCopy7 = new System.Windows.Forms.Label();
            this.lblDetailTitle = new System.Windows.Forms.Label();
            this.lblCopy5 = new System.Windows.Forms.Label();
            this.lblDetailAuthor = new System.Windows.Forms.Label();
            this.lblCopy4 = new System.Windows.Forms.Label();
            this.lblDetailStatus = new System.Windows.Forms.Label();
            this.lblDetailISBN = new System.Windows.Forms.Label();
            this.lblCopy3 = new System.Windows.Forms.Label();
            this.lblCopy1 = new System.Windows.Forms.Label();
            this.lblCopy2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sataPanel1.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.btnSearch.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnSearch.ImageTint = System.Drawing.Color.White;
            this.btnSearch.IsToggleButton = false;
            this.btnSearch.IsToggled = false;
            this.btnSearch.Location = new System.Drawing.Point(818, 87);
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
            this.btnSearch.Size = new System.Drawing.Size(194, 43);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.TextAutoCenter = true;
            this.btnSearch.TextOffset = new System.Drawing.Point(4, 0);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.sataPanel1.Controls.Add(this.txtSearch);
            this.sataPanel1.Controls.Add(this.label1);
            this.sataPanel1.Controls.Add(this.lblStatus);
            this.sataPanel1.Controls.Add(this.btnSearch);
            this.sataPanel1.Location = new System.Drawing.Point(22, 83);
            this.sataPanel1.Name = "sataPanel1";
            this.sataPanel1.Size = new System.Drawing.Size(1045, 166);
            this.sataPanel1.TabIndex = 17;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.LightGray;
            this.txtSearch.BorderRadius = 5;
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.CadetBlue;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.CadetBlue;
            this.txtSearch.Location = new System.Drawing.Point(28, 87);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "Search by Book ID, Title, or Author...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(754, 43);
            this.txtSearch.TabIndex = 35;
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
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(28, 139);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status";
            this.lblStatus.Visible = false;
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
            // pnlDetail
            // 
            this.pnlDetail.BackColor = System.Drawing.Color.White;
            this.pnlDetail.BackColor2 = System.Drawing.Color.White;
            this.pnlDetail.BorderColor = System.Drawing.Color.SkyBlue;
            borderRadius2.BottomLeft = 10;
            borderRadius2.BottomRight = 10;
            borderRadius2.TopLeft = 10;
            borderRadius2.TopRight = 10;
            this.pnlDetail.BorderRadius = borderRadius2;
            this.pnlDetail.BorderThickness = 2;
            this.pnlDetail.Controls.Add(this.panel1);
            this.pnlDetail.Controls.Add(this.label3);
            this.pnlDetail.Location = new System.Drawing.Point(22, 300);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(1045, 290);
            this.pnlDetail.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.lblCopy10);
            this.panel1.Controls.Add(this.lblCopy9);
            this.panel1.Controls.Add(this.lblCopy8);
            this.panel1.Controls.Add(this.lblCopy6);
            this.panel1.Controls.Add(this.lblCopy7);
            this.panel1.Controls.Add(this.lblDetailTitle);
            this.panel1.Controls.Add(this.lblCopy5);
            this.panel1.Controls.Add(this.lblDetailAuthor);
            this.panel1.Controls.Add(this.lblCopy4);
            this.panel1.Controls.Add(this.lblDetailStatus);
            this.panel1.Controls.Add(this.lblDetailISBN);
            this.panel1.Controls.Add(this.lblCopy3);
            this.panel1.Controls.Add(this.lblCopy1);
            this.panel1.Controls.Add(this.lblCopy2);
            this.panel1.Location = new System.Drawing.Point(31, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 202);
            this.panel1.TabIndex = 19;
            // 
            // lblCopy10
            // 
            this.lblCopy10.AutoSize = true;
            this.lblCopy10.Location = new System.Drawing.Point(688, 167);
            this.lblCopy10.Name = "lblCopy10";
            this.lblCopy10.Size = new System.Drawing.Size(67, 16);
            this.lblCopy10.TabIndex = 13;
            this.lblCopy10.Text = "lblCopy10";
            // 
            // lblCopy9
            // 
            this.lblCopy9.AutoSize = true;
            this.lblCopy9.Location = new System.Drawing.Point(509, 167);
            this.lblCopy9.Name = "lblCopy9";
            this.lblCopy9.Size = new System.Drawing.Size(60, 16);
            this.lblCopy9.TabIndex = 15;
            this.lblCopy9.Text = "lblCopy9";
            // 
            // lblCopy8
            // 
            this.lblCopy8.AutoSize = true;
            this.lblCopy8.Location = new System.Drawing.Point(345, 167);
            this.lblCopy8.Name = "lblCopy8";
            this.lblCopy8.Size = new System.Drawing.Size(60, 16);
            this.lblCopy8.TabIndex = 14;
            this.lblCopy8.Text = "lblCopy8";
            // 
            // lblCopy6
            // 
            this.lblCopy6.AutoSize = true;
            this.lblCopy6.Location = new System.Drawing.Point(32, 167);
            this.lblCopy6.Name = "lblCopy6";
            this.lblCopy6.Size = new System.Drawing.Size(60, 16);
            this.lblCopy6.TabIndex = 12;
            this.lblCopy6.Text = "lblCopy6";
            // 
            // lblCopy7
            // 
            this.lblCopy7.AutoSize = true;
            this.lblCopy7.Location = new System.Drawing.Point(181, 167);
            this.lblCopy7.Name = "lblCopy7";
            this.lblCopy7.Size = new System.Drawing.Size(60, 16);
            this.lblCopy7.TabIndex = 11;
            this.lblCopy7.Text = "lblCopy7";
            // 
            // lblDetailTitle
            // 
            this.lblDetailTitle.AutoSize = true;
            this.lblDetailTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailTitle.ForeColor = System.Drawing.Color.Olive;
            this.lblDetailTitle.Location = new System.Drawing.Point(31, 20);
            this.lblDetailTitle.Name = "lblDetailTitle";
            this.lblDetailTitle.Size = new System.Drawing.Size(104, 23);
            this.lblDetailTitle.TabIndex = 0;
            this.lblDetailTitle.Text = "lblDetailTitle";
            // 
            // lblCopy5
            // 
            this.lblCopy5.AutoSize = true;
            this.lblCopy5.Location = new System.Drawing.Point(688, 136);
            this.lblCopy5.Name = "lblCopy5";
            this.lblCopy5.Size = new System.Drawing.Size(60, 16);
            this.lblCopy5.TabIndex = 6;
            this.lblCopy5.Text = "lblCopy5";
            // 
            // lblDetailAuthor
            // 
            this.lblDetailAuthor.AutoSize = true;
            this.lblDetailAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailAuthor.Location = new System.Drawing.Point(68, 55);
            this.lblDetailAuthor.Name = "lblDetailAuthor";
            this.lblDetailAuthor.Size = new System.Drawing.Size(51, 18);
            this.lblDetailAuthor.TabIndex = 1;
            this.lblDetailAuthor.Text = "Author";
            // 
            // lblCopy4
            // 
            this.lblCopy4.AutoSize = true;
            this.lblCopy4.Location = new System.Drawing.Point(509, 136);
            this.lblCopy4.Name = "lblCopy4";
            this.lblCopy4.Size = new System.Drawing.Size(60, 16);
            this.lblCopy4.TabIndex = 9;
            this.lblCopy4.Text = "lblCopy4";
            // 
            // lblDetailStatus
            // 
            this.lblDetailStatus.AutoSize = true;
            this.lblDetailStatus.Location = new System.Drawing.Point(873, 20);
            this.lblDetailStatus.Name = "lblDetailStatus";
            this.lblDetailStatus.Size = new System.Drawing.Size(44, 16);
            this.lblDetailStatus.TabIndex = 10;
            this.lblDetailStatus.Text = "Status";
            // 
            // lblDetailISBN
            // 
            this.lblDetailISBN.AutoSize = true;
            this.lblDetailISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailISBN.Location = new System.Drawing.Point(68, 84);
            this.lblDetailISBN.Name = "lblDetailISBN";
            this.lblDetailISBN.Size = new System.Drawing.Size(42, 18);
            this.lblDetailISBN.TabIndex = 4;
            this.lblDetailISBN.Text = "ISBN";
            // 
            // lblCopy3
            // 
            this.lblCopy3.AutoSize = true;
            this.lblCopy3.Location = new System.Drawing.Point(345, 136);
            this.lblCopy3.Name = "lblCopy3";
            this.lblCopy3.Size = new System.Drawing.Size(60, 16);
            this.lblCopy3.TabIndex = 7;
            this.lblCopy3.Text = "lblCopy3";
            // 
            // lblCopy1
            // 
            this.lblCopy1.AutoSize = true;
            this.lblCopy1.Location = new System.Drawing.Point(32, 136);
            this.lblCopy1.Name = "lblCopy1";
            this.lblCopy1.Size = new System.Drawing.Size(60, 16);
            this.lblCopy1.TabIndex = 3;
            this.lblCopy1.Text = "lblCopy1";
            // 
            // lblCopy2
            // 
            this.lblCopy2.AutoSize = true;
            this.lblCopy2.Location = new System.Drawing.Point(181, 136);
            this.lblCopy2.Name = "lblCopy2";
            this.lblCopy2.Size = new System.Drawing.Size(60, 16);
            this.lblCopy2.TabIndex = 2;
            this.lblCopy2.Text = "lblCopy2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(470, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Search Result";
            // 
            // InquiryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1108, 660);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sataPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InquiryForm";
            this.Text = "InquiryForm";
            this.sataPanel1.ResumeLayout(false);
            this.sataPanel1.PerformLayout();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FrameworkTest.SATAButton btnSearch;
        private SATAUiFramework.SATAPanel sataPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private SATAUiFramework.SATAPanel pnlDetail;
        private System.Windows.Forms.Label lblDetailISBN;
        private System.Windows.Forms.Label lblCopy1;
        private System.Windows.Forms.Label lblCopy2;
        private System.Windows.Forms.Label lblDetailAuthor;
        private System.Windows.Forms.Label lblDetailTitle;
        private System.Windows.Forms.Label lblCopy4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCopy3;
        private System.Windows.Forms.Label lblCopy5;
        private System.Windows.Forms.Label lblDetailStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCopy10;
        private System.Windows.Forms.Label lblCopy9;
        private System.Windows.Forms.Label lblCopy8;
        private System.Windows.Forms.Label lblCopy6;
        private System.Windows.Forms.Label lblCopy7;
    }
}