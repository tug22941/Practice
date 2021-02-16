<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gridview_P1.aspx.cs" Inherits="Practice.Gridview_P1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GV_Practice1</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvBooks" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="gvBooks_PageIndexChanging" PageSize="3">
                <Columns>
                    <asp:BoundField DataField="ISBN" HeaderText="ISBN" />
                    <asp:BoundField DataField="Title" HeaderText="Title" />
                    <asp:BoundField DataField="Authors" HeaderText="Author" />
                    <asp:BoundField DataField="BasePrice" HeaderText="Price" />
                    <asp:BoundField DataField="TotalSales" HeaderText="Total Sold" />
                    <asp:BoundField DataField="TotalQuantityRented" HeaderText="Total Rented" />
                    <asp:BoundField DataField="TotalQuantitySold" HeaderText="Total Sold" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
