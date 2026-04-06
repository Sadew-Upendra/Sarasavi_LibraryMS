namespace Sarasavi_Library_MS.Forms
{
    partial class LoanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            SATAUiFramework.BorderRadius borderRadius2 = new SATAUiFramework.BorderRadius();
            this.sataPanel1 = new SATAUiFramework.SATAPanel();
            this.txtUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerify = new FrameworkTest.SATAButton();
            this.lblHeader = new System.Windows.Forms.Label();
            this.dgvActiveLoans = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlStep2 = new SATAUiFramework.SATAPanel();
            this.txtCopyID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new FrameworkTest.SATAButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlBorrowerInfo = new System.Windows.Forms.Panel();
            this.lblBorrowerName = new System.Windows.Forms.Label();
            this.lblBorrowerType = new System.Windows.Forms.Label();
            this.lblActiveLoansCount = new System.Windows.Forms.Label();
            this.btnRemoveFromCart = new FrameworkTest.SATAButton();
            this.btnClearCart = new FrameworkTest.SATAButton();
            this.btnConfirmLoan = new FrameworkTest.SATAButton();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.lblCartCount = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStatus2 = new System.Windows.Forms.Label();
            this.sataPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveLoans)).BeginInit();
            this.pnlStep2.SuspendLayout();
            this.pnlBorrowerInfo.SuspendLayout();
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
            this.sataPanel1.Controls.Add(this.pnlBorrowerInfo);
            this.sataPanel1.Controls.Add(this.label5);
            this.sataPanel1.Controls.Add(this.txtUserID);
            this.sataPanel1.Controls.Add(this.label2);
            this.sataPanel1.Controls.Add(this.btnVerify);
            this.sataPanel1.Location = new System.Drawing.Point(21, 23);
            this.sataPanel1.Name = "sataPanel1";
            this.sataPanel1.Size = new System.Drawing.Size(1053, 176);
            this.sataPanel1.TabIndex = 19;
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
            this.txtUserID.Location = new System.Drawing.Point(159, 54);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.PlaceholderText = "Ex: U-0001";
            this.txtUserID.SelectedText = "";
            this.txtUserID.Size = new System.Drawing.Size(560, 43);
            this.txtUserID.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "User ID:";
            // 
            // btnVerify
            // 
            this.btnVerify.ButtonText = "Verify";
            this.btnVerify.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnVerify.CheckedForeColor = System.Drawing.Color.White;
            this.btnVerify.CheckedImageTint = System.Drawing.Color.White;
            this.btnVerify.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnVerify.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.HoverBackground = System.Drawing.Color.Yellow;
            this.btnVerify.HoverForeColor = System.Drawing.Color.Black;
            this.btnVerify.HoverImage = null;
            this.btnVerify.HoverImageTint = System.Drawing.Color.White;
            this.btnVerify.HoverOutline = System.Drawing.Color.Empty;
            this.btnVerify.Image = ((System.Drawing.Image)(resources.GetObject("btnVerify.Image")));
            this.btnVerify.ImageAutoCenter = true;
            this.btnVerify.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnVerify.ImageOffset = new System.Drawing.Point(-4, 0);
            this.btnVerify.ImageTint = System.Drawing.Color.White;
            this.btnVerify.IsToggleButton = false;
            this.btnVerify.IsToggled = false;
            this.btnVerify.Location = new System.Drawing.Point(807, 54);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.NormalBackground = System.Drawing.Color.Gold;
            this.btnVerify.NormalForeColor = System.Drawing.Color.Black;
            this.btnVerify.NormalOutline = System.Drawing.Color.Empty;
            this.btnVerify.OutlineThickness = 2F;
            this.btnVerify.PressedBackground = System.Drawing.Color.Yellow;
            this.btnVerify.PressedForeColor = System.Drawing.Color.Black;
            this.btnVerify.PressedImageTint = System.Drawing.Color.White;
            this.btnVerify.PressedOutline = System.Drawing.Color.Empty;
            this.btnVerify.Rounding = new System.Windows.Forms.Padding(5);
            this.btnVerify.Size = new System.Drawing.Size(193, 43);
            this.btnVerify.TabIndex = 16;
            this.btnVerify.TextAutoCenter = true;
            this.btnVerify.TextOffset = new System.Drawing.Point(4, 0);
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(495, 449);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(136, 23);
            this.lblHeader.TabIndex = 17;
            this.lblHeader.Text = "Active Loans";
            // 
            // dgvActiveLoans
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvActiveLoans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActiveLoans.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActiveLoans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvActiveLoans.ColumnHeadersHeight = 35;
            this.dgvActiveLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActiveLoans.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvActiveLoans.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvActiveLoans.Location = new System.Drawing.Point(33, 484);
            this.dgvActiveLoans.MultiSelect = false;
            this.dgvActiveLoans.Name = "dgvActiveLoans";
            this.dgvActiveLoans.RowHeadersVisible = false;
            this.dgvActiveLoans.RowHeadersWidth = 51;
            this.dgvActiveLoans.RowTemplate.Height = 24;
            this.dgvActiveLoans.Size = new System.Drawing.Size(1032, 147);
            this.dgvActiveLoans.TabIndex = 21;
            this.dgvActiveLoans.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvActiveLoans.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvActiveLoans.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvActiveLoans.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvActiveLoans.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvActiveLoans.ThemeStyle.BackColor = System.Drawing.Color.GhostWhite;
            this.dgvActiveLoans.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvActiveLoans.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvActiveLoans.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvActiveLoans.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvActiveLoans.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvActiveLoans.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvActiveLoans.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvActiveLoans.ThemeStyle.ReadOnly = false;
            this.dgvActiveLoans.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvActiveLoans.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvActiveLoans.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvActiveLoans.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvActiveLoans.ThemeStyle.RowsStyle.Height = 24;
            this.dgvActiveLoans.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvActiveLoans.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnlStep2
            // 
            this.pnlStep2.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlStep2.BackColor2 = System.Drawing.Color.Ivory;
            this.pnlStep2.BorderColor = System.Drawing.Color.SkyBlue;
            borderRadius2.BottomLeft = 10;
            borderRadius2.BottomRight = 10;
            borderRadius2.TopLeft = 10;
            borderRadius2.TopRight = 10;
            this.pnlStep2.BorderRadius = borderRadius2;
            this.pnlStep2.BorderThickness = 2;
            this.pnlStep2.Controls.Add(this.lblStatus2);
            this.pnlStep2.Controls.Add(this.label4);
            this.pnlStep2.Controls.Add(this.lblCartCount);
            this.pnlStep2.Controls.Add(this.txtCopyID);
            this.pnlStep2.Controls.Add(this.lstCart);
            this.pnlStep2.Controls.Add(this.label3);
            this.pnlStep2.Controls.Add(this.btnRemoveFromCart);
            this.pnlStep2.Controls.Add(this.btnClearCart);
            this.pnlStep2.Controls.Add(this.btnAdd);
            this.pnlStep2.Controls.Add(this.btnConfirmLoan);
            this.pnlStep2.Location = new System.Drawing.Point(21, 220);
            this.pnlStep2.Name = "pnlStep2";
            this.pnlStep2.Size = new System.Drawing.Size(1053, 211);
            this.pnlStep2.TabIndex = 22;
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
            this.txtCopyID.Location = new System.Drawing.Point(159, 55);
            this.txtCopyID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCopyID.Name = "txtCopyID";
            this.txtCopyID.PlaceholderText = "Ex: A00011";
            this.txtCopyID.SelectedText = "";
            this.txtCopyID.Size = new System.Drawing.Size(560, 43);
            this.txtCopyID.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Copy ID:";
            // 
            // btnAdd
            // 
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnAdd.CheckedForeColor = System.Drawing.Color.White;
            this.btnAdd.CheckedImageTint = System.Drawing.Color.White;
            this.btnAdd.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnAdd.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.HoverBackground = System.Drawing.Color.Yellow;
            this.btnAdd.HoverForeColor = System.Drawing.Color.Black;
            this.btnAdd.HoverImage = null;
            this.btnAdd.HoverImageTint = System.Drawing.Color.White;
            this.btnAdd.HoverOutline = System.Drawing.Color.Empty;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAutoCenter = true;
            this.btnAdd.ImageExpand = new System.Drawing.Point(-4, -4);
            this.btnAdd.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnAdd.ImageTint = System.Drawing.Color.White;
            this.btnAdd.IsToggleButton = false;
            this.btnAdd.IsToggled = false;
            this.btnAdd.Location = new System.Drawing.Point(807, 55);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NormalBackground = System.Drawing.Color.Gold;
            this.btnAdd.NormalForeColor = System.Drawing.Color.Black;
            this.btnAdd.NormalOutline = System.Drawing.Color.Empty;
            this.btnAdd.OutlineThickness = 2F;
            this.btnAdd.PressedBackground = System.Drawing.Color.Yellow;
            this.btnAdd.PressedForeColor = System.Drawing.Color.Black;
            this.btnAdd.PressedImageTint = System.Drawing.Color.White;
            this.btnAdd.PressedOutline = System.Drawing.Color.Empty;
            this.btnAdd.Rounding = new System.Windows.Forms.Padding(5);
            this.btnAdd.Size = new System.Drawing.Size(193, 43);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.TextAutoCenter = true;
            this.btnAdd.TextOffset = new System.Drawing.Point(5, 0);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(421, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Step 2 - Add Copies to Cart";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Location = new System.Drawing.Point(448, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 19);
            this.label5.TabIndex = 36;
            this.label5.Text = "Step 1 - Verify User";
            // 
            // pnlBorrowerInfo
            // 
            this.pnlBorrowerInfo.Controls.Add(this.label6);
            this.pnlBorrowerInfo.Controls.Add(this.label7);
            this.pnlBorrowerInfo.Controls.Add(this.label8);
            this.pnlBorrowerInfo.Controls.Add(this.lblActiveLoansCount);
            this.pnlBorrowerInfo.Controls.Add(this.lblBorrowerType);
            this.pnlBorrowerInfo.Controls.Add(this.lblBorrowerName);
            this.pnlBorrowerInfo.Location = new System.Drawing.Point(41, 108);
            this.pnlBorrowerInfo.Name = "pnlBorrowerInfo";
            this.pnlBorrowerInfo.Size = new System.Drawing.Size(464, 55);
            this.pnlBorrowerInfo.TabIndex = 23;
            // 
            // lblBorrowerName
            // 
            this.lblBorrowerName.AutoSize = true;
            this.lblBorrowerName.Location = new System.Drawing.Point(29, 28);
            this.lblBorrowerName.Name = "lblBorrowerName";
            this.lblBorrowerName.Size = new System.Drawing.Size(44, 16);
            this.lblBorrowerName.TabIndex = 0;
            this.lblBorrowerName.Text = "Name";
            // 
            // lblBorrowerType
            // 
            this.lblBorrowerType.AutoSize = true;
            this.lblBorrowerType.Location = new System.Drawing.Point(190, 28);
            this.lblBorrowerType.Name = "lblBorrowerType";
            this.lblBorrowerType.Size = new System.Drawing.Size(39, 16);
            this.lblBorrowerType.TabIndex = 1;
            this.lblBorrowerType.Text = "Type";
            // 
            // lblActiveLoansCount
            // 
            this.lblActiveLoansCount.AutoSize = true;
            this.lblActiveLoansCount.Location = new System.Drawing.Point(381, 28);
            this.lblActiveLoansCount.Name = "lblActiveLoansCount";
            this.lblActiveLoansCount.Size = new System.Drawing.Size(41, 16);
            this.lblActiveLoansCount.TabIndex = 2;
            this.lblActiveLoansCount.Text = "Count";
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.ButtonText = "Remove";
            this.btnRemoveFromCart.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnRemoveFromCart.CheckedForeColor = System.Drawing.Color.White;
            this.btnRemoveFromCart.CheckedImageTint = System.Drawing.Color.White;
            this.btnRemoveFromCart.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnRemoveFromCart.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRemoveFromCart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromCart.HoverBackground = System.Drawing.Color.IndianRed;
            this.btnRemoveFromCart.HoverForeColor = System.Drawing.Color.White;
            this.btnRemoveFromCart.HoverImage = null;
            this.btnRemoveFromCart.HoverImageTint = System.Drawing.Color.White;
            this.btnRemoveFromCart.HoverOutline = System.Drawing.Color.Empty;
            this.btnRemoveFromCart.Image = null;
            this.btnRemoveFromCart.ImageAutoCenter = true;
            this.btnRemoveFromCart.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnRemoveFromCart.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnRemoveFromCart.ImageTint = System.Drawing.Color.White;
            this.btnRemoveFromCart.IsToggleButton = false;
            this.btnRemoveFromCart.IsToggled = false;
            this.btnRemoveFromCart.Location = new System.Drawing.Point(719, 139);
            this.btnRemoveFromCart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.NormalBackground = System.Drawing.Color.Firebrick;
            this.btnRemoveFromCart.NormalForeColor = System.Drawing.Color.White;
            this.btnRemoveFromCart.NormalOutline = System.Drawing.Color.Empty;
            this.btnRemoveFromCart.OutlineThickness = 2F;
            this.btnRemoveFromCart.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveFromCart.PressedForeColor = System.Drawing.Color.White;
            this.btnRemoveFromCart.PressedImageTint = System.Drawing.Color.White;
            this.btnRemoveFromCart.PressedOutline = System.Drawing.Color.Empty;
            this.btnRemoveFromCart.Rounding = new System.Windows.Forms.Padding(5);
            this.btnRemoveFromCart.Size = new System.Drawing.Size(127, 49);
            this.btnRemoveFromCart.TabIndex = 41;
            this.btnRemoveFromCart.TextAutoCenter = true;
            this.btnRemoveFromCart.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // btnClearCart
            // 
            this.btnClearCart.ButtonText = "Clear";
            this.btnClearCart.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnClearCart.CheckedForeColor = System.Drawing.Color.White;
            this.btnClearCart.CheckedImageTint = System.Drawing.Color.White;
            this.btnClearCart.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnClearCart.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClearCart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCart.HoverBackground = System.Drawing.Color.Chocolate;
            this.btnClearCart.HoverForeColor = System.Drawing.Color.White;
            this.btnClearCart.HoverImage = null;
            this.btnClearCart.HoverImageTint = System.Drawing.Color.White;
            this.btnClearCart.HoverOutline = System.Drawing.Color.Empty;
            this.btnClearCart.Image = null;
            this.btnClearCart.ImageAutoCenter = true;
            this.btnClearCart.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnClearCart.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClearCart.ImageTint = System.Drawing.Color.White;
            this.btnClearCart.IsToggleButton = false;
            this.btnClearCart.IsToggled = false;
            this.btnClearCart.Location = new System.Drawing.Point(568, 139);
            this.btnClearCart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.NormalBackground = System.Drawing.Color.SaddleBrown;
            this.btnClearCart.NormalForeColor = System.Drawing.Color.White;
            this.btnClearCart.NormalOutline = System.Drawing.Color.Empty;
            this.btnClearCart.OutlineThickness = 2F;
            this.btnClearCart.PressedBackground = System.Drawing.Color.Chocolate;
            this.btnClearCart.PressedForeColor = System.Drawing.Color.White;
            this.btnClearCart.PressedImageTint = System.Drawing.Color.White;
            this.btnClearCart.PressedOutline = System.Drawing.Color.Empty;
            this.btnClearCart.Rounding = new System.Windows.Forms.Padding(5);
            this.btnClearCart.Size = new System.Drawing.Size(127, 49);
            this.btnClearCart.TabIndex = 40;
            this.btnClearCart.TextAutoCenter = true;
            this.btnClearCart.TextOffset = new System.Drawing.Point(0, 0);
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnConfirmLoan
            // 
            this.btnConfirmLoan.ButtonText = "Confirm";
            this.btnConfirmLoan.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnConfirmLoan.CheckedForeColor = System.Drawing.Color.White;
            this.btnConfirmLoan.CheckedImageTint = System.Drawing.Color.White;
            this.btnConfirmLoan.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnConfirmLoan.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfirmLoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmLoan.HoverBackground = System.Drawing.Color.ForestGreen;
            this.btnConfirmLoan.HoverForeColor = System.Drawing.Color.White;
            this.btnConfirmLoan.HoverImage = null;
            this.btnConfirmLoan.HoverImageTint = System.Drawing.Color.White;
            this.btnConfirmLoan.HoverOutline = System.Drawing.Color.Empty;
            this.btnConfirmLoan.Image = null;
            this.btnConfirmLoan.ImageAutoCenter = true;
            this.btnConfirmLoan.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnConfirmLoan.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnConfirmLoan.ImageTint = System.Drawing.Color.White;
            this.btnConfirmLoan.IsToggleButton = false;
            this.btnConfirmLoan.IsToggled = false;
            this.btnConfirmLoan.Location = new System.Drawing.Point(872, 139);
            this.btnConfirmLoan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfirmLoan.Name = "btnConfirmLoan";
            this.btnConfirmLoan.NormalBackground = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmLoan.NormalForeColor = System.Drawing.Color.White;
            this.btnConfirmLoan.NormalOutline = System.Drawing.Color.Empty;
            this.btnConfirmLoan.OutlineThickness = 2F;
            this.btnConfirmLoan.PressedBackground = System.Drawing.Color.LightGreen;
            this.btnConfirmLoan.PressedForeColor = System.Drawing.Color.White;
            this.btnConfirmLoan.PressedImageTint = System.Drawing.Color.White;
            this.btnConfirmLoan.PressedOutline = System.Drawing.Color.Empty;
            this.btnConfirmLoan.Rounding = new System.Windows.Forms.Padding(5);
            this.btnConfirmLoan.Size = new System.Drawing.Size(127, 49);
            this.btnConfirmLoan.TabIndex = 39;
            this.btnConfirmLoan.TextAutoCenter = true;
            this.btnConfirmLoan.TextOffset = new System.Drawing.Point(0, 0);
            this.btnConfirmLoan.Click += new System.EventHandler(this.btnConfirmLoan_Click);
            // 
            // lstCart
            // 
            this.lstCart.BackColor = System.Drawing.Color.MintCream;
            this.lstCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 16;
            this.lstCart.Location = new System.Drawing.Point(41, 118);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(176, 80);
            this.lstCart.TabIndex = 42;
            // 
            // lblCartCount
            // 
            this.lblCartCount.AutoSize = true;
            this.lblCartCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCartCount.Location = new System.Drawing.Point(238, 157);
            this.lblCartCount.Name = "lblCartCount";
            this.lblCartCount.Size = new System.Drawing.Size(68, 16);
            this.lblCartCount.TabIndex = 43;
            this.lblCartCount.Text = "Cart Count";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Location = new System.Drawing.Point(705, 136);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 44;
            this.lblStatus.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(379, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Count";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(197, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Name";
            // 
            // lblStatus2
            // 
            this.lblStatus2.AutoSize = true;
            this.lblStatus2.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus2.Location = new System.Drawing.Point(241, 121);
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(44, 16);
            this.lblStatus2.TabIndex = 45;
            this.lblStatus2.Text = "Status";
            this.lblStatus2.Visible = false;
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1108, 660);
            this.Controls.Add(this.pnlStep2);
            this.Controls.Add(this.dgvActiveLoans);
            this.Controls.Add(this.sataPanel1);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoanForm";
            this.Text = "LoanForm";
            this.sataPanel1.ResumeLayout(false);
            this.sataPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveLoans)).EndInit();
            this.pnlStep2.ResumeLayout(false);
            this.pnlStep2.PerformLayout();
            this.pnlBorrowerInfo.ResumeLayout(false);
            this.pnlBorrowerInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SATAUiFramework.SATAPanel sataPanel1;
        private System.Windows.Forms.Label label2;
        private FrameworkTest.SATAButton btnVerify;
        private System.Windows.Forms.Label lblHeader;
        private Guna.UI2.WinForms.Guna2TextBox txtUserID;
        private Guna.UI2.WinForms.Guna2DataGridView dgvActiveLoans;
        private SATAUiFramework.SATAPanel pnlStep2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtCopyID;
        private System.Windows.Forms.Label label3;
        private FrameworkTest.SATAButton btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlBorrowerInfo;
        private System.Windows.Forms.Label lblActiveLoansCount;
        private System.Windows.Forms.Label lblBorrowerType;
        private System.Windows.Forms.Label lblBorrowerName;
        private FrameworkTest.SATAButton btnRemoveFromCart;
        private FrameworkTest.SATAButton btnClearCart;
        private FrameworkTest.SATAButton btnConfirmLoan;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Label lblCartCount;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblStatus2;
    }
}