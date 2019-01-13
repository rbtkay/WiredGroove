var emailExpression = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
var nameExpression = /^[A-Z][a-z]+\s[A-Z][a-z]+/;
var phoneExpression = /^(00961)\d{8}/;
var passwordExpression = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$/;

$(document).ready(function () {

    $("#txtDoBID").datepicker();

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
            $("#smNameID").text("Input valid name (e.g. John Smith)");
        }
        else {
            $("#smNameID").text("");
        }
    });

    // Phone Verification
    $("#txtPhoneID").blur(function () {
        if ($("#txtPhoneID").val() == "") {
            $("#smPhoneID").text("Field Required");
        }
        else if (!$("#txtPhoneID").val().match(phoneExpression)) {
            $("#smPhoneID").text("Input valid phone (e.g. 0096170123456)");
        }
        else {
            $("#smPhoneID").text("");
        }
    });

    // Password Verification
    $("#txtPasswordID").blur(function () {
        if ($("#txtPasswordID").val() == "") {
            $("#smPasswordID").text("Field Required");
        }
        else if (!$("#txtPasswordID").val().match(passwordExpression)) {
            $("#smPasswordID").text("Input valid password (min. 10 chars, 1 lower-case, 1 upper-case, 1 digit, 1 special character)");
        }
        else {
            $("#hiddenPass").text($("#txtPasswordID").val());
            $("#smPasswordID").text("");
        }
    });

    // Matching Passwords
    $("#txtConfirmPasswordID").blur(function () {
        if ($("#txtConfirmPasswordID").val() == "") {
            $("#smConfirmPasswordID").text("Field Required");
        }
        else if ($("#txtPasswordID").val() != $("#txtConfirmPasswordID").val()) {
            $("#smConfirmPasswordID").text("Passwords do not match!");
        }
        else {
            $("#hiddenPass").text($("#txtPasswordID").val());
            $("#smConfirmPasswordID").text("");
        }
    });

    // Keeping track of password
    $("#txtPasswordID").val($("#hiddenPass").text());
    $("#txtConfirmPasswordID").val($("#hiddenPass").text());
});


