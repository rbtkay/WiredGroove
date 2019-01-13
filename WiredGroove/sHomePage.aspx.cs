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

namespace WiredGroove
{
    public partial class sHomePage : System.Web.UI.Page
    {
        public static string emailLogIn;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Session["signInEmail"] as string))
            {
                Response.Redirect("SignIn.aspx");
            }
            else
            {
                if (!(String.IsNullOrEmpty(Session["musician"] as string)))
                    hiddenField.Value = Session["musician"].ToString();
            }


        }

        [WebMethod]
        public static List<PopularArtist> GetArtists()
        {
            List<PopularArtist> artistList = DataLayerFactory.Instance.GetPopularArtist();
            return artistList;
            //string artistList = "Cats";
            //JavaScriptSerializer js = new JavaScriptSerializer();
            //js.Serialize(artistList);
            //var employers = _employerRepository.GetByTaxId(taxId).ToList();
            //var agencies = _employerRepository.GetByTaxId(taxId).Select(e => e.GeneralAgency).ToArray();
            //return Json(new { success = true, employers, agencies }, JsonRequestBehavior.AllowGet);
        }

        [WebMethod]
        public static List<Event> GetListJobs()
        {
            List<Event> artistList = DataLayerFactory.Instance.GetJobOffers();
            return artistList;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}