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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {

        }

        private void frmHome_Load(object sender, EventArgs e)
        {
           
            
            TotalBalances();
            CountUsers();
            CountClients();
            FillUserData();
            CountTransferLog();
            
        }

        
        private void TotalBalances()
        {
            lbTotalBalances.Text = ClsClinet.TotalBalances().ToString();
           
        }

        private void CountUsers()
        {
            lbUsers.Text = ClsUser.TotalUsers().ToString();
        }

        private void CountClients()
        {
            lbTotalClients.Text = ClsClinet.CountClients().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void FillUserData()
        {
            lbUserName.Text = ClsCurrentUser.CurrentUser.UserName;

            ClsPerson person = ClsPerson.Find(ClsCurrentUser.CurrentUser.PersonID);

            if (person.Profile != "")
            {
                pcbProfile.Load(person.Profile);
            }

            lbFristName.Text = person.FirstName;
            lbLastName.Text = person.LastName;
            lbEmail.Text = person.Email;
            lbPhone.Text = person.Phone;
        }


         private void CountTransferLog()
        {
            lbTransferLog.Text = ClsTranferLogRegister.CountTrnasferLog().ToString();
        }
   
    }
}
