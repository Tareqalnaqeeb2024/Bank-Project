using System;
using System.Data;
using System.Data.SqlClient;

namespace BankDataAccess
{
  public  class ClsUserData
    {
    public static int AddNewUser (string UserName,string Password, int Permissions , int PersonID)

        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            string query = @"Insert Into Users (UserName,PassWord,Permissions,PersonID) 
                                         Values(@UserName,@PassWord,@Permissions,@PersonID);
                                          select Scope_Identity();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("PassWord", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                object reslut = command.ExecuteScalar();

                if(reslut != null && int.TryParse(reslut.ToString() , out int InsertedID))
                {
                    UserID = InsertedID;
                }
            }catch
            {
                UserID = -1;
            }
            finally
            {
                connection.Close();
            }

            return UserID;


        }

    public static bool GetUserByID(int ID ,ref string UserName,ref string PassWord,ref int Permissions , ref int PersonID)
        {
            bool  IsFound = false;
            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            string Query = "select * from Users where UserID =@UserID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if(reader.Read())
                {
                    IsFound = true;
                    UserName = (string)reader["UserName"];
                    PassWord = (string)reader["PassWord"];
                    Permissions = (int)reader["Permissions"];
                    PersonID = (int)reader["PersonID"];
                }
                reader.Close();


            }catch
            {
                IsFound = false;
            }finally
            {
                connection.Close();
            }
            return IsFound;
        }


        public static bool GetUserByUserName( string UserName, ref int ID,  ref string PassWord, ref int Permissions, ref int PersonID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            string Query = "select * from Users where UserName =@UserName";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    IsFound = true;
                    ID = (int)reader["UserID"];
                    PassWord = (string)reader["PassWord"];
                    Permissions = (int)reader["Permissions"];
                    PersonID = (int)reader["PersonID"];
                }
                reader.Close();


            }
            catch
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }
        public static bool UpdateUser(int ID , string UserName, string PassWord, int Permissions ,int PersonID)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            string Query = @"Update Users set
                                               UserName   =   @UserName,
                                                PassWord  =   @PassWord,
                                             Permissions  =   @Permissions,
                                                PersonID  =   @PersonID
                                            where UserID  =   @UserID " ;

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserID", ID);
            command.Parameters.AddWithValue("@UserName",UserName);
            command.Parameters.AddWithValue("@PassWord", PassWord);
            command.Parameters.AddWithValue("@Permissions",Permissions);
            command.Parameters.AddWithValue("@PersonID",PersonID );

            try
            {
                connection.Open();

                RowAffected = command.ExecuteNonQuery();

            }catch
            {
                RowAffected = -1;

            }finally
            {
                connection.Close();

            }
            return (RowAffected >0);
        }
    
   public static DataTable GetALLUsers()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            string query = @" 
select Users.UserID , Users.UserName , Person.FirstName , Person.LastName   , Users.PassWord , Users.Permissions
  from Person join
    Users on  Users.PersonID = Person.PersonID; ";

            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    dataTable.Load(reader);

                }
                reader.Close();

            }catch
            {

            }finally
            {
                connection.Close();
            }

            return dataTable;
        }
    

   public static bool DeleteUser(int ID)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            string query = "Delete  Users where UserID=@UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", ID);

            try
            {
                connection.Open();

                RowAffected = command.ExecuteNonQuery();

            }catch
            {
                RowAffected = -1;

            }finally
            {
                connection.Close();
            }
            return (RowAffected > 0);

        }
   
   public static bool IsExistUser(int ID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            string query = "select found=1 from Users where UserID =@UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                IsFound = reader.HasRows;

                reader.Close();

            }
            catch (Exception ex)
            {

                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

     public static int TotalUsers()
        {
            int Balances = 0;

            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            string Query = "select Users = Count(UserID) from Users";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                object reslut = command.ExecuteScalar();

                if (reslut != null && int.TryParse(reslut.ToString(), out int InsretedID))
                {
                    Balances = InsretedID;



                }

            }
            catch

            {

            }
            finally
            {
                connection.Close();

            }

            return Balances;



        
    }
    }
}
