using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WiredGroove
{
    public partial class test1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = LoadData();
            GridView1.DataBind();
            if (IsPostBack)
            {
                Response.Write("Session" + Session["test"].ToString());
            }
                
        }

        public DataTable LoadData()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-HI71AFPV;Initial Catalog=WiredGrooveDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();

            string query = "select Artist_Name from Artist_T where Account_Email in " +
                "(select Account_Email from Artist_Events_T where Event_ID in " +
                "(select Event_ID from Event_T where Event_HostEmail = @email))";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@email", "kevin@gmail.com");

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            connection.Close();

            return dt;
        }
    }
}