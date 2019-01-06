<%@ Page Title="" Language="C#" MasterPageFile="~/WiredGroove.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WiredGroove.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="bgImages" style="position:fixed; background-image: url('../Images/HomePageBackground.jpg');">
        <div style="background-color:lightgray; margin-left:10%; margin-top:10%; width: 30%; position:fixed;" class="img-rounded" >
            
            <form runat="server" class="form" style="width: 80%; height:80%; margin:40px;">
                <div class="form-group">
                    <h1>Find Artists Around You</h1>
                </div>
                <div class="form-group">
                    <label for="txtLocationID">Where?</label>
                    <asp:TextBox ID="txtLocationID" runat="server" class="form-control"></asp:TextBox>
                    <small id="txtLocationHelperID" class="form-text text-muted">Don't worry, we won't track your location (yet)</small>
                </div>
                <div class="form-group">
                    <label for="txtCalendarID">When?</label>
                    <asp:TextBox ID="txtCalendarID" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
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
                </div>

                <br />

                <div class="form-group" style="text-align: center">
                    <asp:Button ID="btnLookupID" runat="server" Text="Lookup Artists" />
                </div>
            </form>
        </div>
    </div>
</asp:Content>
