using WiredGroove.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            string preferences = ddlPreferencesID.Text;

            if (!string.IsNullOrEmpty(email))
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