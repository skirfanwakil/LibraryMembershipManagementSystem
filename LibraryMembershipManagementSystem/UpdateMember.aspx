<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateMember.aspx.cs" Inherits="LibraryMembershipManagementSystem.UpdateMember" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Member</title>
</head>

<body>

<form id="form1" runat="server">

<div style="text-align:center; margin-top:60px;">

    <h1>Library Membership Management System</h1>

    <h2>Update Member</h2>

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

    <asp:Label ID="lblDetails"
        runat="server"
        Text="Member Details"
        Visible="false">
    </asp:Label>

    <br /><br />

    <asp:Label ID="lblCurrentName"
        runat="server"
        Text="Current Name:"
        Visible="false">
    </asp:Label>

    &nbsp;<asp:Label ID="lblNameValue"
        runat="server"
        Visible="false">
    </asp:Label>

    <br /><br />

    <asp:Label ID="lblCurrentEmail"
        runat="server"
        Text="Current Email:"
        Visible="false">
    </asp:Label>

    &nbsp;<asp:Label ID="lblEmailValue"
        runat="server"
        Visible="false">
    </asp:Label>

    <br /><br />

    <asp:Label ID="lblCurrentClass"
        runat="server"
        Text="Current Class:"
        Visible="false">
    </asp:Label>

    &nbsp;<asp:Label ID="lblClassValue"
        runat="server"
        Visible="false">
    </asp:Label>

    <br /><br />

    <asp:Label ID="lblUpdateDetails"
        runat="server"
        Text="Enter New Details"
        Visible="false">
    </asp:Label>

    <br /><br />

    <asp:Label ID="lblName"
        runat="server"
        Text="New Name:"
        Visible="false">
    </asp:Label>

    &nbsp;<asp:TextBox ID="txtName"
        runat="server"
        Visible="false">
    </asp:TextBox>

    <br /><br />

    <asp:Label ID="lblEmail"
        runat="server"
        Text="New Email:"
        Visible="false">
    </asp:Label>

    &nbsp;<asp:TextBox ID="txtEmail"
        runat="server"
        Visible="false">
    </asp:TextBox>

    <br /><br />

    <asp:Label ID="lblClass"
        runat="server"
        Text="New Class:"
        Visible="false">
    </asp:Label>

    &nbsp;<asp:TextBox ID="txtClass"
        runat="server"
        Visible="false">
    </asp:TextBox>

    <br /><br />

    <asp:Button ID="btnUpdate"
        runat="server"
        Text="Update Member"
        OnClick="btnUpdate_Click"
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