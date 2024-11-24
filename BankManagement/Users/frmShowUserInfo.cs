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
    public partial class frmShowUserInfo : Form
    {
        int _UserID = -1;
        clsUsers _User; 
        public frmShowUserInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void frmShowUserInfo_Load(object sender, EventArgs e)
        {
            _User = clsUsers.GetFindUserInfoByUserID(_UserID);
            if(_User == null)
            {
                MessageBox.Show("User Not Exist with " + _UserID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            ctrlUserCard1.LoadUserInfo(_UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
