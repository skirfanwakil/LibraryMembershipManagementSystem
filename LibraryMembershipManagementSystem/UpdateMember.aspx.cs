using System;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace LibraryMembershipManagementSystem
{
    public partial class UpdateMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminID"] == null)
            {
                Response.Redirect("index.aspx");
            }

            if (!IsPostBack)
            {
                HideUpdateFields();
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            if (txtMemberID.Text.Trim() == "")
            {
                lblMessage.Text = "Please enter Member ID.";
                HideUpdateFields();
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
                            // Show current member details
                            lblDetails.Visible = true;

                            lblCurrentName.Visible = true;
                            lblNameValue.Visible = true;
                            lblNameValue.Text = reader["Name"].ToString();

                            lblCurrentEmail.Visible = true;
                            lblEmailValue.Visible = true;
                            lblEmailValue.Text = reader["Email"].ToString();

                            lblCurrentClass.Visible = true;
                            lblClassValue.Visible = true;
                            lblClassValue.Text = reader["Class"].ToString();

                            // Put current values into editable fields
                            txtName.Text = reader["Name"].ToString();
                            txtEmail.Text = reader["Email"].ToString();
                            txtClass.Text = reader["Class"].ToString();

                            // Show update fields
                            lblUpdateDetails.Visible = true;

                            lblName.Visible = true;
                            txtName.Visible = true;

                            lblEmail.Visible = true;
                            txtEmail.Visible = true;

                            lblClass.Visible = true;
                            txtClass.Visible = true;

                            btnUpdate.Visible = true;

                            lblMessage.Text = "Member details found.";
                        }
                        else
                        {
                            lblMessage.Text = "Member ID not found.";
                            HideUpdateFields();
                        }
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Database Error: " + ex.Message;
                    HideUpdateFields();
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMemberID.Text.Trim() == "")
            {
                lblMessage.Text = "Please enter Member ID.";
                return;
            }

            if (txtName.Text.Trim() == "")
            {
                lblMessage.Text = "Please enter Name.";
                return;
            }

            string cs = ConfigurationManager
                .ConnectionStrings["LMMSConnection"]
                .ConnectionString;

            string query = @"UPDATE Members
                             SET Name = @Name,
                                 Email = @Email,
                                 Class = @Class
                             WHERE MemberID = @MemberID";

            using (MySqlConnection con = new MySqlConnection(cs))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue(
                    "@MemberID",
                    txtMemberID.Text.Trim());

                cmd.Parameters.AddWithValue(
                    "@Name",
                    txtName.Text.Trim());

                cmd.Parameters.AddWithValue(
                    "@Email",
                    txtEmail.Text.Trim());

                cmd.Parameters.AddWithValue(
                    "@Class",
                    txtClass.Text.Trim());

                try
                {
                    con.Open();

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        lblMessage.Text = "Member updated successfully!";

                        // Update displayed current details
                        lblNameValue.Text = txtName.Text.Trim();
                        lblEmailValue.Text = txtEmail.Text.Trim();
                        lblClassValue.Text = txtClass.Text.Trim();
                    }
                    else
                    {
                        lblMessage.Text = "Member ID not found.";
                        HideUpdateFields();
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

        private void HideUpdateFields()
        {
            lblDetails.Visible = false;

            lblCurrentName.Visible = false;
            lblNameValue.Visible = false;

            lblCurrentEmail.Visible = false;
            lblEmailValue.Visible = false;

            lblCurrentClass.Visible = false;
            lblClassValue.Visible = false;

            lblUpdateDetails.Visible = false;

            lblName.Visible = false;
            txtName.Visible = false;

            lblEmail.Visible = false;
            txtEmail.Visible = false;

            lblClass.Visible = false;
            txtClass.Visible = false;

            btnUpdate.Visible = false;
        }
    }
}