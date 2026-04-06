namespace Sarasavi_Library_MS.Forms
{
    partial class UserForm1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new FrameworkTest.SATAButton();
            this.btnUpdate = new FrameworkTest.SATAButton();
            this.cmbType = new SATAComboBox();
            this.txtTelNo = new SATATextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new FrameworkTest.SATAButton();
            this.btnSave = new FrameworkTest.SATAButton();
            this.cmbSex = new SATAComboBox();
            this.txtNIC = new SATATextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new SATATextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new SATATextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvUserTable = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.lblUserID);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.cmbType);
            this.panel1.Controls.Add(this.txtTelNo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.cmbSex);
            this.panel1.Controls.Add(this.txtNIC);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 388);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnDelete.CheckedForeColor = System.Drawing.Color.White;
            this.btnDelete.CheckedImageTint = System.Drawing.Color.White;
            this.btnDelete.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnDelete.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.HoverBackground = System.Drawing.Color.IndianRed;
            this.btnDelete.HoverForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverImage = null;
            this.btnDelete.HoverImageTint = System.Drawing.Color.White;
            this.btnDelete.HoverOutline = System.Drawing.Color.Empty;
            this.btnDelete.Image = null;
            this.btnDelete.ImageAutoCenter = true;
            this.btnDelete.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnDelete.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDelete.ImageTint = System.Drawing.Color.White;
            this.btnDelete.IsToggleButton = false;
            this.btnDelete.IsToggled = false;
            this.btnDelete.Location = new System.Drawing.Point(631, 319);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NormalBackground = System.Drawing.Color.Firebrick;
            this.btnDelete.NormalForeColor = System.Drawing.Color.White;
            this.btnDelete.NormalOutline = System.Drawing.Color.Empty;
            this.btnDelete.OutlineThickness = 2F;
            this.btnDelete.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.PressedForeColor = System.Drawing.Color.White;
            this.btnDelete.PressedImageTint = System.Drawing.Color.White;
            this.btnDelete.PressedOutline = System.Drawing.Color.Empty;
            this.btnDelete.Rounding = new System.Windows.Forms.Padding(5);
            this.btnDelete.Size = new System.Drawing.Size(127, 49);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.TextAutoCenter = true;
            this.btnDelete.TextOffset = new System.Drawing.Point(0, 0);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ButtonText = "Update";
            this.btnUpdate.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.CheckedForeColor = System.Drawing.Color.White;
            this.btnUpdate.CheckedImageTint = System.Drawing.Color.White;
            this.btnUpdate.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.HoverBackground = System.Drawing.Color.DarkSeaGreen;
            this.btnUpdate.HoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverImage = null;
            this.btnUpdate.HoverImageTint = System.Drawing.Color.White;
            this.btnUpdate.HoverOutline = System.Drawing.Color.Empty;
            this.btnUpdate.Image = null;
            this.btnUpdate.ImageAutoCenter = true;
            this.btnUpdate.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnUpdate.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnUpdate.ImageTint = System.Drawing.Color.White;
            this.btnUpdate.IsToggleButton = false;
            this.btnUpdate.IsToggled = false;
            this.btnUpdate.Location = new System.Drawing.Point(784, 319);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.NormalBackground = System.Drawing.Color.Gold;
            this.btnUpdate.NormalForeColor = System.Drawing.Color.White;
            this.btnUpdate.NormalOutline = System.Drawing.Color.Empty;
            this.btnUpdate.OutlineThickness = 2F;
            this.btnUpdate.PressedBackground = System.Drawing.Color.LightGreen;
            this.btnUpdate.PressedForeColor = System.Drawing.Color.White;
            this.btnUpdate.PressedImageTint = System.Drawing.Color.White;
            this.btnUpdate.PressedOutline = System.Drawing.Color.Empty;
            this.btnUpdate.Rounding = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Size = new System.Drawing.Size(127, 49);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.TextAutoCenter = true;
            this.btnUpdate.TextOffset = new System.Drawing.Point(0, 0);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbType
            // 
            this.cmbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbType.BackColor = System.Drawing.Color.Transparent;
            this.cmbType.BackgroundColor = System.Drawing.Color.White;
            this.cmbType.BorderColor = System.Drawing.Color.LightGray;
            this.cmbType.BorderThickness = 2;
            this.cmbType.CornerRadius = 5;
            this.cmbType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.Items = new string[] {
        "Member",
        "Visitor"};
            this.cmbType.Keys = null;
            this.cmbType.Location = new System.Drawing.Point(822, 182);
            this.cmbType.Name = "cmbType";
            this.cmbType.SelectedIndex = 0;
            this.cmbType.Size = new System.Drawing.Size(241, 43);
            this.cmbType.TabIndex = 17;
            this.cmbType.Text = "sataComboBox1";
            this.cmbType.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.cmbType.TextOffset = new System.Windows.Forms.Padding(0, -3, 0, 0);
            // 
            // txtTelNo
            // 
            this.txtTelNo.BackColor = System.Drawing.Color.White;
            this.txtTelNo.BorderColor = System.Drawing.Color.LightGray;
            this.txtTelNo.BorderFocusColor = System.Drawing.Color.CadetBlue;
            this.txtTelNo.BorderRadius = 5;
            this.txtTelNo.BorderSize = 2;
            this.txtTelNo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelNo.Icon = null;
            this.txtTelNo.IconSize = new System.Drawing.Size(20, 20);
            this.txtTelNo.Location = new System.Drawing.Point(212, 182);
            this.txtTelNo.Multiline = false;
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.PasswordChar = false;
            this.txtTelNo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTelNo.PlaceholderText = "Enter Mobile Number";
            this.txtTelNo.Size = new System.Drawing.Size(365, 43);
            this.txtTelNo.TabIndex = 16;
            this.txtTelNo.Text = "sataTextBox1";
            this.txtTelNo.Texts = "";
            this.txtTelNo.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Telephone No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(684, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "User Type:";
            // 
            // btnClear
            // 
            this.btnClear.ButtonText = "Clear";
            this.btnClear.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnClear.CheckedForeColor = System.Drawing.Color.White;
            this.btnClear.CheckedImageTint = System.Drawing.Color.White;
            this.btnClear.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnClear.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.HoverBackground = System.Drawing.Color.IndianRed;
            this.btnClear.HoverForeColor = System.Drawing.Color.White;
            this.btnClear.HoverImage = null;
            this.btnClear.HoverImageTint = System.Drawing.Color.White;
            this.btnClear.HoverOutline = System.Drawing.Color.Empty;
            this.btnClear.Image = null;
            this.btnClear.ImageAutoCenter = true;
            this.btnClear.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnClear.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClear.ImageTint = System.Drawing.Color.White;
            this.btnClear.IsToggleButton = false;
            this.btnClear.IsToggled = false;
            this.btnClear.Location = new System.Drawing.Point(479, 319);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.NormalBackground = System.Drawing.Color.SaddleBrown;
            this.btnClear.NormalForeColor = System.Drawing.Color.White;
            this.btnClear.NormalOutline = System.Drawing.Color.Empty;
            this.btnClear.OutlineThickness = 2F;
            this.btnClear.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.PressedForeColor = System.Drawing.Color.White;
            this.btnClear.PressedImageTint = System.Drawing.Color.White;
            this.btnClear.PressedOutline = System.Drawing.Color.Empty;
            this.btnClear.Rounding = new System.Windows.Forms.Padding(5);
            this.btnClear.Size = new System.Drawing.Size(127, 49);
            this.btnClear.TabIndex = 13;
            this.btnClear.TextAutoCenter = true;
            this.btnClear.TextOffset = new System.Drawing.Point(0, 0);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.ButtonText = "Save";
            this.btnSave.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnSave.CheckedForeColor = System.Drawing.Color.White;
            this.btnSave.CheckedImageTint = System.Drawing.Color.White;
            this.btnSave.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnSave.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.HoverBackground = System.Drawing.Color.DarkSeaGreen;
            this.btnSave.HoverForeColor = System.Drawing.Color.White;
            this.btnSave.HoverImage = null;
            this.btnSave.HoverImageTint = System.Drawing.Color.White;
            this.btnSave.HoverOutline = System.Drawing.Color.Empty;
            this.btnSave.Image = null;
            this.btnSave.ImageAutoCenter = true;
            this.btnSave.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnSave.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSave.ImageTint = System.Drawing.Color.White;
            this.btnSave.IsToggleButton = false;
            this.btnSave.IsToggled = false;
            this.btnSave.Location = new System.Drawing.Point(936, 319);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.NormalBackground = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.NormalForeColor = System.Drawing.Color.White;
            this.btnSave.NormalOutline = System.Drawing.Color.Empty;
            this.btnSave.OutlineThickness = 2F;
            this.btnSave.PressedBackground = System.Drawing.Color.LightGreen;
            this.btnSave.PressedForeColor = System.Drawing.Color.White;
            this.btnSave.PressedImageTint = System.Drawing.Color.White;
            this.btnSave.PressedOutline = System.Drawing.Color.Empty;
            this.btnSave.Rounding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(127, 49);
            this.btnSave.TabIndex = 12;
            this.btnSave.TextAutoCenter = true;
            this.btnSave.TextOffset = new System.Drawing.Point(0, 0);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbSex
            // 
            this.cmbSex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSex.BackColor = System.Drawing.Color.Transparent;
            this.cmbSex.BackgroundColor = System.Drawing.Color.White;
            this.cmbSex.BorderColor = System.Drawing.Color.LightGray;
            this.cmbSex.BorderThickness = 2;
            this.cmbSex.CornerRadius = 5;
            this.cmbSex.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSex.Items = new string[] {
        "Male",
        "Female",
        "Other"};
            this.cmbSex.Keys = null;
            this.cmbSex.Location = new System.Drawing.Point(822, 114);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.SelectedIndex = 0;
            this.cmbSex.Size = new System.Drawing.Size(241, 43);
            this.cmbSex.TabIndex = 10;
            this.cmbSex.Text = "sataComboBox1";
            this.cmbSex.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.cmbSex.TextOffset = new System.Windows.Forms.Padding(0, -3, 0, 0);
            // 
            // txtNIC
            // 
            this.txtNIC.BackColor = System.Drawing.Color.White;
            this.txtNIC.BorderColor = System.Drawing.Color.LightGray;
            this.txtNIC.BorderFocusColor = System.Drawing.Color.CadetBlue;
            this.txtNIC.BorderRadius = 5;
            this.txtNIC.BorderSize = 2;
            this.txtNIC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIC.Icon = null;
            this.txtNIC.IconSize = new System.Drawing.Size(20, 20);
            this.txtNIC.Location = new System.Drawing.Point(212, 114);
            this.txtNIC.Multiline = false;
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.PasswordChar = false;
            this.txtNIC.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNIC.PlaceholderText = "Enter National Identity Card Number";
            this.txtNIC.Size = new System.Drawing.Size(365, 43);
            this.txtNIC.TabIndex = 9;
            this.txtNIC.Text = "sataTextBox1";
            this.txtNIC.Texts = "";
            this.txtNIC.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "NIC No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(684, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sex:";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderColor = System.Drawing.Color.LightGray;
            this.txtAddress.BorderFocusColor = System.Drawing.Color.CadetBlue;
            this.txtAddress.BorderRadius = 5;
            this.txtAddress.BorderSize = 2;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Icon = null;
            this.txtAddress.IconSize = new System.Drawing.Size(20, 20);
            this.txtAddress.Location = new System.Drawing.Point(212, 247);
            this.txtAddress.Multiline = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = false;
            this.txtAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAddress.PlaceholderText = "Enter Home Address";
            this.txtAddress.Size = new System.Drawing.Size(851, 43);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Text = "sataTextBox1";
            this.txtAddress.Texts = "";
            this.txtAddress.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Address:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.LightGray;
            this.txtName.BorderFocusColor = System.Drawing.Color.CadetBlue;
            this.txtName.BorderRadius = 5;
            this.txtName.BorderSize = 2;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Icon = null;
            this.txtName.IconSize = new System.Drawing.Size(20, 20);
            this.txtName.Location = new System.Drawing.Point(212, 49);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "Enter Full Name";
            this.txtName.Size = new System.Drawing.Size(851, 43);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "sataTextBox1";
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(50, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Full Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(478, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Registered Users";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dgvUserTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 388);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 272);
            this.panel2.TabIndex = 1;
            // 
            // dgvUserTable
            // 
            this.dgvUserTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserTable.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvUserTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserTable.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUserTable.Location = new System.Drawing.Point(40, 55);
            this.dgvUserTable.MultiSelect = false;
            this.dgvUserTable.Name = "dgvUserTable";
            this.dgvUserTable.ReadOnly = true;
            this.dgvUserTable.RowHeadersWidth = 51;
            this.dgvUserTable.RowTemplate.Height = 24;
            this.dgvUserTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserTable.Size = new System.Drawing.Size(1023, 202);
            this.dgvUserTable.TabIndex = 0;
            this.dgvUserTable.SelectionChanged += new System.EventHandler(this.dgvUserTable_SelectionChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(54, 319);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 16);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = "status";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(54, 352);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(47, 16);
            this.lblUserID.TabIndex = 21;
            this.lblUserID.Text = "user id";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 660);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.Text = "RegisterUserForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblName;
        private SATATextBox txtName;
        private SATATextBox txtNIC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private SATATextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private SATAComboBox cmbSex;
        private System.Windows.Forms.Label label3;
        private FrameworkTest.SATAButton btnSave;
        private FrameworkTest.SATAButton btnClear;
        private SATAComboBox cmbType;
        private SATATextBox txtTelNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvUserTable;
        private FrameworkTest.SATAButton btnDelete;
        private FrameworkTest.SATAButton btnUpdate;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblStatus;
    }
}