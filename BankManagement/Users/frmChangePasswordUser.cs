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
    public partial class frmChangePasswordUser : Form
    {
        int _UserID = -1; 
        private clsUsers _User;
        public frmChangePasswordUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;

        }
        private void _ResetDefaultValues()
        {
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = ""; 
            txtConfirmPassword.Text = "";
            txtCurrentPassword.Focus();

            
        }
        private void frmChangePasswordUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            _User = clsUsers.GetFindUserInfoByUserID(_UserID);
            if(_User == null) 
            {
                MessageBox.Show("User Not Found with this ID " + _UserID.ToString()
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;

            
            }
            ctrlUserCard1.LoadUserInfo( _UserID );
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "CurrentPassWord Cannot be Blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            }
            ;

            if (!clsUsers.IsUserPassWordExist(_UserID, txtCurrentPassword.Text.Trim()))
             {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Password Not Currect ");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            }
        
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "CurrentPassWord Cannot be Blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, null);
            }

            ;

            if (txtCurrentPassword.Text.Trim() == txtNewPassword.Text.Trim())
            {
                e.Cancel= true;
                errorProvider1.SetError(txtNewPassword, "the New Password Must Be Different to the Current Password ");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtNewPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "the New Password Must Be the Same ");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, null);
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
            _User.PassWord = txtNewPassword.Text.Trim();
            if (_User.Save())
            {
                MessageBox.Show("New Passwrod Saved Succesfuly ", "Password Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefaultValues();
                return;
            }
            else
            {
                MessageBox.Show("An Erro Occured, Password did not change.",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
