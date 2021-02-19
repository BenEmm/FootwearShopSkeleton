<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID: "></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" OnTextChanged="txtCustomerID_TextChanged"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <p>
            <asp:Label ID="lblFirstName" runat="server" Text="First Name: " width="86px"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblSurname" runat="server" Text="Surname: " width="86px"></asp:Label>
        <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddressNO" runat="server" Text="Address No: " width="86px"></asp:Label>
        <asp:TextBox ID="txtAddressNo" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddress" runat="server" Text="Address: " width="86px"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPostcode" runat="server" Text="Postcode: " width="86px"></asp:Label>
        <asp:TextBox ID="txtPostcode" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email: " width="86px"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAccountCreationDate" runat="server" Text="Account Creation Date: " width="86px"></asp:Label>
        <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblCustomer" runat="server" Text="Is Customer: " width="86px"></asp:Label>
        <asp:CheckBox ID="chkConfirm" runat="server" />
        <br />
        <asp:Label ID="lblTotalSpent" runat="server" Text="Total Spent: " width="86px"></asp:Label>
        <asp:TextBox ID="txtTotalSpent" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
