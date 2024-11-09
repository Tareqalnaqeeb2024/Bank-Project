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
    public partial class frmClinets : Form
    {
       

        public frmClinets()
        {

            InitializeComponent();

        }
        private void _RefershAllClinets()
        {
            dgvClients.DataSource = ClsClinet.GetAllClinets();
        }

        private void dvgClinets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmClinets_Load(object sender, EventArgs e)
        {
            _RefershAllClinets();
        }

        private void btnAddNewClinet_Click(object sender, EventArgs e)
        {
            
            if (!ClsCurrentUser.CurrentUser.CheckPermission(ClsUser.EnPermission.enAddNewClient))
            {
                MessageBox.Show("Access Deined Contact Your Admin", "Erros", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;

            }
            else
            {

                frmAddAndEditecs frm = new frmAddAndEditecs(-1);
                frm.ShowDialog();
                _RefershAllClinets();
            }
        }


        private void btnDeleteClinet_Click(object sender, EventArgs e)
        {
            if (!ClsCurrentUser.CurrentUser.CheckPermission(ClsUser.EnPermission.enDeleteClient))
            {
                MessageBox.Show("Access Deined Contact Your Admin", "Erros", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;

            }
            if (MessageBox.Show("Are you Sure To Delete Clinet with [" + dgvClients.CurrentRow.Cells[0].Value+ "]",
                "Delete Clinet" , MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                if (ClsClinet.DeleteClinet((int)dgvClients.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Delete Clinet Successfuly");
                    _RefershAllClinets();
                }else
                {
                    MessageBox.Show("Falied Delete Clinet");
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ClsCurrentUser.CurrentUser.CheckPermission(ClsUser.EnPermission.enUpdateClient))
            {
                MessageBox.Show("Access Deined Contact Your Admin", "Erros", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;

            }
            else
            {

                frmAddAndEditecs frm = new frmAddAndEditecs((int)dgvClients.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
                _RefershAllClinets();
            }

        }

        private void btnFindClinet_Click(object sender, EventArgs e)
        {
            if (!ClsCurrentUser.CurrentUser.CheckPermission(ClsUser.EnPermission.enFindClient))
            {
                MessageBox.Show("Access Deined Contact Your Admin", "Erros", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;

            }

            string ID = txtFindByID.Text;

            if(string.IsNullOrWhiteSpace(ID))
            {

                txtFindByID.PlaceholderText = "";
                txtFindByID.Focus();
                return;

            }
            
            int  ClinetID = int.Parse(txtFindByID.Text);

           

           

            DataTable dataTable = new DataTable();

            ClsClinet Clinet1 = ClsClinet.Find(ClinetID);

            //ClsPerson Person = ClsPerson.Find(Clinet1.PersonID);


            if (Clinet1 != null)
            {
                ClsPerson Person = ClsPerson.Find(Clinet1.PersonID);

                dataTable.Columns.Add("ClinetID", typeof(int));

                dataTable.Columns.Add("FullName", typeof(string));
                dataTable.Columns.Add("PersonID", typeof(int));
                dataTable.Columns.Add("Phone", typeof(string));
                dataTable.Columns.Add("Email", typeof(string));
                dataTable.Columns.Add("Gender", typeof(string));
                dataTable.Columns.Add("BirthDay", typeof(DateTime));
                dataTable.Columns.Add("Address", typeof(string));
                dataTable.Columns.Add("Profile", typeof(string));


                //dataTable.Columns.Add()


                dataTable.Columns.Add("account Number", typeof(string));
                dataTable.Columns.Add("AccountBalance", typeof(decimal));
                dataTable.Columns.Add("PinCode", typeof(int));

                dataTable.Rows.Add(Clinet1.ClinetID, Person.FirstName + " " + Person.LastName, Person.ID, Person.Phone, Person.Email, Person.Gender, Person.BirthDay,
                    Person.Address, Person.Profile,
        Clinet1.AccountNumber, Clinet1.AccountBalance, Clinet1.PinCode);


                dgvClients.DataSource = dataTable;


            }
            else

            {

                MessageBox.Show("Client With ID  [" + ClinetID + " ]not exsit");
                return;
            }

           


        }

        private void btnFindByAccNumber_Click(object sender, EventArgs e)
        {
            if (!ClsCurrentUser.CurrentUser.CheckPermission(ClsUser.EnPermission.enFindClient))
            {
                MessageBox.Show("Access Deined Contact Your Admin", "Erros", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }

            DataTable dataTable = new DataTable();

            string AccountNumber = txtFindByAccounNumber.Text;
            if(string.IsNullOrWhiteSpace(AccountNumber))
            {
                txtFindByAccounNumber.Text = "";
                txtFindByAccounNumber.Focus();
                return;
            }

            ClsClinet Client2 = ClsClinet.Find(AccountNumber);

            if (Client2 != null)
            {
                ClsPerson Person2 = ClsPerson.Find(Client2.PersonID);

                dataTable.Columns.Add("ClinetID", typeof(int));

                dataTable.Columns.Add("FullName", typeof(string));
                dataTable.Columns.Add("PersonID", typeof(int));
                dataTable.Columns.Add("Phone", typeof(string));
                dataTable.Columns.Add("Email", typeof(string));
                dataTable.Columns.Add("Gender", typeof(string));
                dataTable.Columns.Add("BirthDay", typeof(DateTime));
                dataTable.Columns.Add("Address", typeof(string));
                dataTable.Columns.Add("Profile", typeof(string));


                //dataTable.Columns.Add()


                dataTable.Columns.Add("account Number", typeof(string));
                dataTable.Columns.Add("AccountBalance", typeof(decimal));
                dataTable.Columns.Add("PinCode", typeof(int));

                dataTable.Rows.Add(Client2.ClinetID, Person2.FirstName + " " + Person2.LastName, Person2.ID, Person2.Phone, Person2.Email, Person2.Gender, Person2.BirthDay,
                    Person2.Address, Person2.Profile,
        Client2.AccountNumber, Client2.AccountBalance, Client2.PinCode);


                dgvClients.DataSource = dataTable;
            }
            else
            {

                MessageBox.Show("Client With Account Number  [" + AccountNumber + " ]not exsit");
                return;
            }

        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            if(!ClsCurrentUser.CurrentUser.CheckPermission(ClsUser.EnPermission.enShowClient))
            {
                MessageBox.Show("You can not Access this Button ");

                return;
            }
            _RefershAllClinets();
        }

       

       
    }
}
