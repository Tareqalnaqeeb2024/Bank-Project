using System;
using System.Data;
using System.Data.SqlClient;

namespace BankDataAccess
{
    public class ClsClientData
    {
        public static bool GetClinetByID(int ID, ref string AccountNumber, ref decimal AccountBalance,
              ref int PinCode, ref int PersonID)
        {
            bool Isfound = false;

            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            string query = "select * from Clinets where ClinetID =@ClinetID ";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClinetID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Isfound = true;
                    AccountNumber = (string)reader["AccountNumber"];
                    AccountBalance = (decimal)reader["AccountBalance"];
                    PinCode = (int)reader["PinCode"];
                    PersonID = (int)reader["PersonID"];


                }


                reader.Close();
            }
            catch
            {

                Isfound = false;
            }
            finally
            {
                connection.Close();
            }

            return Isfound;
        }

        public static bool GetClientInfoByAccountNumber(string AccountNumber,
            ref int ClientID, ref int PinCode, ref decimal AccountBalance, ref int PersonID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            string query = "select * from  Clinets  where AccountNumber =@AccountNumber";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    IsFound = true;

                    ClientID = (int)reader["ClinetID"];
                    PinCode = (int)reader["PinCode"];
                    AccountBalance = (decimal)reader["AccountBalance"];
                    PersonID = (int)reader["PersonID"];



                }

                else
                {
                    IsFound = false;
                }

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



        public static int AddNewClinet(string AccountNumber, decimal AccountBalance, int PinCode, int PersonID)
        {
            int ClinetID = -1;
            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            string Query = @"Insert into Clinets(AccountNumber,AccountBalance,PinCode,PersonID)
                        values(@AccountNumber,@AccountBalance,@PinCode,@PersonID);
                      select Scope_Identity(); ";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);
            command.Parameters.AddWithValue("@PinCode", PinCode);

            try
            {
                connection.Open();


                object reslut = command.ExecuteScalar();



                if (reslut != null && int.TryParse(reslut.ToString(), out int InsertedID))
                {
                    ClinetID = InsertedID;
                }


            }
            catch (Exception ex)
            {
                ClinetID = -1;
            }
            finally
            {
                connection.Close();
            }
            return ClinetID;



        }


        public static bool IsExsitClient(int ID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            string query = "select found=1 from Clinets where ClinetID =@ClinetID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClinetID", ID);

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


        public static bool UpdateClinet(int ID, string AccountNumber, decimal AccountBalance, int PinCode, int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            string Query = @"Update Clinets 
                             set AccountNumber = @AccountNumber,
                                 AccountBalance= @AccountBalance,
                                 PinCode        = @PinCode,
                                  PersonID      =@PersonID
                                 Where ClinetID= @ClinetID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ClinetID", ID);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            int RowAffected = 0;

            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();



            }
            catch
            {
                RowAffected = -1;
            }
            finally
            {
                connection.Close();
            }

            return (RowAffected > 0);


        }


        public static DataTable GetAllClinets()
        {
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            string Query = @"

select Clinets.ClinetID, Person.FirstName +  Person.LastName as FullNme , Person.PersonID  ,  Person.Phone , Person.Email ,Person.Gender , Person.BirthDay ,Person.Address,Person.Profile,
    Clinets.AccountNumber, Clinets.AccountBalance, Clinets.PinCode
from Clinets  join 
     Person on Clinets.PersonID = Person.PersonID    ";
            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    table.Load(reader);



                }
                reader.Close();
            }
            catch

            {

            }
            finally
            {
                connection.Close();

            }

            return table;
        }


        public static bool DeleteClinet(int ID)
        {
            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            string Query = "Delete   Clinets Where ClinetID=@ClinetID ";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ClinetID", ID);

            int rowAffected = 0;

            try
            {
                connection.Open();

                rowAffected = command.ExecuteNonQuery();
            }

            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return (rowAffected > 0);
        }

        public static DataTable GetTotalBalance()
        {
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            string Query = @"

select Clinets.ClinetID, Person.FirstName +  Person.LastName as FullNme , Person.PersonID  ,  Person.Phone , Person.Email , 
    Clinets.AccountNumber, Clinets.AccountBalance
from Clinets  join 
     Person on Clinets.PersonID = Person.PersonID    ";
            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    table.Load(reader);



                }
                reader.Close();
            }
            catch

            {

            }
            finally
            {
                connection.Close();

            }

            return table;
        }


        public static Decimal TotalBalances()
        {
            decimal Balances = 0;

            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            string Query = "select TotalBalances = sum (AccountBalance) from Clinets";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                object reslut = command.ExecuteScalar();

                if (reslut != null && decimal.TryParse(reslut.ToString(), out decimal InsretedID))
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


        public static int TotalClients()
        {
            int Balances = 0;

            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            string Query = "select TotalClinet = Count(ClinetID) from Clinets";

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
