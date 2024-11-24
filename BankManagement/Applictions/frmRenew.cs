using BankManagement.ClassGlobal;
using BankManagement.People;
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
using static System.Net.Mime.MediaTypeNames;

namespace BankManagement.Applictions
{
    public partial class frmRenew : Form
    {
        int _AccountID = -1;
        clsClientAccount _CurrentAccount;
        clsApplications _Applications;
        public frmRenew(int AccountID)
        {
            InitializeComponent();
            _AccountID = AccountID;
        }

        private void frmRenew_Load(object sender, EventArgs e)
        {

             _CurrentAccount = clsClientAccount.GetFindInfoByAccountID(_AccountID);
            if (_CurrentAccount == null ) 
            {
                MessageBox.Show("Account With ID " + _AccountID + " Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            
            }


            ctrlClientDetails1.LoadClientAccount(_AccountID);
            if (DateTime.Now < _CurrentAccount.ExpirationDate )
            {
                MessageBox.Show("Client Account Not Expiraed Yet  ", "Is Not Expirard", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CreateClientAccountFirstTime()
        {
            _Applications = new clsApplications();
            _Applications.PersonID = _CurrentAccount.PersonID;
            _Applications.ApplicationType = (int)clsApplicationTypes.enApplicationType.RenewAccount;
            _Applications.ApplicationDate = DateTime.Now;
            // _Applications.CreatedByUserID = CurrentUser
            _Applications.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            if (_Applications.Save())
            {
                _CurrentAccount.IsActive = false;
                _CurrentAccount.Save();
                clsClientAccount NewAccouunt  = new clsClientAccount();
                NewAccouunt.PersonID = _CurrentAccount.PersonID;
                NewAccouunt.ApplicationID = _Applications.ApplicationID;
                NewAccouunt.LocalDeposit     = _CurrentAccount.LocalDeposit;
                if (_CurrentAccount.EuroDeposit != -1)
                    NewAccouunt.EuroDeposit = _CurrentAccount.EuroDeposit;
                else
                    NewAccouunt.EuroDeposit = -1;
                NewAccouunt.CreationDate = DateTime.Now;
                NewAccouunt.ExpirationDate = DateTime.Now.AddYears(5);
                NewAccouunt.IsActive = true;
                // _Applications.CreatedByUserID = CurrentUser
                NewAccouunt.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                if (NewAccouunt.Save())
                {
                    MessageBox.Show("Renew  Account Done Successfuly " + NewAccouunt.AccountID.ToString(), "Save Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrlClientDetails1.LoadClientAccount(NewAccouunt.AccountID);
                    btnRenew.Enabled = false;
                }
                else
                    MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRenew_Click(object sender, EventArgs e)
        {
            
            CreateClientAccountFirstTime();
        }
    }
}
