namespace Sarasavi_Library_MS.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FrameworkTest.SATAButton();
            this.btnMaximize = new FrameworkTest.SATAButton();
            this.btnClose = new FrameworkTest.SATAButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sataPictureBox1 = new SATAUiFramework.Controls.SATAPictureBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblProfileCheck = new System.Windows.Forms.Label();
            this.btnLogout = new FrameworkTest.SATAButton();
            this.btnUser = new FrameworkTest.SATAButton();
            this.btnBook = new FrameworkTest.SATAButton();
            this.btnInquiry = new FrameworkTest.SATAButton();
            this.btnLoan = new FrameworkTest.SATAButton();
            this.btnReturn = new FrameworkTest.SATAButton();
            this.btnReservations = new FrameworkTest.SATAButton();
            this.btnDashboard = new FrameworkTest.SATAButton();
            this.sataDragControl1 = new SATAUiFramework.Controls.SATADragControl();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sataPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(28)))), ((int)(((byte)(42)))));
            this.titleBar.Controls.Add(this.btnMinimize);
            this.titleBar.Controls.Add(this.btnMaximize);
            this.titleBar.Controls.Add(this.btnClose);
            this.titleBar.Controls.Add(this.label1);
            this.titleBar.Controls.Add(this.pictureBox1);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1535, 46);
            this.titleBar.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.ButtonText = "";
            this.btnMinimize.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnMinimize.CheckedForeColor = System.Drawing.Color.White;
            this.btnMinimize.CheckedImageTint = System.Drawing.Color.White;
            this.btnMinimize.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnMinimize.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.btnMinimize.HoverForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverImage = null;
            this.btnMinimize.HoverImageTint = System.Drawing.Color.White;
            this.btnMinimize.HoverOutline = System.Drawing.Color.Empty;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageAutoCenter = true;
            this.btnMinimize.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnMinimize.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnMinimize.ImageTint = System.Drawing.Color.White;
            this.btnMinimize.IsToggleButton = false;
            this.btnMinimize.IsToggled = false;
            this.btnMinimize.Location = new System.Drawing.Point(1391, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.NormalBackground = System.Drawing.Color.Transparent;
            this.btnMinimize.NormalForeColor = System.Drawing.Color.White;
            this.btnMinimize.NormalOutline = System.Drawing.Color.Empty;
            this.btnMinimize.OutlineThickness = 2F;
            this.btnMinimize.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.btnMinimize.PressedForeColor = System.Drawing.Color.White;
            this.btnMinimize.PressedImageTint = System.Drawing.Color.White;
            this.btnMinimize.PressedOutline = System.Drawing.Color.Empty;
            this.btnMinimize.Rounding = new System.Windows.Forms.Padding(5);
            this.btnMinimize.Size = new System.Drawing.Size(48, 46);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.TextAutoCenter = true;
            this.btnMinimize.TextOffset = new System.Drawing.Point(0, 0);
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.ButtonText = "";
            this.btnMaximize.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnMaximize.CheckedForeColor = System.Drawing.Color.White;
            this.btnMaximize.CheckedImageTint = System.Drawing.Color.White;
            this.btnMaximize.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnMaximize.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMaximize.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.btnMaximize.HoverForeColor = System.Drawing.Color.White;
            this.btnMaximize.HoverImage = null;
            this.btnMaximize.HoverImageTint = System.Drawing.Color.White;
            this.btnMaximize.HoverOutline = System.Drawing.Color.Empty;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.ImageAutoCenter = true;
            this.btnMaximize.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnMaximize.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnMaximize.ImageTint = System.Drawing.Color.White;
            this.btnMaximize.IsToggleButton = false;
            this.btnMaximize.IsToggled = false;
            this.btnMaximize.Location = new System.Drawing.Point(1439, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.NormalBackground = System.Drawing.Color.Transparent;
            this.btnMaximize.NormalForeColor = System.Drawing.Color.White;
            this.btnMaximize.NormalOutline = System.Drawing.Color.Empty;
            this.btnMaximize.OutlineThickness = 2F;
            this.btnMaximize.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.btnMaximize.PressedForeColor = System.Drawing.Color.White;
            this.btnMaximize.PressedImageTint = System.Drawing.Color.White;
            this.btnMaximize.PressedOutline = System.Drawing.Color.Empty;
            this.btnMaximize.Rounding = new System.Windows.Forms.Padding(5);
            this.btnMaximize.Size = new System.Drawing.Size(48, 46);
            this.btnMaximize.TabIndex = 6;
            this.btnMaximize.TextAutoCenter = true;
            this.btnMaximize.TextOffset = new System.Drawing.Point(0, 0);
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.ButtonText = "";
            this.btnClose.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnClose.CheckedForeColor = System.Drawing.Color.White;
            this.btnClose.CheckedImageTint = System.Drawing.Color.White;
            this.btnClose.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnClose.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.HoverBackground = System.Drawing.Color.Red;
            this.btnClose.HoverForeColor = System.Drawing.Color.White;
            this.btnClose.HoverImage = null;
            this.btnClose.HoverImageTint = System.Drawing.Color.White;
            this.btnClose.HoverOutline = System.Drawing.Color.Empty;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAutoCenter = true;
            this.btnClose.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnClose.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnClose.ImageTint = System.Drawing.Color.White;
            this.btnClose.IsToggleButton = false;
            this.btnClose.IsToggled = false;
            this.btnClose.Location = new System.Drawing.Point(1487, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.NormalBackground = System.Drawing.Color.Transparent;
            this.btnClose.NormalForeColor = System.Drawing.Color.White;
            this.btnClose.NormalOutline = System.Drawing.Color.Empty;
            this.btnClose.OutlineThickness = 2F;
            this.btnClose.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.PressedForeColor = System.Drawing.Color.White;
            this.btnClose.PressedImageTint = System.Drawing.Color.White;
            this.btnClose.PressedOutline = System.Drawing.Color.Empty;
            this.btnClose.Rounding = new System.Windows.Forms.Padding(5);
            this.btnClose.Size = new System.Drawing.Size(48, 46);
            this.btnClose.TabIndex = 5;
            this.btnClose.TextAutoCenter = true;
            this.btnClose.TextOffset = new System.Drawing.Point(0, 0);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sarasavi Library Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.sataPictureBox1);
            this.panel2.Controls.Add(this.guna2Separator1);
            this.panel2.Controls.Add(this.lblProfileCheck);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnUser);
            this.panel2.Controls.Add(this.btnBook);
            this.panel2.Controls.Add(this.btnInquiry);
            this.panel2.Controls.Add(this.btnLoan);
            this.panel2.Controls.Add(this.btnReturn);
            this.panel2.Controls.Add(this.btnReservations);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 914);
            this.panel2.TabIndex = 1;
            // 
            // sataPictureBox1
            // 
            this.sataPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.sataPictureBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(28)))), ((int)(((byte)(42)))));
            this.sataPictureBox1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(28)))), ((int)(((byte)(42)))));
            this.sataPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.sataPictureBox1.BorderSize = 1;
            this.sataPictureBox1.GradientAngle = 50F;
            this.sataPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("sataPictureBox1.Image")));
            this.sataPictureBox1.Location = new System.Drawing.Point(69, 13);
            this.sataPictureBox1.Name = "sataPictureBox1";
            this.sataPictureBox1.Size = new System.Drawing.Size(85, 85);
            this.sataPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sataPictureBox1.TabIndex = 11;
            this.sataPictureBox1.TabStop = false;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(17, 144);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(220, 10);
            this.guna2Separator1.TabIndex = 10;
            // 
            // lblProfileCheck
            // 
            this.lblProfileCheck.AutoSize = true;
            this.lblProfileCheck.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileCheck.ForeColor = System.Drawing.SystemColors.Info;
            this.lblProfileCheck.Location = new System.Drawing.Point(81, 104);
            this.lblProfileCheck.Name = "lblProfileCheck";
            this.lblProfileCheck.Size = new System.Drawing.Size(63, 26);
            this.lblProfileCheck.TabIndex = 6;
            this.lblProfileCheck.Text = "Admin";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.ButtonText = "Log Out";
            this.btnLogout.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnLogout.CheckedForeColor = System.Drawing.Color.White;
            this.btnLogout.CheckedImageTint = System.Drawing.Color.White;
            this.btnLogout.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnLogout.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.HoverBackground = System.Drawing.Color.Red;
            this.btnLogout.HoverForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverImage = null;
            this.btnLogout.HoverImageTint = System.Drawing.Color.White;
            this.btnLogout.HoverOutline = System.Drawing.Color.Empty;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAutoCenter = false;
            this.btnLogout.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnLogout.ImageOffset = new System.Drawing.Point(30, -1);
            this.btnLogout.ImageTint = System.Drawing.Color.White;
            this.btnLogout.IsToggleButton = false;
            this.btnLogout.IsToggled = false;
            this.btnLogout.Location = new System.Drawing.Point(0, 862);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.NormalBackground = System.Drawing.Color.Transparent;
            this.btnLogout.NormalForeColor = System.Drawing.Color.White;
            this.btnLogout.NormalOutline = System.Drawing.Color.Empty;
            this.btnLogout.OutlineThickness = 2F;
            this.btnLogout.PressedBackground = System.Drawing.Color.Red;
            this.btnLogout.PressedForeColor = System.Drawing.Color.White;
            this.btnLogout.PressedImageTint = System.Drawing.Color.White;
            this.btnLogout.PressedOutline = System.Drawing.Color.Empty;
            this.btnLogout.Rounding = new System.Windows.Forms.Padding(5);
            this.btnLogout.Size = new System.Drawing.Size(258, 52);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.TextAutoCenter = true;
            this.btnLogout.TextOffset = new System.Drawing.Point(0, 0);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUser
            // 
            this.btnUser.ButtonText = "User Registration";
            this.btnUser.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnUser.CheckedForeColor = System.Drawing.Color.White;
            this.btnUser.CheckedImageTint = System.Drawing.Color.White;
            this.btnUser.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnUser.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnUser.HoverForeColor = System.Drawing.Color.White;
            this.btnUser.HoverImage = null;
            this.btnUser.HoverImageTint = System.Drawing.Color.White;
            this.btnUser.HoverOutline = System.Drawing.Color.Empty;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAutoCenter = false;
            this.btnUser.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnUser.ImageOffset = new System.Drawing.Point(6, -1);
            this.btnUser.ImageTint = System.Drawing.Color.White;
            this.btnUser.IsToggleButton = false;
            this.btnUser.IsToggled = false;
            this.btnUser.Location = new System.Drawing.Point(14, 562);
            this.btnUser.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnUser.Name = "btnUser";
            this.btnUser.NormalBackground = System.Drawing.Color.Transparent;
            this.btnUser.NormalForeColor = System.Drawing.Color.White;
            this.btnUser.NormalOutline = System.Drawing.Color.Empty;
            this.btnUser.OutlineThickness = 2F;
            this.btnUser.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(112)))));
            this.btnUser.PressedForeColor = System.Drawing.Color.White;
            this.btnUser.PressedImageTint = System.Drawing.Color.White;
            this.btnUser.PressedOutline = System.Drawing.Color.Empty;
            this.btnUser.Rounding = new System.Windows.Forms.Padding(5);
            this.btnUser.Size = new System.Drawing.Size(233, 52);
            this.btnUser.TabIndex = 8;
            this.btnUser.TextAutoCenter = false;
            this.btnUser.TextOffset = new System.Drawing.Point(10, 0);
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnBook
            // 
            this.btnBook.ButtonText = "Book Registration";
            this.btnBook.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnBook.CheckedForeColor = System.Drawing.Color.White;
            this.btnBook.CheckedImageTint = System.Drawing.Color.White;
            this.btnBook.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnBook.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnBook.HoverForeColor = System.Drawing.Color.White;
            this.btnBook.HoverImage = null;
            this.btnBook.HoverImageTint = System.Drawing.Color.White;
            this.btnBook.HoverOutline = System.Drawing.Color.Empty;
            this.btnBook.Image = ((System.Drawing.Image)(resources.GetObject("btnBook.Image")));
            this.btnBook.ImageAutoCenter = false;
            this.btnBook.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnBook.ImageOffset = new System.Drawing.Point(6, -1);
            this.btnBook.ImageTint = System.Drawing.Color.White;
            this.btnBook.IsToggleButton = false;
            this.btnBook.IsToggled = false;
            this.btnBook.Location = new System.Drawing.Point(14, 498);
            this.btnBook.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnBook.Name = "btnBook";
            this.btnBook.NormalBackground = System.Drawing.Color.Transparent;
            this.btnBook.NormalForeColor = System.Drawing.Color.White;
            this.btnBook.NormalOutline = System.Drawing.Color.Empty;
            this.btnBook.OutlineThickness = 2F;
            this.btnBook.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(112)))));
            this.btnBook.PressedForeColor = System.Drawing.Color.White;
            this.btnBook.PressedImageTint = System.Drawing.Color.White;
            this.btnBook.PressedOutline = System.Drawing.Color.Empty;
            this.btnBook.Rounding = new System.Windows.Forms.Padding(5);
            this.btnBook.Size = new System.Drawing.Size(233, 52);
            this.btnBook.TabIndex = 7;
            this.btnBook.TextAutoCenter = false;
            this.btnBook.TextOffset = new System.Drawing.Point(10, 0);
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnInquiry
            // 
            this.btnInquiry.ButtonText = "Inquiry";
            this.btnInquiry.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnInquiry.CheckedForeColor = System.Drawing.Color.White;
            this.btnInquiry.CheckedImageTint = System.Drawing.Color.White;
            this.btnInquiry.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnInquiry.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInquiry.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInquiry.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnInquiry.HoverForeColor = System.Drawing.Color.White;
            this.btnInquiry.HoverImage = null;
            this.btnInquiry.HoverImageTint = System.Drawing.Color.White;
            this.btnInquiry.HoverOutline = System.Drawing.Color.Empty;
            this.btnInquiry.Image = ((System.Drawing.Image)(resources.GetObject("btnInquiry.Image")));
            this.btnInquiry.ImageAutoCenter = false;
            this.btnInquiry.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnInquiry.ImageOffset = new System.Drawing.Point(6, -1);
            this.btnInquiry.ImageTint = System.Drawing.Color.White;
            this.btnInquiry.IsToggleButton = false;
            this.btnInquiry.IsToggled = false;
            this.btnInquiry.Location = new System.Drawing.Point(14, 434);
            this.btnInquiry.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnInquiry.Name = "btnInquiry";
            this.btnInquiry.NormalBackground = System.Drawing.Color.Transparent;
            this.btnInquiry.NormalForeColor = System.Drawing.Color.White;
            this.btnInquiry.NormalOutline = System.Drawing.Color.Empty;
            this.btnInquiry.OutlineThickness = 2F;
            this.btnInquiry.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(112)))));
            this.btnInquiry.PressedForeColor = System.Drawing.Color.White;
            this.btnInquiry.PressedImageTint = System.Drawing.Color.White;
            this.btnInquiry.PressedOutline = System.Drawing.Color.Empty;
            this.btnInquiry.Rounding = new System.Windows.Forms.Padding(5);
            this.btnInquiry.Size = new System.Drawing.Size(233, 52);
            this.btnInquiry.TabIndex = 6;
            this.btnInquiry.TextAutoCenter = false;
            this.btnInquiry.TextOffset = new System.Drawing.Point(10, 0);
            this.btnInquiry.Click += new System.EventHandler(this.btnInquiry_Click);
            // 
            // btnLoan
            // 
            this.btnLoan.ButtonText = "Loan Process";
            this.btnLoan.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnLoan.CheckedForeColor = System.Drawing.Color.White;
            this.btnLoan.CheckedImageTint = System.Drawing.Color.White;
            this.btnLoan.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnLoan.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoan.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnLoan.HoverForeColor = System.Drawing.Color.White;
            this.btnLoan.HoverImage = null;
            this.btnLoan.HoverImageTint = System.Drawing.Color.White;
            this.btnLoan.HoverOutline = System.Drawing.Color.Empty;
            this.btnLoan.Image = ((System.Drawing.Image)(resources.GetObject("btnLoan.Image")));
            this.btnLoan.ImageAutoCenter = false;
            this.btnLoan.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnLoan.ImageOffset = new System.Drawing.Point(6, -1);
            this.btnLoan.ImageTint = System.Drawing.Color.White;
            this.btnLoan.IsToggleButton = false;
            this.btnLoan.IsToggled = false;
            this.btnLoan.Location = new System.Drawing.Point(14, 242);
            this.btnLoan.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.NormalBackground = System.Drawing.Color.Transparent;
            this.btnLoan.NormalForeColor = System.Drawing.Color.White;
            this.btnLoan.NormalOutline = System.Drawing.Color.Empty;
            this.btnLoan.OutlineThickness = 2F;
            this.btnLoan.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(112)))));
            this.btnLoan.PressedForeColor = System.Drawing.Color.White;
            this.btnLoan.PressedImageTint = System.Drawing.Color.White;
            this.btnLoan.PressedOutline = System.Drawing.Color.Empty;
            this.btnLoan.Rounding = new System.Windows.Forms.Padding(5);
            this.btnLoan.Size = new System.Drawing.Size(233, 52);
            this.btnLoan.TabIndex = 5;
            this.btnLoan.TextAutoCenter = false;
            this.btnLoan.TextOffset = new System.Drawing.Point(10, 0);
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.ButtonText = "Return Process";
            this.btnReturn.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnReturn.CheckedForeColor = System.Drawing.Color.White;
            this.btnReturn.CheckedImageTint = System.Drawing.Color.White;
            this.btnReturn.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnReturn.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnReturn.HoverForeColor = System.Drawing.Color.White;
            this.btnReturn.HoverImage = null;
            this.btnReturn.HoverImageTint = System.Drawing.Color.White;
            this.btnReturn.HoverOutline = System.Drawing.Color.Empty;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageAutoCenter = false;
            this.btnReturn.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnReturn.ImageOffset = new System.Drawing.Point(6, -1);
            this.btnReturn.ImageTint = System.Drawing.Color.White;
            this.btnReturn.IsToggleButton = false;
            this.btnReturn.IsToggled = false;
            this.btnReturn.Location = new System.Drawing.Point(14, 306);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.NormalBackground = System.Drawing.Color.Transparent;
            this.btnReturn.NormalForeColor = System.Drawing.Color.White;
            this.btnReturn.NormalOutline = System.Drawing.Color.Empty;
            this.btnReturn.OutlineThickness = 2F;
            this.btnReturn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(112)))));
            this.btnReturn.PressedForeColor = System.Drawing.Color.White;
            this.btnReturn.PressedImageTint = System.Drawing.Color.White;
            this.btnReturn.PressedOutline = System.Drawing.Color.Empty;
            this.btnReturn.Rounding = new System.Windows.Forms.Padding(5);
            this.btnReturn.Size = new System.Drawing.Size(233, 52);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.TextAutoCenter = false;
            this.btnReturn.TextOffset = new System.Drawing.Point(10, 0);
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.ButtonText = "Reservations";
            this.btnReservations.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnReservations.CheckedForeColor = System.Drawing.Color.White;
            this.btnReservations.CheckedImageTint = System.Drawing.Color.White;
            this.btnReservations.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnReservations.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReservations.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservations.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnReservations.HoverForeColor = System.Drawing.Color.White;
            this.btnReservations.HoverImage = null;
            this.btnReservations.HoverImageTint = System.Drawing.Color.White;
            this.btnReservations.HoverOutline = System.Drawing.Color.Empty;
            this.btnReservations.Image = ((System.Drawing.Image)(resources.GetObject("btnReservations.Image")));
            this.btnReservations.ImageAutoCenter = false;
            this.btnReservations.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnReservations.ImageOffset = new System.Drawing.Point(6, -1);
            this.btnReservations.ImageTint = System.Drawing.Color.White;
            this.btnReservations.IsToggleButton = false;
            this.btnReservations.IsToggled = false;
            this.btnReservations.Location = new System.Drawing.Point(14, 370);
            this.btnReservations.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.NormalBackground = System.Drawing.Color.Transparent;
            this.btnReservations.NormalForeColor = System.Drawing.Color.White;
            this.btnReservations.NormalOutline = System.Drawing.Color.Empty;
            this.btnReservations.OutlineThickness = 2F;
            this.btnReservations.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(112)))));
            this.btnReservations.PressedForeColor = System.Drawing.Color.White;
            this.btnReservations.PressedImageTint = System.Drawing.Color.White;
            this.btnReservations.PressedOutline = System.Drawing.Color.Empty;
            this.btnReservations.Rounding = new System.Windows.Forms.Padding(5);
            this.btnReservations.Size = new System.Drawing.Size(233, 52);
            this.btnReservations.TabIndex = 3;
            this.btnReservations.TextAutoCenter = false;
            this.btnReservations.TextOffset = new System.Drawing.Point(10, 0);
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.ButtonText = "Dashboard";
            this.btnDashboard.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnDashboard.CheckedForeColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedImageTint = System.Drawing.Color.White;
            this.btnDashboard.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnDashboard.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnDashboard.HoverForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverImage = null;
            this.btnDashboard.HoverImageTint = System.Drawing.Color.White;
            this.btnDashboard.HoverOutline = System.Drawing.Color.Empty;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAutoCenter = false;
            this.btnDashboard.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnDashboard.ImageOffset = new System.Drawing.Point(6, -1);
            this.btnDashboard.ImageTint = System.Drawing.Color.White;
            this.btnDashboard.IsToggleButton = false;
            this.btnDashboard.IsToggled = false;
            this.btnDashboard.Location = new System.Drawing.Point(14, 178);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.NormalBackground = System.Drawing.Color.Transparent;
            this.btnDashboard.NormalForeColor = System.Drawing.Color.White;
            this.btnDashboard.NormalOutline = System.Drawing.Color.Empty;
            this.btnDashboard.OutlineThickness = 2F;
            this.btnDashboard.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(112)))));
            this.btnDashboard.PressedForeColor = System.Drawing.Color.White;
            this.btnDashboard.PressedImageTint = System.Drawing.Color.White;
            this.btnDashboard.PressedOutline = System.Drawing.Color.Empty;
            this.btnDashboard.Rounding = new System.Windows.Forms.Padding(5);
            this.btnDashboard.Size = new System.Drawing.Size(233, 52);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.TextAutoCenter = false;
            this.btnDashboard.TextOffset = new System.Drawing.Point(10, 0);
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // sataDragControl1
            // 
            this.sataDragControl1.SelectControl = this.titleBar;
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.contentPanel.Location = new System.Drawing.Point(0, 79);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1277, 835);
            this.contentPanel.TabIndex = 14;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(33, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(134, 27);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Dashboard";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(1138, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sarasavi";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1096, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(1044, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Library Management System";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.GhostWhite;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Controls.Add(this.contentPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(258, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1277, 914);
            this.panel3.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 960);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainUIForm";
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sataPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Panel panel2;
        private FrameworkTest.SATAButton btnDashboard;
        private FrameworkTest.SATAButton btnInquiry;
        private FrameworkTest.SATAButton btnLoan;
        private FrameworkTest.SATAButton btnReturn;
        private FrameworkTest.SATAButton btnReservations;
        private FrameworkTest.SATAButton btnUser;
        private FrameworkTest.SATAButton btnBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FrameworkTest.SATAButton btnLogout;
        private SATAUiFramework.Controls.SATADragControl sataDragControl1;
        private FrameworkTest.SATAButton btnClose;
        private FrameworkTest.SATAButton btnMinimize;
        private FrameworkTest.SATAButton btnMaximize;
        private System.Windows.Forms.Label lblProfileCheck;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private SATAUiFramework.Controls.SATAPictureBox sataPictureBox1;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
    }
}