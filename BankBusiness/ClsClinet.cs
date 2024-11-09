using System;
using System.Data;
using BankDataAccess;

namespace BankBusiness
{
    public class ClsClinet 
    {
        public enum EnMode { Add = 0, Update = 1 };
        public static EnMode Mode = EnMode.Add;
        public int ClinetID { get; set; }
        public string AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
        public int PinCode { get; set; }
        public int PersonID { get; set; }
   


        public ClsClinet()
        {
            this.PersonID = 0;
            this.ClinetID = -1;
            this.AccountNumber = "";
            this.AccountBalance = 0;
            this.PinCode = 0;
            Mode = EnMode.Add;
        }

       
        private ClsClinet(int ID , string AccountNumber, decimal AccountBalance, int PinCode, int PersonID  )
        {
            
            this.ClinetID = ID;
            this.AccountNumber = AccountNumber;
            this.AccountBalance = AccountBalance;
            this.PinCode = PinCode;
            this.PersonID = PersonID;

            Mode = EnMode.Update;

        }

        

        public static ClsClinet Find(int ID)
        {
            decimal AccountBalance =0 ;
            int PersonID = -1, PinCode = 0; string AccountNumber=""  ;

            
         
            if (ClsClientData.GetClinetByID(ID, ref AccountNumber, ref AccountBalance, ref PinCode, ref PersonID))
            {
                return new ClsClinet(ID, AccountNumber, AccountBalance, PinCode, PersonID);
            }
            else
            {
                return null;
            }

        }

        public static ClsClinet Find(string AccountNumber)
        {
            decimal AccountBalance = 0;
            int PersonID = -1, PinCode = 0 , ClinetID =-1;

            if(ClsClientData.GetClientInfoByAccountNumber(AccountNumber,ref ClinetID ,ref PinCode ,ref AccountBalance ,ref PersonID))
            {
                return new ClsClinet(ClinetID, AccountNumber, AccountBalance, PinCode, PersonID);
            }
            else
            {
                return null;
            }

        }

        private bool _AddNewClient()
        {
            this.ClinetID = ClsClientData.AddNewClinet( this.AccountNumber, this.AccountBalance, this.PinCode , this.PersonID);
            return (this.ClinetID != -1);
        }

        private bool _UpdateClinet()
        {
            return ClsClientData.UpdateClinet(this.ClinetID, this.AccountNumber, this.AccountBalance, this.PinCode, this.PersonID);

        }

        public  bool Save()
        {
            switch(Mode)
            {
                case EnMode.Add:
                    if(_AddNewClient())
                    {
                        return true;
                        Mode = EnMode.Update;

                    }
                    else
                    {
                        return false;
                    }
                case EnMode.Update:
                    return _UpdateClinet();
            }
            return false;
        }


        public  bool Deposite(decimal Amount)
        {
            this.AccountBalance += Amount;
            return true;

        }

        public bool Withdraw(decimal Amonut)
        {
            if(this.AccountBalance < Amonut)
            {
                return false;
            }else
            {
                this.AccountBalance -= Amonut;
                return true;
            }
        }

        public  bool  Trnafer( ClsClinet ToClinet , decimal Amonut)
        {
            if(this.AccountBalance < Amonut)
            {
                return false;
            }
            else
            {
                this.Withdraw(Amonut);
                ToClinet.Deposite(Amonut);
                return true;
            }
        }

        
   
    public static bool IsExsitClinet(int ID)
        {
            return ClsClientData.IsExsitClient(ID);
        }


        public static DataTable GetAllClinets()
        {
            return ClsClientData.GetAllClinets();
        }

     public static bool DeleteClinet(int ID)
        {
            return ClsClientData.DeleteClinet(ID);
        }
     public static DataTable GetTotalBalance()
        {
            return ClsClientData.GetTotalBalance();
        }
     public static Decimal TotalBalances()
        {
            return ClsClientData.TotalBalances();
        }

        public static int CountClients()
        {
           return  ClsClientData.TotalClients();
        }
    }

    
}
