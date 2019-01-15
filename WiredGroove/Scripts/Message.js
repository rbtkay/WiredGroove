$(document).ready(function () {

    $.ajax({
        type: "POST",
        url: "Messages.aspx/GetMessages",
        data: '{}',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            console.log(data);
            PopulateMessageList($("#list-messages"), data)
        },
    });

    function PopulateMessageList(parent, messageItem) {
        $.each(messageItem.d, function () {
            let div = $(`
                <div class ="row">
                    <div class="col-sm-12">
                        <div class ="form-group">
                            <h4 class="media-heading" style="color: maroon"> ` + this.messageSender + ` </h3>
                            <h5 class ="media-heading form-control"> ` + this.messageContent + ` </h3>
                            
                        </div>
                     </div>
                 </div>
                 `);
            div.appendTo(parent);
        });
    }
});