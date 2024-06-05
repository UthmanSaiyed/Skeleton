<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 516px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 34px; top: 59px; position: absolute" Text="Order ID" width="175px"></asp:Label>
        <p>&nbsp;</p>
        <p>
            <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 238px; top: 52px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPromoCode" runat="server" style="z-index: 1; left: 34px; top: 121px; position: absolute" Text="Promo Code" width="175px"></asp:Label>
            <asp:TextBox ID="txtPromoCode" runat="server" style="z-index: 1; left: 238px; top: 120px; position: absolute" width="248px" height="38px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblOrderFeedback" runat="server" style="z-index: 1; left: 34px; top: 181px; position: absolute" Text="OrderFeedback" width="175px"></asp:Label>
        </p>
        <asp:TextBox ID="txtOrderFeedback" runat="server" style="z-index: 1; left: 238px; top: 182px; position: absolute" width="248px" height="38px"></asp:TextBox>
        <p>
            <asp:Label ID="lblOrderStatus" runat="server" style="z-index: 1; left: 34px; top: 241px; position: absolute" Text="Order Status" width="175px"></asp:Label>
        </p>
        <p>
            <asp:CheckBox ID="chkOrderStatus" runat="server" style="z-index: 1; left: 238px; top: 245px; position: absolute; width: 248px; bottom: 1045px;" Text="Active" height="38px" />
        </p>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 34px; top: 301px; position: absolute" Text="Order Date" width="175px"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 238px; top: 302px; position: absolute" width="248px" height="38px"></asp:TextBox>
        <asp:Label ID="lblIsPaid" runat="server" style="z-index: 1; left: 34px; top: 361px; position: absolute" Text="Is Paid" width="175px"></asp:Label>
        <asp:CheckBox ID="chkIsPaid" runat="server" style="z-index: 1; left: 238px; top: 365px; position: absolute; width: 248px;" Text="Paid" height="38px" />
        <asp:Label ID="lblTotalAmount" runat="server" style="z-index: 1; left: 34px; top: 420px; position: absolute" Text="Total Amount"></asp:Label>
        <asp:TextBox ID="txtTotalAmount" runat="server" style="z-index: 1; left: 238px; top: 421px; position: absolute" width="248px" height="38px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 35px; top: 470px; position: absolute; color: black;"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 28px; top: 510px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 114px; top: 510px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <p>&nbsp;</p>
        <p>
            <asp:Button ID="btnReturnToMainMenu" runat="server" OnClick="btnReturnToMainMenu_Click" style="z-index: 1; left: 568px; top: 507px; position: absolute; width: 304px" Text="Return to Main Menu" />
        </p>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 582px; top: 151px; position: absolute" Text="Find" />
        </p>
    </form>
</body>
</html>