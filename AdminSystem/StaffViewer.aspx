<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Viewer</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnAddStaff" runat="server" Text="Add Staff" OnClick="btnAddStaff_Click" />
            <asp:Button ID="btnListStaff" runat="server" Text="List Staff" OnClick="btnListStaff_Click" />
            <asp:Button ID="btnFindStaff" runat="server" Text="Find Staff" OnClick="btnFindStaff_Click" />
            <asp:Button ID="btnFilterStaff" runat="server" Text="Filter Staff" OnClick="btnFilterStaff_Click" />
            <asp:Button ID="btnStatistics" runat="server" Text="Statistics" OnClick="btnStatistics_Click" />
        </div>
    </form>
</body>
</html>
