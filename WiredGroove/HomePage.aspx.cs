using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WiredGroove
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Session["signInEmail"] as string))
            {
                Response.Redirect("sHomePage.aspx");
            }
        }

        protected void btnLookupID_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtArtistNameID.Text) || !String.IsNullOrEmpty(txtLocationID.Text) ||
                !String.IsNullOrEmpty(txtInstrumentID.Text) || !String.IsNullOrEmpty(ddlGenreID.Text))
            {
                Session["searchName"] = txtArtistNameID.Text;
                Session["searchGenre"] = ddlGenreID.Text;
                Session["searchLocation"] = txtLocationID.Text;
                Session["searchInstrument"] = txtInstrumentID.Text;
                Response.Redirect("SearchResult.aspx");
            }
        }
    }
}