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
    public partial class frmFindPerson : Form
    {
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public frmFindPerson()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //send PersonId By Delegation Method
           DataBack?.Invoke(this, ctrlPersonCardwithFilter1.PersonID);
            this.Close();
        }
    }
}
