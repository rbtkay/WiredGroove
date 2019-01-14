<%@ Page Title="" Language="C#" MasterPageFile="~/WiredGroove.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WiredGroove.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="bgImages" style="position: fixed; background-image: url('../Images/HomePageBackground.jpg');">
        <div style="background-color: lightgray; margin-left: 10%; margin-top: 10%; width: 30%; position: fixed;" class="img-rounded">

            <form runat="server" class="form" style="width: 80%; height: 80%; margin: 40px;">
                <div class="form-group">
                    <h1 style="color: maroon;">Find Artists Around You</h1>
                </div>
                <div class="form-group">
                    <label for="txtLocationID">Where?</label>
                    <asp:TextBox ID="txtLocationID" runat="server" class="form-control"></asp:TextBox>
                    <small id="txtLocationHelperID" class="form-text text-muted">Don't worry, we won't track your location (yet)</small>
                </div>
                <div class="form-group">
                    <label for="txtInstrumentID">Instrument</label>
                    <asp:TextBox ID="txtInstrumentID" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="ddlGenreID">Genre?</label>
                    <asp:DropDownList ID="ddlGenreID" runat="server" CssClass="form-control">
                        <asp:ListItem Selected="True" Value="--Select Genre--" Text=" -- Select Genre -- "></asp:ListItem>
                        <asp:ListItem Value="Rock" Text="Rock"></asp:ListItem>
                        <asp:ListItem Value="Techno" Text="Techno"></asp:ListItem>
                        <asp:ListItem Value="Rap" Text="Rap"></asp:ListItem>
                        <asp:ListItem Value="Classical" Text="Classical"></asp:ListItem>
                        <asp:ListItem Value="Metal" Text="Metal"></asp:ListItem>
                        <asp:ListItem Value="Arabic" Text="Arabic"></asp:ListItem>
                        <asp:ListItem Value="French" Text="French"></asp:ListItem>
                    </asp:DropDownList>
                    <small id="ddlGenreHelperID" class="form-text text-muted">Select the musician genre</small>
                </div>
                <div class="form-group" style="text-align: center">
                    -----------OR-----------
                </div>

                <div class="form-group">
                    <label for="txtArtistNameID">Who?</label>
                    <asp:TextBox ID="txtArtistNameID" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <br />

                <div class="form-group" style="text-align: center">
                    <asp:Button ID="btnLookupID" ClientIDMode="Static" runat="server" Text="Lookup Artists" CssClass="btn btn-primary btn-lg" Style="background-color: maroon;" OnClick="btnLookupID_Click" />
                </div>
            </form>
        </div>
    </div>
</asp:Content>
