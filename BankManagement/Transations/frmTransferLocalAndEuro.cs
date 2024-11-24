using BankManagement.ClassGlobal;
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
    public partial class frmTransferLocalAndEuro : Form
    {
        private clsTransationTypes.enTransactionTypes _TransactionType;
        clsTransationTypes _TransationTypes;
        public frmTransferLocalAndEuro(clsTransationTypes.enTransactionTypes TransactionType)
        {
            InitializeComponent();
            _TransactionType = TransactionType;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTransferLocalAndEuro_Load(object sender, EventArgs e)
        {
            if (_TransactionType == clsTransationTypes.enTransactionTypes.TransferLocalCurrency)
            {
                lblTitle.Text = "Transfer Local Currency";
            }
            else
                lblTitle.Text = "Transfer Euro Currency";


            btnProcess.Enabled = true;
            _TransationTypes = clsTransationTypes.GetTransactionInfoByTransactionID((int)_TransactionType);

            lblFees.Text = _TransationTypes.TransationFees.ToString();
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
                historyTransactions.AccountReceiveID = ctrlClientWithFIlter2.AccountID;
                if (_TransactionType == clsTransationTypes.enTransactionTypes.TransferLocalCurrency)
                {
                    historyTransactions.CurrencyType = clsHistoryTransactions.enCurrencyType.LocalCurrency;
                    historyTransactions.LocalAmount = int.Parse(txtAmount.Text.Trim().ToString());
                    historyTransactions.EuroAmount = -1;
                }
                if (_TransactionType == clsTransationTypes.enTransactionTypes.TransferEuroCurrency)
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
                MessageBox.Show("You Should Select the sender Account First ", "Sender Account Not Seclected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ctrlClientWithFIlter2.SelectedClientAccountInfo == null)
            {
                MessageBox.Show("You Should Select the Receiver Account First ", "Receiver Account Not Seclected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_TransactionType == clsTransationTypes.enTransactionTypes.TransferLocalCurrency) {
                if (ctrlClientWithFIlter1.SelectedClientAccountInfo.LocalDeposit >= int.Parse(txtAmount.Text.Trim().ToString()) + _TransationTypes.TransationFees)
                {
                    ctrlClientWithFIlter1.SelectedClientAccountInfo.LocalDeposit -= int.Parse(txtAmount.Text.Trim().ToString()) + _TransationTypes.TransationFees;
                    ctrlClientWithFIlter2.SelectedClientAccountInfo.LocalDeposit += int.Parse(txtAmount.Text.Trim().ToString());
                    if (ctrlClientWithFIlter1.SelectedClientAccountInfo.Save() && ctrlClientWithFIlter2.SelectedClientAccountInfo.Save())
                    {
                        RegisterTransaction();
                        MessageBox.Show("Transaction Done Successful ", "Transaction Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ctrlClientWithFIlter1.LoadAccountInfoInfo(ctrlClientWithFIlter1.SelectedClientAccountInfo.AccountID);
                        ctrlClientWithFIlter2.LoadAccountInfoInfo(ctrlClientWithFIlter2.SelectedClientAccountInfo.AccountID);
                        btnProcess.Enabled = false;
                        return;
                    }
                    else
                        MessageBox.Show("System Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                    MessageBox.Show("Sender Account Dont Have the Requirement Amount", "Not Enough Amount ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (_TransactionType == clsTransationTypes.enTransactionTypes.TransferEuroCurrency)
            {
                if (ctrlClientWithFIlter1.SelectedClientAccountInfo.EuroDeposit >= int.Parse(txtAmount.Text.Trim().ToString()) && ctrlClientWithFIlter1.SelectedClientAccountInfo.LocalDeposit >= _TransationTypes.TransationFees)
                {
                    ctrlClientWithFIlter1.SelectedClientAccountInfo.EuroDeposit -= int.Parse(txtAmount.Text.Trim().ToString()) + _TransationTypes.TransationFees;
                    ctrlClientWithFIlter1.SelectedClientAccountInfo.LocalDeposit -= _TransationTypes.TransationFees;
                    ctrlClientWithFIlter2.SelectedClientAccountInfo.EuroDeposit += int.Parse(txtAmount.Text.Trim().ToString());
                    if (ctrlClientWithFIlter1.SelectedClientAccountInfo.Save() && ctrlClientWithFIlter2.SelectedClientAccountInfo.Save())
                    {
                        RegisterTransaction();
                        MessageBox.Show("Transaction Done Successful ", "Transaction Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ctrlClientWithFIlter1.LoadAccountInfoInfo(ctrlClientWithFIlter1.SelectedClientAccountInfo.AccountID);
                        ctrlClientWithFIlter2.LoadAccountInfoInfo(ctrlClientWithFIlter2.SelectedClientAccountInfo.AccountID);
                        btnProcess.Enabled = false;
                        return;
                    }
                    else
                        MessageBox.Show("System Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                    MessageBox.Show("Sender Account Dont Have the Requirement Amount", "Not Enough Amount ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnProcess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                //that Mean Press ENTER in Key Board
                btnProcess.PerformClick();
            }

            //this will allow only digits if person id is selected

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
