<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFC1.aspx.cs" Inherits="Practice.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WFC1</title>

    <style>
        body{
            background-color:lightpink;
        }
    </style>
</head>
<body>
    <h3>ASPX WebForm "Button" control used to submit form for server-side processing</h3>

    <form id="form1" runat="server">
        <asp:Label ID="lblName" runat="server" Text="Enter your name:"></asp:Label><br />
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
        <asp:Button ID="btnProcess" runat="server" Text="Submit Name" OnClick="btnProcess_Click"/>
    </form>
</body>
</html>
