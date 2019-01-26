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
        public static int connectionID;

        protected void Page_Load(object sender, EventArgs e)
        {
            connectionID = Int32.Parse(Request.QueryString["connectionId"].ToString());
            //destinationEmail = Request.QueryString["Connection_Email"].ToString();
            if (!String.IsNullOrEmpty(Session["signInEmail"].ToString()))
            {
                HiddenSenderEmail.Value = Session["signInEmail"].ToString();
            }
        }

        protected void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMessageContent.Text))
            {
                string content = txtMessageContent.Text;
                string senderName = DataLayerFactory.Instance.GetAccountName(Session["signInEmail"] as string);
                string senderEmail = Session["signInEmail"] as string;

                DataLayerFactory.Instance.InsertMessage(connectionID, content, senderName, senderEmail);
                txtMessageContent.Text = String.Empty;
            }
        }

        [WebMethod]
        public static List<Message> GetMessages()
        {
            List<Message> messageList = DataLayerFactory.Instance.GetListMessage(connectionID);
            return messageList;
        }
    }
}