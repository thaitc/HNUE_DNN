<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Manager_LookUp.ascx.cs" Inherits="Look_Up.Manager_LookUp" %>
<head>
    <title></title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>
    <script src="/DesktopModules/Week calendar/ckeditor/ckeditor.js"></script>

    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"></script>
</head>
<body>
    <div class="center">
        <div class="row">
            <div class="input-group-prepend col-md-2">
                <label>Tiêu đề:</label>
            </div>
            <div class="col-md-6">
                <asp:TextBox type="text" runat="server" class="form-control" ID="tbTitle"></asp:TextBox>
            </div>
            <div class="col-md-4"></div>
            <div class="col-md-12">
                <br />
            </div>
            <div class="input-group-prepend col-md-2">
                <label>Người hướng dẫn</label>
            </div>
            <div class="col-md-6">
                <asp:TextBox type="text" runat="server" class="form-control" ID="tbInstroctor"></asp:TextBox>
            </div>
            <div class="col-md-4"></div>
            <div class="col-md-12">
                <br />
            </div>
            <div class="input-group-prepend col-md-2">
                <label>Tác giả</label>
            </div>
            <div class="col-md-6">
                <asp:TextBox type="text" runat="server" class="form-control" ID="tb_Author"></asp:TextBox>
            </div>
            <div class="col-md-4"></div>
            <div class="col-md-12">
                <br />
            </div>
            <div class="input-group-prepend col-md-2">
                <label>Năm</label>
            </div>
            <div class="col-md-6">
                <asp:TextBox type="text" runat="server" class="form-control" ID="tbYear"></asp:TextBox>
            </div>
            <div class="col-md-4"></div>
            <div class="col-md-12">
                <br />
            </div>
            <div class="input-group-prepend col-md-2">
                <label>Mã thư viện</label>
            </div>
            <div class="col-md-6">
                <asp:TextBox type="text" runat="server" class="form-control" ID="tb_LibraryID"></asp:TextBox>
            </div>
            <div class="col-md-4"></div>
            <div class="col-md-12">
                <br />
            </div>
            <div class="input-group-prepend col-md-2">
                <label>Từ khoá</label>
            </div>
            <div class="col-md-6">
                <textarea class="form-control" id="tbKey" runat="server">  
                </textarea>
            </div>
            <div class="col-md-4"></div>
            <div class="col-md-12">
                <br />
            </div>
            <div class="col-md-10 text-center">
                <asp:Button runat="server" class="btn btn-primary" OnClick="bt_Update_Click" Text="Update" ID="bt_Update" />&ensp;
         <asp:Button runat="server" class="btn btn-secondary" OnClick="bt_Cancel_Click" Text="Cancel" ID="bt_Cancel" />
            </div>
        </div>

    </div>
</body>
<script>
    $(function () {
        $('[id$=bt_Update]').click(function () {
            var Title = $('input[id$=tbTitle]').val();

            if (Title == '') {
                alert('Vui lòng nhập tiêu đề ');
                    return false;
                }
            });
     });
</script>