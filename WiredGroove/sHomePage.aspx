<%@ Page Title="" Language="C#" MasterPageFile="~/WiredGroove.Master" AutoEventWireup="true" CodeBehind="sHomePage.aspx.cs" Inherits="WiredGroove.sHomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <div style="margin-top: 5%" class="newFeedContainer">
            <div class="col-sm-2">
                <div class="list-group" id="list-tab" role="tablist">
                    <a class="list-group-item list-group-item-action" id="list-home-list" href="#list-home" role="tab" aria-controls="home">Profile</a>
                    <button type="button" class="list-group-item list-group-item-action" data-toggle="modal" data-target="#myModal">Upload Media</button>
                    <a class="list-group-item list-group-item-action" id="list-messages-list" data-toggle="list" href="CreateEvent.aspx" role="tab" aria-controls="messages">Create Event</a>
                    <a class="list-group-item list-group-item-action" id="list-settings-list" data-toggle="list" href="MyEvent.aspx" role="tab" aria-controls="settings">My Events</a>
                </div>
            </div>
            <div class="col-sm-7" id="newsFeed">


                <!-- Modal -->
                <div class="modal fade" id="myModal" role="dialog">
                    <div class="modal-dialog">

                        <!-- Modal content-->
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal">&times;</button>
                                <h4 class="modal-title">Upload Media</h4>
                            </div>
                            <div class="modal-body">
                                <table>
                                    <tr>
                                        <td colspan="2">
                                            <label>Post Title: </label>
                                        </td>
                                        <td colspan="2">
                                            <asp:TextBox ID="mediaName" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td colspan="2">
                                            <label>Add a Caption: </label>
                                        </td>
                                        <td colspan="2">
                                            <asp:TextBox ID="mediaCaption" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="4">
                                            <asp:FileUpload class="form-horizontal" ID="FileUpload" runat="server" />
                                        </td>
                                    </tr>
                                </table>
                                <asp:Button ID="btnUpload" class="btn btn-primary" Style="background-color: maroon; display: flex; justify-content: center;" runat="server" Text="Upload" OnClick="btnUpload_Click" />

                            </div>
                            <div class="modal-footer">
                                <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
            <div class="col-sm-3" id="list-popular-artist">
            </div>
        </div>

        <asp:HiddenField ID="hiddenField" ClientIDMode="static" runat="server" />
        <asp:HiddenField ID="HiddenFieldLikes" runat="server" />

        <script src="Scripts/LoggedInHome.js"></script>

    </form>
</asp:Content>
