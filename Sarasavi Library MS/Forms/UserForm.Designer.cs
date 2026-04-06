namespace Sarasavi_Library_MS.Forms
{
    partial class UserForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNIC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTelNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvUserTable = new System.Windows.Forms.DataGridView();
            this.btnDelete = new FrameworkTest.SATAButton();
            this.btnUpdate = new FrameworkTest.SATAButton();
            this.btnClear = new FrameworkTest.SATAButton();
            this.btnSave = new FrameworkTest.SATAButton();
            this.cmbSex = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Telephone No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "NIC No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Address:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(50, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 23);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Full Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(690, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "User Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(690, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Sex:";
            // 
            // txtName
            // 
            this.txtName.BorderRadius = 5;
            this.txtName.BorderThickness = 2;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.CadetBlue;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.CadetBlue;
            this.txtName.Location = new System.Drawing.Point(212, 29);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Enter Full Name";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(851, 43);
            this.txtName.TabIndex = 30;
            // 
            // txtNIC
            // 
            this.txtNIC.BorderRadius = 5;
            this.txtNIC.BorderThickness = 2;
            this.txtNIC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNIC.DefaultText = "";
            this.txtNIC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNIC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNIC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNIC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNIC.FocusedState.BorderColor = System.Drawing.Color.CadetBlue;
            this.txtNIC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIC.ForeColor = System.Drawing.Color.Black;
            this.txtNIC.HoverState.BorderColor = System.Drawing.Color.CadetBlue;
            this.txtNIC.Location = new System.Drawing.Point(212, 94);
            this.txtNIC.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.PlaceholderText = "Enter National Identity Card Number";
            this.txtNIC.SelectedText = "";
            this.txtNIC.Size = new System.Drawing.Size(365, 43);
            this.txtNIC.TabIndex = 31;
            // 
            // txtTelNo
            // 
            this.txtTelNo.BorderRadius = 5;
            this.txtTelNo.BorderThickness = 2;
            this.txtTelNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelNo.DefaultText = "";
            this.txtTelNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelNo.FocusedState.BorderColor = System.Drawing.Color.CadetBlue;
            this.txtTelNo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelNo.ForeColor = System.Drawing.Color.Black;
            this.txtTelNo.HoverState.BorderColor = System.Drawing.Color.CadetBlue;
            this.txtTelNo.Location = new System.Drawing.Point(212, 162);
            this.txtTelNo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.PlaceholderText = "Enter Mobile Number";
            this.txtTelNo.SelectedText = "";
            this.txtTelNo.Size = new System.Drawing.Size(365, 43);
            this.txtTelNo.TabIndex = 32;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderRadius = 5;
            this.txtAddress.BorderThickness = 2;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.CadetBlue;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.CadetBlue;
            this.txtAddress.Location = new System.Drawing.Point(212, 227);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceholderText = "Enter Home Address";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(851, 43);
            this.txtAddress.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dgvUserTable);
            this.panel2.Location = new System.Drawing.Point(0, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 279);
            this.panel2.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(478, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Registered Users";
            // 
            // dgvUserTable
            // 
            this.dgvUserTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserTable.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvUserTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserTable.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUserTable.Location = new System.Drawing.Point(40, 55);
            this.dgvUserTable.MultiSelect = false;
            this.dgvUserTable.Name = "dgvUserTable";
            this.dgvUserTable.ReadOnly = true;
            this.dgvUserTable.RowHeadersVisible = false;
            this.dgvUserTable.RowHeadersWidth = 51;
            this.dgvUserTable.RowTemplate.Height = 24;
            this.dgvUserTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserTable.Size = new System.Drawing.Size(1023, 202);
            this.dgvUserTable.TabIndex = 0;
            this.dgvUserTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserTable_CellClick);
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
            this.btnDelete.Location = new System.Drawing.Point(631, 301);
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
            this.btnDelete.TabIndex = 38;
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
            this.btnUpdate.HoverBackground = System.Drawing.Color.Gold;
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
            this.btnUpdate.Location = new System.Drawing.Point(784, 301);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.NormalBackground = System.Drawing.Color.Goldenrod;
            this.btnUpdate.NormalForeColor = System.Drawing.Color.White;
            this.btnUpdate.NormalOutline = System.Drawing.Color.Empty;
            this.btnUpdate.OutlineThickness = 2F;
            this.btnUpdate.PressedBackground = System.Drawing.Color.Gold;
            this.btnUpdate.PressedForeColor = System.Drawing.Color.White;
            this.btnUpdate.PressedImageTint = System.Drawing.Color.White;
            this.btnUpdate.PressedOutline = System.Drawing.Color.Empty;
            this.btnUpdate.Rounding = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Size = new System.Drawing.Size(127, 49);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.TextAutoCenter = true;
            this.btnUpdate.TextOffset = new System.Drawing.Point(0, 0);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnClear.HoverBackground = System.Drawing.Color.Chocolate;
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
            this.btnClear.Location = new System.Drawing.Point(479, 301);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.NormalBackground = System.Drawing.Color.SaddleBrown;
            this.btnClear.NormalForeColor = System.Drawing.Color.White;
            this.btnClear.NormalOutline = System.Drawing.Color.Empty;
            this.btnClear.OutlineThickness = 2F;
            this.btnClear.PressedBackground = System.Drawing.Color.Chocolate;
            this.btnClear.PressedForeColor = System.Drawing.Color.White;
            this.btnClear.PressedImageTint = System.Drawing.Color.White;
            this.btnClear.PressedOutline = System.Drawing.Color.Empty;
            this.btnClear.Rounding = new System.Windows.Forms.Padding(5);
            this.btnClear.Size = new System.Drawing.Size(127, 49);
            this.btnClear.TabIndex = 36;
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
            this.btnSave.Location = new System.Drawing.Point(936, 301);
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
            this.btnSave.TabIndex = 35;
            this.btnSave.TextAutoCenter = true;
            this.btnSave.TextOffset = new System.Drawing.Point(0, 0);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbSex
            // 
            this.cmbSex.BackColor = System.Drawing.Color.Transparent;
            this.cmbSex.BorderRadius = 5;
            this.cmbSex.BorderThickness = 2;
            this.cmbSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSex.FocusedColor = System.Drawing.Color.CadetBlue;
            this.cmbSex.FocusedState.BorderColor = System.Drawing.Color.CadetBlue;
            this.cmbSex.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbSex.ItemHeight = 37;
            this.cmbSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbSex.Location = new System.Drawing.Point(822, 94);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(241, 43);
            this.cmbSex.StartIndex = 0;
            this.cmbSex.TabIndex = 39;
            this.cmbSex.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.Transparent;
            this.cmbType.BorderRadius = 5;
            this.cmbType.BorderThickness = 2;
            this.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FocusedColor = System.Drawing.Color.CadetBlue;
            this.cmbType.FocusedState.BorderColor = System.Drawing.Color.CadetBlue;
            this.cmbType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbType.ItemHeight = 37;
            this.cmbType.Items.AddRange(new object[] {
            "Member",
            "Visitor"});
            this.cmbType.Location = new System.Drawing.Point(822, 162);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(241, 43);
            this.cmbType.StartIndex = 0;
            this.cmbType.TabIndex = 40;
            this.cmbType.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1108, 660);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.txtNIC);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtNIC;
        private Guna.UI2.WinForms.Guna2TextBox txtTelNo;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvUserTable;
        private FrameworkTest.SATAButton btnDelete;
        private FrameworkTest.SATAButton btnUpdate;
        private FrameworkTest.SATAButton btnClear;
        private FrameworkTest.SATAButton btnSave;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSex;
        private Guna.UI2.WinForms.Guna2ComboBox cmbType;
    }
}