<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 98px; top: 85px; position: absolute" Text="Customer ID" width="109px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 208px; top: 86px; position: absolute"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 98px; top: 127px; position: absolute" Text="Name" width="109px"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 208px; top: 128px; position: absolute"></asp:TextBox>
        </p>
       
      
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 98px; top: 170px; position: absolute; bottom: 487px" Text="Email" width="109px"></asp:Label>
        <p>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 208px; top: 168px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblDate" runat="server" style="z-index: 1; left: 98px; top: 208px; position: absolute" Text="Date" width="109px"></asp:Label>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 208px; top: 207px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 98px; top: 245px; position: absolute; width: 109px; right: 930px;" Text="Phone Number"></asp:Label>
        <asp:TextBox ID="txtPhonenumber" runat="server" style="z-index: 1; left: 208px; top: 245px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblNewsletter" runat="server" style="z-index: 1; left: 98px; top: 275px; position: absolute" Text="Newsletter" width="109px"></asp:Label>
        <p>
            <asp:CheckBox ID="cbNewsletter" runat="server" style="z-index: 1; left: 216px; top: 276px; position: absolute" Text="Yes" />
        </p>
        <asp:CheckBox ID="cbNewletterNo" runat="server" style="z-index: 1; left: 303px; top: 277px; position: absolute" Text="No" />
        <asp:CheckBox ID="cbActive" runat="server" style="z-index: 1; left: 100px; top: 316px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 101px; top: 351px; position: absolute" AssociatedControlID="lblError"></asp:Label>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 104px; top: 391px; position: absolute" Text="Ok" />
        
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 161px; top: 391px; position: absolute" Text="Cancel" />
        
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 399px; top: 83px; position: absolute" Text="Find" />
        </p>
        
    </form>
</body>
</html>
