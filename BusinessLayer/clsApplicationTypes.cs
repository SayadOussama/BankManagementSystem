using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BusinessLayer
{
    public  class clsApplicationTypes
    {
        public enum enMode { AddNew= 1,Update= 2 }
        public enMode _Mode  = enMode.AddNew;
        public enum enApplicationType { CreateLocalAccount= 1, CreateLocalAndEuroAccount=2
                ,UpdateLocalAccountToLocalAndEuroAccount=3, RenewAccount = 4 }
        public  clsApplicationTypes.enApplicationType  ID { get; set; }
        public string ApplicationName { get; set; }
        public decimal ApplicationFees { get; set; }

        public clsApplicationTypes() {
            this.ID = clsApplicationTypes.enApplicationType.CreateLocalAccount;
            this.ApplicationName = "";
            this.ApplicationFees = -1; 
            _Mode = enMode.AddNew;  

        
        }
        private  clsApplicationTypes(clsApplicationTypes.enApplicationType ID , string ApplicationName, decimal ApplicationFees)
        {
            this.ID = ID;
            this.ApplicationName = ApplicationName;
            this.ApplicationFees = ApplicationFees;
            _Mode = enMode.Update;
        }
        public static clsApplicationTypes GetFindApplicationTypesInfoByID(clsApplicationTypes.enApplicationType ID)
        {
            string ApplicationName = ""; decimal ApplicationFees = 0;
            bool IsFound = clsDataAppplicationTypes.GetFindApplicationTypesInfoByID
           ((int)ID, ref ApplicationName, ref ApplicationFees);

            if (IsFound)
                return new clsApplicationTypes((clsApplicationTypes.enApplicationType)ID, ApplicationName, ApplicationFees);
            else
                return null;
        }
        public static string ConvertApplicationTypeToString(enApplicationType ApplicationType)
        {
            string StringApplicationType = "";
            switch (ApplicationType)
            {
                case enApplicationType.CreateLocalAccount:
                    StringApplicationType = "CreateLocalAccount";
                    break;
                case enApplicationType.CreateLocalAndEuroAccount:
                    StringApplicationType = "CreateLocalAndEuroAccount";
                    break;
                case enApplicationType.UpdateLocalAccountToLocalAndEuroAccount:
                    StringApplicationType = "UpdateLocalAccountToLocalAndEuroAccount";
                    break;
                case enApplicationType.RenewAccount:
                    StringApplicationType = "RenewAccount";
                    break;
                default:
                    StringApplicationType = "";
                    break;
            }
            return StringApplicationType;   
        }
        public static DataTable GetAllIDList()
        {

            return clsDataAppplicationTypes.GetAllByID();
        }










    }





}
