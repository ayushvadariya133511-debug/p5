<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="WebForm1.aspx.cs"
    Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Login</title>
</head>

<body>
    <form id="form1" runat="server">

        <h2>Login Page</h2>

        <asp:Label ID="lblName" runat="server"
            Text="Name:"></asp:Label>

        <br />

        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>

        <br /><br />

        <asp:Label ID="lblPassword" runat="server"
            Text="Password:"></asp:Label>

        <br />

        <asp:TextBox ID="txtPassword" runat="server"
            TextMode="Password"></asp:TextBox>

        <br /><br />

        <asp:Button ID="btnLogin" runat="server"
            Text="Login"
            OnClick="btnLogin_Click" />

        <br /><br />

        <asp:Label ID="lblMessage" runat="server"></asp:Label>

    </form>
</body>
</html>
