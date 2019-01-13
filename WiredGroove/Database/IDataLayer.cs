using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WiredGroove.Classes;

namespace WiredGroove.Database
{
    public interface IDataLayer
    {
        void InsertAccount(string email, string name, string phone, string password, string dob, string preferences);
        bool CheckAccount(string email, string password);
        List<PopularArtist> GetPopularArtist();
        bool IsMusician(string email);
        List<Event> GetJobOffers();
    }

    public class DataLayerFactory
    {
        private static IDataLayer _instance;
        private static object _locker = new object();

        public static IDataLayer Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_locker)
                    {
                        if (_instance == null)
                        {
                            string connectionString = "Data Source=LAPTOP-HI71AFPV;Initial Catalog=WiredGrooveDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            _instance = new DataLayer(connectionString);
                        }
                    }
                }
                return _instance;
            }
        }
    }
}