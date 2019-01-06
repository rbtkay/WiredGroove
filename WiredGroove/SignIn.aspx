<%@ Page Title="" Language="C#" MasterPageFile="~/WiredGroove.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="WiredGroove.SignIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bgImages" style="position: fixed; background-image: url('../Images/RedMic01.png');">
        <div style="background-color:lightgray; margin-left:10%; margin-top:10%; width: 30%; position:fixed;" class="img-rounded" >
            
            <form runat="server" class="form" style="width: 80%; height:80%; margin:40px;">
                <div class="form-group">
                    <h1>Sign In</h1>
                </div>
                <div class="form-group">
                    <label for="txtEmailID">Email</label>
                    <asp:TextBox ID="txtEmailID" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                    <%--<small id="txtLocationHelperID" class="form-text text-muted">Don't worry, we won't track your location (yet)</small>--%>
                </div>
                <div class="form-group">
                    <label for="txtPasswordID">Password</label>
                    <asp:TextBox ID="txtPasswordID" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <%--<div class="form-group">
                    <label for="ddlGenreID">Genre?</label>
                    <asp:DropDownList ID="ddlGenreID" runat="server" CssClass="form-control">
                        <asp:ListItem Selected="True" Value="--Select Genre--"></asp:ListItem>
                    </asp:DropDownList>
                    <small id="ddlGenreHelperID" class="form-text text-muted">Select the musician genre</small>
                </div>
                <div class="form-group" style="text-align: center">
                    -----------OR-----------
                </div>

                <div class="form-group">
                    <label for="txtArtistNameID">Artist Name:</label>
                    <asp:TextBox ID="txtArtistNameID" runat="server" class="form-control"></asp:TextBox>
                </div>--%>

                <br />

                <div class="form-group" style="margin-left: 30%;">
                    <asp:Button ID="btnSignIn" runat="server" Text="Sign In" CssClass="ui-button"/>
                    <asp:HyperLink ID="hlSignUp" runat="server" style="margin-left: 30%;" NavigateUrl="~/SignUp.aspx">New to WiredGroove?</asp:HyperLink>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
