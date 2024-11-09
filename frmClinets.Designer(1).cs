
namespace BankManagmentSystem
{
    partial class frmClinets
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
            this.btnFindClinet = new Guna.UI2.WinForms.Guna2Button();
            this.dgvClients = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnFindByAccNumber = new Guna.UI2.WinForms.Guna2Button();
            this.txtFindByAccounNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFindByID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRefesh = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteClinet = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewClinet = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFindClinet
            // 
            this.btnFindClinet.BorderRadius = 25;
            this.btnFindClinet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindClinet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindClinet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindClinet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindClinet.FillColor = System.Drawing.Color.SteelBlue;
            this.btnFindClinet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindClinet.ForeColor = System.Drawing.Color.White;
            this.btnFindClinet.Location = new System.Drawing.Point(268, 40);
            this.btnFindClinet.Name = "btnFindClinet";
            this.btnFindClinet.Size = new System.Drawing.Size(180, 45);
            this.btnFindClinet.TabIndex = 5;
            this.btnFindClinet.Tag = "8";
            this.btnFindClinet.Text = "Find Clinet By ID";
            this.btnFindClinet.Click += new System.EventHandler(this.btnFindClinet_Click);
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClients.ColumnHeadersHeight = 22;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvClients.Location = new System.Drawing.Point(0, 203);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClients.RowHeadersVisible = false;
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.RowTemplate.Height = 25;
            this.dgvClients.Size = new System.Drawing.Size(1363, 536);
            this.dgvClients.TabIndex = 8;
            this.dgvClients.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvClients.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClients.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.dgvClients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvClients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClients.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvClients.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvClients.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgvClients.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClients.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClients.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvClients.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvClients.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvClients.ThemeStyle.ReadOnly = false;
            this.dgvClients.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            this.dgvClients.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClients.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClients.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Silver;
            this.dgvClients.ThemeStyle.RowsStyle.Height = 25;
            this.dgvClients.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvClients.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // btnFindByAccNumber
            // 
            this.btnFindByAccNumber.BorderRadius = 25;
            this.btnFindByAccNumber.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindByAccNumber.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindByAccNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindByAccNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindByAccNumber.FillColor = System.Drawing.Color.SteelBlue;
            this.btnFindByAccNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindByAccNumber.ForeColor = System.Drawing.Color.White;
            this.btnFindByAccNumber.Location = new System.Drawing.Point(258, 123);
            this.btnFindByAccNumber.Name = "btnFindByAccNumber";
            this.btnFindByAccNumber.Size = new System.Drawing.Size(224, 45);
            this.btnFindByAccNumber.TabIndex = 11;
            this.btnFindByAccNumber.Tag = "8";
            this.btnFindByAccNumber.Text = "Find Clinet By AccNumber";
            this.btnFindByAccNumber.Click += new System.EventHandler(this.btnFindByAccNumber_Click);
            // 
            // txtFindByAccounNumber
            // 
            this.txtFindByAccounNumber.BorderColor = System.Drawing.Color.White;
            this.txtFindByAccounNumber.BorderRadius = 20;
            this.txtFindByAccounNumber.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txtFindByAccounNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindByAccounNumber.DefaultText = "";
            this.txtFindByAccounNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFindByAccounNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFindByAccounNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindByAccounNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindByAccounNumber.FillColor = System.Drawing.Color.Gray;
            this.txtFindByAccounNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindByAccounNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFindByAccounNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFindByAccounNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindByAccounNumber.IconLeft = global::BankManagmentSystem.Properties.Resources.find;
            this.txtFindByAccounNumber.Location = new System.Drawing.Point(12, 120);
            this.txtFindByAccounNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFindByAccounNumber.Name = "txtFindByAccounNumber";
            this.txtFindByAccounNumber.PasswordChar = '\0';
            this.txtFindByAccounNumber.PlaceholderText = "FindByAccountNumber";
            this.txtFindByAccounNumber.SelectedText = "";
            this.txtFindByAccounNumber.Size = new System.Drawing.Size(219, 48);
            this.txtFindByAccounNumber.TabIndex = 10;
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
            this.txtFindByID.IconLeft = global::BankManagmentSystem.Properties.Resources.find;
            this.txtFindByID.Location = new System.Drawing.Point(12, 37);
            this.txtFindByID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFindByID.Name = "txtFindByID";
            this.txtFindByID.PasswordChar = '\0';
            this.txtFindByID.PlaceholderText = "FindByID";
            this.txtFindByID.SelectedText = "";
            this.txtFindByID.Size = new System.Drawing.Size(219, 48);
            this.txtFindByID.TabIndex = 9;
            this.txtFindByID.Tag = " ID";
            this.txtFindByID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnRefesh.Image = global::BankManagmentSystem.Properties.Resources.refresh;
            this.btnRefesh.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefesh.Location = new System.Drawing.Point(507, 70);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(180, 45);
            this.btnRefesh.TabIndex = 7;
            this.btnRefesh.Text = "RefeshAll";
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnDeleteClinet
            // 
            this.btnDeleteClinet.BorderRadius = 20;
            this.btnDeleteClinet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteClinet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteClinet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteClinet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteClinet.FillColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteClinet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteClinet.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClinet.Image = global::BankManagmentSystem.Properties.Resources.delete;
            this.btnDeleteClinet.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteClinet.Location = new System.Drawing.Point(720, 70);
            this.btnDeleteClinet.Name = "btnDeleteClinet";
            this.btnDeleteClinet.Size = new System.Drawing.Size(180, 45);
            this.btnDeleteClinet.TabIndex = 4;
            this.btnDeleteClinet.Tag = "4";
            this.btnDeleteClinet.Text = "Delete Client";
            this.btnDeleteClinet.Click += new System.EventHandler(this.btnDeleteClinet_Click);
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
            this.btnUpdate.Image = global::BankManagmentSystem.Properties.Resources.user_pen1;
            this.btnUpdate.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdate.Location = new System.Drawing.Point(926, 70);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 45);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Tag = "2";
            this.btnUpdate.Text = "Upadte Client";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddNewClinet
            // 
            this.btnAddNewClinet.BorderRadius = 20;
            this.btnAddNewClinet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewClinet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewClinet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewClinet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewClinet.FillColor = System.Drawing.Color.SteelBlue;
            this.btnAddNewClinet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewClinet.ForeColor = System.Drawing.Color.White;
            this.btnAddNewClinet.Image = global::BankManagmentSystem.Properties.Resources.user_add2;
            this.btnAddNewClinet.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddNewClinet.Location = new System.Drawing.Point(1133, 70);
            this.btnAddNewClinet.Name = "btnAddNewClinet";
            this.btnAddNewClinet.Size = new System.Drawing.Size(180, 45);
            this.btnAddNewClinet.TabIndex = 2;
            this.btnAddNewClinet.Tag = "1";
            this.btnAddNewClinet.Text = "Add New Clinet";
            this.btnAddNewClinet.Click += new System.EventHandler(this.btnAddNewClinet_Click);
            // 
            // frmClinets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 739);
            this.Controls.Add(this.btnFindByAccNumber);
            this.Controls.Add(this.txtFindByAccounNumber);
            this.Controls.Add(this.txtFindByID);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.btnFindClinet);
            this.Controls.Add(this.btnDeleteClinet);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNewClinet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClinets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClinets";
            this.Load += new System.EventHandler(this.frmClinets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnAddNewClinet;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDeleteClinet;
        private Guna.UI2.WinForms.Guna2Button btnFindClinet;
        private Guna.UI2.WinForms.Guna2Button btnRefesh;
        private Guna.UI2.WinForms.Guna2DataGridView dgvClients;
        private Guna.UI2.WinForms.Guna2TextBox txtFindByID;
        private Guna.UI2.WinForms.Guna2TextBox txtFindByAccounNumber;
        private Guna.UI2.WinForms.Guna2Button btnFindByAccNumber;
    }
}