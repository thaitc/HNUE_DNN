<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Calendar_List.ascx.cs" Inherits="Week_calendar.Calendar_List" %>
<head>
    <title>Quản lý lich tuan</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <style>
        td, th {
            text-align: center;
        }
    </style>
</head>
<body>
    <a href="<%= BuildUrl("Manager") %>">
        <svg width="1em" height="1em" viewBox="0 0 16 16" class="bi bi-plus-square" fill="currentColor" xmlns="http://www.w3.org/2000/svg">
            <path fill-rule="evenodd" d="M14 1H2a1 1 0 0 0-1 1v12a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1V2a1 1 0 0 0-1-1zM2 0a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2H2z" />
            <path fill-rule="evenodd" d="M8 4a.5.5 0 0 1 .5.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3A.5.5 0 0 1 8 4z" />
        </svg>&ensp;Thêm lịch tuần</a><br />
    <table border="1" class="table table-striped table-hover">
        <thead class="table-primary">
            <tr>
                <th>STT</th>
                <th>Tiêu đề</th>
                <th>Ngày cập nhật</th>
                <th>Cập nhật bởi</th>
                <th colspan="2">Thao tác</th>
            </tr>
        </thead>
        <asp:Repeater runat="server" ID="rptTuyensinh">
            <ItemTemplate>
                <tr>
                    <td class="text-center"><%#  Container.ItemIndex + 1 %></td>
                    <td style="text-align: center"><%# Eval("Titel") %></td>
                    <td style="text-align: center"><%# Eval("Update","{0:dd-MM-yyyy}") %></td>
                    <td style="text-align: center"><%# Eval("Update_by") %></td>
                    <td>
                        <a id="Edit" href="<%# BuildUrl("Calendar_Edit","Id="+ Eval("Id")) %>">Edit</a>
                    </td>
                    <td>
                        <asp:LinkButton runat="server" ID="LinkButton1" OnClick="Del" CommandArgument='<%# Bind("Id") %>' OnClientClick="return confirm('Bạn có chắc muốn xóa?')">Delete</asp:LinkButton>
                    </td>
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
</body>
