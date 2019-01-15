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
    public partial class ViewProfile : System.Web.UI.Page
    {
        public string email;
        public static string accountEmail;
        protected void Page_Load(object sender, EventArgs e)
        {
            accountEmail = Request.QueryString["accountEmail"].ToString();
            if (!string.IsNullOrEmpty(Session["signInEmail"] as string))
            {
                email = Session["signInEmail"] as string;
                if (DataLayerFactory.Instance.CheckConnection(email, accountEmail))
                {
                    Session["connected"] = "isConnected";
                }
            }
        }

        [WebMethod]
        public static List<Media> GetMedia()
        {
            List<Media> accountMedia = DataLayerFactory.Instance.GetAccountMedia(accountEmail);
            return accountMedia;
        }

        protected void btnAddConnection_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(email))
            {
                DataLayerFactory.Instance.InsertConnection(email, accountEmail);
                Session["connected"] = "isConnected";
            }
            else
            {
                Response.Redirect("SignIn.aspx");
            }
        }

        private void InitializeComponent()
        {
            this.Unload += new System.EventHandler(this.ViewProfile_Unload);

        }

        private void ViewProfile_Unload(object sender, EventArgs e)
        {
            Session.Remove("connected");
        }
    }
}