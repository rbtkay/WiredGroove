$(document).ready(function () {

    if ($("#hiddenField").val() != "") {
        $.ajax({
            type: "POST",
            url: "SearchResult.aspx/GeneralSearch",
            data: '{}',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                console.log(data);
                PopulateSearchResult($("#search-result"), data)
            },
        });
    } else {
        $.ajax({
            type: "POST",
            url: "SearchResult.aspx/SearchResultArtist",
            data: '{}',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                console.log(data);
                PopulateSearchResult($("#search-result"), data)
            },
        });
    }


    function PopulateSearchResult(parent, resultList) {
        $.each(resultList.d, function () {
            let div = $(`
            <div class="row">
                <div class="col-sm-12">
                    <div class="media">
                        <a class="pull-left" href="#">
                            <img class="media-object dp img-circle" style="width: 100px; height: 100px;">
                        </a>
                        <div class="media-body">
                            <h4 class="media-heading">` + this.artistName + `<small> ` + this.artistAddress + `<small></h4>
                            <h5>Main Instrument:<p>`+ this.artistInstrument + `</p></h5>
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