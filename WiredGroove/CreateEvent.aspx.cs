using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WiredGroove.Database;

namespace WiredGroove
{
    public partial class CreateEvent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreateEvent_Click(object sender, EventArgs e)
        {
            string email = Session["signInEmail"] as string;
            string name = txtEventName.Text;
            string startDate = txtStartDate.Text;
            string endDate = txtEndDate.Text;
            string location = ddlLocation.SelectedValue;
            int capacity = Int32.Parse(txtCapacity.Text);
            string type = ddlType.SelectedValue;
            float price = float.Parse(txtPrice.Text);
            float budget = float.Parse(txtBudget.Text);
            string genre = ddlGenre.SelectedValue;

            if (!string.IsNullOrEmpty(name) && 
                !string.IsNullOrEmpty(startDate) && 
                !string.IsNullOrEmpty(endDate) && 
                !string.IsNullOrEmpty(location))
            {
                if (DataLayerFactory.Instance.CreateEvent(email, name, startDate, endDate, location, capacity, type, price, budget, genre))
                {
                    Response.Redirect("sHomePage.aspx");
                }
            }
        }
    }
}