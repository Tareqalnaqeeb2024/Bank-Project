
namespace BankManagmentSystem
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUserName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SildePanl = new System.Windows.Forms.Panel();
            this.pcbProfile = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnClinets = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pcClock = new System.Windows.Forms.PictureBox();
            this.lbClock = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.plBodyOfPage = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfile)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcClock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lbUserName);
            this.panel1.Controls.Add(this.SildePanl);
            this.panel1.Controls.Add(this.pcbProfile);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnTransaction);
            this.panel1.Controls.Add(this.btnClinets);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 752);
            this.panel1.TabIndex = 0;
            // 
            // lbUserName
            // 
            this.lbUserName.BackColor = System.Drawing.Color.Transparent;
            this.lbUserName.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.White;
            this.lbUserName.Location = new System.Drawing.Point(77, 164);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(33, 24);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "???";
            // 
            // SildePanl
            // 
            this.SildePanl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SildePanl.Location = new System.Drawing.Point(12, 248);
            this.SildePanl.Name = "SildePanl";
            this.SildePanl.Size = new System.Drawing.Size(23, 59);
            this.SildePanl.TabIndex = 2;
            // 
            // pcbProfile
            // 
            this.pcbProfile.Image = global::BankManagmentSystem.Properties.Resources.circle_user__6_;
            this.pcbProfile.Location = new System.Drawing.Point(23, 12);
            this.pcbProfile.Name = "pcbProfile";
            this.pcbProfile.Size = new System.Drawing.Size(160, 121);
            this.pcbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbProfile.TabIndex = 2;
            this.pcbProfile.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSettings.Image = global::BankManagmentSystem.Properties.Resources.exit;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(37, 636);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(159, 46);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "LogOut";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUsers.Image = global::BankManagmentSystem.Properties.Resources.user_crown;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(45, 539);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(142, 46);
            this.btnUsers.TabIndex = 5;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTransaction.Image = global::BankManagmentSystem.Properties.Resources.usd_circle;
            this.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.Location = new System.Drawing.Point(37, 442);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(159, 46);
            this.btnTransaction.TabIndex = 4;
            this.btnTransaction.Text = "Transfer";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnClinets
            // 
            this.btnClinets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClinets.FlatAppearance.BorderSize = 0;
            this.btnClinets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClinets.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClinets.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClinets.Image = global::BankManagmentSystem.Properties.Resources.users_alt;
            this.btnClinets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClinets.Location = new System.Drawing.Point(37, 345);
            this.btnClinets.Name = "btnClinets";
            this.btnClinets.Size = new System.Drawing.Size(159, 46);
            this.btnClinets.TabIndex = 3;
            this.btnClinets.Text = "Clinets";
            this.btnClinets.UseVisualStyleBackColor = true;
            this.btnClinets.Click += new System.EventHandler(this.btnClinets_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Image = global::BankManagmentSystem.Properties.Resources.house_chimney__4_;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(38, 248);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(156, 46);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.pcClock);
            this.panel2.Controls.Add(this.lbClock);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(210, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1644, 100);
            this.panel2.TabIndex = 1;
            // 
            // pcClock
            // 
            this.pcClock.Image = global::BankManagmentSystem.Properties.Resources.clock_three;
            this.pcClock.Location = new System.Drawing.Point(446, 42);
            this.pcClock.Name = "pcClock";
            this.pcClock.Size = new System.Drawing.Size(54, 40);
            this.pcClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcClock.TabIndex = 7;
            this.pcClock.TabStop = false;
            // 
            // lbClock
            // 
            this.lbClock.BackColor = System.Drawing.Color.Transparent;
            this.lbClock.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClock.Location = new System.Drawing.Point(497, 51);
            this.lbClock.Name = "lbClock";
            this.lbClock.Size = new System.Drawing.Size(3, 2);
            this.lbClock.TabIndex = 13;
            this.lbClock.Text = null;
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.Image = global::BankManagmentSystem.Properties.Resources.maximize__1_1;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(1173, 26);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(52, 47);
            this.button6.TabIndex = 12;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.Image = global::BankManagmentSystem.Properties.Resources.bank__5_1;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(189, 94);
            this.button5.TabIndex = 11;
            this.button5.Text = "Gaza \r\nBank  ";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Image = global::BankManagmentSystem.Properties.Resources.at;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(812, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 47);
            this.button4.TabIndex = 10;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Image = global::BankManagmentSystem.Properties.Resources.twitter_alt__1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(916, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 47);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Image = global::BankManagmentSystem.Properties.Resources.facebook;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1002, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 47);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Image = global::BankManagmentSystem.Properties.Resources.power1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1291, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 47);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // plBodyOfPage
            // 
            this.plBodyOfPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plBodyOfPage.Location = new System.Drawing.Point(210, 100);
            this.plBodyOfPage.Margin = new System.Windows.Forms.Padding(5);
            this.plBodyOfPage.Name = "plBodyOfPage";
            this.plBodyOfPage.Padding = new System.Windows.Forms.Padding(2);
            this.plBodyOfPage.Size = new System.Drawing.Size(1644, 652);
            this.plBodyOfPage.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1854, 752);
            this.Controls.Add(this.plBodyOfPage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfile)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcClock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnClinets;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pcbProfile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel SildePanl;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel plBodyOfPage;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbUserName;
        private System.Windows.Forms.Button button6;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pcClock;
    }
}

