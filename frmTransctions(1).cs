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
    public partial class frmTransctions : Form
    {
        public enum EnMode { Add = 0 };
        public static EnMode Mode = EnMode.Add;
        ClsTranferLogRegister _TranferLogRegister ;

        int _TransferID;


        public frmTransctions(int ID  )
        {
            InitializeComponent();

            _TransferID = ID;
            if (_TransferID == -1)
            {
                Mode = EnMode.Add;

            }
        }

        public void SaveNewRecord()
        {
            ClsClinet SourceClinet = ClsClinet.Find(txtFromAccNumber.Text);
            ClsClinet DestinationClinet = ClsClinet.Find(txtToAccountNumber.Text);
           ClsTranferLogRegister _TranferLogRegister = new ClsTranferLogRegister();

            _TranferLogRegister.dateTime = DateTime.Now;
            _TranferLogRegister.Amount = Convert.ToDecimal(txtTrnasferAmount.Text);
            _TranferLogRegister.DestiantionClinetID = DestinationClinet.ClinetID;
            _TranferLogRegister.DestinationAccountBalance = DestinationClinet.AccountBalance;
            _TranferLogRegister.SourceClinetID = SourceClinet.ClinetID;
            _TranferLogRegister.SourceAccountBalance = SourceClinet.AccountBalance;
            _TranferLogRegister.UserID =  ClsCurrentUser.CurrentUser.UserID;

            if(_TranferLogRegister.Save())
            {
                MessageBox.Show("Add New Transfer Log Successfuly");
            }
            else
            {
                MessageBox.Show("Failed Add New Transfer ");
            }

          
        }

       

        private void _RefershAllTransferLog()
        {
            dgvTransferLog.DataSource = ClsTranferLogRegister.GetALLTransferRegister();

        }

        private void _TotalBalances()
        {
            dgvTotalBalances.DataSource = ClsClinet.GetTotalBalance();
            lbTotalBalances.Text = ClsClinet.TotalBalances().ToString() + "$";
            //dgvTransferLog.DataSource = ClsTranferLogRegister.GetALLTransferRegister();
            _RefershAllTransferLog();


        }

        private void _Deposite()
        {
            
            ClsClinet clinet = ClsClinet.Find(txtAccNumber.Text);
           


                if (string.IsNullOrWhiteSpace(txtAmount.Text))
                {
                    MessageBox.Show("Please ENter Amonut !!");
                    txtAmount.Focus();
                    return;
                }
                decimal Amount = Convert.ToDecimal(txtAmount.Text);
                
                clinet.Deposite(Amount);

                clinet.Save();
                MessageBox.Show("Done Successfuly New AccountBalances " + clinet.AccountBalance + "$"  );
              
            txtAccountBalance1.Text = clinet.AccountBalance.ToString();

                return;
            

        }

        private void _Withdraw()
        {
            ClsClinet clinet = ClsClinet.Find(txtAccountNumber.Text);

            if(clinet != null && decimal.TryParse(txtWithdrawAmonut.Text, out decimal Amonut))
            {
                if(clinet.Withdraw(Amonut))
                {
                    clinet.Save();
                    MessageBox.Show("Done Withdraw Successfuly New AccNumber  " + clinet.AccountBalance + " ", "Withdraw Message");
                    txtAccountBalance.Text = clinet.AccountBalance.ToString();
                } else
                {
                    MessageBox.Show("Failed  Withdraw");

                }
            }

        }

       
        private void btnCheck_Click(object sender, EventArgs e)
        {
            _Deposite();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            _Withdraw();

        }

        private bool _Transfer()
        {
            ClsClinet FromClinet = ClsClinet.Find(txtFromAccNumber.Text);

            ClsClinet ToClinet = ClsClinet.Find(txtToAccountNumber.Text);


            if (string.IsNullOrWhiteSpace(txtTrnasferAmount.Text))
            {
                MessageBox.Show("Please Enter TransferAmount !!!", "Empty Filed");
                txtTrnasferAmount.Focus();
                return false ;
            }

            decimal AmonutTransfer = Convert.ToDecimal(txtTrnasferAmount.Text);

            if (FromClinet.Trnafer(ToClinet , AmonutTransfer))
            {
                
                FromClinet.Save();
                ToClinet.Save();

                

                txtFTotalBalances.Text = FromClinet.AccountBalance.ToString();
                txtTTotalBalances.Text = ToClinet.AccountBalance.ToString();


                return true;
            }
            else
            {
                return false;
            }

           


        }
       
        private void btnTotalBalances_Click(object sender, EventArgs e)
        {
            _TotalBalances();
        }

       
      

        private void btnTransfer_Click_1(object sender, EventArgs e)
        {
            

            if (_Transfer())
            {
                //frmTransctions frm = new frmTransctions(-1);

                SaveNewRecord();
                _RefershAllTransferLog();

                MessageBox.Show("Done Trnasfer Successfuly");
                


            }
            else
            {
                MessageBox.Show("False");
            }
        }

      
        private void _Sereach()
        {
            ClsClinet clinet = ClsClinet.Find(txtAccNumber.Text);

            ClsPerson person = ClsPerson.Find(clinet.PersonID);
            if (string.IsNullOrWhiteSpace(txtAccNumber.Text.Trim()))
            {
                MessageBox.Show("Please Enter Correcrt Account Number ", "Erros", MessageBoxButtons.OKCancel);
                return;
            }
            if (clinet == null)
            {

                MessageBox.Show("No Exsit AccountNumber[ " + clinet.AccountNumber + "]", "Wrong", MessageBoxButtons.OKCancel);
                return;


            }

            else
            {
                txtFirstName.Text = person.FirstName;
                txtLastName.Text = person.LastName;
                txtPhone.Text = person.Phone;
                txtAccountBalance.Text = clinet.AccountBalance.ToString();
                txtAccountNumber.Text = clinet.AccountNumber;
            }
        }

        private void btnSereach_Click(object sender, EventArgs e)
        {
            ClsClinet clinet = ClsClinet.Find(txtAccNumber.Text);

            ClsPerson person = ClsPerson.Find(clinet.PersonID);
            if (string.IsNullOrWhiteSpace(txtAccNumber.Text.Trim()))
            {
                MessageBox.Show("Please Enter Correcrt Account Number ", "Erros", MessageBoxButtons.OKCancel);
                return;
            }
            if (clinet == null)
            {

                MessageBox.Show("No Exsit AccountNumber[ " + clinet.AccountNumber + "]", "Wrong", MessageBoxButtons.OKCancel);
                return;


            }
            else
            {
                txtAmount.Visible = true;
                btnDeposit.Visible = true;
                grpClientData.Visible = true;
                txtFirstName1.Text = person.FirstName;
                txtEmail1.Text = person.Email;
                txtLastName1.Text = person.LastName;
                txtAccountBalance1.Text = clinet.AccountBalance.ToString();
                txtPhone1.Text = person.Phone;

            }

        }

    
        private void btnSereach1_Click(object sender, EventArgs e)
        {
            ClsClinet clinet = ClsClinet.Find(txtAccountNumber.Text);

            if (string.IsNullOrWhiteSpace(txtAccountNumber.Text.Trim()))
            {
                MessageBox.Show("Please Enter Correcrt Account Number ", "Erros", MessageBoxButtons.OKCancel);
                return;
            }
            if (clinet == null)
            {

                MessageBox.Show("No Exsit AccountNumber[ " + clinet.AccountNumber + "]", "Wrong", MessageBoxButtons.OKCancel);
                return;
            }

            else
            {
                ClsPerson person = ClsPerson.Find(clinet.PersonID);

                txtWithdrawAmonut.Visible = true;
                btnWithdraw.Visible = true;
                gbClientData.Visible = true;
                txtFirstName.Text = person.FirstName;
                txtLastName.Text = person.LastName;
                txtPhone.Text = person.Phone;
                txtEmail.Text = person.Email;
                txtAccountBalance.Text = clinet.AccountBalance.ToString();
                txtAccountNumber.Text = clinet.AccountNumber;
            }


        
        }

        

        private void btnFromCLinet_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtFromAccNumber.Text.Trim()))
            {
                MessageBox.Show("Please Enter Correcrt Account Number ", "Erros", MessageBoxButtons.OKCancel);
                txtFromAccNumber.Focus();

                return;
            }
            ClsClinet clinet = ClsClinet.Find(txtFromAccNumber.Text);

            if (clinet == null )
            {

                MessageBox.Show("No Exsit AccountNumber[ " + txtFromAccNumber + "]", "Wrong", MessageBoxButtons.OKCancel);
                txtFromAccNumber.Clear();
                txtFromAccNumber.Focus();
                return;
            }

            else
            {
                ClsPerson person = ClsPerson.Find(clinet.PersonID);

                txtToAccountNumber.Visible = true;
                btnToClient.Visible = true;
                gpFromClinet.Visible = true;
                txtFFirstName.Text = person.FirstName;
                txtFLastName.Text = person.LastName;
                txtFPhone.Text = person.Phone;
                txtFEmail.Text = person.Email;
                txtFTotalBalances.Text = clinet.AccountBalance.ToString();
                //txtFAccountNumbe.Text = clinet.AccountNumber;
            }

        }

        private void btnToClinet_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtToAccountNumber.Text.Trim()))
            {
                MessageBox.Show("Please Enter Correcrt Account Number ", "Erros", MessageBoxButtons.OKCancel);
                txtToAccountNumber.Focus();
                return;
            }
            ClsClinet clinet = ClsClinet.Find(txtToAccountNumber.Text);

            if (clinet == null )
            {

                MessageBox.Show("No Exsit AccountNumber[ " + txtToAccountNumber + "]", "Wrong", MessageBoxButtons.OKCancel);
                txtToAccountNumber.Clear();
                txtToAccountNumber.Focus();
                return;
            }

            else
            {
                ClsPerson person = ClsPerson.Find(clinet.PersonID);

                txtTrnasferAmount.Visible = true;
                btnTransfer.Visible = true;
                gpToCLinet.Visible = true;
                txtTFirstName.Text = person.FirstName;
                txtTLastName.Text = person.LastName;
                txtToPhone.Text = person.Phone;
                txtTEmail.Text = person.Email;
                txtTTotalBalances.Text = clinet.AccountBalance.ToString();
                //txtFAccountNumbe.Text = clinet.AccountNumber;
            }
        }

        private void TransferLog_Click(object sender, EventArgs e)
        {
            if (_Transfer())
            {
                frmTransctions frm = new frmTransctions(-1);

                SaveNewRecord();
                //_RefershAllTransferLog();

                MessageBox.Show("Done Trnasfer Successfuly");



            }
            else
            {
                MessageBox.Show("False");
            }
        }

       

        private void btnToClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtToAccountNumber.Text.Trim()))
            {
                MessageBox.Show("Please Enter Correcrt Account Number ", "Erros", MessageBoxButtons.OKCancel);
                txtToAccountNumber.Focus();
                return;
            }
            ClsClinet clinet = ClsClinet.Find(txtToAccountNumber.Text);

            if (clinet == null)
            {

                MessageBox.Show("No Exsit AccountNumber[ " + txtToAccountNumber + "]", "Wrong", MessageBoxButtons.OKCancel);
                txtToAccountNumber.Clear();
                txtToAccountNumber.Focus();
                return;
            }

            else
            {
                ClsPerson person = ClsPerson.Find(clinet.PersonID);

                txtTrnasferAmount.Visible = true;
                btnTransfer.Visible = true;
                gpToCLinet.Visible = true;
                txtTFirstName.Text = person.FirstName;
                txtTLastName.Text = person.LastName;
                txtToPhone.Text = person.Phone;
                txtTEmail.Text = person.Email;
                txtTTotalBalances.Text = clinet.AccountBalance.ToString();
                //txtFAccountNumbe.Text = clinet.AccountNumber;
            }
        }

        
    }
}

