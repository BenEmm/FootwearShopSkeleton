<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 321px">
    <form id="form1" runat="server">
        <div style="height: 30px">
            <asp:Label ID="lblStockID" runat="server" Text="Label ID" width="109px"></asp:Label>
            <asp:TextBox ID="txtStockID" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </div>
        <p>
            <asp:Label ID="lblStockDescription" runat="server" Text="Stock Description"></asp:Label>
            <asp:TextBox ID="txtStockDescription" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStockColour" runat="server" Text="Stock Colour" width="109px"></asp:Label>
            <asp:TextBox ID="txtStockColour" runat="server"></asp:TextBox>
        </p>
        <p style="height: 38px">
            <asp:Label ID="lblStockAmount" runat="server" Text="Stock Quantity" width="109px"></asp:Label>
            <asp:TextBox ID="txtStockAmount" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblStockPrice" runat="server" Text="Price" width="109px"></asp:Label>
        <asp:TextBox ID="txtStockPrice" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblDateOrdered" runat="server" Text="Date Ordered" width="109px"></asp:Label>
            <asp:TextBox ID="txtDateOrdered" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkAvailable" runat="server" Text="Available" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click1" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
