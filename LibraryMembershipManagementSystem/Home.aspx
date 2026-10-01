<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LibraryMembershipManagementSystem.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LMMS Dashboard</title>
</head>

<body>

<form id="form1" runat="server">

<div style="text-align:center; margin-top:80px;">

    <h1>Library Membership Management System</h1>

    <h2>Admin Dashboard</h2>

    <br />

    <asp:Label ID="lblWelcome"
        runat="server"
        Text="Welcome Admin">
    </asp:Label>

    <br /><br /><br />

    <asp:Button ID="btnAddMember"
        runat="server"
        Text="Add Member"
        OnClick="btnAddMember_Click" />

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Button ID="btnViewMembers"
        runat="server"
        Text="View Members"
        OnClick="btnViewMembers_Click" />

    <br /><br />

    <asp:Button ID="btnUpdateMember"
        runat="server"
        Text="Update Member"
        OnClick="btnUpdateMember_Click" />

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Button ID="btnDeleteMember"
        runat="server"
        Text="Delete Member"
        OnClick="btnDeleteMember_Click" />

    <br /><br />

    <asp:Button ID="btnChangePassword"
        runat="server"
        Text="Change Password"
        OnClick="btnChangePassword_Click" />

    <br /><br />

    <asp:Button ID="btnLogout"
        runat="server"
        Text="Logout"
        OnClick="btnLogout_Click" />

</div>

</form>

</body>
</html>