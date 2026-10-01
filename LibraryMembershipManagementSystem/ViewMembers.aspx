<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewMembers.aspx.cs" Inherits="LibraryMembershipManagementSystem.ViewMembers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Members</title>
</head>

<body>

<form id="form1" runat="server">

<div style="text-align:center; margin-top:60px;">

    <h1>Library Membership Management System</h1>

    <h2>View Members</h2>

    <br />

    <asp:Label ID="lblSearchID"
        runat="server"
        Text="Search Member ID:">
    </asp:Label>

    &nbsp;<asp:TextBox ID="txtSearchID"
        runat="server">
    </asp:TextBox>

    <br /><br />

    <asp:Button ID="btnSearch"
        runat="server"
        Text="Search"
        OnClick="btnSearch_Click" />

    &nbsp;&nbsp;

    <asp:Button ID="btnViewAll"
        runat="server"
        Text="View All Members"
        OnClick="btnViewAll_Click" />

    <br /><br />

    <asp:Label ID="lblMessage"
        runat="server">
    </asp:Label>

    <br /><br />

    <asp:GridView ID="gvMembers"
        runat="server"
        AutoGenerateColumns="true"
        BorderWidth="1"
        CellPadding="8">
    </asp:GridView>

    <br /><br />

    <asp:Button ID="btnBack"
        runat="server"
        Text="Back to Dashboard"
        OnClick="btnBack_Click" />

</div>

</form>

</body>
</html>