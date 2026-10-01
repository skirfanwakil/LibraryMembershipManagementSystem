using System;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace LibraryMembershipManagementSystem
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminID"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtCurrentPassword.Text.Trim() == "")
            {
                lblMessage.Text = "Please enter current password.";
                return;
            }

            if (txtNewPassword.Text.Trim() == "")
            {
                lblMessage.Text = "Please enter new password.";
                return;
            }

            if (txtConfirmPassword.Text.Trim() == "")
            {
                lblMessage.Text = "Please confirm new password.";
                return;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                lblMessage.Text = "New passwords do not match.";
                return;
            }

            string adminID = Session["AdminID"].ToString();

            string cs = ConfigurationManager
                .ConnectionStrings["LMMSConnection"]
                .ConnectionString;

            using (MySqlConnection con = new MySqlConnection(cs))
            {
                try
                {
                    con.Open();

                    string checkQuery = @"SELECT COUNT(*)
                                          FROM Admin
                                          WHERE AdminID = @AdminID
                                          AND Password = @Password";

                    using (MySqlCommand checkCmd =
                           new MySqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue(
                            "@AdminID", adminID);

                        checkCmd.Parameters.AddWithValue(
                            "@Password", txtCurrentPassword.Text);

                        int count = Convert.ToInt32(
                            checkCmd.ExecuteScalar());

                        if (count == 0)
                        {
                            lblMessage.Text = "Current password is incorrect.";
                            return;
                        }
                    }

                    string updateQuery = @"UPDATE Admin
                                           SET Password = @NewPassword
                                           WHERE AdminID = @AdminID";

                    using (MySqlCommand updateCmd =
                           new MySqlCommand(updateQuery, con))
                    {
                        updateCmd.Parameters.AddWithValue(
                            "@NewPassword", txtNewPassword.Text);

                        updateCmd.Parameters.AddWithValue(
                            "@AdminID", adminID);

                        updateCmd.ExecuteNonQuery();
                    }

                    lblMessage.Text = "Password changed successfully!";

                    txtCurrentPassword.Text = "";
                    txtNewPassword.Text = "";
                    txtConfirmPassword.Text = "";
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