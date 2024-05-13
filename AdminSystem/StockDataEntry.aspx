<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSupplier" runat="server" style="z-index: 1; left: 34px; top: 238px; position: absolute" Text="Supplier" width="55px"></asp:Label>
            <asp:Label ID="lblTicketName" runat="server" style="z-index: 1; left: 34px; top: 293px; position: absolute; width: 98px" Text="Ticket Name"></asp:Label>
        </div>
        <asp:Label ID="lblTicketId" runat="server" style="z-index: 1; left: 34px; top: 71px; position: absolute" Text="Ticket Id"></asp:Label>
        <asp:Label ID="lblEventId" runat="server" style="z-index: 1; left: 34px; top: 118px; position: absolute" Text="Event Id" width="55px"></asp:Label>
        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 34px; top: 157px; position: absolute" Text="Quantity" width="55px"></asp:Label>
        <p>
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 34px; top: 196px; position: absolute" Text="Price" width="55px"></asp:Label>
        </p>
        <asp:TextBox ID="txtTicketId" runat="server" style="z-index: 1; left: 162px; top: 70px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEventId" runat="server" style="z-index: 1; left: 162px; top: 113px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 162px; top: 154px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtSupplier" runat="server" style="z-index: 1; left: 162px; top: 242px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 162px; top: 194px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtTicketName" runat="server" style="z-index: 1; top: 291px; position: absolute; left: 162px"></asp:TextBox>
        <asp:CheckBox ID="CheckBoxYes" runat="server" style="z-index: 1; left: 162px; top: 352px; position: absolute; right: 921px" Text="Yes" />
        <asp:CheckBox ID="CheckBoxNo" runat="server" style="z-index: 1; left: 265px; top: 352px; position: absolute" Text="No" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 42px; top: 503px; position: absolute" Text="OK" width="60px" />
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 176px; top: 503px; position: absolute" Text="Cancel" />
        </p>
        <asp:Label ID="lblInStock" runat="server" style="z-index: 1; left: 34px; top: 353px; position: absolute" Text="InStock" width="55px"></asp:Label>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 34px; top: 432px; position: absolute" Text="[lblError]" width="55px"></asp:Label>
        </p>
    </form>
</body>
</html>
