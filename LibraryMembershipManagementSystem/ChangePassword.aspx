<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="LibraryMembershipManagementSystem.ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Change Password</title>
</head>

<body>

<form id="form1" runat="server">

<div style="text-align:center; margin-top:60px;">

    <h1>Library Membership Management System</h1>
    <h2>Change Password</h2>

    <br />

    <asp:Label ID="lblCurrentPassword"
        runat="server"
        Text="Current Password:">
    </asp:Label>

    &nbsp;<asp:TextBox ID="txtCurrentPassword"
        runat="server"
        TextMode="Password">
    </asp:TextBox>

    <br /><br />

    <asp:Label ID="lblNewPassword"
        runat="server"
        Text="New Password:">
    </asp:Label>

    &nbsp;<asp:TextBox ID="txtNewPassword"
        runat="server"
        TextMode="Password">
    </asp:TextBox>

    <br /><br />

    <asp:Label ID="lblConfirmPassword"
        runat="server"
        Text="Confirm New Password:">
    </asp:Label>

    &nbsp;<asp:TextBox ID="txtConfirmPassword"
        runat="server"
        TextMode="Password">
    </asp:TextBox>

    <br /><br />

    <asp:Button ID="btnChangePassword"
        runat="server"
        Text="Change Password"
        OnClick="btnChangePassword_Click" />

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Button ID="btnBack"
        runat="server"
        Text="Back to Dashboard"
        OnClick="btnBack_Click" />

    <br /><br />

    <asp:Label ID="lblMessage"
        runat="server">
    </asp:Label>

</div>

</form>

</body>
</html>