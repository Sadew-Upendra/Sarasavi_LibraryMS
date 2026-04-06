namespace Sarasavi_Library_MS.Forms
{
    partial class ReturnForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnForm));
            SATAUiFramework.BorderRadius borderRadius1 = new SATAUiFramework.BorderRadius();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvReturnHistory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.btnProcessReturn = new FrameworkTest.SATAButton();
            this.txtCopyID = new Guna.UI2.WinForms.Guna2TextBox();
            this.sataPanel1 = new SATAUiFramework.SATAPanel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnHistory)).BeginInit();
            this.sataPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Return History";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.dgvReturnHistory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 461);
            this.panel1.TabIndex = 1;
            // 
            // dgvReturnHistory
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvReturnHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReturnHistory.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturnHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReturnHistory.ColumnHeadersHeight = 27;
            this.dgvReturnHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReturnHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReturnHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReturnHistory.Location = new System.Drawing.Point(21, 81);
            this.dgvReturnHistory.MultiSelect = false;
            this.dgvReturnHistory.Name = "dgvReturnHistory";
            this.dgvReturnHistory.RowHeadersVisible = false;
            this.dgvReturnHistory.RowHeadersWidth = 51;
            this.dgvReturnHistory.RowTemplate.Height = 24;
            this.dgvReturnHistory.Size = new System.Drawing.Size(1054, 326);
            this.dgvReturnHistory.TabIndex = 1;
            this.dgvReturnHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReturnHistory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvReturnHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvReturnHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvReturnHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvReturnHistory.ThemeStyle.BackColor = System.Drawing.Color.GhostWhite;
            this.dgvReturnHistory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReturnHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvReturnHistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReturnHistory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReturnHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReturnHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvReturnHistory.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvReturnHistory.ThemeStyle.ReadOnly = false;
            this.dgvReturnHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReturnHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReturnHistory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReturnHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvReturnHistory.ThemeStyle.RowsStyle.Height = 24;
            this.dgvReturnHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReturnHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(27, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 23);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Copy ID:";
            // 
            // btnProcessReturn
            // 
            this.btnProcessReturn.ButtonText = "Process Return";
            this.btnProcessReturn.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnProcessReturn.CheckedForeColor = System.Drawing.Color.White;
            this.btnProcessReturn.CheckedImageTint = System.Drawing.Color.White;
            this.btnProcessReturn.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnProcessReturn.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProcessReturn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessReturn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnProcessReturn.HoverForeColor = System.Drawing.Color.Black;
            this.btnProcessReturn.HoverImage = null;
            this.btnProcessReturn.HoverImageTint = System.Drawing.Color.White;
            this.btnProcessReturn.HoverOutline = System.Drawing.Color.Empty;
            this.btnProcessReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnProcessReturn.Image")));
            this.btnProcessReturn.ImageAutoCenter = true;
            this.btnProcessReturn.ImageExpand = new System.Drawing.Point(-1, 0);
            this.btnProcessReturn.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnProcessReturn.ImageTint = System.Drawing.Color.White;
            this.btnProcessReturn.IsToggleButton = false;
            this.btnProcessReturn.IsToggled = false;
            this.btnProcessReturn.Location = new System.Drawing.Point(816, 49);
            this.btnProcessReturn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProcessReturn.Name = "btnProcessReturn";
            this.btnProcessReturn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnProcessReturn.NormalForeColor = System.Drawing.Color.Black;
            this.btnProcessReturn.NormalOutline = System.Drawing.Color.Empty;
            this.btnProcessReturn.OutlineThickness = 2F;
            this.btnProcessReturn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnProcessReturn.PressedForeColor = System.Drawing.Color.Black;
            this.btnProcessReturn.PressedImageTint = System.Drawing.Color.White;
            this.btnProcessReturn.PressedOutline = System.Drawing.Color.Empty;
            this.btnProcessReturn.Rounding = new System.Windows.Forms.Padding(5);
            this.btnProcessReturn.Size = new System.Drawing.Size(209, 43);
            this.btnProcessReturn.TabIndex = 13;
            this.btnProcessReturn.TextAutoCenter = true;
            this.btnProcessReturn.TextOffset = new System.Drawing.Point(1, 0);
            this.btnProcessReturn.Click += new System.EventHandler(this.btnProcessReturn_Click);
            // 
            // txtCopyID
            // 
            this.txtCopyID.BorderColor = System.Drawing.Color.LightGray;
            this.txtCopyID.BorderRadius = 5;
            this.txtCopyID.BorderThickness = 2;
            this.txtCopyID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCopyID.DefaultText = "";
            this.txtCopyID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCopyID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCopyID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCopyID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCopyID.FocusedState.BorderColor = System.Drawing.Color.CadetBlue;
            this.txtCopyID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopyID.ForeColor = System.Drawing.Color.Black;
            this.txtCopyID.HoverState.BorderColor = System.Drawing.Color.CadetBlue;
            this.txtCopyID.Location = new System.Drawing.Point(143, 49);
            this.txtCopyID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCopyID.Name = "txtCopyID";
            this.txtCopyID.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtCopyID.PlaceholderText = "Ex: A00011";
            this.txtCopyID.SelectedText = "";
            this.txtCopyID.Size = new System.Drawing.Size(612, 43);
            this.txtCopyID.TabIndex = 36;
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
            this.sataPanel1.Controls.Add(this.txtCopyID);
            this.sataPanel1.Controls.Add(this.lblName);
            this.sataPanel1.Controls.Add(this.btnProcessReturn);
            this.sataPanel1.Location = new System.Drawing.Point(22, 34);
            this.sataPanel1.Name = "sataPanel1";
            this.sataPanel1.Size = new System.Drawing.Size(1054, 142);
            this.sataPanel1.TabIndex = 19;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(140, 111);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 37;
            this.lblStatus.Text = "Status";
            this.lblStatus.Visible = false;
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1108, 660);
            this.Controls.Add(this.sataPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnHistory)).EndInit();
            this.sataPanel1.ResumeLayout(false);
            this.sataPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private FrameworkTest.SATAButton btnProcessReturn;
        private Guna.UI2.WinForms.Guna2TextBox txtCopyID;
        private Guna.UI2.WinForms.Guna2DataGridView dgvReturnHistory;
        private SATAUiFramework.SATAPanel sataPanel1;
        private System.Windows.Forms.Label lblStatus;
    }
}