<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Calendar_Edit.ascx.cs" Inherits="Week_calendar.Calendar_Edit" %>
<head>
    <title>Edit</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>
    <script src="/DesktopModules/Week calendar/ckeditor/ckeditor.js"></script>
</head>
<div class="input-group mb-3">
    <div class="input-group-prepend">
        <span class="input-group-text" id="basic-addon3">Tiêu đề:</span>
    </div>
    <asp:TextBox type="text" runat="server" class="form-control" ID="Titel" aria-describedby="basic-addon3"></asp:TextBox>
</div>
<div id="calendar" runat="server">
    <asp:TextBox ID="yourTextBoxID" runat="server" TextMode="MultiLine"></asp:TextBox>
</div>
<br />
<div class="text-center">
    <asp:Button runat="server" class="btn btn-primary" OnClick="bt_Update_Click" Text="Update" ID="bt_Update" />&ensp;
         <asp:Button runat="server" class="btn btn-secondary" OnClick="bt_Cancel_Click" Text="Cancel" ID="bt_Cancel" />
</div>
<script type="text/javascript" lang="javascript">CKEDITOR.replace('<%=yourTextBoxID.ClientID%>');</script>
