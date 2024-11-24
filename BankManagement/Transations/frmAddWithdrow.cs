using BankManagement.ClassGlobal;
using BankManagement.ClientAccount;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement.Transations
{
    public partial class frmAddWithdraw : Form
    {
        private clsTransationTypes.enTransactionTypes _TransactionType;
        clsTransationTypes _TransationTypes;  
        public frmAddWithdraw(clsTransationTypes.enTransactionTypes TransactionType)
        {
            InitializeComponent();
            _TransactionType = TransactionType;
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {
                //that Mean Press ENTER in Key Board
                btnProcess.PerformClick();
            }

            //this will allow only digits if person id is selected
           
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void RegisterTransaction()
        {
            clsTransactions transactions = new clsTransactions();
            clsHistoryTransactions historyTransactions = new clsHistoryTransactions();
            transactions.TransactionTypeID = _TransactionType;
            transactions.AccountID = ctrlClientWithFIlter1.AccountID;
            transactions.TransactionDate = DateTime.Now;
            transactions.TransactionFees = _TransationTypes.TransationFees;
            transactions.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            if (transactions.Save())
            {
                historyTransactions.TransactionID = transactions.TransactionID;
                historyTransactions.TransactionType = _TransactionType;
                historyTransactions.AccountID = transactions.AccountID;
                historyTransactions.AccountReceiveID = -1;
                if(rbLocal.Checked == true) { 
                historyTransactions.CurrencyType=clsHistoryTransactions.enCurrencyType.LocalCurrency;
                historyTransactions.LocalAmount = int.Parse(txtAmount.Text.Trim().ToString());
                historyTransactions.EuroAmount = -1;
                }
                if (rbEuro.Checked == true)
                { 
                    historyTransactions.CurrencyType = clsHistoryTransactions.enCurrencyType.EuroCurrecy;
                historyTransactions.LocalAmount = -1;
                historyTransactions.EuroAmount = int.Parse(txtAmount.Text.Trim().ToString());
                 }
                historyTransactions.Save();
            }
        }
        private void btnProcess_Click(object sender, EventArgs e)
        {


            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }






            if (ctrlClientWithFIlter1.SelectedClientAccountInfo == null)
            {
                MessageBox.Show("Select Account ID First ","Information",MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
             }
            if (ctrlClientWithFIlter1.SelectedClientAccountInfo.ExpirationDate <= DateTime.Now )
            {
                MessageBox.Show("Account Was Expaired Renew Account First ", "Account Was Expaired", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (_TransactionType == clsTransationTypes.enTransactionTypes.WithdrawCurrency) { 
            if (rbLocal.Checked)
            {
                if (ctrlClientWithFIlter1.SelectedClientAccountInfo.LocalDeposit  >= int.Parse(txtAmount.Text.Trim().ToString()) + _TransationTypes.TransationFees) { 
                    ctrlClientWithFIlter1.SelectedClientAccountInfo.LocalDeposit-=   int.Parse(txtAmount.Text.Trim().ToString()) + _TransationTypes.TransationFees ;
                    ctrlClientWithFIlter1.SelectedClientAccountInfo.Save();
                    MessageBox.Show("Withdrow Process Done With Success your Balance Now " + ctrlClientWithFIlter1.SelectedClientAccountInfo.LocalDeposit.ToString(), "WithDrow", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrlClientWithFIlter1.LoadAccountInfoInfo(ctrlClientWithFIlter1.AccountID);
                        RegisterTransaction();
                    btnProcess.Enabled = false;
                }
                else
                {
                    MessageBox.Show("You Dont Have the Requirement Amount  " + ctrlClientWithFIlter1.SelectedClientAccountInfo.LocalDeposit.ToString(), "Anount Not Enough", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (rbEuro.Checked)
            {
                if (ctrlClientWithFIlter1.SelectedClientAccountInfo.LocalDeposit >=  _TransationTypes.TransationFees && ctrlClientWithFIlter1.SelectedClientAccountInfo.EuroDeposit >= int.Parse(txtAmount.Text.ToString()))
                {
                    ctrlClientWithFIlter1.SelectedClientAccountInfo.EuroDeposit -= int.Parse(txtAmount.Text.Trim().ToString()) ;
                    ctrlClientWithFIlter1.SelectedClientAccountInfo.LocalDeposit -= _TransationTypes.TransationFees;
                    ctrlClientWithFIlter1.SelectedClientAccountInfo.Save();
                    MessageBox.Show("Withdrow Process Done With Success your Balance Now " + ctrlClientWithFIlter1.SelectedClientAccountInfo.EuroDeposit.ToString(), "WithDrow", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrlClientWithFIlter1.LoadAccountInfoInfo(ctrlClientWithFIlter1.AccountID);
                        RegisterTransaction();
                        btnProcess.Enabled = false;
                }
                else
                {
                    MessageBox.Show("You Dont Have the Requirement Amount  " + ctrlClientWithFIlter1.SelectedClientAccountInfo.LocalDeposit.ToString(), "Anount Not Enough", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
                else
                {
                    MessageBox.Show("You Should Select the Amount Type First   ", "Select Amount Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (_TransactionType == clsTransationTypes.enTransactionTypes.AddCurrency)
            {
                if (rbLocal.Checked)
                {
                    
                        ctrlClientWithFIlter1.SelectedClientAccountInfo.LocalDeposit += int.Parse(txtAmount.Text.Trim().ToString() ) + _TransationTypes.TransationFees;
                        ctrlClientWithFIlter1.SelectedClientAccountInfo.Save();
                        MessageBox.Show("Account Updated Now Your Balance Is  " + ctrlClientWithFIlter1.SelectedClientAccountInfo.LocalDeposit.ToString(), "Updating", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ctrlClientWithFIlter1.LoadAccountInfoInfo(ctrlClientWithFIlter1.AccountID);
                         RegisterTransaction();
                        btnProcess.Enabled = false;
                    }
                    
                
                if (rbEuro.Checked )
                {
                  
                    
                        ctrlClientWithFIlter1.SelectedClientAccountInfo.EuroDeposit += int.Parse(txtAmount.Text.Trim().ToString());
                        
                        ctrlClientWithFIlter1.SelectedClientAccountInfo.Save();
                        MessageBox.Show("Withdrow Process Done With Success your Balance Now " + ctrlClientWithFIlter1.SelectedClientAccountInfo.EuroDeposit.ToString(), "Updating", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ctrlClientWithFIlter1.LoadAccountInfoInfo(ctrlClientWithFIlter1.AccountID);
                        RegisterTransaction();
                        btnProcess.Enabled = false;
                    
                   
                }
                else
                {
                    MessageBox.Show("You Should Select the Amount Type First   ", "Select Amount Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void txtAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmount.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAmount, "You Need To Put Anount First");
            }
            else
            {
                errorProvider1.SetError(txtAmount, null);
            }
        }

        private void frmAddWithdrow_Load(object sender, EventArgs e)
        {
            if(_TransactionType == clsTransationTypes.enTransactionTypes.WithdrawCurrency)
            {
                lblTitle.Text = "Withdraw Transation";
            }
            else 
                lblTitle.Text = "Add Transation";


            btnProcess.Enabled = true;
            _TransationTypes = clsTransationTypes.GetTransactionInfoByTransactionID((int)_TransactionType);
            
            lblFees.Text = _TransationTypes.TransationFees.ToString();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
