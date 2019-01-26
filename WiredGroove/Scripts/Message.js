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
        let turn = 0;
        $.each(messageItem.d, function () {
            if (this.messageSenderEmail === $("#HiddenSenderEmail").val()) {
                let div;
                if (turn == 1) {
                    div = $(`
                    <div class ="row">
                        <div class="col-sm-12">
                            <div class ="form-group" style="float: right">
                            <div class ="row">
                                <h5 class ="form-control" style="text-align: right; width: auto;"> ` + this.messageContent + ` </h3>
                            </div>
                            </div>
                        </div>
                    </div>
                 `)
                } else {
                    div = $(`
                    <div class ="row">
                        <div class="col-sm-12">
                            <div class ="form-group" style="float: right">
                            <div class ="row">
                                <h4 class="media-heading" style="color: maroon; float: right"> ` + this.messageSender + ` </h3>
                            </div>
                            <div class ="row">
                                <h5 class ="form-control" style="text-align: right; width: auto;"> ` + this.messageContent + ` </h3>
                            </div>
                            </div>
                        </div>
                    </div>
                    `);
                }
                div.appendTo(parent);
                turn = 1;
            } else {
                let div;
                if (turn == 2) {
                    div = $(`
                    <div class ="row">
                        <div class="col-sm-12">
                            <div class ="form-group" style="float: left">
                                <h5 class ="form-control" style="width: auto"> ` + this.messageContent + ` </h3>
                            </div>
                        </div>
                    </div>
                    `);
                } else {
                    div = $(`
                    <div class ="row">
                        <div class="col-sm-12">
                            <div class ="form-group" style="float: left">
                                <h4 class="media-heading" style="color: maroon;"> ` + this.messageSender + ` </h3>
                                <h5 class ="form-control" style="width: auto"> ` + this.messageContent + ` </h3>
                            </div>
                        </div>
                    </div>
                    `);
                }
                div.appendTo(parent);
                turn = 2;
            }
        });
    }
});