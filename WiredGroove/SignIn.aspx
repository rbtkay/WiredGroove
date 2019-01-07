<%@ Page Title="" Language="C#" MasterPageFile="~/WiredGroove.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="WiredGroove.SignIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bgImages" style="position: fixed; background-image: url('../Images/RedMic01.png');">

        <div style="background-color: lightgray; margin-left: 10%; margin-top: 10%; width: 30%; position: fixed;" class="img-rounded">


            <form runat="server" class="form, container" style="width: 80%; height: 80%; margin: 40px;">
                <div class="form-group">
                    <h1>Sign In</h1>
                </div>

                <div class="form-group col-sm-12">
                    <label for="txtEmailID">Email</label>
                    <asp:TextBox ID="txtEmailID" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group col-sm-12">
                    <label for="txtPasswordID">Password</label>
                    <asp:TextBox ID="txtPasswordID" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <br />
              
                <asp:Label ID="txtErrID" runat="server" ClientIDMode="Static" class="form-text text-muted text-danger col-sm-12" Style="visibility: hidden" Text="Invalid Email or Password"></asp:Label>
                <div class="col-sm-12">
                    <asp:Button ID="btnSignInID" CssClass="btn btn-primary btn-lg" style="background-color: maroon;" ClientIDMode="Static" runat="server" Text="Sign In" OnClick="btnSignInID_Click" />
                    <asp:HyperLink ID="hlSignUp" runat="server" NavigateUrl="~/SignUp.aspx">New to WiredGroove?</asp:HyperLink>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
