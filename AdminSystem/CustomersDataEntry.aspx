<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 104px; top: 85px; position: absolute" Text="Customer ID" width="79px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 208px; top: 86px; position: absolute"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblFirstname" runat="server" style="z-index: 1; left: 104px; top: 120px; position: absolute" Text="Firstname" width="79px"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtFirstname" runat="server" style="z-index: 1; left: 208px; top: 121px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtLastname" runat="server" style="z-index: 1; left: 208px; top: 155px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblLastname" runat="server" style="z-index: 1; left: 104px; top: 155px; position: absolute; width: 79px" Text="Lastname"></asp:Label>
        </p>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 104px; top: 184px; position: absolute; bottom: 473px" Text="Email"></asp:Label>
        <p>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 208px; top: 184px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblBirthDate" runat="server" style="z-index: 1; left: 104px; top: 215px; position: absolute" Text="Birth Date" width="79px"></asp:Label>
        <asp:TextBox ID="txtBirthDate" runat="server" style="z-index: 1; left: 208px; top: 216px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 104px; top: 245px; position: absolute; width: 109px; right: 1297px;" Text="Phone Number"></asp:Label>
        <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 208px; top: 245px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblNewsletter" runat="server" style="z-index: 1; left: 104px; top: 275px; position: absolute" Text="Newsletter" width="79px"></asp:Label>
        <p>
            <asp:CheckBox ID="cbNewsletter" runat="server" style="z-index: 1; left: 216px; top: 276px; position: absolute" Text="Yes" />
        </p>
        <asp:CheckBox ID="cbNewletterNo" runat="server" style="z-index: 1; left: 303px; top: 277px; position: absolute" Text="No" />
        <asp:CheckBox ID="cbActive" runat="server" style="z-index: 1; left: 100px; top: 316px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 101px; top: 351px; position: absolute" AssociatedControlID="lblError"></asp:Label>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 104px; top: 391px; position: absolute" Text="Ok" />
        
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 161px; top: 391px; position: absolute" Text="Cancel" />
        
    </form>
</body>
</html>
