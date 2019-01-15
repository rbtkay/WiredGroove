<%@ Page Title="" Language="C#" MasterPageFile="~/WiredGroove.Master" AutoEventWireup="true" CodeBehind="Messages.aspx.cs" Inherits="WiredGroove.Messages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript" src="./Scripts/Message.js"></script>
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
            <div class="col-sm-6" id="list-messages" style="margin-top: 5%; margin-left: 10%; background-color: lightgray;">
            </div>

            <div class="form-group" style="margin-top: 5%;">

                <br />
                <br />
                <br />

                <asp:TextBox runat="server" ID="txtMessageContent" ClientIDMode="Static" CssClass="form-control" Style="width: 50%; margin-left: 27%;"></asp:TextBox>
                <asp:Button runat="server" Text="Send" ID="btnSendMessage" ClientIDMode="Static" CssClass="btn btn-primary btn-lg" Style="background-color: maroon; margin-left: 45%;" OnClick="btnSendMessage_Click" />
            </div>
        </div>

    </form>

</asp:Content>
