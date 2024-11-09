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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void _RefeshAllUsers()
        {
            dgvUsers.DataSource = ClsUser.GetALlUsers();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            if(!ClsCurrentUser.CurrentUser.CheckPermission(ClsUser.EnPermission.enShowUser) ||! ClsCurrentUser.CurrentUser.CheckPermission(ClsUser.EnPermission.enAll))
            {
                MessageBox.Show("Access Deined Contact Your Admin", "Erros", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            _RefeshAllUsers();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            _RefeshAllUsers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(!ClsCurrentUser.CurrentUser.CheckPermission(ClsUser.EnPermission.enUpdateUser) ||! ClsCurrentUser.CurrentUser.CheckPermission(ClsUser.EnPermission.enAll))
            {
                MessageBox.Show("Access Deined Contact Your Admin", "Erros", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;

            }
            frmAddUpdateUsers frm = new frmAddUpdateUsers((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.Show();
            _RefeshAllUsers();
            
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
             if(!ClsCurrentUser.CurrentUser.CheckPermission(ClsUser.EnPermission.enAddNewUser))
            {
                MessageBox.Show("Access Deined Contact Your Admin","Erros",MessageBoxButtons.OK,MessageBoxIcon.None);
                return;

            }
            frmAddUpdateUsers frm = new frmAddUpdateUsers(-1);
            frm.Show();
            _RefeshAllUsers();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
           if(!ClsCurrentUser.CurrentUser.CheckPermission(ClsUser.EnPermission.enDeleteUser) || !ClsCurrentUser.CurrentUser.CheckPermission(ClsUser.EnPermission.enAll))
            {
                MessageBox.Show("Access Deined Contact Your Admin", "Erros", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            if(MessageBox.Show("Are You To Delete User With ID [" + dgvUsers.CurrentRow.Cells[0].Value + "]",
                 "Confrim Delete" , MessageBoxButtons.OKCancel) == DialogResult.OK)

            {
                if (ClsUser.Delete((int)dgvUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Deleted User Sucessfuly");
                    _RefeshAllUsers();
                }
            }
        }

        private void btnFindClinet_Click(object sender, EventArgs e)
        {
            if(!ClsCurrentUser.CurrentUser.CheckPermission(ClsUser.EnPermission.enFindUser) )
            {
                MessageBox.Show("Access Deined Contact Your Admin", "Erros", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;

            }
            string ID = txtFindByID.Text;
            if(string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Please Enter UserID");
                txtFindByID.Focus();
                return;
            }
            int UserID = int.Parse(ID);

            ClsUser user = ClsUser.Find(UserID);
            

            DataTable table = new DataTable();


            if(user != null)
            {

                ClsPerson person = ClsPerson.Find(user.PersonID);
                table.Columns.Add("UserID", typeof(int));
                table.Columns.Add("FirstName", typeof(string));
                table.Columns.Add("LastName", typeof(string));
                table.Columns.Add("Email", typeof(string));
                table.Columns.Add("Phone", typeof(string));
                table.Columns.Add("Address", typeof(string));
                table.Columns.Add("Gander", typeof(string));
                table.Columns.Add("UserName", typeof(string));
                table.Columns.Add("PassWord", typeof(string));
                table.Columns.Add("Permissions", typeof(int));


                table.Rows.Add(user.UserID, person.FirstName, person.LastName, person.Email, person.Phone
                    , person.Address, person.Gender, user.UserName, user.PassWord, user.Permissions);


                dgvUsers.DataSource = table;



            }

            else
            {
                MessageBox.Show("User Is Not Exsit");
            }
        }

       

        private void btnFindByUserName_Click(object sender, EventArgs e)
        {
            if(!ClsCurrentUser.CurrentUser.CheckPermission(ClsUser.EnPermission.enFindUser))
            {
                MessageBox.Show("Access Deined Contact Your Admin", "Erros", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            ClsUser user = ClsUser.Find(txtFindByUserName.Text);

            DataTable table = new DataTable();


            if (user != null)
            {

                ClsPerson person = ClsPerson.Find(user.PersonID);
                table.Columns.Add("UserID", typeof(int));
                table.Columns.Add("FirstName", typeof(string));
                table.Columns.Add("LastName", typeof(string));
                table.Columns.Add("Email", typeof(string));
                table.Columns.Add("Phone", typeof(string));
                table.Columns.Add("Address", typeof(string));
                table.Columns.Add("Gander", typeof(string));
                table.Columns.Add("UserName", typeof(string));
                table.Columns.Add("PassWord", typeof(string));
                table.Columns.Add("Permissions", typeof(int));


                table.Rows.Add(user.UserID, person.FirstName, person.LastName, person.Email, person.Phone
                    , person.Address, person.Gender, user.UserName, user.PassWord, user.Permissions);


                dgvUsers.DataSource = table;



            }

            else
            {
                MessageBox.Show("User Is Not Exsit");
            }
        }
    }
}
