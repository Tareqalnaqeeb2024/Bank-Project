using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankBusiness;

namespace BankManagmentSystem
{
    public partial class Form1 : Form
    {
        ClsPerson Person;
        public Form1()
        {
            InitializeComponent();    
        }
        private void btnClinets_Click(object sender, EventArgs e)
        {
            SildePanl.Height = btnClinets.Height;
            SildePanl.Top = btnClinets.Top;

            frmClinets frm = new frmClinets();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            plBodyOfPage.Controls.Clear();
            plBodyOfPage.Controls.Add(frm);
            frm.Show();
        
            
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            SildePanl.Height = btnUsers.Height;
            SildePanl.Top = btnUsers.Top;
            frmUser frm = new frmUser();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;

            plBodyOfPage.Controls.Clear();
            plBodyOfPage.Controls.Add(frm);
            
            frm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            Person = ClsPerson.Find(ClsCurrentUser.CurrentUser.PersonID);
            lbUserName.Text = ClsCurrentUser.CurrentUser.UserName;

            timer1.Enabled = true;

            if ( Person.Profile != "")
            {
                pcbProfile.Load(Person.Profile);
            }
            else
            {
                return;
            }

            SildePanl.Height = btnHome.Height;
            SildePanl.Top = btnHome.Top;
            frmHome frm = new frmHome();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            plBodyOfPage.Controls.Clear();
            plBodyOfPage.Controls.Add(frm);
            frm.Show();


            


        }

       

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            SildePanl.Height = btnTransaction.Height;
            SildePanl.Top = btnTransaction.Top;
            frmTransctions frm = new frmTransctions(-1);
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            plBodyOfPage.Controls.Clear();
            plBodyOfPage.Controls.Add(frm);
            frm.Show();
        }

        private void btnTransferLog_Click(object sender, EventArgs e)
        {

            frmTransctions frm = new frmTransctions(-1);
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            plBodyOfPage.Controls.Clear();
            plBodyOfPage.Controls.Add(frm);
            frm.Show();


        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SildePanl.Height = btnHome.Height;
            SildePanl.Top = btnHome.Top;
            frmHome frm = new frmHome();
            
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            plBodyOfPage.Controls.Clear();
            plBodyOfPage.Controls.Add(frm);
            frm.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
                       
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToString("T");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
