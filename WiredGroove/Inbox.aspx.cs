using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using WiredGroove.Database;
using WiredGroove.Classes;
using System.Web.Services;
using System.IO;

namespace WiredGroove
{
    public partial class Inbox : System.Web.UI.Page
    {
        string email = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Request.QueryString["id"] = Session["signInEmail"] as string;
        }

        [WebMethod]
        public static List<Connection> GetConnections()
        {
            List<Connection> connectionList = DataLayerFactory.Instance.GetListConnection(HttpContext.Current.Session["signInEmail"] as string);
            return connectionList;
        }
    }
}