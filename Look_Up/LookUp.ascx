<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LookUp.ascx.cs" Inherits="Look_Up.LookUp" %>
<head>
    <title>Quản lý lich tuan</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <style>
         th {
            text-align: center;
        }

        .btn1 {
            border: none;
            outline: none;
            padding: 1px 2px;
            margin: 1px;
            background-color: #f1f1f1;
            cursor: pointer;
            font: 14px tahoma;
        }

            /* Style the active class, and buttons on mouse-over */
            .active, .btn1:hover {
                background-color: red;
                color: white;
            }
    </style>
</head>
<body>
    <div class="row">
        <div class="col-md-3">
            <asp:TextBox runat="server" placeholder="Tìm kiếm" ID="search" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:DropDownList ID="drpSearch" name="drpSearch" runat="server" class="form-control">
                <asp:ListItem Value="0">Tất cả</asp:ListItem>
                <asp:ListItem Value="1">Tiêu đề</asp:ListItem>
                <asp:ListItem Value="2">Tác giả</asp:ListItem>
                <asp:ListItem Value="3">Năm</asp:ListItem>
                <asp:ListItem Value="4">Mã thư viện</asp:ListItem>
                <asp:ListItem Value="5">Người hướng dẫn</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="col-md-3">
            <asp:Button runat="server" class="btn btn-primary" OnClick="bt_Search" Text="Search" ID="btSearch"/>
        </div>
        <div class="col-md-3" style="text-align:right">
             <a href="<%= BuildUrl("Manager_LookUp") %>"><asp:Button runat="server" OnClick="bt_Create_Click" class="btn btn-success" Text="Thêm" /></a>
        </div>
    </div>
    <br />
    <table border="0" class="table table-striped table-hover">
        <thead class="table-primary" style="background-color: red;height:10px; color: white;">
            <tr>
                <th>STT</th>
                <th>Tiêu đề</th>
                <th>Tác giả</th>
                <th>Người hướng dẫn</th>
                <th>Năm</th>
                <th>Mã thư viện</th>
                <th colspan="2">Thao tác</th>
            </tr>
        </thead>
        <asp:Repeater runat="server" ID="rptLookUp">
            <ItemTemplate>
                <tr>
                    <td class="text-center"><%#  Container.ItemIndex + 1 %></td>
                    <td style="text-align: justify"><%# Eval("Title") %></td>
                    <td style="text-align: center"><%# Eval("Author") %></td>
                    <td style="text-align: center"><%# Eval("Instructor") %></td>
                    <td style="text-align: center"><%# Eval("Year") %></td>
                    <td style="text-align: center"><%# Eval("LibraryID") %></td>
                    <td>
                        <a id="Edit" href="<%# BuildUrl("Edit","Id="+ Eval("Id")) %>">Edit</a>
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
    <div id="padding" style="overflow: hidden;">
        <asp:LinkButton ID="lbPrevious" runat="server" CssClass="btn1"
            OnClick="lbPrevious_Click"><i class="fa fa-caret-square-o-left" aria-hidden="true"></i></asp:LinkButton>
        <asp:Repeater ID="rptPages" runat="server" OnItemCommand="rptPages_ItemCommand1">
            <ItemTemplate>
                <asp:LinkButton CssClass="btn1" ID="btnPage" Style="padding: 1px 3px; margin: 1px; font: 14px tahoma;"
                    CommandName="Page" OnItemDataBound="rptPaging_ItemDataBound" CommandArgument="<%# Container.DataItem %>" runat="server"><%# Container.DataItem %>
                </asp:LinkButton>
            </ItemTemplate>
        </asp:Repeater>
        <asp:LinkButton ID="lbNext" CssClass="btn1" runat="server" OnClick="lbNext_Click"><i class="fa fa-caret-square-o-right" aria-hidden="true"></i></asp:LinkButton>
    </div>
</body>
<script>
    // Add active class to the current button (highlight it)
    var header = document.getElementById("padding");
    var btns = header.getElementsByClassName("btn");
    for (var i = 0; i < btns.length; i++) {
        btns[i].addEventListener("click", function () {
            var current = document.getElementsByClassName("active");
            current[0].className = current[0].className.replace(" active", "");
            this.className += " active";
        });
    }
</script>