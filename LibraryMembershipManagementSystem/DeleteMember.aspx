<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteMember.aspx.cs" Inherits="LibraryMembershipManagementSystem.DeleteMember" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete Member</title>
</head>

<body>

<form id="form1" runat="server">

<div style="text-align:center; margin-top:60px;">

    <h1>Library Membership Management System</h1>

    <h2>Delete Member</h2>

    <br />

    <asp:Label ID="lblMemberID"
        runat="server"
        Text="Member ID:">
    </asp:Label>

    &nbsp;<asp:TextBox ID="txtMemberID"
        runat="server">
    </asp:TextBox>

    <br /><br />

    <asp:Button ID="btnShow"
        runat="server"
        Text="Show Member Details"
        OnClick="btnShow_Click" />

    <br /><br />

    <asp:Label ID="lblName"
        runat="server"
        Text="Name:">
    </asp:Label>

    &nbsp;<asp:Label ID="lblNameValue"
        runat="server">
    </asp:Label>

    <br /><br />

    <asp:Label ID="lblEmail"
        runat="server"
        Text="Email:">
    </asp:Label>

    &nbsp;<asp:Label ID="lblEmailValue"
        runat="server">
    </asp:Label>

    <br /><br />

    <asp:Label ID="lblClass"
        runat="server"
        Text="Class:">
    </asp:Label>

    &nbsp;<asp:Label ID="lblClassValue"
        runat="server">
    </asp:Label>

    <br /><br />

    <asp:Button ID="btnDelete"
        runat="server"
        Text="Delete Member"
        OnClick="btnDelete_Click"
        Visible="false" />

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