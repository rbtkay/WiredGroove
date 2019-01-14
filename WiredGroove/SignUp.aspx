<%@ Page Title="" Language="C#" MasterPageFile="~/WiredGroove.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="WiredGroove.SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="Scripts/SignUp.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="bgImages" style="position: fixed; background-image: url('../Images/Red.jpg');"></div>

    <div style="background-color: lightgray; margin-left: 35%; margin-top: 7%; width: 30%; position: absolute;" class="img-rounded">

        <form runat="server" class="form" style="width: 80%; height: 80%; margin: auto;">
            <div class="form-group">
                <h1 style="font-weight: bold; color:maroon;">Join WiredGroove!</h1>
            </div>

            <div class="form-group">
                <label for="txtFullNameID">Full Name</label>
                <asp:TextBox ID="txtFullNameID" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                <small id="smNameID" class="form-text text-muted" style="color: red;"></small>
            </div>

            <div class="form-group">
                <label for="txtEmailID">Email</label>
                <asp:TextBox ID="txtEmailID" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                <small id="smEmailID" class="form-text text-muted" style="color: red;"></small>
            </div>

            <div class="form-group">
                <label for="txtPasswordID">Password</label>
                <asp:TextBox ID="txtPasswordID" ClientIDMode="Static" runat="server" CssClass="form-control" TextMode="Password" OnTextChanged="txtPasswordID_TextChanged"></asp:TextBox>
                <small id="smPasswordID" class="form-text text-muted" style="color: red;"></small>

            </div>

            <div class="form-group">
                <label for="txtConfirmPasswordID">Confirm Password</label>
                <asp:TextBox ID="txtConfirmPasswordID" ClientIDMode="Static" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                <small id="smConfirmPasswordID" class="form-text text-muted" style="color: red;"></small>

            </div>

            <div class="form-group">
                <label for="txtPhoneID">Phone</label>
                <asp:TextBox ID="txtPhoneID" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                <small id="smPhoneID" class="form-text text-muted" style="color: red;"></small>

            </div>

            <div class="form-group">
                <label for="txtDoBID">Date of Birth</label>
                <asp:TextBox ID="txtDoBID" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="ddlPreferencesID">Tell us what you like</label>
                <asp:DropDownList ID="ddlPreferencesID" runat="server" CssClass="form-control" Style="width: 50%;" AutoPostBack="True" OnSelectedIndexChanged="ddlPreferencesID_SelectedIndexChanged">
                    <asp:ListItem Selected="True" Value="--Select Genre--" Text=" -- Select Genre -- "></asp:ListItem>
                    <asp:ListItem Value="Rock" Text="Rock"></asp:ListItem>
                    <asp:ListItem Value="Techno" Text="Techno"></asp:ListItem>
                    <asp:ListItem Value="Rap" Text="Rap"></asp:ListItem>
                    <asp:ListItem Value="Classical" Text="Classical"></asp:ListItem>
                    <asp:ListItem Value="Metal" Text="Metal"></asp:ListItem>
                    <asp:ListItem Value="Arabic" Text="Arabic"></asp:ListItem>
                    <asp:ListItem Value="French" Text="French"></asp:ListItem>
                </asp:DropDownList>


                <small id="ddlGenreHelperID" class="form-text text-muted">This will help us filter search results</small>
            </div>

            <div class="form-group">
                <label for="lbPreferencesID">Preferences</label>
                <br />
                <asp:ListBox ID="lbPreferencesID" runat="server" CssClass="form-control"></asp:ListBox>
                <asp:Button ID="btnRemove" runat="server" CssClass="btn btn-primary" Style="background-color: maroon; font-weight: bold; float:right;" Text="-" OnClick="btnRemove_Click" />

            </div>

            <br />

            <div class="form-group" style="text-align: center;">
                <asp:Button ID="btnSignUp" ClientIDMode="Static" runat="server" Text="Sign Up" OnClick="btnSignUp_Click" CssClass="btn btn-primary btn-lg" Style="background-color: maroon;" />
            </div>

            <small id="hiddenPass" runat="server" ClientIDMode="Static" class="hidden"></small>

        </form>
    </div>
</asp:Content>
