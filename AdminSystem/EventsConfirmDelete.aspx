﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EventsConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
<p>
    <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" Width="65px" />
    <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="margin-left: 45px" Text="No" Width="76px" />
</p>
        </div>
    </form>
</body>
</html>
