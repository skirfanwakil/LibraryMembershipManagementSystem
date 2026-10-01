using System;

namespace LibraryMembershipManagementSystem
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminID"] == null)
            {
                Response.Redirect("index.aspx");
            }

            if (!IsPostBack)
            {
                lblWelcome.Text = "Welcome, " + Session["AdminID"].ToString();
            }
        }

        protected void btnAddMember_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddMember.aspx");
        }

        protected void btnViewMembers_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewMembers.aspx");
        }

        protected void btnUpdateMember_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateMember.aspx");
        }

        protected void btnDeleteMember_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteMember.aspx");
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePassword.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();

            Response.Redirect("index.aspx");
        }
    }
}