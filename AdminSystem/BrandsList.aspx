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
        <div>
            <ul class="ul-inline">
                <li>
                    <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" Width="75px" />
                </li>
                <li>
                    <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" Width="75px" />
                </li>
                <li>
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" Width="75px" />
                </li>
            </ul>
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            <br />
            <ul class="ul-inline">
                <li>
                    <asp:Label ID="lblFilter" runat="server" Text="Enter a brand name: "></asp:Label>
                </li>
                <li>
                    <asp:TextBox ID="txtBrandNameInput" runat="server" Width="151px" Height="17px"></asp:TextBox>
                </li>
            </ul>
            <ul class="ul-inline" style="border-width: 2px;">
                <li>
                    <asp:Button ID="btnApply" runat="server" Text="Apply"  Width="75px" OnClick="btnApply_Click" />
                </li>
                <li>
                    <asp:Button ID="btnClear" runat="server" Text="Clear"  Width="75px" OnClick="btnClear_Click" />
                </li>
            </ul>
            
            <style>
                .ul-inline > li {
                    display:inline-block;
                    margin: 10px;
                }
            </style>
        </div>
    </form>
</body>
</html>
