<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BrandsConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 10px;">
            <asp:Label ID="lblConfirm" runat="server" Text="Are you sure you would like to delete this record?"></asp:Label>
            <div style="padding: 20px">
                <asp:Button ID="btnYes" runat="server" Text="Yes" Width="50px" OnClick="btnYes_Click"/>
                <asp:Button ID="btnNo" runat="server" Text="No" Width="50px" OnClick="btnNo_Click" />
            </div>
            
        </div>
    </form>
    <style>
        #btnYes  {
            margin-right:10px;
        }
    </style>
</body>
</html>
