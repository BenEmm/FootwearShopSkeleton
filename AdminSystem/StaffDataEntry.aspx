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
        <asp:Label ID="lblSalary" runat="server" Text="Salary" width="130px"></asp:Label>
        <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="ldlDateOfJoining" runat="server" Text="Date Of Joining"></asp:Label>
            <asp:TextBox ID="txtDateOfJoining" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblPosition" runat="server" Text="Position" width="130px"></asp:Label>
        <asp:TextBox ID="txtPositon" runat="server"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkFullTime" runat="server" Text="Full Time" />
        </p>
        <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        <p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click1" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </p>
    </form>
</body>
</html>
