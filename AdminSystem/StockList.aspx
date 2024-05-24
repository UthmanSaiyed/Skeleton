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
        <asp:ListBox ID="lstStockList" runat="server" Height="409px" Width="554px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        </p>
        <p>
            <asp:Label ID="EntrSupplier" runat="server" height="38px" Text="Enter a Supplier " width="248px"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnFilterApply" runat="server" OnClick="btnFilterApply_Click" Text="Apply FIlter" />
            <asp:Button ID="btnFilterClr" runat="server" OnClick="btnFilterClr_Click" Text="Clear FIlter" />
        </p>
        <p>
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
    </form>
</body>
</html>
