$(document).ready(function () {
    $.ajax({
        type: "POST",
        url: "ViewProfile.aspx/GetMedia",
        data: '{}',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            PopulateMediaList($("#account-media"), data)
        },
    });

    function PopulateMediaList(parent, mediaItem) {
        $.each(mediaItem.d, function () {
            let div = $(`
                <div class ="row">
                    <div class ="col-sm-12">
                        <div class="card">
                            <img class ="media-object dp" src= "` + this.media + `" style="width: 100%; height: 300px;">

                            <div class ="card-body">
                                <h4 class ="media-heading"> ` + this.name + ` <small> ` + this.email + ` <small></h4>
                                <p> `+ this.caption + ` </p>
                                <div>#Likes<p> ` + this.countLikes + ` </p>
                                </div>
                                <hr style="margin: 8px auto">
                            </div>
                        </div>
                    </div>
                        `);

            div.appendTo(parent);
        });
    }
});