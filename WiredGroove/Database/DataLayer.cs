using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using WiredGroove.Classes;

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

        public bool CheckAccount(string email, string password)
        {
            bool isAuthentic = false;
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            try
            {
                string query = "select Account_Email, Account_Password from Account_T";

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
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                connection.Close();
            }

            return isAuthentic;
        }

        public bool IsMusician(string email)
        {
            bool isMusician = false;
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            try
            {
                string query = "select Account_Email from Artist_T";

                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["Account_Email"].ToString() == email)
                    {
                        isMusician = true;
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                connection.Close();
            }

            return isMusician;
        }

        //public List<PopularArtist>

        public List<PopularArtist> GetPopularArtist()
        {
            List<PopularArtist> listArtist = new List<PopularArtist>();

            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            try
            {
                string query = "select Artist_Name, Artist_Instrument, Artist_Genre, Artist_Band from Artist_T";

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PopularArtist artist = new PopularArtist();
                    artist.artistName = reader["Artist_Name"].ToString();
                    artist.artistInstrument = reader["Artist_Instrument"].ToString();
                    artist.artistGenre = reader["Artist_Genre"].ToString();
                    artist.artistBand = reader["Artist_Band"].ToString();
                    listArtist.Add(artist);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                connection.Close();
            }

            return listArtist;
        }

        public List<Event> GetJobOffers()
        {
            List<Event> eventList = new List<Event>();

            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            try
            {
                string query = "select Event_Name, Event_Type, Event_StartDate, Event_EndDate, Event_Location from Event_T";

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Event job = new Event();
                    job.eventName = reader["Event_Name"].ToString();
                    job.eventType = reader["Event_Type"].ToString();
                    job.eventDateStart = (DateTime)reader["Event_StartDate"];
                    job.eventDateEnd = (DateTime)reader["Event_EndDate"];
                    eventList.Add(job);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                connection.Close();
            }

            return eventList;
        }


        //Not Used Yet 
        public string GetUserLocation(string email)
        {
            string userLocation;

            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            try
            {
                string query = "select Artist_Address from Artist_T where Account_Email = @email";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@email", email);
                SqlDataReader reader = cmd.ExecuteReader();
                userLocation = reader.ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                connection.Close();
            }
            return userLocation;
        }

    }
}







