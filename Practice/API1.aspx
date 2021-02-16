<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="API1.aspx.cs" Inherits="Practice.API1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>API1</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body{
            background-color:lightpink;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:GridView ID="gvBooks" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="ISBN" HeaderText="ISBN" />
                    <asp:BoundField DataField="Title" HeaderText="Title" />
                    <asp:BoundField DataField="Author" HeaderText="Author" />
                    <asp:BoundField DataField="Price" HeaderText="Price" />
                    <asp:BoundField DataField="TotalSales" HeaderText="Total Sales" />
                    <asp:BoundField DataField="TotalRented" HeaderText="Total Rented" />
                    <asp:BoundField DataField="TotalSold" HeaderText="Total Sold" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/js/bootstrap.bundle.min.js" ></script>
</body>
</html>
