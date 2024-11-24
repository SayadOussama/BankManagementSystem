using BankManagement.Applictions;
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

namespace BankManagement.ClientAccount
{
    public partial class ctrlClientWithFIlter : UserControl
    {
        // Define a custom event handler delegate with parameters
        public event Action<int> OnClientSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void ClientSelected(int ClientID)
        {
            Action<int> handler = OnClientSelected;
            if (handler != null)
            {
                handler(ClientID); // Raise the event with the parameter
            }
        }
        //private bool _ShowAddPerson = true;
        //public bool ShowAddPerson
        //{
        //    get
        //    {
        //        return _ShowAddPerson;
        //    }
        //    set
        //    {
        //        _ShowAddPerson = value;
        //        btnAddNewAccount.Visible = _ShowAddPerson;
        //    }
        //}
        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }
        }
        public ctrlClientWithFIlter()
        {
            InitializeComponent();
        }
        private int _AccountID = -1;

        //to send Out Of the Control 
        public int AccountID
        {
            get { return ctrlClientDetails1.AccountID; }
        }
        //to send Out Of the Control 
        public clsClientAccount SelectedClientAccountInfo
        {
            get { return ctrlClientDetails1.SelectedClientInfo; }
        }
        public void LoadAccountInfoInfo(int AccountID)
        {

            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = AccountID.ToString();
            FindNow();

        }
        private void FindNow()
        {
            //Way 1 :
            //If the You Load Data = send Data By prameters
            switch (cbFilterBy.Text)
            {
                case "Account ID":
                    ctrlClientDetails1.LoadClientAccount(int.Parse(txtFilterValue.Text));

                    break;

                case "Person ID":
                    ctrlClientDetails1.LoadClientAccountByPersonID(int.Parse(txtFilterValue.Text));
                    break;
                case "Application ID":
                    ctrlClientDetails1.LoadClientAccountByApplicationID(int.Parse(txtFilterValue.Text));
                    break;
                default:
                    break;
            }
            //Way 2 :
            //Notes:
            // If the User Want To Use THe Control From the Form 


            if (OnClientSelected != null && FilterEnabled)
                // Raise the event with a parameter
                OnClientSelected(ctrlClientDetails1.AccountID);
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtFilterValue, null);
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {
                //that Mean Press ENTER in Key Board
                btnFind.PerformClick();
            }

            //this will allow only digits if person id is selected
            if (cbFilterBy.Text == "Account ID" || cbFilterBy.Text == "Person ID"|| cbFilterBy.Text == "Application ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ctrlClientWithFIlter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Focus();
            btnAddNewAccount.Enabled = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            FindNow();
        }

      
       
        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        private void btnAddNewAccount_Click_1(object sender, EventArgs e)
        {
            //frmAddUpdateClientAccount frm1 = new frmAddUpdateClientAccount( );
            //frm1.DataBack += DataBackEvent; // Subscribe to the event
            //frm1.ShowDialog();
        }
        private void DataBackEvent(object sender, int AccountID)
        {
            //cbFilterBy.SelectedIndex = 1;
            //txtFilterValue.Text = AccountID.ToString();
            //ctrlClientDetails1.LoadClientAccount(AccountID);
        }

        private void ctrlClientDetails1_Load(object sender, EventArgs e)
        {

        }
    }
   
}
