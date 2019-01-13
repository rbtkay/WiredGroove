<%@ Page Title="" Language="C#" MasterPageFile="~/WiredGroove.Master" AutoEventWireup="true" CodeBehind="BecomeArtist.aspx.cs" Inherits="WiredGroove.BecomeArtist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bgImages" style="position: fixed; background-image: url('../Images/RedStageHD.jpg');"></div>

    <div style="background-color: lightgray; margin-left: 35%; margin-top: 7%; width: 30%; position: absolute;" class="img-rounded">
        <form runat="server" class="form" style="width: 80%; height: 80%; margin: auto;">
            <div class="form-group">
                <h1 style="font-style: italic; text-align: center; color: maroon;">...Let There Be Sound...</h1>
            </div>

            <div class="form-group">
                <label for="txEmail">Email</label>
                <asp:TextBox ID="txtEmail" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                <small id="" class="form-text text-muted" style="color: red;"></small>
            </div>

            <div class="form-group">
                <label for="txtName">Artist Name</label>
                <asp:TextBox ID="txtName" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                <small id="" class="form-text text-muted" style="color: red;"></small>
            </div>

            <div class="form-group">
                <label for="txtInstrument">Instrument(s)</label>
                <asp:TextBox ID="txtInstrument" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                <small id="" class="form-text text-muted" style="color: red;"></small>
            </div>

            <div class="form-group">
                <label for="txtGenre">Genre</label>
                <asp:DropDownList ID="ddlGenre" ClientIDMode="Static" runat="server" CssClass="form-control">
                </asp:DropDownList>
                <asp:ListBox ID="lbGenre" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:ListBox>
                <small id="" class="form-text text-muted" style="color: red;"></small>
            </div>

            <div class="form-group">
                <label for="txtPortfolio">Portfolio</label>
                <asp:TextBox ID="txtPortfolio" ClientIDMode="Static" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                <small id="" class="form-text text-muted" style="color: red;"></small>
            </div>

            <div class="form-group">
                <label for="txtAddress">Address</label>
                <asp:TextBox ID="txtAddress" ClientIDMode="Static" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                <small id="" class="form-text text-muted" style="color: red;"></small>
            </div>

            <div class="form-group">
                <label for="txtBand">Band (optional)</label>
                <asp:TextBox ID="txtBand" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                <small id="" class="form-text text-muted" style="color: red;"></small>
            </div>

            <div class="form-group">
                <label for="txtAdditionalInfo">Additional Info</label>
                <asp:TextBox ID="txtAdditionalInfo" ClientIDMode="Static" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                <small id="" class="form-text text-muted" style="color: red;"></small>
            </div>

            <div style="text-align: center;">


            </div>
        </form>
    </div>
</asp:Content>
