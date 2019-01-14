using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WiredGroove.Database;

namespace WiredGroove
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Session["pass"] as string))
            {
                hiddenPass.InnerHtml = Session["pass"] as string;
            }
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            string email = txtEmailID.Text;
            string name = txtFullNameID.Text;
            string phone = txtPhoneID.Text;
            string password = txtPasswordID.Text;
            string confirmPassword = txtConfirmPasswordID.Text;
            string dob = txtDoBID.Text;
            string preferences = string.Empty;
            List <string> prefList = new List<string>();
            foreach(ListItem item in lbPreferencesID.Items)
            {
                preferences += item.Text + " ";
            }

            if (!string.IsNullOrEmpty(email) &&
                !string.IsNullOrEmpty(name) &&
                !string.IsNullOrEmpty(phone) &&
                !string.IsNullOrEmpty(password) &&
                !string.IsNullOrEmpty(confirmPassword) &&
                !string.IsNullOrEmpty(dob))
            {
                DataLayerFactory.Instance.InsertAccount(email, name, phone, password, dob, preferences);
                Session["signInEmail"] = txtEmailID.Text;
                Session.Remove("pass");
                Response.Redirect("sHomePage.aspx");
            }
        }

        protected void ddlPreferencesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!lbPreferencesID.Items.Contains(ddlPreferencesID.SelectedItem) && ddlPreferencesID.SelectedValue != "--Select Genre--")
            {
                lbPreferencesID.Items.Add(ddlPreferencesID.SelectedValue);
            }
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbPreferencesID.SelectedItem != null)
            {
                lbPreferencesID.Items.Remove(lbPreferencesID.SelectedItem);
            }
        }

        protected void txtPasswordID_TextChanged(object sender, EventArgs e)
        {
            Session["pass"] = txtPasswordID.Text;
            hiddenPass.InnerHtml = Session["pass"] as string;
        }
    }
}