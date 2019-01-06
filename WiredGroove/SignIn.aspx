﻿<%@ Page Title="" Language="C#" MasterPageFile="~/WiredGroove.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="WiredGroove.SignIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bgImages" style="position: fixed; background-image: url('../Images/RedMic01.png');">
        <div style="background-color: lightgray; margin-left: 10%; margin-top: 10%; width: 40%; position: fixed;" class="img-rounded">

            <form runat="server" class="form" style="width: 80%; height: 80%; margin: 40px;">
                <div class="form-group">
                    <h1>Sign In</h1>
                </div>
                <div class="form-group">
                    <label for="txtEmailID">Email</label>
                    <asp:TextBox ID="txtEmailID" runat="server" ClientIDMode="Static" class="form-control"></asp:TextBox>

                </div>
                <div class="form-group">
                    <label for="txtPasswordID">Password</label>
                    <asp:TextBox ID="txtPasswordID" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <br />
                <asp:Label ID="txtErrID" runat="server" ClientIDMode="Static" class="form-text text-muted text-danger" style="visibility: hidden" Text="Invalid Email or Password"></asp:Label>
                <div class="form-group" style="text-align: center">
                    <asp:Button ID="btnSignInID" CssClass="ui-button" ClientIDMode="Static" runat="server" Text="Sign In" OnClick="btnSignInID_Click" />
                </div>
            </form>
        </div>
    </div>
</asp:Content>
