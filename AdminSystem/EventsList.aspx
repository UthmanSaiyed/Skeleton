<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EventsList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
    <style>
        .button-container {
            position: absolute;
            left: 10px;
            top: 440px; /* Adjust this value based on the height of your ListBox */
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstEventsList" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 392px; width: 373px"></asp:ListBox>            <div class="button-container">
                <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            </div>
        </div>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 74px; top: 440px; position: absolute" Text="Edit" width="37px" />
        <asp:Button ID="btnDelete" runat="server" Style="z-index: 1; left: 140px; top: 440px; position: absolute" Text="Delete" Width="60px" OnClick="btnDelete_Click" />
        <p>
                        <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>

    <asp:Button ID="btnFilterApply" runat="server" OnClick="btnFilterApply_Click" Text="Apply Filter" />
    <asp:Button ID="btnFilterClr" runat="server" OnClick="btnFilterClr_Click" Text="Clear Filter" />
    <asp:Button ID="btnStatistics" runat="server" OnClick="btnStatistics_Click" Text="Statistics Page" />
    <asp:Button ID="btnReturnMM" runat="server" OnClick="btnReturnMM_Click" Text="Return to Main Menu" />
</p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 482px; position: absolute"></asp:Label>
    </form>
</body>
</html>
