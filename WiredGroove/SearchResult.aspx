<%@ Page Title="" Language="C#" MasterPageFile="~/WiredGroove.Master" AutoEventWireup="true" CodeBehind="SearchResult.aspx.cs" Inherits="WiredGroove.SearchResult" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="Scripts/SearchResult.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <div id="search-result" style="margin-top: 5%">

        </div>

        <asp:HiddenField ID="hiddenField" runat="server" />
    </form>
</asp:Content>
