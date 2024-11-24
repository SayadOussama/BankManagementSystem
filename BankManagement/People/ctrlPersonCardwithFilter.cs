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

namespace BankManagement.People
{
    public partial class ctrlPersonCardwithFilter : UserControl
    {

        // Define a custom event handler delegate with parameters
        public event Action<int> OnPersonSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(PersonID); // Raise the event with the parameter
            }
        }



        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get { return _ShowAddPerson; }

            set
            {
                _ShowAddPerson = value;
                btnAddNewPerson.Visible = _ShowAddPerson;
            }



        }

        private bool _FilterEnable = true;
        public bool FilterEnable
        {
            get { return _FilterEnable; }
            set
            {
                _FilterEnable = value;
                gbFilters.Enabled = _FilterEnable;
            }
        }
        private int _PersonID = -1;
        //send out User Control 
        public int PersonID
        { get { return ctrlPersonCard1.PersonID; } }
        //send out User Control 
        public clsPerson SelectPersonInfo
        {
            get { return ctrlPersonCard1.SelectedPersonInfo; }
        }
        public ctrlPersonCardwithFilter()
        {
            InitializeComponent();
        }
        //call the ctrl Out side 
        public void LoadPersonInfo(int PersonID)
        {
            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text= PersonID.ToString();
            FindNow();
        }
        private void FindNow()
        {
            switch (cbFilterBy.Text) 
            {
                case "Person ID":
                    ctrlPersonCard1.LoadPersonInfo(int.Parse(txtFilterValue.Text));
                    break;
                case "National No.":
                    ctrlPersonCard1.LoadPersonInfo(txtFilterValue.Text);
                    break;
                default:
                    break;
            
            }
            //Send back the PersonID from User Contorl to the From By using Event
            if (OnPersonSelected != null && FilterEnable)
                //if we Put it the Person Id Manually
                //we will send back To the from for Reusability
                OnPersonSelected(ctrlPersonCard1.PersonID);
               //Reise the Event 
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
        //Get Focus 
        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnFind.PerformClick();
            }
            //this will allow only digits if person id is selected
            if (cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.DataBack += BackDataEvent;
            frm.ShowDialog();
        }
        //reload User Control 
        private void BackDataEvent(object sender, int PersonID)
        {
            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = PersonID.ToString();
            ctrlPersonCard1.LoadPersonInfo(PersonID);

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

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void ctrlPersonCardwithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Focus();
                

        }
    }
}
