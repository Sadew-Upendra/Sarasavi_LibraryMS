namespace Sarasavi_Library_MS.Forms
{
    partial class ReservationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sataPanel1 = new SATAUiFramework.SATAPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReserveBook = new FrameworkTest.SATAButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvReservations = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelRes = new FrameworkTest.SATAButton();
            this.txtBookID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.sataPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.sataPanel1.Controls.Add(this.lblStatus);
            this.sataPanel1.Controls.Add(this.txtUserID);
            this.sataPanel1.Controls.Add(this.txtBookID);
            this.sataPanel1.Controls.Add(this.label3);
            this.sataPanel1.Controls.Add(this.label2);
            this.sataPanel1.Controls.Add(this.label1);
            this.sataPanel1.Controls.Add(this.btnReserveBook);
            this.sataPanel1.Location = new System.Drawing.Point(26, 33);
            this.sataPanel1.Name = "sataPanel1";
            this.sataPanel1.Size = new System.Drawing.Size(1043, 245);
            this.sataPanel1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(569, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Book ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "User ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(431, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "New Reservation";
            // 
            // btnReserveBook
            // 
            this.btnReserveBook.ButtonText = "Reserve Book";
            this.btnReserveBook.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnReserveBook.CheckedForeColor = System.Drawing.Color.White;
            this.btnReserveBook.CheckedImageTint = System.Drawing.Color.White;
            this.btnReserveBook.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnReserveBook.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReserveBook.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserveBook.HoverBackground = System.Drawing.Color.Yellow;
            this.btnReserveBook.HoverForeColor = System.Drawing.Color.Black;
            this.btnReserveBook.HoverImage = null;
            this.btnReserveBook.HoverImageTint = System.Drawing.Color.White;
            this.btnReserveBook.HoverOutline = System.Drawing.Color.Empty;
            this.btnReserveBook.Image = ((System.Drawing.Image)(resources.GetObject("btnReserveBook.Image")));
            this.btnReserveBook.ImageAutoCenter = true;
            this.btnReserveBook.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnReserveBook.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnReserveBook.ImageTint = System.Drawing.Color.White;
            this.btnReserveBook.IsToggleButton = false;
            this.btnReserveBook.IsToggled = false;
            this.btnReserveBook.Location = new System.Drawing.Point(415, 171);
            this.btnReserveBook.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReserveBook.Name = "btnReserveBook";
            this.btnReserveBook.NormalBackground = System.Drawing.Color.Gold;
            this.btnReserveBook.NormalForeColor = System.Drawing.Color.Black;
            this.btnReserveBook.NormalOutline = System.Drawing.Color.Empty;
            this.btnReserveBook.OutlineThickness = 2F;
            this.btnReserveBook.PressedBackground = System.Drawing.Color.Yellow;
            this.btnReserveBook.PressedForeColor = System.Drawing.Color.Black;
            this.btnReserveBook.PressedImageTint = System.Drawing.Color.White;
            this.btnReserveBook.PressedOutline = System.Drawing.Color.Empty;
            this.btnReserveBook.Rounding = new System.Windows.Forms.Padding(5);
            this.btnReserveBook.Size = new System.Drawing.Size(209, 43);
            this.btnReserveBook.TabIndex = 16;
            this.btnReserveBook.TextAutoCenter = true;
            this.btnReserveBook.TextOffset = new System.Drawing.Point(2, 0);
            this.btnReserveBook.Click += new System.EventHandler(this.btnReserveBook_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(470, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "All Reservations";
            // 
            // dgvReservations
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvReservations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReservations.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReservations.ColumnHeadersHeight = 27;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservations.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReservations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReservations.Location = new System.Drawing.Point(26, 60);
            this.dgvReservations.MultiSelect = false;
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.RowHeadersVisible = false;
            this.dgvReservations.RowHeadersWidth = 51;
            this.dgvReservations.RowTemplate.Height = 24;
            this.dgvReservations.Size = new System.Drawing.Size(1043, 198);
            this.dgvReservations.TabIndex = 23;
            this.dgvReservations.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReservations.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvReservations.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvReservations.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvReservations.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvReservations.ThemeStyle.BackColor = System.Drawing.Color.GhostWhite;
            this.dgvReservations.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReservations.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvReservations.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReservations.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReservations.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReservations.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvReservations.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvReservations.ThemeStyle.ReadOnly = false;
            this.dgvReservations.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReservations.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReservations.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReservations.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvReservations.ThemeStyle.RowsStyle.Height = 24;
            this.dgvReservations.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReservations.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.btnCancelRes);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dgvReservations);
            this.panel1.Location = new System.Drawing.Point(0, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 354);
            this.panel1.TabIndex = 24;
            // 
            // btnCancelRes
            // 
            this.btnCancelRes.ButtonText = "Cancel";
            this.btnCancelRes.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnCancelRes.CheckedForeColor = System.Drawing.Color.White;
            this.btnCancelRes.CheckedImageTint = System.Drawing.Color.White;
            this.btnCancelRes.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnCancelRes.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancelRes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelRes.HoverBackground = System.Drawing.Color.Chocolate;
            this.btnCancelRes.HoverForeColor = System.Drawing.Color.White;
            this.btnCancelRes.HoverImage = null;
            this.btnCancelRes.HoverImageTint = System.Drawing.Color.White;
            this.btnCancelRes.HoverOutline = System.Drawing.Color.Empty;
            this.btnCancelRes.Image = null;
            this.btnCancelRes.ImageAutoCenter = true;
            this.btnCancelRes.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnCancelRes.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCancelRes.ImageTint = System.Drawing.Color.White;
            this.btnCancelRes.IsToggleButton = false;
            this.btnCancelRes.IsToggled = false;
            this.btnCancelRes.Location = new System.Drawing.Point(954, 286);
            this.btnCancelRes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelRes.Name = "btnCancelRes";
            this.btnCancelRes.NormalBackground = System.Drawing.Color.SaddleBrown;
            this.btnCancelRes.NormalForeColor = System.Drawing.Color.White;
            this.btnCancelRes.NormalOutline = System.Drawing.Color.Empty;
            this.btnCancelRes.OutlineThickness = 2F;
            this.btnCancelRes.PressedBackground = System.Drawing.Color.Chocolate;
            this.btnCancelRes.PressedForeColor = System.Drawing.Color.White;
            this.btnCancelRes.PressedImageTint = System.Drawing.Color.White;
            this.btnCancelRes.PressedOutline = System.Drawing.Color.Empty;
            this.btnCancelRes.Rounding = new System.Windows.Forms.Padding(5);
            this.btnCancelRes.Size = new System.Drawing.Size(115, 38);
            this.btnCancelRes.TabIndex = 37;
            this.btnCancelRes.TextAutoCenter = true;
            this.btnCancelRes.TextOffset = new System.Drawing.Point(0, 0);
            this.btnCancelRes.Click += new System.EventHandler(this.btnCancelRes_Click);
            // 
            // txtBookID
            // 
            this.txtBookID.BorderColor = System.Drawing.Color.LightGray;
            this.txtBookID.BorderRadius = 5;
            this.txtBookID.BorderThickness = 2;
            this.txtBookID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookID.DefaultText = "";
            this.txtBookID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBookID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBookID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookID.FocusedState.BorderColor = System.Drawing.Color.CadetBlue;
            this.txtBookID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.ForeColor = System.Drawing.Color.Black;
            this.txtBookID.HoverState.BorderColor = System.Drawing.Color.CadetBlue;
            this.txtBookID.Location = new System.Drawing.Point(688, 96);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBookID.PlaceholderText = "Ex: B0001";
            this.txtBookID.SelectedText = "";
            this.txtBookID.Size = new System.Drawing.Size(313, 43);
            this.txtBookID.TabIndex = 37;
            // 
            // txtUserID
            // 
            this.txtUserID.BorderColor = System.Drawing.Color.LightGray;
            this.txtUserID.BorderRadius = 5;
            this.txtUserID.BorderThickness = 2;
            this.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserID.DefaultText = "";
            this.txtUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserID.FocusedState.BorderColor = System.Drawing.Color.CadetBlue;
            this.txtUserID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.ForeColor = System.Drawing.Color.Black;
            this.txtUserID.HoverState.BorderColor = System.Drawing.Color.CadetBlue;
            this.txtUserID.Location = new System.Drawing.Point(156, 96);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUserID.PlaceholderText = "Ex: U-0001";
            this.txtUserID.SelectedText = "";
            this.txtUserID.Size = new System.Drawing.Size(313, 43);
            this.txtUserID.TabIndex = 38;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Location = new System.Drawing.Point(685, 211);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 39;
            this.lblStatus.Text = "Status";
            this.lblStatus.Visible = false;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1108, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sataPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationForm";
            this.Text = "ReserveForm";
            this.sataPanel1.ResumeLayout(false);
            this.sataPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SATAUiFramework.SATAPanel sataPanel1;
        private System.Windows.Forms.Label label1;
        private FrameworkTest.SATAButton btnReserveBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView dgvReservations;
        private System.Windows.Forms.Panel panel1;
        private FrameworkTest.SATAButton btnCancelRes;
        private Guna.UI2.WinForms.Guna2TextBox txtUserID;
        private Guna.UI2.WinForms.Guna2TextBox txtBookID;
        private System.Windows.Forms.Label lblStatus;
    }
}