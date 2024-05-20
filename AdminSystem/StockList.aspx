<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStockList" runat="server" Height="484px" Width="657px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" Text="Add" />
        </p>
    </form>
</body>
</html>
