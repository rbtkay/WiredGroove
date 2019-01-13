$(document).ready(function () {

    // $.ajax({
    //     type: "Get",
    //     url: "sHomePage.aspx/GetArtist",
    //     data: "data",
    //     dataType: "dataType",
    //     success: function (response) {

    //     }
    // });

    // $.ajax({
    //     method: "Get",
    //     dataType: "text",
    //     url: "./sHomePage.aspx/GetArtist", success: function (result) {
    //         alert(result);
    //     }
    // });
    if ($("#hiddenField").val() == "musician") {
        $.ajax({
            type: "POST",
            url: "sHomePage.aspx/GetListJobs",
            data: '{}',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                PopulateJobList($("#list-popular-artist"), data)
            },
        });
    }else {
        $.ajax({
            type: "POST",
            url: "sHomePage.aspx/GetArtists",
            data: '{}',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                PopulateArtistList($("#list-popular-artist"), data)
            },
        });
    }
    // $.ajax({
    //     type: "GET",
    //     url: "/sHomePage.aspx/GetArtist",
    //     dataType: "json",
    //     success: function (data) {
    //         alert(data);
    //         PopulateArtistList($("#list-popular-artist"), data);
    //     }
    // });
    function PopulateJobList(parent, popularArtists) {
        $.each(popularArtists.d, function () {
            let div = $(`
            <div class="row">
                <div class="col-sm-12">
                    <div class="media">
                        <a class="pull-left" href="#">
                            <img class="media-object dp img-circle" style="width: 100px; height: 100px;">
                        </a>
                        <div class="media-body">
                            <h4 class="media-heading">` + this.eventName + `<small> ` + this.eventType + `<small></h4>
                            <h5>Starting Date:<p>`+ this.eventDateStart + `</p></h5>
                            <hr style="margin: 8px auto">
                        </div>
                    </div>
                </div>
            </div>
            `);
            div.appendTo(parent);
        });
    }

    function PopulateArtistList(parent, popularArtists) {
        $.each(popularArtists.d, function () {
            alert("counting");
            let div = $(`
            <div class="row">
                <div class="col-sm-12">
                    <div class="media">
                        <a class="pull-left" href="#">
                            <img class="media-object dp img-circle" style="width: 100px; height: 100px;">
                        </a>
                        <div class="media-body">
                            <h4 class="media-heading">` + this.artistName + `<small> ` + this.artistBand + `<small></h4>
                            <h5>Instrument:<p>`+ this.artistInstrument + `</p></h5>
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