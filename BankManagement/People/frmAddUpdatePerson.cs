using BankManagement.Properties;
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
using System.IO;
using BankManagement.ClassGlobal;

namespace BankManagement.People
{
    public partial class frmAddUpdatePerson : Form
    {


        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public enum enMode {AddNew= 1 , Update= 2 }
        public enum enGender { Male = 0, Female = 1 }
        private enMode Mode;
        int _PersonID = -1;
        clsPerson _Person;
        public frmAddUpdatePerson()
        {
            InitializeComponent();
            Mode = enMode.AddNew;

        }
        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            Mode = enMode.Update;

        }
        private void _FillContriesInComboBox()
        {
            DataTable dtCountries = clsCountries.GetAllCountriesList();
            foreach(DataRow Row in dtCountries.Rows) 
            {

                cbCountry.Items.Add(Row["CountryName"]);
            }
        }
        private void _ResetDefaultValue()
        {
            _FillContriesInComboBox();
            if(Mode == enMode.AddNew) 
            {
                lblTitle.Text = "Add New Person";
                _Person = new clsPerson(); 

            }
            else
            {
                lblTitle.Text = "Update Person";
            }

            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male_512;
            else 
                pbPersonImage.Image= Resources.Female_512;

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);
            cbCountry.SelectedIndex = cbCountry.FindString("Algeria");
            llRemoveImage.Visible = (pbPersonImage.ImageLocation != null);



        }
        private void _LoadData()
        {
            _Person = clsPerson.GetPersonInfoByPersonID(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show("the Person ID you Chooseing " + _PersonID + " Is Not Find ");
                this.Close();
                return;
            }
            txtFirstName.Text = _Person.FirstName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNO;
            txtEmail.Text= _Person.Email;
            txtAddress.Text = _Person.address;
            txtPhone.Text = _Person.PhoneNumber;
            dtpDateOfBirth.Value = _Person.BirthDay;
            if(_Person.Gender== 0)
                rbMale.Enabled = true;
            else 
                rbFemale.Enabled = true;
            cbCountry.SelectedIndex = cbCountry.FindString(_Person._CountryInfo.CountryName);

            if(_Person.ImagePath != null)
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;    
            }
            llRemoveImage.Visible = (_Person.ImagePath != null);


        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();
            if (Mode == enMode.Update)
                _LoadData();
        }

        private bool _HandlePersonImage()
        {
            if(_Person.ImagePath != pbPersonImage.ImageLocation)
            {
                //Delete Process
                if(_Person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch(IOException) 
                    {
                        //Colud Not  the File  Delete
                    }
                }
                if(pbPersonImage.ImageLocation != null)
                {
                    string SourceImageFile = pbPersonImage.ImageLocation.ToString();
                    //will Change ImageLcationName to GUID and copy to Directory 
                    if (clsUtil.CopyProjectImageToOtherFoler(ref SourceImageFile)) 
                    { 
                        //replace the current image name = to new Name with Guid 
                        pbPersonImage.ImageLocation =SourceImageFile;
                        return true;    
                    
                    }
                    else
                    {
                        MessageBox.Show("Error Copy Image File ","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }




            }
           // if image source  == Image Path or Is Null
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonImage.Load(selectedFilePath);
                llRemoveImage.Visible = true;
                // ...
            }
        
    }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(pbPersonImage != null)
            {
                if (rbMale.Checked)
                    pbPersonImage.Image = Resources.Male_512;
                else
                    pbPersonImage.Image = Resources.Female_512;

                llRemoveImage.Visible =false;
            }
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            //change the defualt image to female incase there is no image set.
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Male_512;

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            //change the defualt image to female incase there is no image set.
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Female_512;
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            //will appling for all Text box we Have in this from 
            TextBox Temp = ((TextBox)sender);
            if(string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "this field is required!");
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            //if txt is Empty
            if (txtEmail.Text.Trim() == "")
                return;

            //get validation 
            if (!clsValidation.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email Address format!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }

        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "this field is required!");
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, null);
            }
            //Make Sure NationalNo Not Use it 
                                    //if we are in Update Mode               if we are in add  New Mode will Check is have person with National No
            if(txtNationalNo.Text.Trim() != _Person.NationalNO && clsPerson.IsPersonExistByNationalNo(txtNationalNo.Text.Trim()))
                
            {
                e.Cancel= true;
                errorProvider1.SetError(txtNationalNo, "National No Is Allready Exist ");
            }
            else {
            
            errorProvider1.SetError(txtNationalNo , null);
            }






        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some filed Are Not Valide ! Put the Mous in the Red Icon(s) to see the error notice ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (!_HandlePersonImage())
                return; 
            int CountryID = clsCountries.FindCountryInfoByCountryName(cbCountry.Text).CountryID;
            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.NationalNO = txtNationalNo.Text.Trim();
            _Person.PhoneNumber =txtPhone.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.address = txtAddress.Text.Trim();

            if(rbMale.Checked)
                _Person.Gender = (byte)enGender.Male;
            else
                _Person.Gender = (byte)enGender.Female;
            _Person.NationalCountryID = CountryID;
            _Person.BirthDay = dtpDateOfBirth.Value;
            if (pbPersonImage.ImageLocation != null)
                _Person.ImagePath = pbPersonImage.ImageLocation;
            else
                _Person.ImagePath = "";
            if (_Person.Save())
            {
                lblPersonID.Text = _PersonID.ToString();
                lblTitle.Text = "Update";
                Mode = enMode.Update;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataBack?.Invoke(this,_Person.PersonID);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }
    }
}
