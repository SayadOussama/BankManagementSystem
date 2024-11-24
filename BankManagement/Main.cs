using BankManagement.Applictions;
using BankManagement.ClassGlobal;
using BankManagement.ClientAccount;
using BankManagement.Login;
using BankManagement.People;
using BankManagement.Transations;
using BankManagement.Users;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class frmMain : Form
    {
        frmLogin _frmLogin;




        public frmMain(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Start(); 
            lblDateAndTime.Text = DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss");
            lblCurrentUser.Text = clsGlobal.CurrentUser.UserName;
        }

        private void lblDateAndTime_Click(object sender, EventArgs e)
        {
            
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateAndTime.Text = DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss");
            lblDateAndTime.Refresh();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void retakeTestToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void manageLocalDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ManageInternationaDrivingLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ManageDetainedLicensestoolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson();
            frm.ShowDialog();
        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            frmFindPerson frm = new frmFindPerson();
            frm.ShowDialog();
        }

        private void btnPeopleMangement_Click(object sender, EventArgs e)
        {
            frmMangePeople frm = new frmMangePeople();
            frm.ShowDialog();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();

        }

        private void btnChangeUserPassword_Click(object sender, EventArgs e)
        {
            ////we will show for  the Current User
            //frmChangePasswordUser frm  = new frmChangePasswordUser(6);
            //frm.ShowDialog();

        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            frmUserManagement frm = new frmUserManagement();
            frm.ShowDialog();
        }

        private void createLocalAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateClientAccount frm = new frmAddUpdateClientAccount(clsApplicationTypes.enApplicationType.CreateLocalAccount);
            frm.ShowDialog();
        }

        private void createEuroAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateClientAccount frm = new frmAddUpdateClientAccount(clsApplicationTypes.enApplicationType.CreateLocalAndEuroAccount);
            frm.ShowDialog();
        }

        private void updateLocalToEuroAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateClientAccount frm = new frmAddUpdateClientAccount(clsApplicationTypes.enApplicationType.UpdateLocalAccountToLocalAndEuroAccount);
            frm.ShowDialog();
        }

        private void applicationManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmApplicationManagment frm = new frmApplicationManagment();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmFindAccount frm = new frmFindAccount();
            frm.ShowDialog();
        }

        private void btnClientManagement_Click(object sender, EventArgs e)
        {
            frmClientManagement frm = new frmClientManagement();
            frm.ShowDialog();   
        }

        private void addAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmAddWithdraw frm = new frmAddWithdraw(clsTransationTypes.enTransactionTypes.AddCurrency);
            frm.ShowDialog();
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddWithdraw frm = new frmAddWithdraw(clsTransationTypes.enTransactionTypes.WithdrawCurrency);
            frm.ShowDialog();
        }

        private void transferLocalAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransferLocalAndEuro frm = new frmTransferLocalAndEuro(clsTransationTypes.enTransactionTypes.TransferLocalCurrency);
            frm.ShowDialog();
        }

        private void transferEuroAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransferLocalAndEuro frm = new frmTransferLocalAndEuro(clsTransationTypes.enTransactionTypes.TransferEuroCurrency);
            frm.ShowDialog();
        }

        private void transactionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransactionList frm = new frmTransactionList();
            frm.ShowDialog();
        }
    }
}
