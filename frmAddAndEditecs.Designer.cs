
namespace BankManagmentSystem
{
    partial class frmAddAndEditecs
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbMode = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LAddImage = new System.Windows.Forms.LinkLabel();
            this.LlRemove = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtFirstName1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAccountBalance = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPinCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpBirthday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gpGender = new System.Windows.Forms.GroupBox();
            this.rdFemale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdMale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.gpGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Account Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(341, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "PinCode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Phone ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "FirstName";
            // 
            // lbMode
            // 
            this.lbMode.AutoSize = true;
            this.lbMode.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMode.Location = new System.Drawing.Point(484, 20);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(27, 19);
            this.lbMode.TabIndex = 31;
            this.lbMode.Text = "??";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 465);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 23);
            this.label9.TabIndex = 35;
            this.label9.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(341, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 23);
            this.label10.TabIndex = 37;
            this.label10.Text = "BithDay";
            // 
            // LAddImage
            // 
            this.LAddImage.AutoSize = true;
            this.LAddImage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAddImage.Location = new System.Drawing.Point(632, 110);
            this.LAddImage.Name = "LAddImage";
            this.LAddImage.Size = new System.Drawing.Size(107, 24);
            this.LAddImage.TabIndex = 38;
            this.LAddImage.TabStop = true;
            this.LAddImage.Text = "Add Image";
            this.LAddImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LAddImage_LinkClicked);
            // 
            // LlRemove
            // 
            this.LlRemove.AutoSize = true;
            this.LlRemove.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlRemove.Location = new System.Drawing.Point(789, 110);
            this.LlRemove.Name = "LlRemove";
            this.LlRemove.Size = new System.Drawing.Size(82, 24);
            this.LlRemove.TabIndex = 39;
            this.LlRemove.TabStop = true;
            this.LlRemove.Text = "Remove";
            this.LlRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlRemove_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtFirstName1
            // 
            this.txtFirstName1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFirstName1.BorderColor = System.Drawing.Color.Teal;
            this.txtFirstName1.BorderRadius = 20;
            this.txtFirstName1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName1.DefaultText = "";
            this.txtFirstName1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName1.FillColor = System.Drawing.Color.Teal;
            this.txtFirstName1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstName1.ForeColor = System.Drawing.Color.Silver;
            this.txtFirstName1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName1.Location = new System.Drawing.Point(12, 110);
            this.txtFirstName1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName1.Name = "txtFirstName1";
            this.txtFirstName1.PasswordChar = '\0';
            this.txtFirstName1.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtFirstName1.PlaceholderText = "FisrtName";
            this.txtFirstName1.SelectedText = "";
            this.txtFirstName1.Size = new System.Drawing.Size(229, 37);
            this.txtFirstName1.TabIndex = 41;
            // 
            // txtLastName1
            // 
            this.txtLastName1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtLastName1.BorderColor = System.Drawing.Color.Teal;
            this.txtLastName1.BorderRadius = 20;
            this.txtLastName1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName1.DefaultText = "";
            this.txtLastName1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName1.FillColor = System.Drawing.Color.Teal;
            this.txtLastName1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastName1.ForeColor = System.Drawing.Color.Silver;
            this.txtLastName1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName1.Location = new System.Drawing.Point(21, 210);
            this.txtLastName1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName1.Name = "txtLastName1";
            this.txtLastName1.PasswordChar = '\0';
            this.txtLastName1.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtLastName1.PlaceholderText = "Last Name";
            this.txtLastName1.SelectedText = "";
            this.txtLastName1.Size = new System.Drawing.Size(229, 37);
            this.txtLastName1.TabIndex = 42;
            // 
            // txtEmail1
            // 
            this.txtEmail1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmail1.BorderColor = System.Drawing.Color.Teal;
            this.txtEmail1.BorderRadius = 20;
            this.txtEmail1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail1.DefaultText = "";
            this.txtEmail1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail1.FillColor = System.Drawing.Color.Teal;
            this.txtEmail1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail1.ForeColor = System.Drawing.Color.Silver;
            this.txtEmail1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail1.Location = new System.Drawing.Point(12, 300);
            this.txtEmail1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.PasswordChar = '\0';
            this.txtEmail1.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtEmail1.PlaceholderText = "Email";
            this.txtEmail1.SelectedText = "";
            this.txtEmail1.Size = new System.Drawing.Size(229, 37);
            this.txtEmail1.TabIndex = 43;
            // 
            // txtPhone1
            // 
            this.txtPhone1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPhone1.BorderColor = System.Drawing.Color.Teal;
            this.txtPhone1.BorderRadius = 20;
            this.txtPhone1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone1.DefaultText = "";
            this.txtPhone1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone1.FillColor = System.Drawing.Color.Teal;
            this.txtPhone1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone1.ForeColor = System.Drawing.Color.Silver;
            this.txtPhone1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone1.Location = new System.Drawing.Point(12, 404);
            this.txtPhone1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.PasswordChar = '\0';
            this.txtPhone1.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtPhone1.PlaceholderText = "Phone";
            this.txtPhone1.SelectedText = "";
            this.txtPhone1.Size = new System.Drawing.Size(229, 37);
            this.txtPhone1.TabIndex = 44;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAddress.BorderColor = System.Drawing.Color.Teal;
            this.txtAddress.BorderRadius = 20;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FillColor = System.Drawing.Color.Teal;
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.ForeColor = System.Drawing.Color.Silver;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(12, 497);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtAddress.PlaceholderText = "Address";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(229, 37);
            this.txtAddress.TabIndex = 45;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAccountNumber.BorderColor = System.Drawing.Color.Teal;
            this.txtAccountNumber.BorderRadius = 20;
            this.txtAccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountNumber.DefaultText = "";
            this.txtAccountNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccountNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccountNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNumber.FillColor = System.Drawing.Color.Teal;
            this.txtAccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAccountNumber.ForeColor = System.Drawing.Color.Silver;
            this.txtAccountNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNumber.Location = new System.Drawing.Point(295, 110);
            this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.PasswordChar = '\0';
            this.txtAccountNumber.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtAccountNumber.PlaceholderText = "Account Number";
            this.txtAccountNumber.SelectedText = "";
            this.txtAccountNumber.Size = new System.Drawing.Size(229, 37);
            this.txtAccountNumber.TabIndex = 46;
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAccountBalance.BorderColor = System.Drawing.Color.Teal;
            this.txtAccountBalance.BorderRadius = 20;
            this.txtAccountBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountBalance.DefaultText = "";
            this.txtAccountBalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccountBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccountBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountBalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountBalance.FillColor = System.Drawing.Color.Teal;
            this.txtAccountBalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountBalance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAccountBalance.ForeColor = System.Drawing.Color.Silver;
            this.txtAccountBalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountBalance.Location = new System.Drawing.Point(295, 210);
            this.txtAccountBalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.PasswordChar = '\0';
            this.txtAccountBalance.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtAccountBalance.PlaceholderText = "Account Balance";
            this.txtAccountBalance.SelectedText = "";
            this.txtAccountBalance.Size = new System.Drawing.Size(229, 37);
            this.txtAccountBalance.TabIndex = 47;
            // 
            // txtPinCode
            // 
            this.txtPinCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPinCode.BorderColor = System.Drawing.Color.Teal;
            this.txtPinCode.BorderRadius = 20;
            this.txtPinCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPinCode.DefaultText = "";
            this.txtPinCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPinCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPinCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPinCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPinCode.FillColor = System.Drawing.Color.Teal;
            this.txtPinCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPinCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPinCode.ForeColor = System.Drawing.Color.Silver;
            this.txtPinCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPinCode.Location = new System.Drawing.Point(295, 300);
            this.txtPinCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.PasswordChar = '\0';
            this.txtPinCode.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtPinCode.PlaceholderText = "PimCode";
            this.txtPinCode.SelectedText = "";
            this.txtPinCode.Size = new System.Drawing.Size(229, 37);
            this.txtPinCode.TabIndex = 48;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.BorderRadius = 20;
            this.dtpBirthday.Checked = true;
            this.dtpBirthday.FillColor = System.Drawing.Color.Teal;
            this.dtpBirthday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpBirthday.ForeColor = System.Drawing.Color.White;
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpBirthday.Location = new System.Drawing.Point(282, 405);
            this.dtpBirthday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBirthday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(323, 36);
            this.dtpBirthday.TabIndex = 49;
            this.dtpBirthday.Value = new System.DateTime(2023, 12, 3, 21, 53, 25, 402);
            // 
            // gpGender
            // 
            this.gpGender.BackColor = System.Drawing.Color.Teal;
            this.gpGender.Controls.Add(this.rdFemale);
            this.gpGender.Controls.Add(this.rdMale);
            this.gpGender.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpGender.ForeColor = System.Drawing.SystemColors.Control;
            this.gpGender.Location = new System.Drawing.Point(295, 478);
            this.gpGender.Name = "gpGender";
            this.gpGender.Size = new System.Drawing.Size(200, 115);
            this.gpGender.TabIndex = 50;
            this.gpGender.TabStop = false;
            this.gpGender.Text = "Gender";
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdFemale.CheckedState.BorderThickness = 0;
            this.rdFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdFemale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdFemale.CheckedState.InnerOffset = -4;
            this.rdFemale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFemale.ForeColor = System.Drawing.Color.White;
            this.rdFemale.Location = new System.Drawing.Point(33, 74);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(105, 27);
            this.rdFemale.TabIndex = 48;
            this.rdFemale.Text = "Female";
            this.rdFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdFemale.UncheckedState.BorderThickness = 2;
            this.rdFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdMale.CheckedState.BorderThickness = 0;
            this.rdMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdMale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdMale.CheckedState.InnerOffset = -4;
            this.rdMale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMale.ForeColor = System.Drawing.Color.White;
            this.rdMale.Location = new System.Drawing.Point(33, 23);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(80, 27);
            this.rdMale.TabIndex = 47;
            this.rdMale.Text = "Male";
            this.rdMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdMale.UncheckedState.BorderThickness = 2;
            this.rdMale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 20;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::BankManagmentSystem.Properties.Resources.circle_xmark2;
            this.btnClose.Location = new System.Drawing.Point(505, 515);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 45);
            this.btnClose.TabIndex = 51;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(647, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 20;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::BankManagmentSystem.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(713, 515);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 45);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddAndEditecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(966, 668);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gpGender);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.txtPinCode);
            this.Controls.Add(this.txtAccountBalance);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone1);
            this.Controls.Add(this.txtEmail1);
            this.Controls.Add(this.txtLastName1);
            this.Controls.Add(this.txtFirstName1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LlRemove);
            this.Controls.Add(this.LAddImage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbMode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Name = "frmAddAndEditecs";
            this.Text = "frmAddAndEditecs";
            this.Load += new System.EventHandler(this.frmAddAndEditecs_Load);
            this.gpGender.ResumeLayout(false);
            this.gpGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbMode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel LAddImage;
        private System.Windows.Forms.LinkLabel LlRemove;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName1;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName1;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail1;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone1;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountBalance;
        private Guna.UI2.WinForms.Guna2TextBox txtPinCode;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBirthday;
        private System.Windows.Forms.GroupBox gpGender;
        private Guna.UI2.WinForms.Guna2RadioButton rdFemale;
        private Guna.UI2.WinForms.Guna2RadioButton rdMale;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}