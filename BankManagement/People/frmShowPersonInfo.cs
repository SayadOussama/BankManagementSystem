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
    public partial class frmShowPersonInfo : Form
    {
        private int _PersonID = -1;
        public frmShowPersonInfo()
        {
            InitializeComponent();
        }
        public frmShowPersonInfo(int personID)
        {
            InitializeComponent();
            _PersonID = personID;
        }

        private void frmShowPersonInfo_Load(object sender, EventArgs e)
        {
            ctrlPersonCard1.LoadPersonInfo(_PersonID);
        }
    }
}
