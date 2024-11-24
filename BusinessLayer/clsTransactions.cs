using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public  class clsTransactions
    {
        public enum enMode { AddNew= 1, Update= 2 }
         public   enMode Mode = enMode.AddNew;    
        public int TransactionID { get; set; }
        public clsTransationTypes.enTransactionTypes TransactionTypeID { get; set; }

        public int AccountID { get; set; }

        public DateTime TransactionDate { get; set; }

        public  decimal TransactionFees { get; set; }

        public int CreatedByUserID { get; set; }
        
        //Composition 
        clsClientAccount ClientAccountInfo;

        clsTransationTypes TransactionTypeInfo;

       public  clsTransactions()
        {
            this.TransactionID = -1; 
            this.TransactionTypeID =  clsTransationTypes.enTransactionTypes.TransferLocalCurrency;
            this.AccountID = -1;
            this.TransactionDate = DateTime.MinValue;
            this.TransactionFees = -1;
            this.CreatedByUserID = -1;
            

        }
        private clsTransactions(int  transactionID,clsTransationTypes.enTransactionTypes transactionTypes , int accountID,DateTime transactionDate 
          ,decimal transactionFees ,int createdByUserID    )
        {
            this.TransactionID=transactionID;
            this.TransactionTypeID=transactionTypes;
            this.AccountID=accountID;
            this.TransactionDate=transactionDate;
            this.TransactionFees=transactionFees;
            this.CreatedByUserID=createdByUserID;
            
            //Loaded Composition Class 
            ClientAccountInfo = clsClientAccount.GetFindInfoByAccountID(this.AccountID);
            TransactionTypeInfo = clsTransationTypes.GetTransactionInfoByTransactionID(this.TransactionID);
            Mode =enMode.Update;








        }



        public static clsTransactions FindTransactionInfoByTransationID(int TransationID)
        {
            int TransactionTypeID = -1; int AccountID = -1; decimal TransactionFees = -1; DateTime TransactionDate = DateTime.MinValue; int CreatedByUserID = -1;
            bool IsFound = clsDataTransactions.GetFindTransactionInfoByTransationID
           (TransationID, ref TransactionTypeID, ref AccountID, ref TransactionDate, ref TransactionFees, ref CreatedByUserID );

            if (IsFound)
                return new clsTransactions(TransationID,(clsTransationTypes.enTransactionTypes) TransactionTypeID, AccountID, TransactionDate, TransactionFees, CreatedByUserID);
            else
                return null;
        }


        private bool _AddNewTransation()
        {
            
            this.TransactionID = clsDataTransactions.AddNewTransation
            ((int)   this.TransactionTypeID, this.AccountID, this.TransactionDate, this.TransactionFees, this.CreatedByUserID);

            return (this.TransactionID != -1);
        }
        private bool _UpdateAddInfo()
        {

            return clsDataTransactions.UpdateTransaction
            (this.TransactionID,(int) this.TransactionTypeID, this.AccountID, this.TransactionDate, this.TransactionFees, this.CreatedByUserID);

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTransation())
                    {

                        Mode = enMode.AddNew;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateAddInfo();

            }

            return false;
        }


       public static decimal GetTransactionTypeFees(int TransactionTypeID)
        {
         return     clsDataTransactions.GetTransactionFeesByID(TransactionTypeID);
        }

        public static DataTable GetTransactionsManagementList()
        {
            return clsDataTransactions.GetTransactionManagementList();
        }

        public bool LocalWithDrawAmountTransaction(clsTransationTypes.enTransactionTypes TransactionTypeID, int AccountID, decimal WithDrawAmount,int CreardByUserID)
        {
           

            clsClientAccount Account = clsClientAccount.GetFindInfoByAccountID(AccountID);
            if (Account == null)
                return false;
           

            // New Transaction object 
            clsTransactions Transaction = new clsTransactions();
            //Load History Record 
            clsHistoryTransactions History = new clsHistoryTransactions();

            Transaction.TransactionTypeID = TransactionTypeID;
            Transaction.AccountID = Account.AccountID;
            Transaction.TransactionDate = DateTime.Now;
            Transaction.TransactionFees = GetTransactionTypeFees((int)TransactionTypeID);
            Transaction.CreatedByUserID = CreardByUserID;
            if (Transaction.Save()) 
            {
                //with draw process
                Account.LocalDeposit =- (GetTransactionTypeFees((int)TransactionTypeID) + WithDrawAmount);
                Account.Save();
                History.TransactionID = Transaction.TransactionID;
                History.TransactionType  = Transaction.TransactionTypeID;
                History.AccountID = Account.AccountID;
                History.AccountReceiveID = -1;
                History.CurrencyType =clsHistoryTransactions.enCurrencyType.LocalCurrency;
                History.LocalAmount  = WithDrawAmount;
                History.EuroAmount = -1;
                if (!History.Save()) { 
                    return false;
                }
                return true;
            }
            return false;
        }
        public bool EuroWithDrawAmountTransaction(clsTransationTypes.enTransactionTypes TransactionTypeID, int AccountID, decimal WithDrawAmount, int CreardByUserID)
        {
            

            clsClientAccount Account = clsClientAccount.GetFindInfoByAccountID(AccountID);
            if (Account == null)
                return false;


            // New Transaction object 
            clsTransactions Transaction = new clsTransactions();
            //Load History Record 
            clsHistoryTransactions History = new clsHistoryTransactions();
            Transaction.TransactionTypeID = TransactionTypeID;
            Transaction.AccountID = Account.AccountID;
            Transaction.TransactionDate = DateTime.Now;
            Transaction.TransactionFees = GetTransactionTypeFees((int)TransactionTypeID);
            Transaction.CreatedByUserID = CreardByUserID;
            if (Transaction.Save())
            {
                //with draw process
                Account.LocalDeposit = -(GetTransactionTypeFees((int)TransactionTypeID) + WithDrawAmount);
                Account.Save();
                History.TransactionID = Transaction.TransactionID;
                History.TransactionType = Transaction.TransactionTypeID;
                History.AccountID = Account.AccountID;
                History.AccountReceiveID = -1;
                History.CurrencyType = clsHistoryTransactions.enCurrencyType.EuroCurrecy;
                History.LocalAmount = -1;
                History.EuroAmount = WithDrawAmount;
                if (!History.Save())
                {
                    return false;
                }



                return true;
            }
            return false;
        }
        public static bool TransferLocalCurrencyTransaction(clsTransationTypes.enTransactionTypes TransactionTypeID,  int SenderAccoundID , int RecevierAccountID , decimal TransferAmount, int CreatedByUserID)
        {
           
            //Load Accounts
            clsClientAccount SenderAccound = clsClientAccount.GetFindInfoByAccountID(SenderAccoundID);
            if (SenderAccound == null)
                return false;

            clsClientAccount RecevierAccount = clsClientAccount.GetFindInfoByAccountID(RecevierAccountID);
            if (RecevierAccount == null)
                return false;



            // New Transaction object 
            clsTransactions Transaction = new clsTransactions();
            //Load History Record 
            clsHistoryTransactions History = new clsHistoryTransactions();
            Transaction.TransactionTypeID = TransactionTypeID;
            Transaction.AccountID = SenderAccound.AccountID;
            Transaction.TransactionDate = DateTime.Now;
            Transaction.TransactionFees = GetTransactionTypeFees((int)TransactionTypeID);
            Transaction.CreatedByUserID = CreatedByUserID;
            if (Transaction.Save())
            {
                //with Transfer process
                SenderAccound.LocalDeposit =-(GetTransactionTypeFees((int)TransactionTypeID) + TransferAmount);
                RecevierAccount.LocalDeposit += TransferAmount;
                if (!SenderAccound.Save())
                    return false;


                if(!RecevierAccount.Save())
                    return false;

                History.TransactionID = Transaction.TransactionID;
                History.TransactionType = Transaction.TransactionTypeID;
                History.AccountID = SenderAccound.AccountID;
                History.AccountReceiveID = RecevierAccount.AccountID;
                History.CurrencyType = clsHistoryTransactions.enCurrencyType.LocalCurrency;
                History.LocalAmount = TransferAmount;
                History.EuroAmount = -1;
                if (!History.Save())
                {
                    return false;
                }



                return true;
            }
            return false;
        }
        public static bool TransferEuroCurrencyTransaction(clsTransationTypes.enTransactionTypes TransactionTypeID, int SenderAccoundID, int RecevierAccountID, decimal TransferAmount, int CreatedByUserID)
        {

            //Load Accounts
            clsClientAccount SenderAccound = clsClientAccount.GetFindInfoByAccountID(SenderAccoundID);
            if (SenderAccound == null)
                return false;

            clsClientAccount RecevierAccount = clsClientAccount.GetFindInfoByAccountID(RecevierAccountID);
            if (RecevierAccount == null)
                return false;



            // New Transaction object 
            clsTransactions Transaction = new clsTransactions();
            //Load History Record 
            clsHistoryTransactions History = new clsHistoryTransactions();
            Transaction.TransactionTypeID = TransactionTypeID;
            Transaction.AccountID = SenderAccound.AccountID;
            Transaction.TransactionDate = DateTime.Now;
            Transaction.TransactionFees = GetTransactionTypeFees((int)TransactionTypeID);
            Transaction.CreatedByUserID = CreatedByUserID;
            if (Transaction.Save())
            {
                //with draw process
                SenderAccound.LocalDeposit =- GetTransactionTypeFees((int)TransactionTypeID);
                SenderAccound.EuroDeposit  =- TransferAmount;
                RecevierAccount.EuroDeposit += TransferAmount;
                if (!SenderAccound.Save())
                    return false;


                if (!RecevierAccount.Save())
                    return false;

                History.TransactionID = Transaction.TransactionID;
                History.TransactionType = Transaction.TransactionTypeID;
                History.AccountID = SenderAccound.AccountID;
                History.AccountReceiveID = RecevierAccount.AccountID;
                History.CurrencyType = clsHistoryTransactions.enCurrencyType.EuroCurrecy;
                History.LocalAmount = -1;
                History.EuroAmount = TransferAmount;
                if (!History.Save())
                {
                    return false;
                }



                return true;
            }
            return false;
        }
        public bool AddNewCurrencyTransaction(clsTransationTypes.enTransactionTypes TransactionTypeID, int AccountID, decimal AddCurrency,clsHistoryTransactions.enCurrencyType CurrencyType ,int CreardByUserID)
        {
            if (TransactionTypeID != clsTransationTypes.enTransactionTypes.WithdrawCurrency)
                return false;

            clsClientAccount Account = clsClientAccount.GetFindInfoByAccountID(AccountID);
            if (Account == null)
                return false;


            // New Transaction object 
            clsTransactions Transaction = new clsTransactions();
            //Load History Record 
            clsHistoryTransactions History = new clsHistoryTransactions();
            Transaction.TransactionTypeID = TransactionTypeID;
            Transaction.AccountID = Account.AccountID;
            Transaction.TransactionDate = DateTime.Now;
            Transaction.TransactionFees = GetTransactionTypeFees((int)TransactionTypeID);
            Transaction.CreatedByUserID = CreardByUserID;
            if (Transaction.Save())
            {
                //with AddCurency process
                if(CurrencyType == clsHistoryTransactions.enCurrencyType.LocalCurrency)
                Account.LocalDeposit =+ AddCurrency;
              
                else
                    Account.EuroDeposit =+ AddCurrency;

                Account.Save();
                History.TransactionID = Transaction.TransactionID;
                History.TransactionType = Transaction.TransactionTypeID;
                History.AccountID = Account.AccountID;
                History.AccountReceiveID = -1;
               
                History.CurrencyType = CurrencyType;
                if (CurrencyType == clsHistoryTransactions.enCurrencyType.LocalCurrency) { 
                    History.LocalAmount = AddCurrency;
                     History.EuroAmount = -1;
                }

                else
                {
                    History.LocalAmount = -1;
                    History.EuroAmount = AddCurrency;
                }


                if (!History.Save())
                {
                    return false;
                }



                return true;
            }
            return false;
        }
        public bool IsAmountAvailable(int AccountID,decimal Amount , clsHistoryTransactions.enCurrencyType CurrencyType)
        {
         clsClientAccount Account = clsClientAccount.GetFindInfoByAccountID(AccountID);
            if (Account == null)
                return false;

           





            if (CurrencyType == clsHistoryTransactions.enCurrencyType.LocalCurrency)
            { 
                if( Account.LocalDeposit >= Amount) 
                    return true;
            }
            else
            {
                if (Account.EuroDeposit >= Amount)
                    return true;
            }
            return false;
        }
    }
}
