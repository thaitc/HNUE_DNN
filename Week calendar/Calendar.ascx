<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Calendar.ascx.cs" Inherits="Week_calendar.Calendar" %>
<head>
    <title>Lich tuan</title>
</head>
<body>
    <div class="row">
        <div class="col-md-12">
            <asp:Label Font-Bold="true" runat="server" ID="lbTitel"></asp:Label><br />
            <br />
        </div>
        <div class="col-md-12" id="calendar" runat="server">
            <asp:TextBox ID="yourTextBoxID" runat="server" TextMode="MultiLine"></asp:TextBox>
        </div>
        <div class="col-md-12">
            <b>
                <asp:Label runat="server" ID="lb_Date"></asp:Label></b>
        </div>
        <hr />
        <div class="col-md-12">
            <table class="list-group ">
                <tr>
                    <th><a style="color: white" class="list-group-item list-group-item-action active">Kế hoạch tuần khác</a></th>
                </tr>
                <asp:Repeater runat="server" ID="rptTuyensinh">
                    <ItemTemplate>
                        <tr>
                            <td>
                                <asp:LinkButton class="list-group-item list-group-item-action" runat="server" ID="bt_View" OnClick="bt_View_Click" CommandArgument='<%# Bind("Id") %>'><%# Eval("Titel") %></asp:LinkButton></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
            <br />
            <asp:Label runat="server" ID="lb_total"></asp:Label>
            <div style="overflow: hidden;">
                <asp:LinkButton ID="lbPrevious" runat="server"
                    OnClick="lbPrevious_Click"><<</asp:LinkButton>
                <asp:Repeater ID="rptPages" runat="server" OnItemCommand="rptPages_ItemCommand1">
                    <ItemTemplate>
                        <asp:LinkButton ID="btnPage" Style="padding: 1px 3px; margin: 1px; font: 14px tahoma;"
                            CommandName="Page" OnItemDataBound="rptPaging_ItemDataBound" CommandArgument="<%# Container.DataItem %>" runat="server"><%# Container.DataItem %>
                        </asp:LinkButton>
                    </ItemTemplate>
                </asp:Repeater>
                <asp:LinkButton ID="lbNext" class="page-item" runat="server" OnClick="lbNext_Click">>></asp:LinkButton>
            </div>
        </div>
    </div>
</body>
