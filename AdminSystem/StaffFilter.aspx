<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffFilter.aspx.cs" Inherits="_1_Search" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search Staff</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSearch" runat="server" Text="Search Staff"></asp:Label>
            <asp:TextBox ID="txtSearchName" runat="server" Placeholder="Staff Name"></asp:TextBox>
            <asp:TextBox ID="txtSearchDepartment" runat="server" Placeholder="Department Name"></asp:TextBox>
            <asp:DropDownList ID="ddlSearchEmploymentStatus" runat="server">
                <asp:ListItem Text="All" Value=""></asp:ListItem>
                <asp:ListItem Text="Employed" Value="True"></asp:ListItem>
                <asp:ListItem Text="Unemployed" Value="False"></asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
        </div>
        <div>
            <asp:GridView ID="gvStaff" runat="server" AutoGenerateColumns="False"
                DataKeyNames="StaffID"
                OnRowEditing="gvStaff_RowEditing"
                OnRowUpdating="gvStaff_RowUpdating"
                OnRowCancelingEdit="gvStaff_RowCancelingEdit"
                OnRowDeleting="gvStaff_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="StaffID" HeaderText="Staff ID" ReadOnly="True" />
                    <asp:BoundField DataField="StaffName" HeaderText="Staff Name" />
                    <asp:BoundField DataField="Address" HeaderText="Address" />
                    <asp:BoundField DataField="DepartmentName" HeaderText="Department Name" />
                    <asp:TemplateField HeaderText="Employment Status">
                        <ItemTemplate>
                            <%# Convert.ToBoolean(Eval("EmploymentStatus")) ? "Employed" : "Unemployed" %>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:DropDownList ID="ddlEmploymentStatus" runat="server">
                                <asp:ListItem Text="Employed" Value="True"></asp:ListItem>
                                <asp:ListItem Text="Unemployed" Value="False"></asp:ListItem>
                            </asp:DropDownList>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Salary" HeaderText="Salary" />
                    <asp:BoundField DataField="DateofEmployment" HeaderText="Date of Employment" DataFormatString="{0:yyyy-MM-dd}" />
                    <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
            <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
        </div>
    </form>
</body>
</html>
