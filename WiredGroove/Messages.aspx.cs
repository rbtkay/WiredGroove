using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WiredGroove.Database;
using WiredGroove.Classes;
using System.Web.Services;
using System.IO;

namespace WiredGroove
{
    public partial class Messages : System.Web.UI.Page
    {
        static string email;
        static string destinationEmail;
        protected void Page_Load(object sender, EventArgs e)
        {
            email = Session["signInEmail"] as string;
            destinationEmail = Request.QueryString["Connection_Email"].ToString();
        }

        [WebMethod]
        public static List<Message> GetMessages()
        {
            int connectionID = DataLayerFactory.Instance.GetConnectionID(email, destinationEmail);
            List<Message> messageList = DataLayerFactory.Instance.GetListMessage(connectionID);
            return messageList;            
        }
    }
}