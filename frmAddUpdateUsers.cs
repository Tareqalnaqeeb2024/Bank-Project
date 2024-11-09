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
    public partial class frmAddUpdateUsers : Form
    {
        public enum EnMode {Add=0 , Update =1 };
        public static EnMode Mode = EnMode.Add;
        ClsUser _User;
        int _UserID;
        ClsPerson _Person;
        
        public frmAddUpdateUsers(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;

            if(_UserID == -1)
            {
                Mode = EnMode.Add;
            }
            else
            {
                Mode = EnMode.Update;
            }
        }

        private void _LoadData()
        {
            if (Mode == EnMode.Add)
            {
                lbMode.Text = "Add New User ";
                 _User = new ClsUser();
                _Person = new ClsPerson();
                
                return;
            }

            _User = ClsUser.Find(_UserID);
            _Person = ClsPerson.Find(_User.PersonID);

            if( _Person  != null && _User !=null)
            {


                lbMode.Text = "Adit User ID = [ " + _User.UserID + " ]";

                txtFirstName.Text = _Person.FirstName;
                txtLastName.Text = _Person.LastName;
                txtEmail.Text = _Person.Email;
                txtPhone.Text = _Person.Phone;
                txtAddress.Text = _Person.Address;
                txtUserName.Text = _User.UserName;
                txtPassWord.Text = _User.PassWord;
                //CheckUserListChecked(_User.Permissions);
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
                    pcUser.Load(_Person.Profile);

                }
               
            }

            else
            {
                MessageBox.Show("This form will be closed because No User with ID = " + _User.UserID);
                this.Close();

                return;
            }


        }
       
        private int _GetPermissions()
        {
            int Permissions =0;

            if(chkAllPermissions.Checked)
            {
                

                Permissions = Convert.ToInt32(chkAllPermissions.Tag);
              
                return Permissions;
                
            }
            if(chkShowAllClients.Checked)
            {
                Permissions += Convert.ToInt32(chkShowAllClients.Tag);
            }
            if(chkShowFindClient.Checked)
            {
                Permissions += Convert.ToInt32(chkShowFindClient.Tag) ;

            }
            if(chkShowAddNewClient.Checked)
            {
                Permissions += Convert.ToInt32(chkShowAddNewClient.Tag);
            }
            if (chkShowDeleteClient.Checked)
            {
                Permissions += Convert.ToInt32(chkShowDeleteClient.Tag);
            }

            if(chkShowUpdateClient.Checked)
            {
                Permissions += Convert.ToInt32(chkShowUpdateClient.Tag);
            }

            if(chkShowAddNewUser.Checked)
            {
                Permissions += Convert.ToInt32(chkShowAddNewUser.Tag);

            }
            if(chkShowUserList.Checked)
            {
                Permissions += Convert.ToInt32(chkShowUserList.Tag);

            }

            if(chkUpdateUser.Checked)
            {
                Permissions += Convert.ToInt32(chkUpdateUser.Tag);

            }

            if(chkFindUser.Checked)
            {
                Permissions += Convert.ToInt32(chkFindUser.Tag);
            }
            if(chkDeleteUser.Checked)
            {
                Permissions += Convert.ToInt32(chkDeleteUser.Tag);
            }

            return Permissions;

            
        }

       
        private void _DisableAllCheckBoxes()
        {
            chkShowAddNewClient.Enabled = false;
            chkShowAllClients.Enabled = false;
            chkShowFindClient.Enabled = false;
            chkShowUpdateClient.Enabled = false;
            chkShowDeleteClient.Enabled = false;
            chkShowUserList.Enabled = false;
            chkUpdateUser.Enabled = false;
            chkShowAddNewUser.Enabled = false;
            chkDeleteUser.Enabled = false;
            chkFindUser.Enabled = false;

        }

        private void _EnableAllCheckBoxes()
        {
            chkShowAddNewClient.Enabled = true;
            chkShowAllClients.Enabled = true;
            chkShowFindClient.Enabled = true;
            chkShowUpdateClient.Enabled = true;
            chkShowDeleteClient.Enabled = true;
            chkShowUserList.Enabled = true;
            chkUpdateUser.Enabled = true;
            chkShowAddNewUser.Enabled = true;
            chkDeleteUser.Enabled = true;
            chkFindUser.Enabled = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            

            _Person.FirstName = txtFirstName.Text;
            _Person.LastName = txtLastName.Text;
            _Person.Email = txtEmail.Text;
            _Person.Phone = txtPhone.Text;
          
            _Person.BirthDay = dtpBirthday.Value;
            _Person.Address = txtAddress.Text;
            if(rdFemale.Checked)
            {
                _Person.Gender = rdFemale.Text;
            }
            else 

            {
                _Person.Gender = rdMale.Text;
            }
            
            if (pcUser.ImageLocation != null)
            {
                _Person.Profile = pcUser.ImageLocation;
            }
            else
            {
                _Person.Profile = "";
            }

            if (_Person.Save())
            {
                _User.UserName = txtUserName.Text;
                _User.PassWord = txtPassWord.Text;
                _User.PersonID = _Person.ID;
                _User.Permissions = _GetPermissions();
                
                if(_User.Save())
                {
                    MessageBox.Show("Data Save  Successfuly");
                }

            }
            else
            {
                MessageBox.Show("Failed  Save Data");
            }

            Mode = EnMode.Update;

            lbMode.Text = "Edit User with ID = ["+_User.UserID+"]" ;

            

        }
        private void frmAddUpdateUsers_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

        private void chkAllPermissions_CheckedChanged(object sender, EventArgs e)
        {
            _DisableAllCheckBoxes();
            
        }

        private void grbPermissions_Click(object sender, EventArgs e)
        {
            _EnableAllCheckBoxes();
            chkAllPermissions.Checked = false;
        }

        private void chkShowAllClients_CheckedChanged(object sender, EventArgs e)
        {
            _EnableAllCheckBoxes();
        }

       

        private void LAddImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string SelectedFilePath = openFileDialog1.FileName;
                pcUser.Load(SelectedFilePath);
            }
        }

       

        private void chkShowUserList_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        
        //private void CheckUserListChecked(int Per)
        //{
        //   // int Per =  ;

        //    if(Per == -1)
        //    {
        //        chkAllPermissions.Checked = true;
        //    }
        //    if(( Per& 1)== Per)
        //    {
        //        chkShowAllClients.Checked = true;
        //    }
        //    if((Per & 2)== Per)
        //    {
        //        chkShowAddNewClient.Checked = true;
        //    }
        //    if((Per & 4)== (Per))
        //    {
        //        chkShowFindClient.Checked = true;
        //    }

        //    if((Per & 8) == Per)
        //    {
        //        chkShowDeleteClient.Checked = true;

        //    }
            
        //    if((Per & 16) == Per)
        //    {
        //        chkShowUpdateClient.Checked = true;

        //    }

        //    if(( Per & 32 ) ==Per)

        //    {
        //        chkShowUserList.Checked = true;

        //    }
        //    if((64 & Per) == (Per ))
        //    {
        //        chkShowAddNewUser.Checked = true;
        //    }
        //    if((128 & Per) ==( Per))
        //    {
        //        chkFindUser.Checked = true;

        //    }
        //    if((256 & Per) ==( Per))
        //    {
        //        chkDeleteUser.Checked = true;
        //    }
        //    if((512 & Per) == (Per))
        //    {
        //        chkUpdateUser.Checked = true;
        //    }
           
        //}

     

        private void txtFirstName_MouseDown(object sender, MouseEventArgs e)
        {
            this.Text = "";
        }

       
    }
}
