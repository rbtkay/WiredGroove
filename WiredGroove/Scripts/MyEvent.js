$(document).ready(function () {
    $.ajax({
        type: "POST",
        url: "MyEvent.aspx/GetMyEvent",
        data: '{}',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            console.log(data);
            PopulateMyEvent($("#myEvent-list"), data)
        },
    });


    function PopulateMyEvent(parent, resultList) {
        $.each(resultList.d, function () {
            let div = $(`
            <div class="row">
                <div class="col-sm-12">
                    <div class="media">
                        <div class="pull-left">
                            <label>From: </label><label> `+ this.eventDateStart + `</label>
                            <br/>
                            <label>To: </label><label> ` + this.eventDateEnd + `</label>
                        </div>
                        <div class="media-body">
                            <h4 class="media-heading">` + this.eventName + `<small> ` + this.eventLocation + `<small></h4>
                            <label><b>Musician: <b/></label><small> `+ this.eventMusician + `</small>
                            <br/>
                            <label><b>Music: <b/></label><small> `+ this.eventGenre + `</small>
                            <br/>
                            <label><b>Type: <b/></label><small> `+ this.eventType + `</small>
                            <hr style="margin: 8px auto">
                        </div>
                    </div>
                </div>
            </div>
            `);
            div.appendTo(parent);
        });
    }
});