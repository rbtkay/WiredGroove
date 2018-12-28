using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WiredGroove.Database
{
    public class DataLayer : IDataLayer
    {
        string _connectionString;

        public DataLayer(string connectionString)
        {
            _connectionString = connectionString;
        }

    }
}