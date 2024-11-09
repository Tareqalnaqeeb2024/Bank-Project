using System;
using System.Data;
using BankDataAccess;

namespace BankBusiness
{
    public class ClsTranferLogRegister
    {
        public enum EnMode { Add = 0, Update = 1 };
        public static EnMode Mode = EnMode.Add;

        public int ID { get; set; }
        public DateTime dateTime { get; set; }
        public decimal Amount { get; set; }
        public int SourceClinetID { get; set; }
        public int DestiantionClinetID { get; set; }
        public int UserID { get; set; }
        public decimal SourceAccountBalance { get; set; }
        public decimal DestinationAccountBalance { get; set; }

        public ClsTranferLogRegister()
        {
            this.ID = -1;
            this.dateTime =new  DateTime() ;
            this.Amount = 0;
            this.SourceClinetID = 0;
            this.DestiantionClinetID = 0;
            this.UserID = -1;
            this.SourceAccountBalance = 0;
            this.DestinationAccountBalance = 0;
            Mode = EnMode.Add;

        }

        private ClsTranferLogRegister(int ID, DateTime dateTime ,decimal Amount , int SourceClinetID ,int DestiantionClinetID,
            int UserID , decimal SourceAccountBalance , decimal DestinationAccountBalance )
        {
            this.ID = ID;
            this.dateTime = dateTime;
            this.Amount = Amount;
            this.SourceClinetID = SourceClinetID;
            this.DestiantionClinetID = DestiantionClinetID;
            this.UserID = UserID;
            this.SourceAccountBalance = SourceAccountBalance;
            this.DestinationAccountBalance = DestinationAccountBalance;
            Mode = EnMode.Update;

        }

        private bool _AddNewTranferLogRegister()
        {
            this.ID = ClsTransferLogRagisterData.AddNewTransferLogRegister( this.dateTime, this.SourceClinetID,
                 this.DestiantionClinetID, this.Amount, this.UserID, this.SourceAccountBalance, this.DestinationAccountBalance);

            return (this.ID != -1);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case EnMode.Add:
                    {
                        if(_AddNewTranferLogRegister())
                        {
                            return true;
                           
                        }else
                        {
                            return false;
                        }
                    }
            }
            return false;
        }
     
        public static DataTable GetALLTransferRegister()

        {
            return ClsTransferLogRagisterData.GetAllTranferLogRegister();
        }

        public static int CountTrnasferLog()
        {
            return ClsTransferLogRagisterData.TotalTransferLog();
        }
        /*public static bool Find(int ID)
        {
            DateTime dateTime = new DateTime( 1999,5,2); decimal Amount = 0; int SourceClinetID = -1; int DestiantionClinetID = -1;

            int UserID = -1; decimal SourceAccountBalance = -1; decimal DestinationAccountBalance = 0;

            if(ClsTransferLogRagisterData.GetRegisterByID(ID, ref dateTime , ref SourceClinetID ,ref DestiantionClinetID
                 , ref Amount , ref UserID , ref SourceAccountBalance , ref DestinationAccountBalance))
            {


            }


        }*/
    
    }
}
