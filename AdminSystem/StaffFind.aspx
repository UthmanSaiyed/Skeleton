<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffFind.aspx.cs" Inherits="_1_Find" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Find Staff</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSearch" runat="server" Text="Find Staff"></asp:Label>
            <asp:TextBox ID="txtSearchName" runat="server" Placeholder="Staff Name"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
        </div>
        <div>
            <asp:GridView ID="gvStaff" runat="server" AutoGenerateColumns="False"
                DataKeyNames="StaffID">
                <Columns>
                    <asp:BoundField DataField="StaffID" HeaderText="Staff ID" ReadOnly="True" />
                    <asp:BoundField DataField="StaffName" HeaderText="Staff Name" />
                    <asp:BoundField DataField="Address" HeaderText="Address" />
                    <asp:BoundField DataField="DepartmentName" HeaderText="Department Name" />
                    <asp:BoundField DataField="EmploymentStatus" HeaderText="Employment Status" />
                    <asp:BoundField DataField="Salary" HeaderText="Salary" />
                    <asp:BoundField DataField="DateofEmployment" HeaderText="Date of Employment" DataFormatString="{0:yyyy-MM-dd}" />
                </Columns>
            </asp:GridView>
            <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
        </div>
    </form>
</body>
</html>
