<%@ Page Title="" Language="C#" MasterPageFile="~/WiredGroove.Master" AutoEventWireup="true" CodeBehind="CreateEvent.aspx.cs" Inherits="WiredGroove.CreateEvent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bgImages" style="position: fixed; background-color: maroon;">
        <div class="img-rounded" style="background-color: lightgray; width: 80%; margin: 5%;">
            <form runat="server">
                <div class="form-group">
                    <h1 style="color: maroon">Host Event</h1>
                </div>

                <div class="form-group">
                    <label for="txtEventName">Event Name</label>
                    <asp:TextBox ID="txtEventName" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="txtStartDate">Start Date</label>
                    <asp:TextBox ID="txtStartDate" runat="server" ClientIDMode="Static" CssClass="form-control" Style="width: 40%;"></asp:TextBox>
                    <%--check here--%>
                    <label for="txtEndDate">End Date</label>
                    <asp:TextBox ID="txtEndDate" runat="server" ClientIDMode="Static" CssClass="form-control" Style="width: 40%;"></asp:TextBox>
                    <%--check here--%>
                </div>

                <div class="form-group">
                    <label for="ddlLocation">Location</label>
                    <asp:DropDownList ID="ddlLocation" ClientIDMode="Static" runat="server" CssClass="form-control">
                        <asp:ListItem Value="--Select Location--" Text=" -- Select Location -- " Selected="True"></asp:ListItem>
                        <asp:ListItem Value="Beirut" Text="Beirut"></asp:ListItem>
                        <asp:ListItem Value="Zahle" Text="Zahle"></asp:ListItem>
                        <asp:ListItem Value="Saida" Text="Saida"></asp:ListItem>
                        <asp:ListItem Value="Jbeil" Text="Jbeil"></asp:ListItem>
                        <asp:ListItem Value="Hamra" Text="Hamra"></asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="form-group">
                    <label for="txtCapacity">Capacity</label>
                    <asp:TextBox ID="txtCapacity" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="ddlType">Type</label>
                    <asp:DropDownList ID="ddlType" ClientIDMode="Static" runat="server">
                        <asp:ListItem Value="--Select Type--" Text=" -- Select Type -- " Selected="True"></asp:ListItem>
                        <asp:ListItem Value="Anniversary" Text="Anniversary"></asp:ListItem>
                        <asp:ListItem Value="House Party" Text="House Party"></asp:ListItem>
                        <asp:ListItem Value="Rave" Text="Rave"></asp:ListItem>
                        <asp:ListItem Value="Concert" Text="Concert"></asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="form-group">
                    <label for="ddlGenre">Genre</label>
                    <asp:DropDownList ID="ddlGenre" ClientIDMode="Static" runat="server">
                        <asp:ListItem Selected="True" Value="--Select Genre--" Text=" -- Select Genre -- "></asp:ListItem>
                        <asp:ListItem Value="Rock" Text="Rock"></asp:ListItem>
                        <asp:ListItem Value="Techno" Text="Techno"></asp:ListItem>
                        <asp:ListItem Value="Rap" Text="Rap"></asp:ListItem>
                        <asp:ListItem Value="Classical" Text="Classical"></asp:ListItem>
                        <asp:ListItem Value="Metal" Text="Metal"></asp:ListItem>
                        <asp:ListItem Value="Arabic" Text="Arabic"></asp:ListItem>
                        <asp:ListItem Value="French" Text="French"></asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="form-group">
                    <label for="txtPrice">Price</label>
                    $<asp:TextBox ID="txtPrice" ClientIDMode="Static" runat="server"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="txtBudget">Budget</label>
                    $<asp:TextBox ID="txtBudget" ClientIDMode="Static" runat="server"></asp:TextBox>
                </div>

                <div class="form-group" style="text-align: center;">
                    <asp:Button ID="btnCreateEvent" ClientIDMode="Static" runat="server" Text="Create Event" CssClass="btn btn-primary btn-lg" Style="background-color: maroon;" OnClick="btnCreateEvent_Click" />
                </div>
            </form>

        </div>
    </div>
</asp:Content>
