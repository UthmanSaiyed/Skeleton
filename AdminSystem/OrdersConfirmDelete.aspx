<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 13px; top: 133px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        </p>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 105px; top: 199px; position: absolute; width: 163px" Text="Yes" />
        <p>
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 322px; top: 200px; position: absolute" Text="No" width="163px" />
        </p>
    </form>
</body>
</html>