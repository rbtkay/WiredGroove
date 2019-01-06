<%@ Page Title="" Language="C#" MasterPageFile="~/WiredGroove.Master" AutoEventWireup="true" CodeBehind="sHomePage.aspx.cs" Inherits="WiredGroove.sHomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




    <div style="margin-top: 5%">
        <div class="col-sm-2">
            <div class="list-group" id="list-tab" role="tablist">
                <a class="list-group-item list-group-item-action" id="list-home-list"  href="#list-home" role="tab" aria-controls="home">Home</a>
                <a class="list-group-item list-group-item-action" id="list-profile-list" data-toggle="list" href="#list-profile" role="tab" aria-controls="profile">Profile</a>
                <a class="list-group-item list-group-item-action" id="list-messages-list" data-toggle="list" href="#list-messages" role="tab" aria-controls="messages">Messages</a>
                <a class="list-group-item list-group-item-action" id="list-settings-list" data-toggle="list" href="#list-settings" role="tab" aria-controls="settings">Settings</a>
            </div>
        </div>
        <div class="col-sm-7">
            
        </div>
        <div class="col-sm-3">
            <div class="row">
                <div class="col-sm-12">
                    <div class="media">
                        <a class="pull-left" href="#">
                            <img class="media-object dp img-circle" src="http://www.huffmancode.com/img/hardik.jpg" style="width: 100px; height: 100px;">
                        </a>
                        <div class="media-body">
                            <h4 class="media-heading">Hardik Sondagar <small>India</small></h4>
                            <h5>Software Developer at <a href="http://gridle.in">Gridle.in</a></h5>
                            <hr style="margin: 8px auto">

                            <span class="label label-default">HTML5/CSS3</span>
                            <span class="label label-default">jQuery</span>
                            <span class="label label-info">CakePHP</span>
                            <span class="label label-default">Android</span>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <div class="media">
                        <a class="pull-left" href="#">
                            <img class="media-object dp img-circle" src="http://www.huffmancode.com/img/hardik.jpg" style="width: 100px; height: 100px;">
                        </a>
                        <div class="media-body">
                            <h4 class="media-heading">Hardik Sondagar <small>India</small></h4>
                            <h5>Software Developer at <a href="http://gridle.in">Gridle.in</a></h5>
                            <hr style="margin: 8px auto">

                            <span class="label label-default">HTML5/CSS3</span>
                            <span class="label label-default">jQuery</span>
                            <span class="label label-info">CakePHP</span>
                            <span class="label label-default">Android</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
