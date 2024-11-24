using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public  class clsTransationTypes
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;

        

        public enum enTransactionTypes
        {
            WithdrawCurrency = 1, TransferLocalCurrency = 2
                , TransferEuroCurrency = 3, AddCurrency = 4
        }
        public   enTransactionTypes TransationTypeID = enTransactionTypes.WithdrawCurrency;
        public   string TransctionName {  get; set; }
        public   decimal TransationFees { get; set; }

        public clsTransationTypes() 
        {
            this.TransationTypeID = enTransactionTypes.WithdrawCurrency;
            this.TransctionName = "";
            this.TransationFees = -1;
            Mode = enMode.AddNew;




        } 
        private clsTransationTypes(enTransactionTypes TransationTypeID, string TransationFees , decimal TramsationFees)
        {
            this.TransationTypeID = TransationTypeID;
            this.TransctionName= TransationFees;
            this.TransationFees= TramsationFees;
            Mode = enMode.Update;
        }

        public static clsTransationTypes GetTransactionInfoByTransactionID(int TransactionID)
        {
            string TransactionName = ""; decimal TransactionFees = -1;
            bool IsFound = clsDataTransationTypes.GetTransactionInfoByTransactionID
           (TransactionID, ref TransactionName, ref TransactionFees);

            if (IsFound)
                return new clsTransationTypes((enTransactionTypes)TransactionID, TransactionName, TransactionFees);
            else
                return null;
        }
        public static DataTable GetAllTransactionIDList()
        {

            return clsDataAppplicationTypes.GetAllByID();
        }







    }
}
