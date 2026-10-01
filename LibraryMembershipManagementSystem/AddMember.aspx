<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMember.aspx.cs" Inherits="LibraryMembershipManagementSystem.AddMember" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Member</title>
</head>

<body>

<form id="form1" runat="server">

<div style="text-align:center; margin-top:60px;">

    <h1>Library Membership Management System</h1>
    <h2>Add New Member</h2>

    <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
    &nbsp;<asp:TextBox ID="txtName" runat="server"></asp:TextBox>

    <br /><br />

    <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
    &nbsp;<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>

    <br /><br />

    <asp:Label ID="lblClass" runat="server" Text="Class:"></asp:Label>
    &nbsp;<asp:TextBox ID="txtClass" runat="server"></asp:TextBox>

    <br /><br />

    <asp:Button ID="btnSave" runat="server"
        Text="Save Member"
        OnClick="btnSave_Click" />

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Button ID="btnBack" runat="server"
        Text="Back to Dashboard"
        OnClick="btnBack_Click" />

    <br /><br />

    <asp:Label ID="lblMessage" runat="server"></asp:Label>

</div>

</form>

</body>
</html>