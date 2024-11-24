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
    public partial class frmShowClientDetails : Form
    {
        int _AccountID = -1; 
        public frmShowClientDetails(int AccountID)
        {
            InitializeComponent();
            _AccountID = AccountID;
        }

        private void frmShowClientDetails_Load(object sender, EventArgs e)
        {
            clsClientAccount _Account = clsClientAccount.GetFindInfoByAccountID(_AccountID);
            if (_Account == null) {

                MessageBox.Show("Client Account with ID " + _AccountID.ToString() + " Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            ctrlClientDetails1.LoadClientAccount(_AccountID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
