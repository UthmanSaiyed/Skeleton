<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffStatistics.aspx.cs" Inherits="_1_Statistics" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Statistics</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Staff Statistics</h2>
            <asp:Label ID="lblTotalStaff" runat="server" Text="Total Staff:"></asp:Label><br />
            <asp:Label ID="lblEmployedStaff" runat="server" Text="Employed Staff:"></asp:Label><br />
            <asp:Label ID="lblUnemployedStaff" runat="server" Text="Unemployed Staff:"></asp:Label><br />
            <asp:Label ID="lblAverageSalary" runat="server" Text="Average Salary:"></asp:Label><br />
            <asp:Label ID="lblMinimumSalary" runat="server" Text="Minimum Salary:"></asp:Label><br />
            <asp:Label ID="lblMaximumSalary" runat="server" Text="Maximum Salary:"></asp:Label><br />
            <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
        </div>
    </form>
</body>
</html>
