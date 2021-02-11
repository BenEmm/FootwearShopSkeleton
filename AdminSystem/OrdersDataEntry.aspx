<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    This is the order entry page
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderNo" runat="server" Text="Order Number" width="47px"></asp:Label>
        <asp:TextBox ID="txtOrderNo" runat="server" Height="25px" style="margin-left: 40px" Width="178px"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name" width="47px"></asp:Label>
            <asp:TextBox ID="txtCustomerName" runat="server" style="margin-left: 38px" Width="178px" height="25px"></asp:TextBox>
        </p>
        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="margin-left: 38px" height="25px" width="178px"></asp:TextBox>
        <p>
            <asp:Label ID="lblTrackingNo" runat="server" Text="Tracking Number" width="47px"></asp:Label>
            <asp:TextBox ID="txtTrackingNo" runat="server" style="margin-left: 42px"></asp:TextBox>
        </p>
        <asp:Label ID="lblTotalPrice" runat="server" Text="Total Price" width="47px"></asp:Label>
        <asp:TextBox ID="txtTotalPrice" runat="server" style="margin-left: 41px" height="25px" width="178px"></asp:TextBox>
        <p>
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity" width="47px"></asp:Label>
            <asp:TextBox ID="txtQuantity" runat="server" style="margin-left: 42px" height="25px" width="178px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblShippingDate" runat="server" Text="Shipping Date" width="47px"></asp:Label>
            <asp:TextBox ID="txtShippingDate" runat="server" style="margin-left: 42px" height="25px" width="178px"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkShipped" runat="server" Text="Shipped" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="margin-left: 14px" Text="Cancel" Width="91px" />
        </p>
    </form>
</body>
</html>
