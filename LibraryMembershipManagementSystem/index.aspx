<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="LibraryMembershipManagementSystem.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Login</title>
</head>

<body>

<form id="form1" runat="server">

<div style="text-align:center; margin-top:150px;">

    <h1>Library Membership Management System</h1>

    <h2>Admin Login</h2>

    <asp:Label ID="lblAdminID"
        runat="server"
        Text="Admin ID:">
    </asp:Label>

    &nbsp;<asp:TextBox ID="txtAdminID"
        runat="server">
    </asp:TextBox>

    <br /><br />

    <asp:Label ID="lblPassword"
        runat="server"
        Text="Password:">
    </asp:Label>

    &nbsp;<asp:TextBox ID="txtPassword"
        runat="server"
        TextMode="Password">
    </asp:TextBox>

    <br /><br />

    <asp:Button ID="btnLogin"
        runat="server"
        Text="Login"
        OnClick="btnLogin_Click" />

    <br /><br />

    <asp:Label ID="lblMessage"
        runat="server">
    </asp:Label>

</div>

</form>

</body>
</html>