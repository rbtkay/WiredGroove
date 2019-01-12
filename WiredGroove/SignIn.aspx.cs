using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WiredGroove.Database;

namespace WiredGroove
{
    public partial class SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignInID_Click(object sender, EventArgs e)
        {
            if(DataLayerFactory.Instance.CheckAccount(txtEmailID.Text, txtPasswordID.Text))
            {
                Session["signInEmail"] = txtEmailID.Text;
                Response.Redirect("sHomePage.aspx");
            }
            else
            {
                txtErrID.Style.Remove("visibility");
            }
        }
    }
}