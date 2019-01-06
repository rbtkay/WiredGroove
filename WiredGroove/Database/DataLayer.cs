using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WiredGroove.Database
{
    public class DataLayer : IDataLayer
    {
        string _connectionString;

        public DataLayer(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool CheckAccount(string email, string password)
        {
            bool isAuthentic = false;
            SqlConnection connection = new SqlConnection(_connectionString);
            string query = "select Account_Email, Account_Password from Account_T";
            connection.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);


                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["Account_Email"].ToString() == email && reader["Account_Password"].ToString() == password)
                    {
                        isAuthentic = true;
                        break;
                    }
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return isAuthentic;
        }

    }
}