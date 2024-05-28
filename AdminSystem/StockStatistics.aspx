<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockStatistics.aspx.cs" Inherits="StockStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Stock List - Grouped By Supplier</div>
        <asp:GridView ID="GridViewStGroupBySupplier" runat="server">
        </asp:GridView>
        Stock List - Grouped By Price
        <asp:GridView ID="GridViewStGroupByPrice" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
