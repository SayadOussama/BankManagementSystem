using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessLayer
{
    public class clsApplications
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        
        public int ApplicationID { get; set; }
        public int PersonID { get; set; }
        public int  ApplicationType { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int CreatedByUserID { get; set; }
        //Compositions
        public clsPerson _PersonInfo;
        public clsApplicationTypes _AppTypeInfo;
        public clsApplications()
        {
            this.ApplicationID = -1;
            this.PersonID = -1;
            this.ApplicationType = -1;
            this.ApplicationDate = DateTime.MinValue;
            this.CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }
        private clsApplications(int ApplicationID, int PersonID, int ApplicationType, DateTime ApplicationDate, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.PersonID = PersonID;
            this.ApplicationType = ApplicationType;
            this.ApplicationDate = ApplicationDate;
            this.CreatedByUserID = CreatedByUserID;

            //LoadComposition
            this._PersonInfo = clsPerson.GetPersonInfoByPersonID(this.PersonID);
            this._AppTypeInfo = clsApplicationTypes.GetFindApplicationTypesInfoByID((clsApplicationTypes.enApplicationType)this.ApplicationType);

            Mode = enMode.Update;
        }
        public static clsApplications GetApplicationInfoByAppID(int ApplicationID)
        {
            int PersonID = -1; int ApplicationTypeID = -1; DateTime ApplicationDate = DateTime.MinValue; int CreatedByUserID = -1;
            bool IsFound = clsDataApplications.GetApplicationInfoByApplicationID
           (ApplicationID, ref PersonID, ref ApplicationTypeID, ref ApplicationDate, ref CreatedByUserID);

            if (IsFound)
                return new clsApplications(ApplicationID, PersonID, ApplicationTypeID, ApplicationDate, CreatedByUserID);
            else
                return null;
        }
        private bool _AddNewInfoByApplicationID()
        {

            this.ApplicationID = clsDataApplications.AddNewApplicationID
             (this.PersonID, (int)this.ApplicationType, this.ApplicationDate, this.CreatedByUserID);

            return (this.ApplicationID != -1);
        }
        private bool _UpdateApplicationInfoByAppId()
        {

            return clsDataApplications.UpdateByApplicationID
            (this.ApplicationID, this.PersonID, (int)this.ApplicationType, this.ApplicationDate, this.CreatedByUserID);

        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInfoByApplicationID())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateApplicationInfoByAppId();
            }
            return false;
        }
        public static bool IsApplicationExistByApplicationID(int ApplicationID)
        {
            return clsDataApplications.IsApplicationExistByAppID(ApplicationID);
        }
        public static bool DeleteApplicationID(int ApplicationID)
        {

            return clsDataApplications.DeleteApplicationByAppID(ApplicationID);
        }
        public static DataTable GetApplicationsList()
        {
            return clsDataApplications.GetApplicationsList();
  
        }
       public static bool  IsApplicationExist(int PersonID , int ApplicationTypeID)
        {
            return clsDataApplications.IsApplicationExist(PersonID , ApplicationTypeID);
        }
    }
}
