using System;
using System.Data;
using BankDataAccess;

namespace BankBusiness
{
  public   class ClsUser
    {
        public enum EnPermission
        {
            enAll = -1, enShowClient = 1, enAddNewClient = 2, enFindClient = 4,
            enDeleteClient = 8, enUpdateClient = 16, enShowUser = 32, enAddNewUser = 64,
            enFindUser = 128, enDeleteUser = 256, enUpdateUser = 512
        };
        public enum EnMode { Add =0 , UpDate=1};
        public EnMode Mode = EnMode.Add;
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
         public int Permissions { get; set; }
        public int PersonID { get; set; }

        public ClsUser()
        {
            this.UserID = -1;
            this.UserName = "";
            this.PassWord = "";
            this.Permissions = 0;
            this.PersonID = 0;
            Mode = EnMode.Add;
        }

        private ClsUser(int ID , string UserName, string PassWord, int Permissions ,int PersonID)
        {
            this.UserID = ID;
            this.UserName = UserName;
            this.PassWord = PassWord;
            this.Permissions = Permissions;
            this.PersonID = PersonID;

            Mode = EnMode.UpDate;
        }

        private bool _AddNewUser()
        {
            this.UserID = ClsUserData.AddNewUser(this.UserName, this.PassWord, this.Permissions, this.PersonID);

            return (this.UserID != -1);

        }

        private bool _UpdateUser()
        {
            return ClsUserData.UpdateUser(this.UserID, this.UserName, this.PassWord, this.Permissions, this.PersonID);
        }

      public  bool Save()
        {
            switch(Mode)
            {
                case EnMode.Add:

                    {
                        if (_AddNewUser())
                        {
                            return true;
                            Mode = EnMode.UpDate;
                        }else
                        {
                            return false;
                        }
                    }
                case EnMode.UpDate:
                    {
                        return _UpdateUser();
                    }
         
            }
            return false;
        }
     
      public static ClsUser Find(int ID)
        {
            string UserName = "", PassWord = "";
            int Permissions = 0, PersonID = 0;

           if( ClsUserData.GetUserByID(ID,ref UserName,ref PassWord,ref Permissions, ref PersonID))
            {
                return new ClsUser(ID, UserName, PassWord, Permissions, PersonID);
            }else
            {
                return null;
            }
        }

        public static ClsUser Find(string UserName)
        {
            int ID = -1; string  PassWord = "";
            int Permissions = 0, PersonID = 0;

            if (ClsUserData.GetUserByUserName(UserName , ref ID, ref PassWord, ref Permissions, ref PersonID))
            {
                return new ClsUser( ID, UserName, PassWord, Permissions, PersonID);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetALlUsers()
        {
            return ClsUserData.GetALLUsers();
        }
    public static bool Delete(int ID)
        {
            return ClsUserData.DeleteUser(ID);
        }

        public static bool IsExistUser(int ID)
        {
            return ClsUserData.IsExistUser(ID);
        }

        public  bool CheckPermission(EnPermission permission)
        {
            if(this.Permissions == -1)
            {
                return true;
            }
            if (((int)permission & this.Permissions) == (int)permission)
            {
                return true;
            }
            else
            {

                return false;
            }
            
        }

        public static int TotalUsers()
        {
            return ClsUserData.TotalUsers();
        }

       
    }
}
