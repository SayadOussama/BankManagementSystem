using BankManagement.ClientAccount;
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

namespace BankManagement.Applictions
{
    public partial class frmApplicationManagment : Form
    {
        private static DataTable dt = clsApplications.GetApplicationsList();
        public frmApplicationManagment()
        {
            InitializeComponent();
        }
        private void _RefrachList()
        {
            dt = clsApplications.GetApplicationsList();
            dgvApplicationManagement.DataSource = dt;
            lblTotalRecords.Text = dt.Rows.Count.ToString();
        }
        private void frmApplicationManagment_Load(object sender, EventArgs e)
        {
            dt = clsApplications.GetApplicationsList();
            dgvApplicationManagement.DataSource = dt;
            cbFilterBy.SelectedIndex = 0;
            lblTotalRecords.Text = dt.Rows.Count.ToString();

            //Styling The Grid View width of the Table 
            if (dgvApplicationManagement.Rows.Count > 0)
            {
                //specify the width and ReName the HeaderText 
                dgvApplicationManagement.Columns[0].HeaderText = "Application ID";
                dgvApplicationManagement.Columns[0].Width = 80;

                dgvApplicationManagement.Columns[1].HeaderText = "Full Name";
                dgvApplicationManagement.Columns[1].Width = 280;

                dgvApplicationManagement.Columns[2].HeaderText = "Application Name";
                dgvApplicationManagement.Columns[2].Width = 280;

                dgvApplicationManagement.Columns[3].HeaderText = "Application Fees";
                dgvApplicationManagement.Columns[3].Width = 80;

                dgvApplicationManagement.Columns[4].HeaderText = "User Name";
                dgvApplicationManagement.Columns[4].Width = 100;
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Doing Maping to the Real Name In Query Data 
            switch (cbFilterBy.Text)
            {
                case "Application ID":

                    FilterColumn = "ApplicationID";
                    break;
                
                case "Full Name":

                    FilterColumn = "FullName";
                    break;

                case "ApplicationName":
                    FilterColumn = "Application Name";
                    break;
                case "ApplicationFees":
                    FilterColumn = "Application Fees";
                    break;
                case "User Name":
                    FilterColumn = "UserName";
                    break;
                
                default:
                    FilterColumn = "None";
                    break;
            }
            //if User Nathing Doing Nathing select 
            if (FilterColumn == "None" || txtFilterValue.Text.Trim() == "")
            {
                dt.DefaultView.RowFilter = "";
                lblTotalRecords.Text = dt.Rows.Count.ToString();
                return;
            }
            //filteration process
            //Person ID is Degite 
            if (FilterColumn == "ApplicationID")
                dt.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());


            lblTotalRecords.Text = dt.Rows.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void btnCreateLocalAccount_Click(object sender, EventArgs e)
        {
            frmAddUpdateClientAccount frm =new frmAddUpdateClientAccount(clsApplicationTypes.enApplicationType.CreateLocalAccount);
            frm.ShowDialog();
            frmApplicationManagment_Load(null, null);
        }

        private void btnLocalandEuro_Click(object sender, EventArgs e)
        {
            frmAddUpdateClientAccount frm = new frmAddUpdateClientAccount(clsApplicationTypes.enApplicationType.CreateLocalAndEuroAccount);
            frm.ShowDialog();
            frmApplicationManagment_Load(null, null);
        }

        private void accountIndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationID = (int)dgvApplicationManagement.CurrentRow.Cells[0].Value;
            int AccountID = clsClientAccount.GetAccountIDByApplicationID(ApplicationID);
            frmShowClientDetails frm = new frmShowClientDetails(AccountID);
            frm.ShowDialog();
        }

        private void updateLocalToLocalAndEuroAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationID = (int)dgvApplicationManagement.CurrentRow.Cells[0].Value;
            int AccountID = clsClientAccount.GetAccountIDByApplicationID(ApplicationID);
            clsClientAccount CurrentAccount = clsClientAccount.GetAccountInfoByApplicationID(ApplicationID);
            if (CurrentAccount.EuroDeposit == -1)
           
            {
                frmAddUpdateClientAccount frm = new frmAddUpdateClientAccount(AccountID, clsApplicationTypes.enApplicationType.UpdateLocalAccountToLocalAndEuroAccount);
                frm.ShowDialog();
                frmApplicationManagment_Load(null, null);
            }
            else
            {
                MessageBox.Show("this Account  with ID " + AccountID + "AllReady Update to Local And Euro Account", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void renewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationID = (int)dgvApplicationManagement.CurrentRow.Cells[0].Value;
            clsClientAccount Account = clsClientAccount.GetAccountInfoByApplicationID(ApplicationID);
            if(!Account.IsActive)
            {

                MessageBox.Show("Account Must Active to Renew Account", "Account Not Active",MessageBoxButtons.OK, MessageBoxIcon.Information); 
                return;
            }
            frmRenew frm = new frmRenew(Account.AccountID);
            frm.ShowDialog();
            frmApplicationManagment_Load(null, null);
        }
    }
}