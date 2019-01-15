<%@ Page Title="" Language="C#" MasterPageFile="~/WiredGroove.Master" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="WiredGroove.ViewProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript" src="./Scripts/ViewProfile.js"></script>

    <form runat="server">
        <div style="margin-top: 5%">
            <div class="col-sm-2">
                <div class="list-group" id="list-tab" role="tablist">
                    <a class="list-group-item list-group-item-action" id="list-home-list" href="#list-home" role="tab" aria-controls="home">Profile</a>
                    <button type="button" class="list-group-item list-group-item-action" data-toggle="modal" data-target="#myModal">Upload Media</button>
                    <a class="list-group-item list-group-item-action" id="list-messages-list" data-toggle="list" href="CreateEvent.aspx" role="tab" aria-controls="messages">Create Event</a>
                    <a class="list-group-item list-group-item-action" id="list-settings-list" data-toggle="list" href="MyEvent.aspx" role="tab" aria-controls="settings">My Events</a>
                    <%if (string.IsNullOrEmpty(Session["connected"] as string)) { %>
                    <asp:Button ID="btnAddConnection" runat="server" ClientIDMode="Static" CssClass="btn btn-primary" style="background-color: maroon" Text="Connect" OnClick="btnAddConnection_Click"/>
                    <% } %>
                </div>
            </div>
            <div class="col-sm-7" id="account-media">
            </div>
        </div>
    </form>
</asp:Content>
