using System;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace LibraryMembershipManagementSystem
{
    public partial class AddMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminID"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                lblMessage.Text = "Please enter member name.";
                return;
            }

            string cs = ConfigurationManager
                .ConnectionStrings["LMMSConnection"]
                .ConnectionString;

            string query = @"INSERT INTO Members
                            (Name, Email, Class, Verified)
                            VALUES
                            (@Name, @Email, @Class, 'No')";

            using (MySqlConnection con = new MySqlConnection(cs))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@Class", txtClass.Text.Trim());

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();

                    lblMessage.Text = "Member added successfully!";

                    txtName.Text = "";
                    txtEmail.Text = "";
                    txtClass.Text = "";
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Database Error: " + ex.Message;
                }
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}