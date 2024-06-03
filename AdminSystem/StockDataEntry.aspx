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
        <asp:Label ID="lblSKU" runat="server" style="z-index: 1; left: 32px; top: 100px; position: absolute" Text="SKU" width="55px"></asp:Label>
        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 34px; top: 157px; position: absolute" Text="Quantity" width="55px"></asp:Label>
        <p>
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 34px; top: 196px; position: absolute" Text="Price" width="55px"></asp:Label>
        </p>
        <asp:TextBox ID="txtTicketId" runat="server" style="z-index: 1; left: 162px; top: 70px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtSKU" runat="server" style="z-index: 1; left: 162px; top: 113px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 162px; top: 154px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtSupplier" runat="server" style="z-index: 1; left: 162px; top: 242px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 162px; top: 194px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtTicketName" runat="server" style="z-index: 1; top: 291px; position: absolute; left: 162px"></asp:TextBox>
        <asp:CheckBox ID="chkInStock" runat="server" style="z-index: 1; left: 162px; top: 352px; position: absolute; right: 921px" Text="InStock" />
        <asp:Button ID="Button1" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 55px; top: 503px; position: absolute; right: 2643px; width: 70px;" Text="OK" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 402px; top: 74px; position: absolute" Text="Find" width="60px" />
        <p>
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 176px; top: 503px; position: absolute" Text="Cancel" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 34px; top: 432px; position: absolute" Text="[lblError]" width="55px"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnReturnMM" runat="server" style="z-index: 1; left: 346px; top: 503px; position: absolute; width: 292px;" Text="Return to Main Menu" OnClick="btnReturnMM_Click" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
