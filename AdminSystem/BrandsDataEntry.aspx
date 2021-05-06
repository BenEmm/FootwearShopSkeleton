<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BrandsDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Add Brand</title>
    </head>
    <body style="height: 250px; font-family: sans-serif;">
    <style>
        body  {
            width: 60%;
            padding: 30px;
        }
        span  {
            padding-left: 5px;
            padding-right: 5px;
        }
        #calendar  {
            padding:30px;
            text-align:center;
            align-content:center;
        }
        .row  {
            margin: 15px;
            width: 386px;
        }
        .label  {
            margin-right: 5px;
        }
        .title  {
            font-size: 25px;
        }
        .inline {
            width:48%;
            display:inline;
            float:left;
        }
        .error  {
            background-color: #cb4d4d;
            width: auto;
            text-align:center;
            /*padding:;*/
        }
    </style>
    <form id="form1" runat="server">
        <div class="inline">

            <asp:Label ID="lblDataEntry" runat="server" Text="Add new brand..." class="label title"></asp:Label>

            <hr />

            <asp:Label ID="lblErrorAlert" class="label error" runat="server" Visible="false"></asp:Label>

            <div class="row">
                <asp:Label ID="lblBrandID" class="label" runat="server" Text="Brand ID: "></asp:Label>
                <asp:TextBox ID="tbBrandID" runat="server" Width="152px" Wrap="False"></asp:TextBox>
                <span></span>
                <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />
            </div>
            <hr />
            <asp:Label ID="lblValidateError" class="label error" runat="server" Visible="false"></asp:Label>
            <br />
            <div class="row">
                <asp:Label ID="lblName" class="label" runat="server" Text="Brand name: "></asp:Label>
                <asp:TextBox ID="tbName" runat="server" Width="152px" Wrap="False"></asp:TextBox>
            </div>
            <div class="row" style="height: 26px; width: 263px;">
                <asp:Label ID="lblTop" runat="server" class="label" Text="Top product: "></asp:Label>
                <asp:DropDownList ID="dropTop" runat="server" OnSelectedIndexChanged="dropTop_SelectedIndexChanged">
                    <asp:ListItem Selected="True" Value="1">1</asp:ListItem>
                    <asp:ListItem Selected="False" Value="2">2</asp:ListItem>
                    <asp:ListItem Selected="False" Value="3">3</asp:ListItem>
                    <asp:ListItem Selected="False" Value="4">4</asp:ListItem>
                    <asp:ListItem Selected="False" Value="5">5</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="row" style="height: 26px; width: 263px;">
                <asp:Label ID="lblLatest" runat="server" class="label" Text="Latest product:"></asp:Label>
                <asp:DropDownList ID="dropLatest" runat="server" Height="16px">
                    <asp:ListItem Selected="True" Value="1">1</asp:ListItem>
                    <asp:ListItem Selected="False" Value="2">2</asp:ListItem>
                    <asp:ListItem Selected="False" Value="3">3</asp:ListItem>
                    <asp:ListItem Selected="False" Value="4">4</asp:ListItem>
                    <asp:ListItem Selected="False" Value="5">5</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="row">
                <asp:Label ID="lblList" class="label" runat="server" Text="List this brand?: "></asp:Label>
                <asp:CheckBox ID="cbList" runat="server" OnCheckedChanged="cbList_CheckedChanged" />
            </div>
            <div class="row">
                <asp:Label ID="lblRestockDate" class="label" runat="server" Text="Select restock date: "></asp:Label>
                <span>
                    <asp:Label ID="lblSelectedDate" class="label" runat="server" Text=""></asp:Label>
                </span>
                <asp:Button ID="btnShowCalendar" runat="server" Text="Select" OnClick="btnShowCalendar_click" />
            </div>
            <div class="row">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            </div>
            
        </div>
        <div class="inline">
            <div id="calendar">
                <asp:Calendar ID="cdrRestock" runat="server" Height="16px" Width="120px" BackColor="#FF6600" BorderColor="#666666" CellPadding="3" CellSpacing="1" OnSelectionChanged="cdrRestock_SelectionChanged" Visible="False"></asp:Calendar>
            </div>
        </div>
    </form>
    </body>
</html>
