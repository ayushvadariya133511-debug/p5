<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Leave.aspx.cs"
    Inherits="WebApplication1.Leave" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Leave</title>
</head>

<body>
    <form id="form1" runat="server">

        <h2>Employee Leave Management System</h2>

        <asp:Label ID="lblWelcome" runat="server"></asp:Label>

        <br /><br />

        <asp:Label ID="lblLeaveType" runat="server"
            Text="Select Leave Type:"></asp:Label>

        <br />

        <asp:DropDownList ID="ddlLeaveType" runat="server">
            <asp:ListItem Text="-- Select Leave Type --"
                Value=""></asp:ListItem>

            <asp:ListItem Text="Casual Leave"
                Value="Casual Leave"></asp:ListItem>

            <asp:ListItem Text="Sick Leave"
                Value="Sick Leave"></asp:ListItem>

            <asp:ListItem Text="Earned Leave"
                Value="Earned Leave"></asp:ListItem>

            <asp:ListItem Text="Emergency Leave"
                Value="Emergency Leave"></asp:ListItem>
        </asp:DropDownList>

        <br /><br />

        <asp:Label ID="lblDate" runat="server"
            Text="Select Leave Date:"></asp:Label>

        <br />

        <asp:Calendar ID="Calendar1" runat="server"
            OnSelectionChanged="Calendar1_SelectionChanged">
        </asp:Calendar>

        <br />

        <asp:Label ID="lblSelectedDate" runat="server"
            Text="Selected Date: Not Selected">
        </asp:Label>

        <br /><br />

        <asp:Button ID="btnApplyLeave" runat="server"
            Text="Apply Leave"
            OnClick="btnApplyLeave_Click" />

        <br /><br />

        <asp:Label ID="lblResult" runat="server"></asp:Label>

        <br /><br />

        <asp:Button ID="btnLogout" runat="server"
            Text="Logout"
            OnClick="btnLogout_Click" />

    </form>
</body>
</html>
