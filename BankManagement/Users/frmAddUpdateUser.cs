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

namespace BankManagement.Users
{
    public partial class frmAddUpdateUser : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _UserID = -1;
        clsUsers _User;
        public frmAddUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _Mode = enMode.Update;
        }
        private void _ResetDefaultValue()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                _User = new clsUsers();
                tpLoginInfo.Enabled = false;
                ctrlPersonCardwithFilter1.FilterFocus();

            }
            else
            {
                lblTitle.Text = "Update User";
                tpLoginInfo.Enabled = true ;
                btnSave.Enabled = true;
            }

            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            chkIsActive.Checked = true  ;
        }
        private void LoadData()
        {
            _User = clsUsers.GetFindUserInfoByUserID( _UserID );
            ctrlPersonCardwithFilter1.Enabled = false;
            if(_User == null ) {
                MessageBox.Show("User With ID " + _UserID.ToString() + " Not Exist", "User Not Found ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            
            }
            ctrlPersonCardwithFilter1.LoadPersonInfo(_User.PersonID);
            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName.ToString();
            txtPassword.Text = _User.PassWord.ToString();
            txtConfirmPassword.Text = _User.PassWord.ToString();
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();

            if (_Mode == enMode.Update)
                LoadData();
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password Field cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "UserName Field cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            };
            if (clsUsers.IsUserExistByUserName(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "UserName All Ready Use it Try Another UserName ");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }
            if(txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Must Be the Same");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private void btnPersonInfoNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;

                tpLoginInfo.Enabled = true;
                //show Login Info Tab
                tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpLoginInfo"];
                return;
            }
            //incase in Add NEw Mode
            if(ctrlPersonCardwithFilter1.PersonID != -1)
            {
                if (clsUsers.IsUserExistByPersonID(ctrlPersonCardwithFilter1.PersonID))
                {
                    MessageBox.Show("the Person You Select Is Already Have User Account ,Try To Enter Anohter PersonID", "Person Have Account ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardwithFilter1.FilterFocus();
                }
                else
                {
                    btnSave.Enabled = true;
                    tpLoginInfo.Enabled = true;
                    //go to Login Tabpage 
                    tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpLoginInfo"];
                }
            }
            else

            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardwithFilter1.FilterFocus();

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
            _User.PersonID = ctrlPersonCardwithFilter1.PersonID;
            _User.UserName = txtUserName.Text.Trim();
            _User.PassWord = txtPassword.Text.Trim();
            _User.IsActive = chkIsActive.Checked;


            if (_User.Save())
            {
                lblUserID.Text = _User.UserID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update User";
         

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
