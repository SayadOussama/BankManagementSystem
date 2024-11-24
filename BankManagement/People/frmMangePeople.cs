using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement.People
{

    
    public partial class frmMangePeople : Form
    {
        private static DataTable dt = clsPerson.GetPeopleList();
        public frmMangePeople()
        {
            InitializeComponent();
        }
        private  void _RefrachList()
        {
            dt = clsPerson.GetPeopleList();
            dgvPeople.DataSource = dt;
            lblRecordsCount.Text = dt.Rows.Count.ToString();
        }

        private void frmMangePeople_Load(object sender, EventArgs e)
        {
            dgvPeople.DataSource = dt;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dt.Rows.Count.ToString();

            //Styling The Grid View width of the Table 
            if(dgvPeople.Rows.Count > 0)
            {
                //specify the width and ReName the HeaderText 
                dgvPeople.Columns[0].HeaderText = "Person ID";
                dgvPeople.Columns[0].Width = 80;

                dgvPeople.Columns[1].HeaderText = "National NO";
                dgvPeople.Columns[1].Width = 100;

                dgvPeople.Columns[2].HeaderText = "Full Name";
                dgvPeople.Columns[2].Width = 280;

                dgvPeople.Columns[3].HeaderText = "Gender";
                dgvPeople.Columns[3].Width = 100;

                dgvPeople.Columns[4].HeaderText = "Phone Number";
                dgvPeople.Columns[4].Width = 120;

                dgvPeople.Columns[5].HeaderText = "Email";
                dgvPeople.Columns[5].Width = 170;

                dgvPeople.Columns[6].HeaderText = "Country ";
                dgvPeople.Columns[6].Width = 150;
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Doing Maping to the Real Name In Query Data 
            switch(cbFilterBy.Text)
            {
                case "Person ID":

                    FilterColumn = "PersonID";
                    break;
                case "National No.":
                    FilterColumn = "NationalNO";
                    break;
                case "Full Name":

                    FilterColumn = "FullName";
                    break;
                case "Gender":
                    FilterColumn = "Gender";
                    break;
                case "Phone":
                    FilterColumn = "PhoneNumber";
                    break;
                case "Email":
                    FilterColumn = "Email";
                    break;
                case "Country":
                    FilterColumn = "CountryName";
                    break;
                    default:
                    FilterColumn = "None";
                    break;
            }
            //if User Nathing Doing Nathing select 
            if(FilterColumn == "None"|| txtFilterValue.Text.Trim() == "")
            {
                dt.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dt.Rows.Count.ToString();
                return; 
            }
            //filteration process
            //Person ID is Degite 
            if (FilterColumn == "PersonID")
                dt.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());


            lblRecordsCount.Text = dt.Rows.Count.ToString();


        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");
            if (cbFilterBy.Visible )
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id is selected.
            if (cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm= new frmAddUpdatePerson();
            frm.ShowDialog();
            _RefrachList();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            frmShowPersonInfo frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();

        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            frmAddUpdatePerson frm = new frmAddUpdatePerson(PersonID);
            frm.ShowDialog();
            _RefrachList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            _RefrachList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            if(MessageBox.Show("Are you Sure You Want To Delete Person with ID "+PersonID.ToString()+" Confirm to Delte ","Confirm to Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsPerson.DeletePersonByPersonID(PersonID))
                {
                    MessageBox.Show("Person with ID " + PersonID + "was Delete With Success");
                    _RefrachList();

                }
                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
