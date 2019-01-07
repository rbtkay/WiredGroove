﻿$(document).ready(function () {

    alert("javascript works");

    $.ajax({
        method: "get",
        url: "Handler/PopularArtistHandler.ashx",
        dataType: "json",
        success: function (data) {
            PopulateArtistList($("#list-popular-artist"), data);
        }
    });

    function PopulateArtistList(parent, popularArtists) {
        alert("json works");
        $.each(popularArtists, function () {
            let li = $(`
            <div class="row">
                <div class="col-sm-12">
                    <div class="media">
                        <a class="pull-left" href="#">
                            <img class="media-object dp img-circle" src="http://www.huffmancode.com/img/hardik.jpg" style="width: 100px; height: 100px;">
                        </a>
                        <div class="media-body">
                            <h4 class="media-heading">` + this.artistName + `<small>India</small></h4>
                            <h5>Software Developer at <a href="http://gridle.in">Gridle.in</a></h5>
                            <hr style="margin: 8px auto">

                            <span class="label label-default">HTML5/CSS3</span>
                            <span class="label label-default">jQuery</span>
                            <span class="label label-info">CakePHP</span>
                            <span class="label label-default">Android</span>
                        </div>
                    </div>
                </div>
            </div>
            `);
            li.appendTo(parent);
        });
    }

});