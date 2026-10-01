using System;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace LibraryMembershipManagementSystem
{
    public partial class DeleteMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminID"] == null)
            {
                Response.Redirect("index.aspx");
            }

            if (!IsPostBack)
            {
                btnDelete.Visible = false;
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            if (txtMemberID.Text.Trim() == "")
            {
                lblMessage.Text = "Please enter Member ID.";
                btnDelete.Visible = false;
                return;
            }

            string cs = ConfigurationManager
                .ConnectionStrings["LMMSConnection"]
                .ConnectionString;

            string query = @"SELECT Name, Email, Class
                             FROM Members
                             WHERE MemberID = @MemberID";

            using (MySqlConnection con = new MySqlConnection(cs))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue(
                    "@MemberID",
                    txtMemberID.Text.Trim());

                try
                {
                    con.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblNameValue.Text = reader["Name"].ToString();
                            lblEmailValue.Text = reader["Email"].ToString();
                            lblClassValue.Text = reader["Class"].ToString();

                            lblMessage.Text = "Member details found.";

                            btnDelete.Visible = true;
                        }
                        else
                        {
                            lblNameValue.Text = "";
                            lblEmailValue.Text = "";
                            lblClassValue.Text = "";

                            lblMessage.Text = "Member ID not found.";

                            btnDelete.Visible = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Database Error: " + ex.Message;
                    btnDelete.Visible = false;
                }
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMemberID.Text.Trim() == "")
            {
                lblMessage.Text = "Please enter Member ID.";
                btnDelete.Visible = false;
                return;
            }

            string cs = ConfigurationManager
                .ConnectionStrings["LMMSConnection"]
                .ConnectionString;

            string query = "DELETE FROM Members WHERE MemberID = @MemberID";

            using (MySqlConnection con = new MySqlConnection(cs))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue(
                    "@MemberID",
                    txtMemberID.Text.Trim());

                try
                {
                    con.Open();

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        lblMessage.Text = "Member deleted successfully!";

                        txtMemberID.Text = "";
                        lblNameValue.Text = "";
                        lblEmailValue.Text = "";
                        lblClassValue.Text = "";

                        btnDelete.Visible = false;
                    }
                    else
                    {
                        lblMessage.Text = "Member ID not found.";
                        btnDelete.Visible = false;
                    }
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