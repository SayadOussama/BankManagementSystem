using BankManagement.Properties;
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
using System.IO;
using BankManagement.People;
namespace BankManagement.ClientAccount
{
    public partial class ctrlClientDetails : UserControl
    {
        int _AccountID = -1;
        clsClientAccount _ClientAccount;
        public int AccountID { get { return _ClientAccount.AccountID; } }
        public clsClientAccount SelectedClientInfo
        {
            get { return _ClientAccount; }
        }

        public ctrlClientDetails()
        {
            InitializeComponent();
        }
        
        public void _ResetAccountCardInfo()
        {

            lblPersonID.Text = "[?????]";
            lblAccountID.Text = "[?????]";
            lblFullName.Text = "[?????]";
            lblApplicationID.Text = "[?????]";
            lblCreatedbyUser.Text = "[?????]";
            lblExpairationDate.Text = "[?????]";
            lblDollarAmount.Text = "[?????]";
            lblEuroAmount.Text = "[?????]";
            lblCreatedbyUser.Text = "[?????]";
            lblIsActive.Text = "[?????]";
            pbPersonImage.Image = Resources.Male_512;

        }
        public void LoadClientAccount(int AccountID)
        {
            _AccountID = AccountID;
            _ClientAccount = clsClientAccount.GetFindInfoByAccountID(_AccountID);
            if (_ClientAccount == null)
            {
                _ResetAccountCardInfo();
                MessageBox.Show("Client Account Not Exist "+ _AccountID.ToString() , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }
        public void LoadClientAccountByPersonID(int PersonID)
        {
            int _PersonID = PersonID;
            _ClientAccount = clsClientAccount.GetAccountInfoByPersonID(_PersonID);
            if (_ClientAccount == null)
            {
                _ResetAccountCardInfo();
                MessageBox.Show("Client Account Not Exist " + _AccountID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }
        public void LoadClientAccountByApplicationID(int ApplicationID)
        {
            int _ApplicationID = ApplicationID;
            _ClientAccount = clsClientAccount.GetFindInfoByAccountID(_ApplicationID);
            if (_ClientAccount == null)
            {
                _ResetAccountCardInfo();
                MessageBox.Show("Client Account Not Exist " + _AccountID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }
        private void _FillPersonInfo()
        {
            llEditPersonInfo.Enabled = true;
            lblPersonID.Text = _ClientAccount.PersonID.ToString();
            _AccountID = _ClientAccount.AccountID;
            lblAccountID.Text = _ClientAccount.AccountID.ToString();
            lblApplicationID.Text = _ClientAccount.ApplicationID.ToString();
            lblFullName.Text = _ClientAccount._PersonInfo.FullName;
            lblAccountID.Text = _ClientAccount.AccountID.ToString();
            lblCreationDate.Text = _ClientAccount.CreationDate.ToShortDateString();
            lblExpairationDate.Text = _ClientAccount.ExpirationDate.ToShortDateString();
            lblDollarAmount.Text = _ClientAccount.LocalDeposit.ToString();
            if (_ClientAccount.EuroDeposit == -1)
                lblEuroAmount.Text = "No Permission";
            else
                lblEuroAmount.Text = _ClientAccount.EuroDeposit.ToString();
            if (_ClientAccount.IsActive)
                lblIsActive.Text = "Yas";
            else lblIsActive.Text = "No";
            lblCreatedbyUser.Text = _ClientAccount.CreatedByUserID.ToString();
            _LoadPersonImage();


        }
        private void _LoadPersonImage()
        {
            if (_ClientAccount._PersonInfo.Gender == 0)
                pbPersonImage.Image = Resources.Male_512;

            else
                pbPersonImage.Image = Resources.Female_512;

            if (_ClientAccount._PersonInfo.ImagePath != "")
            {
                string ImagePath = _ClientAccount._PersonInfo.ImagePath;
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctrlClientDetails_Load(object sender, EventArgs e)
        {
        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(_ClientAccount.PersonID);
            frm.ShowDialog();
            //Fet Refrash Card 
            LoadClientAccount(_ClientAccount.AccountID);
        }
    }
}
