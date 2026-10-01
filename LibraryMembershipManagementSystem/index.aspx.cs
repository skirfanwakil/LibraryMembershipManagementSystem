using System;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace LibraryMembershipManagementSystem
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string adminID = txtAdminID.Text.Trim();
            string password = txtPassword.Text;

            if (adminID == "" || password == "")
            {
                lblMessage.Text = "Please enter Admin ID and Password.";
                return;
            }

            string cs = ConfigurationManager
                .ConnectionStrings["LMMSConnection"]
                .ConnectionString;

            string query = @"SELECT COUNT(*)
                             FROM Admin
                             WHERE AdminID = @AdminID
                             AND Password = @Password";

            using (MySqlConnection con = new MySqlConnection(cs))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@AdminID", adminID);
                cmd.Parameters.AddWithValue("@Password", password);

                try
                {
                    con.Open();

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {
                        Session["AdminID"] = adminID;
                        Response.Redirect("Home.aspx");
                    }
                    else
                    {
                        lblMessage.Text = "Invalid Admin ID or Password.";
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Database Error: " + ex.Message;
                }
            }
        }
    }
}