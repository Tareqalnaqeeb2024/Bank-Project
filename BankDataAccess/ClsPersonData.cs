using System;
using System.Data;
using System.Data.SqlClient;


namespace BankDataAccess
{
    public class ClsPersonData
    {

        public static bool GetPersonByID(int ID, ref string FirstName, ref string LastName, ref string Email, ref string Phone
           , ref string Gender,ref DateTime BirthDay , ref string Address , ref string Profile )
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);
            string query = "select * from Person where PersonID =@PersonID";

            
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    Gender = (string)reader["Gender"];
                    BirthDay = (DateTime)reader["BirthDay"];
                    Address = (string)reader["Address"];
                    

                    if(reader["Profile"] !=DBNull.Value )
                    {
                        Profile = (string)reader["Profile"];

                    }else
                    {
                        Profile = "";
                    }

                }else
                {
                    isFound = false;
                }
                    reader.Close();

            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;





        }

        public static int AddNewPerson(string FirstName, string LastName, string Email,string Phone
            ,  string Gender,  DateTime BirthDay,  string Address,  string Profile)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            string query = @"Insert into Person(FirstName ,LastName,Email,Phone,Gender,BirthDay,Address,Profile)
                            values(@FirstName,@LastName,@Email,@Phone,@Gender,@BirthDay,@Address,@Profile);
                             select Scope_Identity();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@BirthDay", BirthDay);
            command.Parameters.AddWithValue("@Address", Address);

            if (Profile != "" && Profile != null)
                command.Parameters.AddWithValue("@Profile", Profile);
            else
                command.Parameters.AddWithValue("@Profile", System.DBNull.Value);





            try
            {
                connection.Open();

                object reslut = command.ExecuteScalar();

                if(reslut != null && int.TryParse(reslut.ToString() , out int Insearted))
                {
                    ID = Insearted;

                }
            }
            catch(Exception ex)
            {
                ID = -1;
            }
            finally
            {
                connection.Close();
            }

            return ID ;
        }

        public static bool UpdatePerson(int ID ,  string FirstName,  string  LastName ,  string Email , string Phone
            ,  string Gender,  DateTime BirthDay,  string Address,  string Profile)
        {
            int rowAffected = -1;

            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            string query = @"Update Person Set
                            FirstName =@FirstName,
                            LastName  =@LastName,
                             Email    =@Email,
                             Phone    =@Phone,
                             Gender   =@Gender,
                           BirthDay   =@BirthDay,
                          Address     =@Address,
                         Profile      =@Profile
                       Where PersonID =@PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@BirthDay", BirthDay);
            command.Parameters.AddWithValue("@Address", Address);

            if (Profile != "" || Profile != null)
                command.Parameters.AddWithValue("@Profile", Profile);
            else
                command.Parameters.AddWithValue("@Profile", System.DBNull.Value);

            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();

                
            }

            catch (Exception ex)
            {
                rowAffected = -1;
            }
            finally
            {
                connection.Close();
            }

            return (rowAffected > 0);

        }
     public static DataTable GetALlPersons()
        {
            DataTable dataTable = new DataTable();


            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            string query = "select * from Person";

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


            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }
    
         public static bool DeletePerson(int ID)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            

            string query = @"Delete Person Where PersonID= @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID",ID);

            try
            {
                connection.Open();

                RowAffected = command.ExecuteNonQuery();

            }
            
            catch (Exception ec)
            {
                

            }
            finally
            {
                connection.Close();
            }
            return (RowAffected > 0);

        }

        public static bool IsPersonExsit(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            string query = "Select Found=1  From Person Where PersonID=@PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();

            }
            catch
            {
                isFound = false;

            }
            finally
            {
                connection.Close();
            }

            return isFound;



        }

    }
}
