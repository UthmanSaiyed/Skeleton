<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffAdd.aspx.cs" Inherits="_1_Add" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Staff</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaffName" runat="server" Text="Staff Name:" />
            <asp:TextBox ID="txtStaffName" runat="server" />
        </div>
        <div>
            <asp:Label ID="lblAddress" runat="server" Text="Address:" />
            <asp:TextBox ID="txtAddress" runat="server" />
        </div>
        <div>
            <asp:Label ID="lblDepartmentName" runat="server" Text="Department Name:" />
            <asp:TextBox ID="txtDepartmentName" runat="server" />
        </div>
        <div>
            <asp:Label ID="lblEmploymentStatus" runat="server" Text="Employment Status:" />
            <asp:CheckBox ID="chkEmploymentStatus" runat="server" />
        </div>
        <div>
            <asp:Label ID="lblSalary" runat="server" Text="Salary:" />
            <asp:TextBox ID="txtSalary" runat="server" />
        </div>
        <div>
            <asp:Label ID="lblDateofEmployment" runat="server" Text="Date of Employment:" />
            <asp:TextBox ID="txtDateofEmployment" runat="server" />
        </div>
        <div>
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </div>
    </form>
</body>
</html>
