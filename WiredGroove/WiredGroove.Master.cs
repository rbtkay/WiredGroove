using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WiredGroove.Database;

namespace WiredGroove
{
    public partial class WiredGroove : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Session["signInEmail"] as string))
            {
                namePlaceHolder.InnerText = DataLayerFactory.Instance.GetAccountName(Session["signInEmail"] as string);
                namePlaceHolder.InnerHtml += "<span class=\"caret\" style=\"color: white; \"></span>";
            }
        }
    }
}