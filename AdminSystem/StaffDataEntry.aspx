<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffID" runat="server" Text="StaffID" width="130px"></asp:Label>
        <asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblFullName" runat="server" Text="Full Name" width="130px"></asp:Label>
            <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblPassword" runat="server" Text="Password" width="130px"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="ldlDateOfLeaving" runat="server" Text="Date Of Leaving"></asp:Label>
            <asp:TextBox ID="txtDateOfLeaving" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblPosition" runat="server" Text="Position" width="130px"></asp:Label>
        <asp:TextBox ID="txtPositon" runat="server"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkFullTime" runat="server" Text="Full Time" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click1" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
