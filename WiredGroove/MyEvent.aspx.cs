using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WiredGroove.Database;
using WiredGroove.Classes;
using System.Web.Services;

namespace WiredGroove
{
    public partial class MyEvent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(Session["signInEmail"] as String))
            {
                Response.Redirect("SignIn.aspx");
            }
        }

        [WebMethod]
        public static List<Event> GetMyEvent()
        {
            List<Event> eventList = DataLayerFactory.Instance.GetMyEvents(HttpContext.Current.Session["signInEmail"] as String);
            return eventList;
        }
    }
}