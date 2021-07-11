using System.Data.SqlClient;
using System.Data;
using System;

namespace ATM

{
    public static class DatabaseHelper
    {
        public static SqlConnection GetDBConnection()
        {
            string connectionString = Properties.Settings.Default.connection_String;

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();

            return sqlConnection;
        }

        public static DataTable Get_DataTable(string SQL_Text)
        {
            SqlConnection sqlConnection = GetDBConnection();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(SQL_Text, sqlConnection);

            adapter.Fill(table);

            return table;
        }

        public static void Execute_SQL(string SQL_Text)
        {

            SqlConnection sqlConnection = GetDBConnection();

            SqlCommand sqlCommand = new SqlCommand(SQL_Text, sqlConnection);

            sqlCommand.ExecuteNonQuery();

        }

        public static void CloseDBConnection()
        {
            string connectionString = Properties.Settings.Default.connection_String;

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            if (sqlConnection.State != ConnectionState.Closed) sqlConnection.Close();

        }

        public static Account GetAccount(uint accountNumber)
        {
            Account account;   
            uint number;
            ushort pin;
            double balance;
            uint remainingLoginAttempts;
            bool locked;
        
            using (SqlConnection sqlConnection = GetDBConnection())
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Accounts WHERE Number = @accountNumber", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@accountNumber", accountNumber.ToString());
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        number = (uint)(int)reader.GetValue(reader.GetOrdinal("Number"));
                        pin = (ushort)(int)reader.GetValue(reader.GetOrdinal("Pin"));
                        balance = (double)reader.GetValue(reader.GetOrdinal("Balance"));
                        remainingLoginAttempts = (uint)(int)reader.GetValue(reader.GetOrdinal("RemainingLoginAttempts"));
                        locked = (bool)reader.GetValue(reader.GetOrdinal("Locked"));
                        account = new Account(number, pin, balance, remainingLoginAttempts, locked);
                    }
                    else
                    {
                        account = null;
                    }
                    reader.Close();
                }
            }

            CloseDBConnection();

            return account;
        }

        public static void UpdateAccount(Account newAccount)
        {

            using (SqlConnection sqlConnection = GetDBConnection())
            {
                SqlCommand sqlCommand = new SqlCommand("UPDATE Accounts SET Balance = @newBalance, RemainingLoginAttempts = @newRemainingLoginAttempts, Locked = @newLocked WHERE Number = @newAccountNumber", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@newAccountNumber", newAccount.Number.ToString());
                sqlCommand.Parameters.AddWithValue("@newBalance", newAccount.Balance.ToString());
                sqlCommand.Parameters.AddWithValue("@newRemainingLoginAttempts", newAccount.RemainingLoginAttempts.ToString());
                sqlCommand.Parameters.AddWithValue("@newLocked", newAccount.Locked.ToString());
                sqlCommand.ExecuteNonQuery();
            }

            CloseDBConnection();
        }
    }
}