using BankManagement.ClassGlobal;
using BankManagement.People;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BankManagement.Applictions
{
    public partial class frmAddUpdateClientAccount : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        clsClientAccount _ClientAccount;
        clsApplicationTypes _ApplicationTypes;
        clsApplications _Applications;
        int _AccountID = -1; 
        int _ApplicationID  = -1;

       
        public clsApplicationTypes.enApplicationType  _ApplicationTypeID = clsApplicationTypes.enApplicationType.CreateLocalAccount;
        public frmAddUpdateClientAccount(clsApplicationTypes.enApplicationType ApplicationTypeID)
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            _ApplicationTypeID = ApplicationTypeID; 
        }
        public frmAddUpdateClientAccount(int AccountID , clsApplicationTypes.enApplicationType ApplicationTypeID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _AccountID = AccountID;
            _ApplicationTypeID = ApplicationTypeID;
        }

        private void _ResetDefualtValues()
        {

            //this will initialize the reset the defaule values
            string ApplicationTypeName = "";
            ApplicationTypeName = clsApplicationTypes.ConvertApplicationTypeToString(_ApplicationTypeID);


            
            if(_ApplicationTypeID == clsApplicationTypes.enApplicationType.CreateLocalAndEuroAccount || _ApplicationTypeID == clsApplicationTypes.enApplicationType.UpdateLocalAccountToLocalAndEuroAccount)
             txtEuroDeposit.Enabled = true;
            else 
            txtEuroDeposit.Enabled = false;

            
            if(_Mode == enMode.AddNew && _ApplicationTypeID == clsApplicationTypes.enApplicationType.UpdateLocalAccountToLocalAndEuroAccount)
            {
                lblTitle.Text = "Add New " + ApplicationTypeName;
                _ClientAccount = new clsClientAccount();
                tpCreateAccountClient.Enabled = true;
                btnSave.Enabled = true;
            }
            if (_Mode == enMode.AddNew)
            {

                

                lblTitle.Text = "Add New "+ ApplicationTypeName ;
               
                _ClientAccount = new clsClientAccount();

                tpCreateAccountClient.Enabled = false;

                ctrlPersonCardwithFilter1.FilterFocus();
            }
            else
            {
                lblTitle.Text = "Update "+ ApplicationTypeName; 
               

                tpCreateAccountClient.Enabled = true;
                btnSave.Enabled = true;


            }
            lblCreationDate.Text = DateTime.Now.ToShortDateString();
            lblExpirationDate.Text = DateTime.Now.AddYears(5).ToShortDateString();
            txtLocalDeposit.Text = "";
            txtEuroDeposit.Text = "";
            lblAccountID.Text = "????";
            lblApplicationID.Text = "?????";
            lblApplicationFees.Text = clsApplicationTypes.GetFindApplicationTypesInfoByID(_ApplicationTypeID).ApplicationFees.ToString();
            chkIsActive.Checked = true;


        }
        private void _LoadData()
        {
            _ClientAccount = clsClientAccount.GetFindInfoByAccountID( _AccountID );
            if (_ClientAccount == null )
            {
                MessageBox.Show("Client Account With ID " + _AccountID + " Not Exist");
                this.Close();
                return;
            }
            lblAccountID.Text = _ClientAccount.AccountID.ToString();
            lblApplicationID.Text =_ClientAccount.ApplicationID.ToString();
            lblCreationDate.Text = _ClientAccount.CreationDate.ToShortDateString();
            txtLocalDeposit.Text = _ClientAccount.LocalDeposit.ToString();
            txtEuroDeposit.Text = _ClientAccount.EuroDeposit.ToString();
            if(_ClientAccount.EuroDeposit != -1)
                txtEuroDeposit.Enabled = true;
            else 
                txtEuroDeposit.Enabled = false;
            lblExpirationDate.Text = _ClientAccount.ExpirationDate.ToShortDateString();
            chkIsActive.Checked = _ClientAccount.IsActive;
            ctrlPersonCardwithFilter1.LoadPersonInfo(_ClientAccount.PersonID);
            ctrlPersonCardwithFilter1.FilterEnable = false;
        }

        private void frmAddUpdateClientAccount_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }
        private void CreateClientAccountFirstTime()
        {
            _Applications = new clsApplications();
            _Applications.PersonID = ctrlPersonCardwithFilter1.PersonID;
            _Applications.ApplicationType = (int)_ApplicationTypeID;
            _Applications.ApplicationDate = DateTime.Now;
            // _Applications.CreatedByUserID = CurrentUser
            _Applications.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            if (_Applications.Save())
            {
                _ClientAccount.PersonID = _Applications.PersonID;
                _ClientAccount.ApplicationID = _Applications.ApplicationID;
                _ClientAccount.LocalDeposit = decimal.Parse(txtLocalDeposit.Text);
                if (txtEuroDeposit.Enabled==true)
                    _ClientAccount.EuroDeposit = decimal.Parse(txtEuroDeposit.Text);
                else
                    _ClientAccount.EuroDeposit = -1;
                _ClientAccount.CreationDate = DateTime.Now;
                _ClientAccount.ExpirationDate = DateTime.Now.AddYears(5);
                _ClientAccount.IsActive = chkIsActive.Checked;
                // _Applications.CreatedByUserID = CurrentUser
                _ClientAccount.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                if (_ClientAccount.Save())
                {
                    MessageBox.Show("Client Account Created Successfuly " + _ClientAccount.AccountID.ToString(), "Save Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblAccountID.Text = _ClientAccount.AccountID.ToString();
                    lblApplicationID.Text = _ClientAccount.ApplicationID.ToString();

                }
                else
                    MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            //Load Application 
            if(_Mode == enMode.AddNew && _ApplicationTypeID != clsApplicationTypes.enApplicationType.UpdateLocalAccountToLocalAndEuroAccount)
            {

                CreateClientAccountFirstTime();
                return;
            }
            //for Update Local to Local and Euro Account  the First Time 
            if(_Mode == enMode.Update && _ApplicationTypeID == clsApplicationTypes.enApplicationType.UpdateLocalAccountToLocalAndEuroAccount && _ClientAccount.EuroDeposit==-1 )
                {
                //Note
                //to Update account Local we need To Delete the Old Application And Replace with New Application 
                clsClientAccount currentClientAccount = clsClientAccount.GetFindInfoByAccountID(_AccountID);
                int OldApplicationID = currentClientAccount.ApplicationID;
                // in this case we need Only to Create new Application 
                _Applications = new clsApplications();
                _Applications.PersonID = ctrlPersonCardwithFilter1.PersonID;
                _Applications.ApplicationType = (int)_ApplicationTypeID;
                _Applications.ApplicationDate = DateTime.Now;
                // _Applications.CreatedByUserID = CurrentUser
                _Applications.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                _Applications.Save();
               //Replace Account ApplicationID By new Applications AppID 
                _ClientAccount.ApplicationID = _Applications.ApplicationID;
                clsApplications.DeleteApplicationID(OldApplicationID);
            }
            // en Update Mode 
            _ClientAccount.LocalDeposit = decimal.Parse(txtLocalDeposit.Text);
            if (txtEuroDeposit.Enabled==true)
                _ClientAccount.EuroDeposit = decimal.Parse(txtEuroDeposit.Text);
            else
                _ClientAccount.EuroDeposit = -1;
            //_ClientAccount.CreatedByUserID = CurrentUser;
            _ClientAccount.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_ClientAccount.Save())
            {
                MessageBox.Show("Client Account Update Successfuly " + _ClientAccount.AccountID.ToString(), "Save Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtLocalDeposit_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLocalDeposit.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLocalDeposit, "Local Deposit cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtLocalDeposit, null);
            }
        }

        private void txtEuroDeposit_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLocalDeposit.Text.Trim()) && txtEuroDeposit.Enabled==true)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLocalDeposit, "Local Deposit cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtLocalDeposit, null);
            }
        }

        private void btnPersonInfoNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                //Unlock the Login Tab
                tpCreateAccountClient.Enabled = true;
                //Go to the Next Tab
                tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpCreateAccountClient"];
                return;
            }
            //incase of add new mode.
            if (ctrlPersonCardwithFilter1.PersonID != -1)
            {
                if (clsClientAccount.IsAccountExistInfoByPersonID(ctrlPersonCardwithFilter1.PersonID))
                {
                    MessageBox.Show("Selected Person already has a Account Client , choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardwithFilter1.FilterFocus();
                }
                else
                {
                    btnSave.Enabled = true;
                    //Unlock the Login Tab
                    tpCreateAccountClient.Enabled = true;
                    //Go to the Next Tab
                    tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpCreateAccountClient"];
                }
            }
            else

            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardwithFilter1.FilterFocus();

            }
        }

    }
    }
