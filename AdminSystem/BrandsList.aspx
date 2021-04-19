<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BrandsList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstBrandList" runat="server" Height="320px" Width="393px" OnSelectedIndexChanged="lstBrandList_SelectedIndexChanged"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" Width="75px" />
        </p>
    </form>
</body>
</html>
