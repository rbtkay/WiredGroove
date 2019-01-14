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

    // $('#btnUpload').on("click", function () {
    //     var byteData = reader.result;
    //     byteData = byteData.split(';')[1].replace("base64,", "");
    //     $.ajax({
    //         type: "POST",
    //         url: "sHomePage.aspx/InsertImage",
    //         data: '{byteData: "' + byteData + '", imageName: "' + fileName + '", contentType: "' + contentType + '" }',
    //         contentType: "application/json; charset=utf-8",
    //         dataType: "json",
    //         success: function (response) { alert(response.d); },
    //         error: function (response) { alert(response.responseText); }
    //     });
    //     return false;
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
    } else {
        $.ajax({
            type: "POST",
            url: "sHomePage.aspx/GetArtists",
            data: '{}',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                PopulateArtistList($("#list-popular-artist"), data)
                // console.log(data);
            },
        });
    }

    $.ajax({
        type: "POST",
        url: "sHomePage.aspx/GetNewsFeed",
        data: '{}',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            console.log(data.d);
            PopulateNewsFeed($("#newsFeed"), data)
        },
    });
    // $.ajax({
    //     type: "GET",
    //     url: "/sHomePage.aspx/GetArtist",
    //     dataType: "json",
    //     success: function (data) {
    //         alert(data);
    //         PopulateArtistList($("#list-popular-artist"), data);
    //     }
    // });
    function PopulateNewsFeed(parent, mediaList) {
        $.each(mediaList.d, function () {
            if (this.type == "Image") {
                let div = $(`
            <div class="row">
            <div class="col-sm-12">
                <div class="card">
                    <a class="card-img-top" href="#">
                        <img class="media-object dp " src="`+ this.media + `" style="width: 100%; height: 300px;">
                    </a>
                    <div class="card-body">
                        <h4 class="media-heading">` + this.name + `<small> ` + this.email + `<small></h4>
                        <p>`+ this.caption + `</p>
                        <div>#Likes<p>`+ this.countLikes + `</p>
                        </h5>
                        <hr style="margin: 8px auto">
                    </div>
                </div>
            </div>
        </div>
            `);
                div.appendTo(parent);
            } else if (this.type == "Audio") {
                let div = $(`
            <div class="row">
            <div class="col-sm-12">
                <div class="media">
                    <a class=pull-left href="#">
                    <audio controls>
                        <source src="`+ this.media + `" type="audio/ogg">
                        <source src="`+ this.media + `" type="audio/mpeg">
                        Your browser does not support the audio element.
                    </audio>
                    </a>
                    <div class="media-body">
                        <h4 class="media-heading">` + this.name + `<small> ` + this.email + `<small></h4>
                        <h5>#Likes<h6>`+ this.countLikes + `</h6>
                        </h5>
                        <hr style="margin: 8px auto">
                    </div>
                </div>
            </div>
        </div>
            `);
                div.appendTo(parent);
            }

        });
    }

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
            //alert("counting");
            let div = $(`
            <div class="row">
                <div class="col-sm-12">
                    <div class="media">
                        <a class="pull-left" href="#">
                            <img class="media-object dp img-circle" src="`+ this.artistPicture + `" style="width: 100px; height: 100px;">
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