using System;
using System.Data;

using BankDataAccess;


namespace BankBusiness
{
    public class ClsPerson
    {

        public enum EnMode { Add =0 , Update=1};
        public static EnMode Mode = EnMode.Add;
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDay { get; set; }
        public string Address { get; set; }
        public string Profile { get; set; }

        public ClsPerson ()
        {
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.Gender = "";
            this.BirthDay = DateTime.Now;
            this.Address = "";
            Mode = EnMode.Add;
            this.ID = -1;

        }

        private  ClsPerson(int ID , string FirstName , string LastName , string Email,string Phone
            ,  string Gender,  DateTime BirthDay,  string Address,  string Profile)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Gender = Gender;
            this.BirthDay = BirthDay;
            this.Address = Address;
            this.Profile = Profile;
            Mode = EnMode.Update;

        }

        public static ClsPerson Find(int ID)
        {
            string FirstName = "", LastName = "", Email = "", Phone = "" , Gender ="",Address ="",Profile ="";
            DateTime BirthDay = DateTime.Now;

            if(ClsPersonData.GetPersonByID(ID,ref FirstName , ref LastName, ref Email , ref Phone, ref  Gender, ref  BirthDay, ref  Address, ref Profile))
            {
                return new  ClsPerson(ID, FirstName, LastName, Email, Phone ,Gender ,BirthDay ,Address ,Profile);


            }
            else
            {
                return null;
            }

        }

        private  bool _AddNewPerson()
        {
            this.ID = ClsPersonData.AddNewPerson(this.FirstName, this.LastName, this.Email, this.Phone ,this.Gender ,this.BirthDay ,this.Address ,this.Profile);
            return (this.ID != -1);
        }

        private bool _UpdatePerson()
        {
            return ClsPersonData.UpdatePerson(this.ID, this.FirstName, this.LastName, this.Email, this.Phone,this.Gender,this.BirthDay,this.Address,this.Profile);
        }
        public  bool Save()
        {
            switch(Mode)
            {
                case EnMode.Add:
                    if(_AddNewPerson())
                    {
                        return true;
                        Mode = EnMode.Update;
                    }
                    else
                    {
                        return false;
                    }
                case EnMode.Update:
                    
                     return   _UpdatePerson();
                    


            }
            return false;
        }
    
        public static DataTable GetAllPersons()
        {
            return ClsPersonData.GetALlPersons();
        }

        public static bool DeletePerson(int ID)
        {
            return ClsPersonData.DeletePerson(ID);
        }

        public static bool IsPersonExsit(int ID)

        {
            return ClsPersonData.IsPersonExsit(ID);
        }
    }
}
