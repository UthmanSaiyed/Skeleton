<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 516px">
    &nbsp;<form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 34px; top: 59px; position: absolute" Text="Order ID" width="175px"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 238px; top: 52px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblTicketID" runat="server" style="z-index: 1; left: 34px; top: 121px; position: absolute" Text="Ticket ID" width="175px"></asp:Label>
            <asp:TextBox ID="txtTicketID" runat="server" style="z-index: 1; left: 238px; top: 120px; position: absolute" width="248px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 34px; top: 181px; position: absolute" Text="Customer ID" width="175px"></asp:Label>
            <asp:TextBox ID="txtIsPaid" runat="server" style="z-index: 1; left: 240px; top: 362px; position: absolute"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 238px; top: 182px; position: absolute" width="248px"></asp:TextBox>
        <p>
            <asp:Label ID="lblOrderStatus" runat="server" style="z-index: 1; left: 34px; top: 241px; position: absolute" Text="Order Status" width="175px"></asp:Label>
        </p>
        <asp:TextBox ID="txtOrderStatus" runat="server" style="z-index: 1; left: 238px; top: 243px; position: absolute" width="248px"></asp:TextBox>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 34px; top: 301px; position: absolute" Text="Order Date" width="175px"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 238px; top: 302px; position: absolute" width="248px"></asp:TextBox>
        <asp:Label ID="lblIsPaid" runat="server" style="z-index: 1; left: 34px; top: 361px; position: absolute" Text="Is Paid" width="175px"></asp:Label>
        <asp:Label ID="lblTotalAmount" runat="server" style="z-index: 1; left: 34px; top: 420px; position: absolute" Text="Total Amount"></asp:Label>
        <asp:TextBox ID="txtTotalAmount" runat="server" style="z-index: 1; left: 238px; top: 421px; position: absolute" width="248px"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 91px; top: 487px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 35px; top: 581px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 28px; top: 649px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 114px; top: 650px; position: absolute" Text="Cancel" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 582px; top: 151px; position: absolute" Text="Find" />
        </p>
    </form>
</body>
</html>
