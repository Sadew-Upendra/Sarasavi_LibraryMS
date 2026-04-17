namespace Sarasavi_Library_MS.Forms
{
    partial class UserMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMainForm));
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
            this.btnProfile = new FrameworkTest.SATAButton();
            this.btnInquiry = new FrameworkTest.SATAButton();
            this.btnLoan = new FrameworkTest.SATAButton();
            this.btnReservations = new FrameworkTest.SATAButton();
            this.btnDashboard = new FrameworkTest.SATAButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sataDragControl1 = new SATAUiFramework.Controls.SATADragControl();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sataPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.titleBar.Size = new System.Drawing.Size(1370, 46);
            this.titleBar.TabIndex = 1;
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
            this.btnMinimize.Location = new System.Drawing.Point(1226, 0);
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
            this.btnMaximize.Location = new System.Drawing.Point(1274, 0);
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
            this.btnClose.Location = new System.Drawing.Point(1322, 0);
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
            this.panel2.Controls.Add(this.btnProfile);
            this.panel2.Controls.Add(this.btnInquiry);
            this.panel2.Controls.Add(this.btnLoan);
            this.panel2.Controls.Add(this.btnReservations);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 747);
            this.panel2.TabIndex = 2;
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
            this.lblProfileCheck.Location = new System.Drawing.Point(90, 104);
            this.lblProfileCheck.Name = "lblProfileCheck";
            this.lblProfileCheck.Size = new System.Drawing.Size(46, 26);
            this.lblProfileCheck.TabIndex = 6;
            this.lblProfileCheck.Text = "User";
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
            this.btnLogout.Location = new System.Drawing.Point(0, 695);
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
            // btnProfile
            // 
            this.btnProfile.ButtonText = "Profile";
            this.btnProfile.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnProfile.CheckedForeColor = System.Drawing.Color.White;
            this.btnProfile.CheckedImageTint = System.Drawing.Color.White;
            this.btnProfile.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnProfile.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnProfile.HoverForeColor = System.Drawing.Color.White;
            this.btnProfile.HoverImage = null;
            this.btnProfile.HoverImageTint = System.Drawing.Color.White;
            this.btnProfile.HoverOutline = System.Drawing.Color.Empty;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAutoCenter = false;
            this.btnProfile.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnProfile.ImageOffset = new System.Drawing.Point(6, -1);
            this.btnProfile.ImageTint = System.Drawing.Color.White;
            this.btnProfile.IsToggleButton = false;
            this.btnProfile.IsToggled = false;
            this.btnProfile.Location = new System.Drawing.Point(14, 432);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.NormalBackground = System.Drawing.Color.Transparent;
            this.btnProfile.NormalForeColor = System.Drawing.Color.White;
            this.btnProfile.NormalOutline = System.Drawing.Color.Empty;
            this.btnProfile.OutlineThickness = 2F;
            this.btnProfile.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(112)))));
            this.btnProfile.PressedForeColor = System.Drawing.Color.White;
            this.btnProfile.PressedImageTint = System.Drawing.Color.White;
            this.btnProfile.PressedOutline = System.Drawing.Color.Empty;
            this.btnProfile.Rounding = new System.Windows.Forms.Padding(5);
            this.btnProfile.Size = new System.Drawing.Size(233, 52);
            this.btnProfile.TabIndex = 8;
            this.btnProfile.TextAutoCenter = false;
            this.btnProfile.TextOffset = new System.Drawing.Point(10, 0);
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
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
            this.btnInquiry.Location = new System.Drawing.Point(14, 368);
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
            this.btnReservations.Location = new System.Drawing.Point(14, 304);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(858, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Library Management System";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(910, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(952, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 27);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sarasavi";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(22, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(134, 27);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Dashboard";
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.contentPanel.Location = new System.Drawing.Point(0, 81);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1112, 666);
            this.contentPanel.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.contentPanel);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(258, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 747);
            this.panel1.TabIndex = 17;
            // 
            // sataDragControl1
            // 
            this.sataDragControl1.SelectControl = this.titleBar;
            // 
            // UserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1370, 793);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFormUser";
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sataPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private FrameworkTest.SATAButton btnMinimize;
        private FrameworkTest.SATAButton btnMaximize;
        private FrameworkTest.SATAButton btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private SATAUiFramework.Controls.SATAPictureBox sataPictureBox1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lblProfileCheck;
        private FrameworkTest.SATAButton btnLogout;
        private FrameworkTest.SATAButton btnProfile;
        private FrameworkTest.SATAButton btnInquiry;
        private FrameworkTest.SATAButton btnLoan;
        private FrameworkTest.SATAButton btnReservations;
        private FrameworkTest.SATAButton btnDashboard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel panel1;
        private SATAUiFramework.Controls.SATADragControl sataDragControl1;
    }
}