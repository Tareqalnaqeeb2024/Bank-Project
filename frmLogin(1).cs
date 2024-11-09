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
    public partial class frmLogin : Form
    {
       

        public frmLogin()
        {
           
            InitializeComponent();


        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
          

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            string UserName = txtUserName.Text;

            string PassWord = (txtPassWord.Text);

            ClsCurrentUser.CurrentUser = ClsUser.Find(UserName);

            if (ClsCurrentUser.CurrentUser != null)
            {
                
                if(ClsCurrentUser.CurrentUser.PassWord == PassWord)
                {
                    Form1 frm = new Form1();
                    
                   
                    frm.Show();
                    
                }
                else
                {
                    lbFailedPassWord.Visible = true;

                    MessageBox.Show("Password Of [" + PassWord + "]" + "Is Wrong","Wrong PassWord");
                }
            }
            
            else
            {
                lbFiledUserName.Visible = true;
                MessageBox.Show("Erros in User Name", "Failed Login");
            }
        }

       
     
    }
}
