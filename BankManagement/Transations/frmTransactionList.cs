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

namespace BankManagement.Transations
{
    public partial class frmTransactionList : Form
    {
        private static DataTable dt = clsTransactions.GetTransactionsManagementList();
       
        public frmTransactionList()
        {
            InitializeComponent();
        }

        private void _RefrachList()
        {
            dt = clsTransactions.GetTransactionsManagementList();
            dgvTransactions.DataSource = dt;
            lblRecordsCount.Text = dt.Rows.Count.ToString();
        }

        private void frmTransactionList_Load(object sender, EventArgs e)
        {
            dgvTransactions.DataSource = dt;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dt.Rows.Count.ToString();

            if (dgvTransactions.Rows.Count > 0)
            {
                //specify the width and ReName the HeaderText 
                dgvTransactions.Columns[0].HeaderText = "Transaction ID";
                dgvTransactions.Columns[0].Width = 80;

                dgvTransactions.Columns[1].HeaderText = "Transaction Name";
                dgvTransactions.Columns[1].Width = 150;

                dgvTransactions.Columns[2].HeaderText = "Account ID";
                dgvTransactions.Columns[2].Width = 60;

                dgvTransactions.Columns[3].HeaderText = "Full Name";
                dgvTransactions.Columns[3].Width = 120;

                dgvTransactions.Columns[4].HeaderText = "Transaction Date";
                dgvTransactions.Columns[4].Width = 150;

                dgvTransactions.Columns[5].HeaderText = "Transaction Fees";
                dgvTransactions.Columns[5].Width = 80;

                dgvTransactions.Columns[6].HeaderText = "User Name";
                dgvTransactions.Columns[6].Width = 80;
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Doing Maping to the Real Name In Query Data 
            switch (cbFilterBy.Text)
            {
                case "Transaction ID":

                    FilterColumn = "TransactionID";
                    break;
                case "Transaction Name":
                    FilterColumn = "TransactionName";
                    break;
                case "Account ID":

                    FilterColumn = "AccountID";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }
            //if User Nathing Doing Nathing select 
            if (FilterColumn == "None" || txtFilterValue.Text.Trim() == "")
            {
                dt.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dt.Rows.Count.ToString();
                return;
            }
            if (FilterColumn == "TransactionID" || FilterColumn == "AccountID")
                dt.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dt.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Transaction ID"|| cbFilterBy.Text == "Account ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");
            if (cbFilterBy.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void btnTransactionHistroty_Click(object sender, EventArgs e)
        {
            frmTransactionHistortList frm = new frmTransactionHistortList();
            frm.ShowDialog();
        }
    }
}
