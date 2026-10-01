using System;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace LibraryMembershipManagementSystem
{
    public partial class ViewMembers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminID"] == null)
            {
                Response.Redirect("index.aspx");
            }

            if (!IsPostBack)
            {
                LoadMembers();
            }
        }

        private void LoadMembers()
        {
            string cs = ConfigurationManager
                .ConnectionStrings["LMMSConnection"]
                .ConnectionString;

            string query = @"SELECT MemberID, Name, Email, Class, Verified
                             FROM Members";

            using (MySqlConnection con = new MySqlConnection(cs))
            using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
            {
                DataTable dt = new DataTable();

                da.Fill(dt);

                gvMembers.DataSource = dt;
                gvMembers.DataBind();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchID.Text.Trim() == "")
            {
                lblMessage.Text = "Please enter Member ID.";
                gvMembers.DataSource = null;
                gvMembers.DataBind();
                return;
            }

            string cs = ConfigurationManager
                .ConnectionStrings["LMMSConnection"]
                .ConnectionString;

            string query = @"SELECT MemberID, Name, Email, Class, Verified
                             FROM Members
                             WHERE MemberID = @MemberID";

            using (MySqlConnection con = new MySqlConnection(cs))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue(
                    "@MemberID",
                    txtSearchID.Text.Trim()
                );

                DataTable dt = new DataTable();

                try
                {
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        gvMembers.DataSource = dt;
                        gvMembers.DataBind();

                        lblMessage.Text = "Member found.";
                    }
                    else
                    {
                        gvMembers.DataSource = null;
                        gvMembers.DataBind();

                        lblMessage.Text = "Member ID not found.";
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Database Error: " + ex.Message;
                }
            }
        }

        protected void btnViewAll_Click(object sender, EventArgs e)
        {
            txtSearchID.Text = "";
            lblMessage.Text = "";

            LoadMembers();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}