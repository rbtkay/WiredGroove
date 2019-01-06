var emailExpression = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
var nameExpression = /^[A-Z][a-z]+\s[A-Z][a-z]+/;

$(document).ready(function () {

    // Email Verification
    $("#txtEmailID").blur(function () {
        if ($("#txtEmailID").val() == "") {
            $("#smEmailID").text("Field Required");
        }
        else if (!$("#txtEmailID").val().match(emailExpression)) {
            $("#smEmailID").text("Input valid email (e.g. abc@def.com)");
        }
        else {
            $("#smEmailID").text("");
        }
    });

    // FullName Verification
    $("#txtFullNameID").blur(function () {
        if ($("#txtFullNameID").val() == "") {
            $("#smNameID").text("Field Required");
        }
        else if (!$("#txtFullNameID").val().match(nameExpression)) {
            $("#smNameID").text("Input valid email (e.g. John Smith)");
        }
        else {
            $("#smNameID").text("");
        }
    });
});


