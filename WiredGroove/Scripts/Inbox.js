$(document).ready(function () {
    $.ajax({
        type: "POST",
        url: "Inbox.aspx/GetConnections",
        data: '{}',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            PopulateConnectionList($("#list-connection"), data)
        },
    });

    function PopulateConnectionList(parent, connectionItem) {
        $.each(connectionItem.d, function () {
            let div = $(`
                <div class="row">
                    <div class ="col-sm-12">
                        <div class ="media">
                            <a class ="pull-left" href="Messages.aspx?connectionId=` + this.connectionID + `">
                                <img class="media-object dp img-circle" style="width: 100px; height: 100px;">
                            </a>
                            <div class="media-body">
                                <h4 class ="media-heading"> ` + this.destinationName + ` </h4>
                            </div>
                        </div>
                    </div>
                </div>
                `);
            div.appendTo(parent);
        });
    }
});