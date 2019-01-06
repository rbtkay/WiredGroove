﻿using System;
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

        public void InsertAccount(string email, string name, string phone, string password, string dob, string preferences)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    string query = "insert into Account_T (Account_Email, Account_FullName, Account_Phone, Account_Password, Account_DoB, Account_Preferences)" +
                                   "values (@EMAIL, @FULLNAME, @PHONE, @PASSWORD, @DOB, @PREFERENCES)";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EMAIL", email);
                    cmd.Parameters.AddWithValue("@FULLNAME", name);
                    cmd.Parameters.AddWithValue("@PHONE", phone);
                    cmd.Parameters.AddWithValue("@PASSWORD", password);
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.Parameters.AddWithValue("@PREFERENCES", preferences);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

    }
}