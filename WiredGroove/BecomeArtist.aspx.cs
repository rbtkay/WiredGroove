using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WiredGroove.Database;

namespace WiredGroove
{
    public partial class BecomeArtist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session["signInEmail"] as string))
            {
                Response.Redirect("SignIn.aspx");
            }

            if (IsPostBack)
            {
                smWrong.InnerText = "Oops! Something went wrong...";
            }

            txtEmail.Text = Session["signInEmail"] as string;
        }

        protected void btnBecome_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string name = txtName.Text;
            string instrument = txtInstrument.Text;
            string genre = ddlGenre.Text;
            string portfolio = txtPortfolio.Text;
            string address = txtAddress.Text;
            string band = txtBand.Text;
            string additionalInfo = txtAdditionalInfo.Text;


            if (!string.IsNullOrEmpty(name) &&
                !string.IsNullOrEmpty(instrument) &&
                !string.IsNullOrEmpty(genre) && // << to change this to read from listbox instead of ddl
                !string.IsNullOrEmpty(portfolio) &&
                !string.IsNullOrEmpty(address) &&
                !string.IsNullOrEmpty(additionalInfo))
            {
                if (DataLayerFactory.Instance.InsertArtist(email, name, instrument, genre, portfolio, address, band, additionalInfo))
                {
                    Session["musician"] = "musician";
                    Response.Redirect("sHomePage.aspx");
                }
                else
                {

                }
            }
        }
    }
}