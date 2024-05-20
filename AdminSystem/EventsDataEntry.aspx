<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EventsDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 349px">
    <form id="form1" runat="server">
        <div>
            EventsDataEntry</div>
        <asp:Label ID="lblEventsID" runat="server" style="z-index: 1; left: 13px; top: 77px; position: absolute" Text="EventsID" width="69px"></asp:Label>
        <asp:TextBox ID="txtEventsID" runat="server" style="z-index: 1; left: 111px; top: 77px; position: absolute" width="128px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtTitle" runat="server" style="z-index: 1; left: 111px; top: 112px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblLocation" runat="server" style="z-index: 1; left: 13px; top: 152px; position: absolute" Text="Location" width="69px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 13px; top: 115px; position: absolute; width: 69px" Text="Title"></asp:Label>
            <asp:Label ID="lblDate" runat="server" style="z-index: 1; left: 13px; top: 190px; position: absolute" Text="Date" width="69px"></asp:Label>
            <asp:TextBox ID="txtDate" runat="server" OnTextChanged="txtDate_TextChanged" style="z-index: 1; left: 111px; top: 187px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtLocation" runat="server" style="z-index: 1; left: 111px; top: 151px; position: absolute" width="128px"></asp:TextBox>
            <asp:Label ID="lblTime" runat="server" style="z-index: 1; left: 13px; top: 227px; position: absolute" Text="Time" width="69px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 13px; top: 264px; position: absolute" Text="Description"></asp:Label>
            <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 111px; top: 259px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtTime" runat="server" style="z-index: 1; left: 111px; top: 223px; position: absolute" width="128px"></asp:TextBox>
            <asp:CheckBox ID="chkActive" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" style="z-index: 1; left: 137px; top: 296px; position: absolute" Text="Active" />
        </p>
        <p>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 98px; position: absolute; top: 347px" Text="OK" width="60px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 197px; top: 347px; position: absolute" Text="Cancel" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 324px; position: absolute"></asp:Label>
    </form>
</body>
</html>
