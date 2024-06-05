<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersStatistics.aspx.cs" Inherits="OrdersStatistics" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Statistics Page</title>
</head>
<body style="height: 889px">
    <form id="form1" runat="server">
        <div>
            <div>
                <h1>Statistics Page</h1>
            </div>
            <div>
                <h3>Order List - Grouped by Status</h3>
                <asp:GridView ID="GridViewOrdersGroupedByStatus" runat="server"></asp:GridView>
            </div>
            <div>
                <h3>Order List - Grouped by Date</h3>
                <asp:GridView ID="GridViewOrdersGroupedByDate" runat="server"></asp:GridView>
            </div>
            <div>
            </div>
        </div>
        <p>
            &nbsp;</p>
                <asp:Button ID="btnBack" runat="server" Text="Back to previous page" OnClick="btnBack_Click" Width="282px" />
    </form>
</body>
</html>
