using BankManagement.Applictions;
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

namespace BankManagement.ClientAccount
{
    public partial class frmClientManagement : Form
    {
        private static DataTable _dtAllClient;
        public frmClientManagement()
        {
            InitializeComponent();
        }

        private void frmClientManagement_Load(object sender, EventArgs e)
        {
            _dtAllClient = clsClientAccount.GetAllClientList();
            dgvClientManagement.DataSource = _dtAllClient;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvClientManagement.Rows.Count.ToString();
           
            if(dgvClientManagement.Rows.Count > 0 ) { 
            dgvClientManagement.Columns[0].HeaderText = "Account ID";
            dgvClientManagement.Columns[0].Width = 50;

            dgvClientManagement.Columns[1].HeaderText = "Application ID";
            dgvClientManagement.Columns[1].Width = 50;

            dgvClientManagement.Columns[2].HeaderText = "Full Name";
            dgvClientManagement.Columns[2].Width = 150;

            dgvClientManagement.Columns[3].HeaderText = "Creation Date";
            dgvClientManagement.Columns[3].Width = 150;

            dgvClientManagement.Columns[4].HeaderText = "Local Deposit";
            dgvClientManagement.Columns[4].Width = 100;

            dgvClientManagement.Columns[5].HeaderText = "Euro Deposit";
            dgvClientManagement.Columns[5].Width = 100;

            dgvClientManagement.Columns[6].HeaderText = "Expiration Date";
            dgvClientManagement.Columns[6].Width = 150;

            dgvClientManagement.Columns[7].HeaderText = "Is Active";
            dgvClientManagement.Columns[7].Width = 80;

            dgvClientManagement.Columns[8].HeaderText = "Created By User";
            dgvClientManagement.Columns[8].Width = 80;
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Is Active")
            {
                txtFilterValue.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0;
            }

            else

            {

                txtFilterValue.Visible = (cbFilterBy.Text != "None");
                cbIsActive.Visible = false;

                if (cbFilterBy.Text == "None")
                {
                    txtFilterValue.Enabled = false;
                }
                else
                    txtFilterValue.Enabled = true;

                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "Account ID":
                    FilterColumn = "AccountID";
                    break;
                case "Application ID":
                    FilterColumn = "ApplicationID";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;


                case "Is Active":
                    FilterColumn = "IsActive";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllClient.DefaultView.RowFilter = "";
                lblRecordsCount.Text = _dtAllClient.Rows.Count.ToString();
                return;
            }


            if (FilterColumn != "FullName" )
                //in this case we deal with numbers not string.
                _dtAllClient.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllClient.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            //Refresh Counter when you  Do fillter
            lblRecordsCount.Text = _dtAllClient.Rows.Count.ToString();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbIsActive.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "All")
                _dtAllClient.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtAllClient.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);
            //Refresh Counter when you  Do fillter
            lblRecordsCount.Text = _dtAllClient.Rows.Count.ToString();
        }

        private void clientDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AccountID = (int)dgvClientManagement.CurrentRow.Cells[0].Value;
            frmShowClientDetails frm = new frmShowClientDetails(AccountID);
            frm.ShowDialog();
        }

        private void deToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AccountID = (int)dgvClientManagement.CurrentRow.Cells[0].Value;
            clsClientAccount Account = clsClientAccount.GetFindInfoByAccountID(AccountID);
            if (Account != null)
            {
                frmAddUpdateClientAccount frm = new frmAddUpdateClientAccount(AccountID, (clsApplicationTypes.enApplicationType)Account._ApplicationInfo.ApplicationType);
                frm.ShowDialog();
                frmClientManagement_Load(null, null);

            }
            else
                MessageBox.Show("Account with ID " + AccountID + " Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AccountID = (int)dgvClientManagement.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure you want to this Account With ID [" + dgvClientManagement.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsClientAccount.DeleteAccountID(AccountID))
                {
                    MessageBox.Show("Account Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmClientManagement_Load(null, null);
                }
                else
                    MessageBox.Show("Account was not deleted because You Have System Problem Isuue .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
