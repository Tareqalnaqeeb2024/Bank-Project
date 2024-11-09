using System;
using System.Data;
using System.Data.SqlClient;

namespace BankDataAccess
{
    public class ClsTransferLogRagisterData
    {
        public static int AddNewTransferLogRegister(  DateTime date , int SourceClinetID , int DestinationClinetID , 
             decimal Amount , int UserID , decimal SourceAccountBalance ,decimal DestinationAccountBalance)
        {

            int TransferLogin = -1;

            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            string Query = @"Insert Into TransferLogRegister
                (DateTime,SourceClientID,DestinationClinetID,Amount,UserID,SourceAccountBalance,DestinationAccountBalance)
               Values  (@DateTime,@SourceClientID,@DestinationClinetID,@Amount,@UserID,@SourceAccountBalance,@DestinationAccountBalance)
                    select Scope_Identity(); ";


            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@DateTime", date);
            command.Parameters.AddWithValue("@SourceClientID", SourceClinetID);
            command.Parameters.AddWithValue("@DestinationClinetID", DestinationClinetID);
            command.Parameters.AddWithValue("@Amount",Amount);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@SourceAccountBalance", SourceAccountBalance);
            command.Parameters.AddWithValue("@DestinationAccountBalance", DestinationAccountBalance);


            try
            {
                connection.Open();

                object reslut = command.ExecuteScalar();
                
                if(reslut != null && int.TryParse(reslut.ToString() ,out int InsertedID))
                {
                    TransferLogin = InsertedID;

                }
            }catch
            {
                TransferLogin = -1;
            }finally
            {
                connection.Close();
            }
            return TransferLogin;

            
        }
    
     public static DataTable GetAllTranferLogRegister()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            string Query = " Select * From TransferLogRegister";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    dataTable.Load(reader);

                }
            }catch
            {

            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }
     
     public static bool GetRegisterByID(int ID ,ref DateTime date, ref  int SourceClinetID, ref int DestinationClinetID,
            ref decimal Amount, ref int UserID, ref decimal SourceAccountBalance, ref decimal DestinationAccountBalance)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            string Query = "select from TransferLogRegister where ID =@ID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    date = (DateTime)reader["DateTime"];
                    SourceClinetID = (int)reader["SourceClientID"];
                    DestinationClinetID = (int)reader["DestinationClinetID"];
                    Amount = (decimal)reader["Amount"];
                    UserID = (int)reader["UserID"];
                    SourceAccountBalance = (decimal)reader["SourceAccountBalance"];
                    DestinationAccountBalance = (decimal)reader["DestinationAccountBalance"];

                    reader.Close();


                }

            }catch
            {
                isFound = false;
            }finally
            {
                connection.Close();
            }
            return isFound;

        }

        public static int TotalTransferLog()
        {
            int Balances = 0;

            SqlConnection connection = new SqlConnection(clsBankSettings.ConnectionString);

            string Query = "select countTransferLogRegister = Count(ID) from TransferLogRegister";

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
