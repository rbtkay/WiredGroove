<%@ Page Title="" Language="C#" MasterPageFile="~/WiredGroove.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="WiredGroove.SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bgImages" style="position: fixed; background-image: url('../Images/Red.jpg');">
        <div style="background-color: lightgray; margin-left: 35%; margin-top: 7%; width: 30%; position: fixed;" class="img-rounded">

            <form runat="server" class="form" style="width: 80%; height: 80%; margin: auto;">
                <div class="form-group">
                    <h1>Join WiredGroove!</h1>
                </div>

                <div class="form-group">
                    <label for="txtFullNameID">Full Name</label>
                    <asp:TextBox ID="txtFullNameID" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                    <%--<small id="txtLocationHelperID" class="form-text text-muted">Hello</small>--%>
                </div>

                <div class="form-group">
                    <label for="txtEmailID">Email</label>
                    <asp:TextBox ID="txtEmailID" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="txtPasswordID">Password</label>
                    <asp:TextBox ID="txtPasswordID" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="txtConfirmPasswordID">Confirm Password</label>
                    <asp:TextBox ID="txtConfirmPasswordID" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="txtPhoneID">Phone</label>
                    <asp:TextBox ID="txtPhoneID" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="txtDoBID">Date of Birth</label>
                    <asp:TextBox ID="txtDoBID" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="ddlPreferencesID">Tell us what you like</label>
                    <asp:DropDownList ID="ddlPreferencesID" runat="server" CssClass="form-control">
                        <asp:ListItem Selected="True" Value="--Select Genre--"></asp:ListItem>
                    </asp:DropDownList>
                    <small id="ddlGenreHelperID" class="form-text text-muted">This will help us filter search results</small>
                </div>

                <div class="form-group">
                    <label for="lbPreferencesID">Preferences</label>
                    <br />
                    <asp:ListBox ID="lbPreferencesID" runat="server" Width="100%">
                        
                    </asp:ListBox>
                </div>

                <br />

                <div class="form-group" style="text-align: center;">
                    <asp:Button ID="btnSignUp" runat="server" Text="Sign Up" CssClass="ui-button" OnClick="btnSignUp_Click" />
                </div>
     
            </form>
        </div>
    </div>
</asp:Content>
