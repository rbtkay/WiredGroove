$(document).ready(function () {

    $.ajax({
        method: "get",
        url: "Handler/PopularArtistHandler.ashx",
        dataType: "json",
        success: function (data) {
            PopulateArtistList($("#list-popular-artist"), data);
        }
    });

    function PopulateArtistList(parent, popularArtists) {
        $.each(popularArtists, function () {
            let div = $(`
            <div class="row">
                <div class="col-sm-12">
                    <div class="media">
                        <a class="pull-left" href="#">
                            <img class="media-object dp img-circle" src="http://www.huffmancode.com/img/hardik.jpg" style="width: 100px; height: 100px;">
                        </a>
                        <div class="media-body">
                            <h4 class="media-heading">` + this.artistName + `<small> `+ this.artistBand +`<small></h4>
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