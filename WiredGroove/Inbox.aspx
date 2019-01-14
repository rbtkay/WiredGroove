<%@ Page Title="" Language="C#" MasterPageFile="~/WiredGroove.Master" AutoEventWireup="true" CodeBehind="Inbox.aspx.cs" Inherits="WiredGroove.Inbox" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <div style="margin-top: 5%">
            <div class="col-sm-2">
                <div class="list-group" id="list-tab" role="tablist">
                    <a class="list-group-item list-group-item-action" id="list-home-list" href="#list-home" role="tab" aria-controls="home">Profile</a>
                    <button type="button" class="list-group-item list-group-item-action" data-toggle="modal" data-target="#myModal">Upload Media</button>
                    <a class="list-group-item list-group-item-action" id="list-messages-list" data-toggle="list" href="CreateEvent.aspx" role="tab" aria-controls="messages">Create Event</a>
                    <a class="list-group-item list-group-item-action" id="list-settings-list" data-toggle="list" href="#list-settings" role="tab" aria-controls="settings">Settings</a>
                </div>
            </div>
            <div class="col-sm-7" id="list-connection">
            </div>
            <div class="col-sm-3" id="list-popular-artist">
            </div>
        </div>

    </form>
    <script type="text/javascript" src="./Scripts/Inbox.js"></script>
</asp:Content>
