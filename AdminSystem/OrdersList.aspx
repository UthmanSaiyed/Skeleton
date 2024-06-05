<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrdersList" runat="server" style="z-index: 1; left: 10px; top: 51px; position: absolute; height: 930px; width: 930px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 16px; top: 1002px; position: absolute" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 110px; top: 1001px; position: absolute; width: 87px" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 219px; top: 1001px; position: absolute" Text="Delete" />
        </p>
        <p>
            <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 20px; top: 1096px; position: absolute" Text="Enter a Promo Code"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 312px; top: 1098px; position: absolute; bottom: 258px;"></asp:TextBox>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 30px; top: 1182px; position: absolute" Text="Apply Filter" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 278px; top: 1180px; position: absolute" Text="Clear Filter" />
        </p>
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 39px; top: 1276px; position: absolute; color: black;"></asp:Label>
        </p>
            <asp:Button ID="btnStatisticsPage" runat="server" OnClick="btnStatisticsPage_Click" style="z-index: 1; left: 528px; top: 1175px; position: absolute" Text="Statistics Page" />
        <p>
            <asp:Button ID="btnReturnToMainMenu" runat="server" OnClick="btnReturnToMainMenu_Click" style="z-index: 1; left: 836px; top: 1173px; position: absolute; width: 302px" Text="Return to Main Menu" />
        </p>
    </form>
</body>
</html>