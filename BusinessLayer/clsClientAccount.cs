using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public  class clsClientAccount
    {


        public enum enMode { AddNew =1 , Update =2}
        public enMode Mode = enMode.AddNew;
       public int AccountID { get; set; }

        public int PersonID { get; set; }

       public int ApplicationID { get; set; }

        public decimal LocalDeposit { get; set; }

        public decimal EuroDeposit { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime ExpirationDate  { get; set;}

        public bool  IsActive {  get; set; }    

        public int CreatedByUserID { get; set; }

        private  byte _MaxLengthYears = 5;
        
        public byte MaxLengthYears 
        {
            get { return _MaxLengthYears; }




        }
        // Max of Expiration Date 
        private int _MaxAccountLength = 5;

        public clsPerson _PersonInfo {  get; set; }
        public clsApplications _ApplicationInfo { get; set; }

        public clsClientAccount()
        {
            this.AccountID = -1; 
            this.PersonID = -1;
            this.ApplicationID = -1;
            this.LocalDeposit = -1;
            this.EuroDeposit = -1;
            this.CreationDate = DateTime.MinValue;
            this.ExpirationDate = DateTime.MinValue;
            this.IsActive = false;
            this.CreatedByUserID = -1;
            Mode = enMode.AddNew; 


        }
        private clsClientAccount( int accountID, int personID, int applicationID, decimal localDeposit, decimal eruoDeposit, DateTime creationDate, DateTime expirationDate, bool isActive, int createdByUserID)
        {
           
            this.AccountID = accountID;
            this.PersonID = personID;
            this.ApplicationID = applicationID;
            this.LocalDeposit = localDeposit;
            this.EuroDeposit = eruoDeposit;
            this.CreationDate = creationDate;
            this.ExpirationDate = expirationDate;
            this.IsActive = isActive;
            this.CreatedByUserID = createdByUserID;

            //Compositions
           _PersonInfo = clsPerson.GetPersonInfoByPersonID(this.PersonID);
            _ApplicationInfo = clsApplications.GetApplicationInfoByAppID(this.ApplicationID);

            Mode = enMode.Update    ;
            
        }
        public static clsClientAccount GetFindInfoByAccountID(int AccountID)
        {
            int PersonID = -1; int ApplicationID = -1; decimal LocalDeposit = -1; decimal EuroDeposit = -1; DateTime CreationDate = DateTime.MinValue; DateTime ExpirationDate = DateTime.MinValue; bool IsActive = false; int CreatedByUserID = -1;
            bool IsFound = clsDataClientAccount.GetFindAccountInfoByAccountID
           (AccountID, ref PersonID, ref ApplicationID, ref LocalDeposit, ref EuroDeposit, ref CreationDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID);

            if (IsFound)
                return new clsClientAccount(AccountID, PersonID, ApplicationID, LocalDeposit, EuroDeposit, CreationDate, ExpirationDate, IsActive, CreatedByUserID);
            else
                return null;
        }
        public static clsClientAccount GetAccountInfoByPersonID(int PersonID)
        {
            int AccountID = -1; int ApplicationID = -1; decimal LocalDeposit = -1; decimal EuroDeposit = -1; DateTime CreationDate = DateTime.MinValue; DateTime ExpirationDate = DateTime.MinValue; bool IsActive = false; int CreatedByUserID = -1;
            bool IsFound = clsDataClientAccount.GetFindInfoByPersonID
           (ref AccountID,  PersonID, ref ApplicationID, ref LocalDeposit, ref EuroDeposit, ref CreationDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID);

            if (IsFound)
                return new clsClientAccount(AccountID, PersonID, ApplicationID, LocalDeposit, EuroDeposit, CreationDate, ExpirationDate, IsActive, CreatedByUserID);
            else
                return null;
        }
        public static clsClientAccount GetAccountInfoByApplicationID(int ApplicationID)
        {
            int AccountID = -1; int PersonID = -1; decimal LocalDeposit = -1; decimal EuroDeposit = -1; DateTime CreationDate = DateTime.MinValue; DateTime ExpirationDate = DateTime.MinValue; bool IsActive = false; int CreatedByUserID = -1;
            bool IsFound = clsDataClientAccount.GetFindInfoByApplicationID
           (ref AccountID, ref PersonID,  ApplicationID, ref LocalDeposit, ref EuroDeposit, ref CreationDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID);

            if (IsFound)
                return new clsClientAccount(AccountID, PersonID, ApplicationID, LocalDeposit, EuroDeposit, CreationDate, ExpirationDate, IsActive, CreatedByUserID);
            else
                return null;
        }
        private bool _AddNewClientAccount()
        {

            this.AccountID = clsDataClientAccount.AddNewClient
            (this.PersonID, this.ApplicationID, this.LocalDeposit, this.EuroDeposit, this.CreationDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);

            return (this.AccountID != -1);
        }
        private bool _UpdateFindInfoByAccountID()
        {

            return clsDataClientAccount.UpdateClientInfoByAccountID
            (this.AccountID, this.PersonID, this.ApplicationID, this.LocalDeposit, this.EuroDeposit, this.CreationDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID );

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewClientAccount())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateFindInfoByAccountID();

            }

            return false;
        }

        public static bool DeleteAccountID(int AccountID)
        {

            return clsDataApplications.DeleteApplicationByAppID(AccountID);
        }
        public static bool IsAccountExsistByAccountID(int AccountID)
        {
            return clsDataClientAccount.IsAccountExistInfoByAccountID(AccountID);
        }
        public static bool IsAccountExsistByPersonIDAndAppTypeID(int PersonID ,  int ApplicationTypeID)
        {
            return clsDataClientAccount.IsAccountExistInfoByPersonIDAndAppType(PersonID, ApplicationTypeID);
        }
        public clsClientAccount CreateLocalAccount(int CreatedByUserID, int PersonID, decimal LocalCurreny)
        {
       
            clsPerson PeronInfo = clsPerson.GetPersonInfoByPersonID(PersonID);

            if (PeronInfo != null)
            {


                // will Create Application Object 
                clsApplications Application = new clsApplications();
                Application.PersonID = _PersonInfo.PersonID;
                Application.ApplicationType =(int) clsApplicationTypes.enApplicationType.CreateLocalAccount;
                Application.ApplicationDate = DateTime.Now;
                Application.CreatedByUserID = CreatedByUserID;
                if (!Application.Save())
                {
                    return null;    
                }
               
            }
            clsClientAccount CreateAccount = new clsClientAccount();
            CreateAccount.PersonID = this.PersonID;
            CreateAccount.ApplicationID = this.ApplicationID;
            CreateAccount.LocalDeposit = LocalCurreny;
            CreateAccount.CreationDate = DateTime.Now;
            CreateAccount.ExpirationDate = DateTime.Now.AddYears(_MaxAccountLength);
            CreateAccount.IsActive = true;
            CreateAccount.CreatedByUserID = CreatedByUserID;
            if (CreateAccount.Save())
            {
                return CreateAccount;
            }
            else

                return null;
        }
        public static int GetAccountIDByApplicationID(int ApplicationID)
        {
            return clsDataClientAccount.GetAccountIDByApplicationID(ApplicationID);
        }


        public clsClientAccount CreateLocalandEuroAccount(int CreatedByUserID, int PersonID, decimal LocalCurreny,decimal EuroCurreny)
        {

            clsPerson PeronInfo = clsPerson.GetPersonInfoByPersonID(PersonID);

            if (PeronInfo != null)
            {


                // will Create Application Object 
                clsApplications Application = new clsApplications();
                Application.PersonID = _PersonInfo.PersonID;
                Application.ApplicationType =(int) clsApplicationTypes.enApplicationType.CreateLocalAndEuroAccount;
                Application.ApplicationDate = DateTime.Now;
                Application.CreatedByUserID = CreatedByUserID;
                if (!Application.Save())
                {
                    return null;
                }

            }
            clsClientAccount CreateAccount = new clsClientAccount();
            CreateAccount.PersonID = this.PersonID;
            CreateAccount.ApplicationID = this.ApplicationID;
            CreateAccount.LocalDeposit = LocalCurreny;
            CreateAccount.EuroDeposit = EuroCurreny;
            CreateAccount.CreationDate = DateTime.Now;
            CreateAccount.ExpirationDate = DateTime.Now.AddYears(_MaxAccountLength);
            CreateAccount.IsActive = true;
            CreateAccount.CreatedByUserID = CreatedByUserID;
            if (CreateAccount.Save())
            {
                return CreateAccount;
            }
            else

                return null;
        }
        public clsClientAccount UpdateLocalToLocalAndEuroAccount(int CreatedByUserID ,int CurrentClientAccountID, int PersonID,  decimal EuroCurreny)
        {

            clsPerson PeronInfo = clsPerson.GetPersonInfoByPersonID(PersonID);

            if (PeronInfo != null)
            {


                // will Create Application Object 
                clsApplications Application = new clsApplications();
                Application.PersonID = _PersonInfo.PersonID;
                Application.ApplicationType = (int)clsApplicationTypes.enApplicationType.UpdateLocalAccountToLocalAndEuroAccount;
                Application.ApplicationDate = DateTime.Now;
                Application.CreatedByUserID = CreatedByUserID;
                if (!Application.Save())
                {
                    return null;
                }

            }
            clsClientAccount CreateAccount;
            CreateAccount =clsClientAccount.GetFindInfoByAccountID(CurrentClientAccountID);
            if (CreateAccount == null)
            {
                return null ;
            }
            CreateAccount.PersonID = this.PersonID;
            CreateAccount.ApplicationID = this.ApplicationID;
           // CreateAccount.LocalDeposit = LocalCurreny;
            CreateAccount.EuroDeposit = EuroCurreny;
            CreateAccount.CreationDate = DateTime.Now;
            CreateAccount.ExpirationDate = DateTime.Now.AddYears(_MaxAccountLength);
            CreateAccount.IsActive = true;
            CreateAccount.CreatedByUserID = CreatedByUserID;
            if (CreateAccount.Save())
            {
                return CreateAccount;
            }
            else

                return null;
        }
        public bool DectivateAccount()
        {
            return clsDataClientAccount.DeactivateClientAccount(this.AccountID);
        }
        public bool DectivateAccount(int AccountID)
        {
            return clsDataClientAccount.DeactivateClientAccount(AccountID);
        }
        public static bool IsAccountExistInfoByPersonID(int PersonID) {
        return clsDataClientAccount.IsAccountExistInfoByPersonID(PersonID);
                 }
        public clsClientAccount RenewAccount(int CreatedByUserID, int AccountID)
        {

            clsClientAccount CurrentAccount = clsClientAccount.GetFindInfoByAccountID(AccountID);

            if (CurrentAccount == null)
            {
                return null; 
            }
          


                // will Create Application Object 
                clsApplications Application = new clsApplications();
                Application.PersonID = CurrentAccount.PersonID;
                Application.ApplicationType = (int)clsApplicationTypes.enApplicationType.RenewAccount;
                Application.ApplicationDate = DateTime.Now;
                Application.CreatedByUserID = CreatedByUserID;
                if (!Application.Save())
                {
                    return null;
                }

            //Create New Account object
           
            clsClientAccount NewAccountClient = new clsClientAccount();
            NewAccountClient.PersonID = CurrentAccount.PersonID;
            NewAccountClient.ApplicationID = Application.ApplicationID;
            NewAccountClient.LocalDeposit = CurrentAccount.LocalDeposit;
            //Reload the  Currencies form the Old To the New Account  
            if (CurrentAccount.EuroDeposit != null)
                NewAccountClient.EuroDeposit = CurrentAccount.EuroDeposit;
            else
                NewAccountClient.EuroDeposit = -1;
            /////////////////////////////////////////////////
            NewAccountClient.CreationDate = DateTime.Now;
            NewAccountClient.ExpirationDate = DateTime.Now.AddYears(_MaxAccountLength);
            NewAccountClient.IsActive = true;
            NewAccountClient.CreatedByUserID = CreatedByUserID;
            if (NewAccountClient.Save())
            {
                DectivateAccount(CurrentAccount.AccountID);
                return NewAccountClient;
            }
            else

                return null;
        }
        static public DataTable GetAllClientList()
        {
            
          return    clsDataClientAccount.GetAllClientsAccount();
        }
    }
}
