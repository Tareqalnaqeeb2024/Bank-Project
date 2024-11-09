
namespace BankManagmentSystem
{
    partial class frmUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFindByID = new Guna.UI2.WinForms.Guna2Button();
            this.dgvUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtFindByID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFindByUserName = new Guna.UI2.WinForms.Guna2Button();
            this.txtFindByUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRefesh = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewUser = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFindByID
            // 
            this.btnFindByID.BorderRadius = 20;
            this.btnFindByID.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindByID.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindByID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindByID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindByID.FillColor = System.Drawing.Color.SteelBlue;
            this.btnFindByID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindByID.ForeColor = System.Drawing.Color.White;
            this.btnFindByID.Location = new System.Drawing.Point(276, 41);
            this.btnFindByID.Name = "btnFindByID";
            this.btnFindByID.Size = new System.Drawing.Size(142, 48);
            this.btnFindByID.TabIndex = 11;
            this.btnFindByID.Tag = "128";
            this.btnFindByID.Text = "Find User By ID";
            this.btnFindByID.Click += new System.EventHandler(this.btnFindClinet_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver;
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.ColumnHeadersHeight = 22;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsers.Location = new System.Drawing.Point(0, 219);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 26;
            this.dgvUsers.Size = new System.Drawing.Size(1470, 522);
            this.dgvUsers.TabIndex = 14;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(157)))));
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Silver;
            this.dgvUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUsers.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvUsers.ThemeStyle.ReadOnly = false;
            this.dgvUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.dgvUsers.ThemeStyle.RowsStyle.Height = 26;
            this.dgvUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Silver;
            // 
            // txtFindByID
            // 
            this.txtFindByID.BorderColor = System.Drawing.Color.Gray;
            this.txtFindByID.BorderRadius = 20;
            this.txtFindByID.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txtFindByID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindByID.DefaultText = "";
            this.txtFindByID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFindByID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFindByID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindByID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindByID.FillColor = System.Drawing.Color.Gray;
            this.txtFindByID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindByID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFindByID.ForeColor = System.Drawing.Color.White;
            this.txtFindByID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindByID.Location = new System.Drawing.Point(12, 41);
            this.txtFindByID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFindByID.Name = "txtFindByID";
            this.txtFindByID.PasswordChar = '\0';
            this.txtFindByID.PlaceholderText = "FindByID";
            this.txtFindByID.SelectedText = "";
            this.txtFindByID.Size = new System.Drawing.Size(219, 48);
            this.txtFindByID.TabIndex = 15;
            // 
            // btnFindByUserName
            // 
            this.btnFindByUserName.BorderRadius = 25;
            this.btnFindByUserName.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindByUserName.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindByUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindByUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindByUserName.FillColor = System.Drawing.Color.SteelBlue;
            this.btnFindByUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindByUserName.ForeColor = System.Drawing.Color.White;
            this.btnFindByUserName.Location = new System.Drawing.Point(256, 118);
            this.btnFindByUserName.Name = "btnFindByUserName";
            this.btnFindByUserName.Size = new System.Drawing.Size(224, 50);
            this.btnFindByUserName.TabIndex = 17;
            this.btnFindByUserName.Tag = "128";
            this.btnFindByUserName.Text = "Find User By User Name";
            this.btnFindByUserName.Click += new System.EventHandler(this.btnFindByUserName_Click);
            // 
            // txtFindByUserName
            // 
            this.txtFindByUserName.BorderColor = System.Drawing.Color.White;
            this.txtFindByUserName.BorderRadius = 20;
            this.txtFindByUserName.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txtFindByUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindByUserName.DefaultText = "";
            this.txtFindByUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFindByUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFindByUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindByUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindByUserName.FillColor = System.Drawing.Color.Gray;
            this.txtFindByUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindByUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFindByUserName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFindByUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindByUserName.Location = new System.Drawing.Point(12, 118);
            this.txtFindByUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFindByUserName.Name = "txtFindByUserName";
            this.txtFindByUserName.PasswordChar = '\0';
            this.txtFindByUserName.PlaceholderText = "FindByUserName";
            this.txtFindByUserName.SelectedText = "";
            this.txtFindByUserName.Size = new System.Drawing.Size(219, 48);
            this.txtFindByUserName.TabIndex = 16;
            // 
            // btnRefesh
            // 
            this.btnRefesh.BorderRadius = 20;
            this.btnRefesh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefesh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefesh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefesh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefesh.FillColor = System.Drawing.Color.SteelBlue;
            this.btnRefesh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefesh.ForeColor = System.Drawing.Color.White;
            this.btnRefesh.Image = global::BankManagmentSystem.Properties.Resources.refresh1;
            this.btnRefesh.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefesh.Location = new System.Drawing.Point(493, 63);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(175, 45);
            this.btnRefesh.TabIndex = 13;
            this.btnRefesh.Text = "RefeshAll";
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BorderRadius = 20;
            this.btnDeleteUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteUser.FillColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Image = global::BankManagmentSystem.Properties.Resources.delete1;
            this.btnDeleteUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteUser.Location = new System.Drawing.Point(696, 63);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(171, 45);
            this.btnDeleteUser.TabIndex = 10;
            this.btnDeleteUser.Tag = "64";
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 20;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::BankManagmentSystem.Properties.Resources.user_pen2;
            this.btnUpdate.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdate.Location = new System.Drawing.Point(900, 63);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 45);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Tag = "32";
            this.btnUpdate.Text = "Update ";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BorderRadius = 20;
            this.btnAddNewUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewUser.FillColor = System.Drawing.Color.SteelBlue;
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewUser.ForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.Image = global::BankManagmentSystem.Properties.Resources.user_add3;
            this.btnAddNewUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddNewUser.Location = new System.Drawing.Point(1114, 63);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(158, 45);
            this.btnAddNewUser.TabIndex = 8;
            this.btnAddNewUser.Tag = "16";
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 741);
            this.Controls.Add(this.btnFindByUserName);
            this.Controls.Add(this.txtFindByUserName);
            this.Controls.Add(this.txtFindByID);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.btnFindByID);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNewUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUser";
            this.Text = "frmUser";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnRefesh;
        private Guna.UI2.WinForms.Guna2Button btnFindByID;
        private Guna.UI2.WinForms.Guna2Button btnDeleteUser;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnAddNewUser;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUsers;
        private Guna.UI2.WinForms.Guna2TextBox txtFindByID;
        private Guna.UI2.WinForms.Guna2Button btnFindByUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtFindByUserName;
    }
}