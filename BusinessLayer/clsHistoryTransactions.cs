using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsHistoryTransactions
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        public enum enCurrencyType { LocalCurrency = 1 , EuroCurrecy  = 2 }
        
        public   enCurrencyType CurrencyType = enCurrencyType.LocalCurrency;
        
        public int HistoryID {  get; set; }
        
        public int TransactionID { get; set; }

        public clsTransationTypes.enTransactionTypes TransactionType = clsTransationTypes.enTransactionTypes.AddCurrency; 
        public int AccountID {  get; set; }

        public int AccountReceiveID { get; set; }

        public enCurrencyType Currency {  get; set; }   

        public  decimal LocalAmount { get; set; }

        public decimal EuroAmount { get; set;}
        public clsHistoryTransactions()
        {
            this.HistoryID = -1;
            this.TransactionID = -1;
            this.TransactionType = clsTransationTypes.enTransactionTypes.AddCurrency;
            this.AccountID = -1;
            this.AccountReceiveID = -1;
            this.Currency = enCurrencyType.LocalCurrency;
            this.LocalAmount = -1;
            this.EuroAmount = -1;
            Mode = enMode.AddNew;
        }
        private clsHistoryTransactions(int HistoryID , int TransactionID, clsTransationTypes.enTransactionTypes TransactionTypes
            ,int AccountId , int AccountReceiveID ,enCurrencyType Currency , decimal LocalAmount , decimal EuroAmount)
        {
            this.HistoryID = HistoryID ;
            this.TransactionID = TransactionID ;    
            this.TransactionType = TransactionTypes ;
            this.AccountID = AccountID ;
            this.AccountReceiveID = AccountReceiveID ;
            this.Currency = Currency ;
            this.LocalAmount = LocalAmount ;
            this.EuroAmount = EuroAmount ;
            Mode = enMode.Update;
        }

        public static clsHistoryTransactions FindInfoByHitstoryID(int HitstoryID)
        {
            int TransactionID = -1; int TransactionType = -1; int AccountID = -1; int AccountReceiveID = -1; int CurrencyType = -1; decimal LocalAmount = -1; decimal EuroAmount = -1;
            bool IsFound = clsDataHistoryTransactions.FindHistoryInfoByHitstoryID
           (HitstoryID, ref TransactionID, ref TransactionType, ref AccountID, ref AccountReceiveID, ref CurrencyType, ref LocalAmount, ref EuroAmount);

            if (IsFound)
                return new clsHistoryTransactions(HitstoryID, TransactionID, (clsTransationTypes.enTransactionTypes)TransactionType, AccountID, AccountReceiveID, (enCurrencyType)CurrencyType, LocalAmount, EuroAmount);
            else
                return null;
        }
        private bool _AddNewHistory()
        {

            this.HistoryID = clsDataHistoryTransactions.AddNewHitstory
            (this.TransactionID, (int)this.TransactionType, this.AccountID, this.AccountReceiveID, (int)this.CurrencyType, this.LocalAmount, this.EuroAmount);

            return (this.HistoryID != -1);
        }
        private bool _UpdateHistory()
        {

            return clsDataHistoryTransactions.UpdateInfoByHitstoryID
            (this.HistoryID, this.TransactionID,(int) this.TransactionType, this.AccountID, this.AccountReceiveID, (int)this.CurrencyType, this.LocalAmount, this.EuroAmount );

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewHistory())
                    {

                        Mode = enMode.AddNew;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateHistory();

            }

            return false;
        }
        public static bool DeleteHitstoryID(int HitstoryID)
        {

            return clsDataHistoryTransactions.DeleteHistoryInfoByHitstoryID(HitstoryID);
        }
        public static bool HistoyExsitByID(int HitstoryID)
        {

            return clsDataHistoryTransactions.IsHistoryExistByID(HitstoryID);
        }
        public static DataTable GetAllHitstoryIDList()
        {

            return clsDataHistoryTransactions.GetHitoryList();
        }
    }
}
