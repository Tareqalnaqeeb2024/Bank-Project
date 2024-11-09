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
    public partial class frmAddAndEditecs : Form
    {
        public enum EnMode  {add=0,Update=1};
        public static EnMode Mode = EnMode.add;
        int _ClinetID;
        ClsClinet  _Clinet;
        
        ClsPerson _Person;
   
        public frmAddAndEditecs(int ClinetID)
        {
            InitializeComponent();

            _ClinetID = ClinetID;
           
            if(_ClinetID   == -1   )
            {
                Mode = EnMode.add;
            }else
            {
                Mode = EnMode.Update;
            }
            
            
           
        }

       


        private void  _LoadData()
        {


            if (Mode == EnMode.add)
            {
                lbMode.Text = "Add New  Client";
                _Clinet = new ClsClinet();
                _Person = new ClsPerson();
              
            
                return;
            
            }

            _Clinet = ClsClinet.Find(_ClinetID);
           _Person = ClsPerson.Find(_Clinet.PersonID);


            if (_Person != null && _Clinet != null)
            {
                lbMode.Text = "Edit Clinet [" + _ClinetID + "] ";
                txtAccountNumber.Text = _Clinet.AccountNumber.ToString();
                txtAccountBalance.Text = _Clinet.AccountBalance.ToString();
                txtPinCode.Text = _Clinet.PinCode.ToString();
                txtFirstName1.Text = _Person.FirstName;
                txtLastName1.Text = _Person.LastName;
                txtEmail1.Text = _Person.Email;
                txtPhone1.Text = _Person.Phone;

                txtAddress.Text = _Person.Address;

                if (_Person.Gender == "Female")
                {
                    rdFemale.Checked = true;
                }
                else
                {
                    rdMale.Checked = true;
                }


                if (_Person.Profile != "")
                {
                    pictureBox1.Load(_Person.Profile);
                }

            }
            else
            {
                MessageBox.Show("No CLinet with  ID [" + _ClinetID + "]");
                this.Close();
                return;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            _Person.FirstName = txtFirstName1.Text;
            _Person.LastName = txtLastName1.Text;
            _Person.Email = txtEmail1.Text;
            _Person.Phone = txtPhone1.Text;
           _Person.BirthDay = dtpBirthday.Value;
            _Person.Address = txtAddress.Text;

            if(rdFemale.Checked)
            {
                _Person.Gender = rdFemale.Text;
            }
            else if (rdMale.Checked)
            {
                _Person.Gender = rdMale.Text;

            }
            else
            {
                _Person.Gender = "";
            }
            if(pictureBox1.ImageLocation !=null)
            {
                _Person.Profile = pictureBox1.ImageLocation;
            }else
            {
                _Person.Profile = "";
            }

          

            if (_Person.Save())
            {

                _Clinet.PersonID = _Person.ID;
                _Clinet.AccountNumber = txtAccountNumber.Text;
                _Clinet.AccountBalance = Convert.ToDecimal(txtAccountBalance.Text);
                _Clinet.PinCode = Convert.ToInt32(txtPinCode.Text);

                if (_Clinet.Save())
                {
                    

                    MessageBox.Show("Data Saved Successflluy");
                    
                }
                else
                {
                    MessageBox.Show("Erros: Data Is not Saved Successfully");

                }
            }
            

            Mode = EnMode.Update;

            lbMode.Text = " Edite Clinet [ " + _Clinet.ClinetID+" ]" + _ClinetID ;
        }


        private void frmAddAndEditecs_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void LAddImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string SelectedFilePath = openFileDialog1.FileName;
                pictureBox1.Load(SelectedFilePath);
            }
        }

        private void LlRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // PictureBox1.ImageLocation = null;
          //  PictureBox1.Visible = false;
        }

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
