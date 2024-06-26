﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff List</title>
</head>
<body>
    <form id="form1" runat="server">
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
            <asp:Button ID="btnAddStaff" runat="server" Text="Add Staff" OnClick="btnAddStaff_Click" />
            <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
        </div>
    </form>
</body>
</html>
