using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using WiredGroove.Classes;
using System.IO;

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

            string emailAccount = email;
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
                    InsertPicture(emailAccount);
                }
            }
        }

        public void InsertPicture(string accountEmail)
        {
            //string imgPath = "../Images/BasicAccount.png";
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            try
            {
                string query1 = "update Account_T " +
                                        "set Account_Picture = " +
                                        "(SELECT BulkColumn " +
                                        "FROM Openrowset(Bulk 'D:/AUST/Web Prog/WiredGroove/WiredGroove/Images/BasicAccount.png', Single_Blob) as img)" +
                                        "where Account_Email = @email";

                SqlCommand cmd = new SqlCommand(query1, connection);
                //cmd.Parameters.AddWithValue("@imgPath", imgPath);
                cmd.Parameters.AddWithValue("@email", accountEmail);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                connection.Close();
            }

        }

        public string GetAccountName(string email)
        {
            string returnString = string.Empty;
            SqlConnection conn = new SqlConnection(_connectionString);
            try
            {
                string query = "select Account_FullName from Account_T where Account_Email = @EMAIL";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EMAIL", email);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    returnString = sdr[0] as string;
                    break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return returnString;
        }

        public bool CheckAccount(string email, string password)
        {
            bool isAuthentic = false;
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            try
            {
                string query = "select Account_Email, Account_FullName, Account_Password from Account_T";

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

        public bool InsertArtist(string email, string name, string instrument, string genre, string portfolio, string address, string band, string additionalInfo)
        {
            bool status;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "insert into Artist_T values (@EMAIL, @NAME, @INSTRUMENT, @GENRE, @PORTFOLIO, @ADDRESS, @BAND, @ADDITIONALINFO)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EMAIL", email);
                    cmd.Parameters.AddWithValue("@NAME", name);
                    cmd.Parameters.AddWithValue("@INSTRUMENT", instrument);
                    cmd.Parameters.AddWithValue("@GENRE", genre);
                    cmd.Parameters.AddWithValue("@PORTFOLIO", portfolio);
                    cmd.Parameters.AddWithValue("@ADDRESS", address);
                    cmd.Parameters.AddWithValue("@BAND", band);
                    cmd.Parameters.AddWithValue("@ADDITIONALINFO", additionalInfo);

                    cmd.ExecuteNonQuery();
                    status = true;
                }
                catch (Exception ex)
                {
                    status = false;
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }

            return status;

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
                string query = "select Account_Email, Artist_Name, Artist_Instrument, Artist_Genre, Artist_Band from Artist_T";

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PopularArtist artist = new PopularArtist();
                    artist.artistName = reader["Artist_Name"].ToString();
                    artist.artistInstrument = reader["Artist_Instrument"].ToString();
                    artist.artistGenre = reader["Artist_Genre"].ToString();
                    artist.artistBand = reader["Artist_Band"].ToString();
                    artist.artistPicture = GetPictureArtist(reader["Account_Email"].ToString());
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

        public string GetPictureArtist(string artistEmail)
        {
            string imgString = string.Empty;
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            try
            {
                string query = "select Account_Picture from Account_T where Account_Email = @email and Account_Picture is NOT NULL";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@email", artistEmail);

                byte[] bytes;

                if (cmd.ExecuteScalar() != null)
                {
                    bytes = (byte[])cmd.ExecuteScalar();
                    imgString = "data:Image/png;base64," + Convert.ToBase64String(bytes);
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
            return imgString;
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

        public void UploadMedia(string email, string name, string caption, string filePath, string fileType)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            try
            {
                string query = "insert into Media_T (Account_Email, Media_Name, Media_Caption, Media_Path, Media_Type) values (@email, @name, @caption, @path, @fileType)";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@caption", caption);
                cmd.Parameters.AddWithValue("@path", filePath);
                cmd.Parameters.AddWithValue("@fileType", fileType);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                connection.Close();
            }


        }

        public List<Media> GetAllMedia()
        {
            List<Media> mediaList = new List<Media>();

            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            try
            {
                string query = "select Account_Email, Media_Name, Media_Caption, Media_LikesCount, Media_Path, Media_Type from Media_T";

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Media media = new Media();
                    media.email = reader["Account_Email"].ToString();
                    media.name = reader["Media_Name"].ToString();
                    media.caption = reader["Media_Caption"].ToString();
                    media.media = reader["Media_Path"].ToString().Substring(1);
                    if (!String.IsNullOrEmpty(reader["Media_LikesCount"].ToString()))
                        media.countLikes = Int32.Parse(reader["Media_LikesCount"].ToString());
                    media.type = reader["Media_Type"].ToString();
                    mediaList.Add(media);
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

            return mediaList;
        }

        public string GetPictureMedia(int id)
        {
            string imgString = string.Empty;
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            try
            {
                //string haha = "caroline@gmail.com";
                string query = "select Media_Image from Media_T where Media_ID = @id";

                SqlCommand cmd = new SqlCommand(query, connection);
                //cmd.Parameters.AddWithValue("@email", haha);
                cmd.Parameters.AddWithValue("@id", id);

                byte[] bytes;

                if (cmd.ExecuteScalar() != null)
                {
                    bytes = (byte[])cmd.ExecuteScalar();
                    imgString = "data:Image/png;base64," + bytes.ToString();
                }
                //imgString = "hello";
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                connection.Close();
            }
            return imgString;
        }

        public List<PopularArtist> SearchResultArtist(string name, string genre, string location, string instrument)
        {
            List<PopularArtist> artistList = new List<PopularArtist>();

            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            try
            {
                string query = "select * from Artist_T " +
                    "where Artist_Name = @name OR " +
                    "Artist_Genre = @genre OR " +
                    "Artist_address = @location OR " +
                    "Artist_Instrument = @instrument";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@genre", genre);
                cmd.Parameters.AddWithValue("@location", location);
                cmd.Parameters.AddWithValue("@instrument", instrument);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PopularArtist artist = new PopularArtist();

                    artist.artistName = reader["Artist_Name"].ToString();
                    artist.artistGenre = reader["Artist_Genre"].ToString();
                    artist.artistAddress = reader["Artist_Address"].ToString();
                    artist.artistInstrument = reader["Artist_Instrument"].ToString();

                    artistList.Add(artist);
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

            return artistList;
        }

        public bool CreateEvent(string email, string name, string startDate, string endDate, string location, int capacity, string type, float price, float budget, string genre)
        {
            bool status;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "insert into Event_T (Event_HostEmail, Event_Name, Event_StartDate, Event_EndDate, Event_Location, Event_Capacity, Event_Type, Event_Price, Event_Budget, Event_Genre) " +
                                   "values (@EMAIL, @NAME, @STARTDATE, @ENDDATE, @LOCATION, @CAPACITY, @TYPE, @PRICE, @BUDGET, @GENRE)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EMAIL", email);
                    cmd.Parameters.AddWithValue("@NAME", name);
                    cmd.Parameters.AddWithValue("@STARTDATE", startDate);
                    cmd.Parameters.AddWithValue("@ENDDATE", endDate);
                    cmd.Parameters.AddWithValue("@LOCATION", location);
                    cmd.Parameters.AddWithValue("@CAPACITY", capacity);
                    cmd.Parameters.AddWithValue("@TYPE", type);
                    cmd.Parameters.AddWithValue("@PRICE", price);
                    cmd.Parameters.AddWithValue("@BUDGET", budget);
                    cmd.Parameters.AddWithValue("@GENRE", genre);

                    cmd.ExecuteNonQuery();
                    status = true;
                }
                catch (Exception ex)
                {
                    status = false;
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }

            }
            return status;
        }

        public List<Connection> GetListConnection(string email)
        {
            List<Connection> listConnection = new List<Connection>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "select Account_T.Account_FullName from Account_T where Account_T.Account_Email in " +
                        "(select distinct Connection_T.Connection_Email from Connection_T where Connection_T.Account_Email = @EMAIL)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EMAIL", email);
                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        Connection connection = new Connection();
                        connection.destinationName = sdr["Account_FullName"].ToString();
                        listConnection.Add(connection);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }

                return listConnection;
            }
        }

        public List<Message> GetListMessage(int connectionID)
        {
            List<Message> listMessage = new List<Message>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "select * from Message_T where Connection_ID = @CONNECTIONID order by Message_Timestamp desc";


                    //string query = "select * from Message_T where Message_T.Connection_ID = " + 
                    //    "(select Connection_T.Connection_ID from Connection_T where Connection_T.Account_Email =  @EMAIL " +
                    //    ""
                    //in " +
                    //           "(select Connection_T.Connection_ID where " +
                    //           "(Connection_T.Account_Email = @EMAIL and Connection_T.Connection_Email = @DESTINATION) OR " +
                    //           "(Connection_T.Account_Email = @DESTINATION and Connection_T.Connection_Email = @EMAIL)) " +
                    //           "order by Message_Timestamp desc";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CONNECTIONID", connectionID);
                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        Message msg = new Message();
                        msg.messageSender = sdr["Account_Email"].ToString();
                        msg.messageContent = sdr["Message_Content"].ToString();
                        msg.messageTimestamp = sdr["Message_Timestamp"].ToString();
                        listMessage.Add(msg);
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }

            return listMessage;
        }

        public int GetConnectionID(string email, string destination)
        {
            int id = 0;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "select Connection_ID from Connection_T where " +
                                   "(Account_Email = @EMAIL and Connection_Email = @DESTINATION) or " +
                                   "(Account_Email = @DESTINATION and Connection_Email = @EMAIL);";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EMAIL", email);
                    cmd.Parameters.AddWithValue("@DESTINATION", destination);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        id = Int32.Parse(sdr["Connection_ID"].ToString());
                    }
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            return id;
        }
    }
}







