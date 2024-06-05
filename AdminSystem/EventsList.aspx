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
            <asp:ListBox ID="lstEventsList" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 392px; width: 373px"></asp:ListBox>
            <div class="button-container">
                <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            </div>
        </div>
    </form>
</body>
</html>
