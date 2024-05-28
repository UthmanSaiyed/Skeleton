<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblMenu" runat="server" style="top: 51px; left: 500px; height: 36px; width: 315px; right: 500px" Text="Next Tickets Main Menu"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnEvents" runat="server" Text="Events" />
            <asp:Button ID="btnStaff" runat="server" Text="Staff" />
            <asp:Button ID="btnCustomers" runat="server" Text="Customers" />
        </p>
        <asp:Button ID="btnStock" runat="server" OnClick="btnStock_Click" Text="Stock" />
        <asp:Button ID="btnOrders" runat="server" Text="Orders" />
    </form>
</body>
</html>
