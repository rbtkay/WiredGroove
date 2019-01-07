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

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            string email = txtEmailID.Text;
            string name = txtFullNameID.Text;
            string phone = txtPhoneID.Text;
            string password = txtPasswordID.Text;
            string dob = txtDoBID.Text;
            string preferences = ddlPreferencesID.Text; // to change this to read from list instead of ddl when genres implemented

            if (!string.IsNullOrEmpty(email) &&
                !string.IsNullOrEmpty(name) &&
                !string.IsNullOrEmpty(phone) &&
                !string.IsNullOrEmpty(password) &&
                !string.IsNullOrEmpty(dob) &&
                !string.IsNullOrEmpty(preferences))
            {
                DataLayerFactory.Instance.InsertAccount(email, name, phone, password, dob, preferences);
                txtEmailID.Text = "";
                txtFullNameID.Text = "";
                txtPhoneID.Text = "";
                txtPasswordID.Text = "";
                txtDoBID.Text = "";
                txtConfirmPasswordID.Text = "";
            }
        }
    }
}