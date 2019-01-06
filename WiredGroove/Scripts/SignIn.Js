$(document).ready(function () {
    // let regEmail = /^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$/;
    // $('#txtEmailVerificationID').addClass('invisibleClass');

    // if ($('#txtEmailID').val() != null) {
    //     $('#txtEmailVerificationID').addClass('invisibleClass');
    // }

    // if (!($('#txtEmailID').val().match(regEmail))) {
    //     $('#txtEmailVerificationID').removeClass('invisibleClass');
    // } else if ($('#txtEmailID').val() != null) {
    //     $('#txtEmailVerificationID').addClass('invisibleClass');    
    // }
    //         $('#btnSignInID').attr('disabled', 'enabled');
    //         $('#btnSignInID').addClass('btn-success');
    //     }
    //     // $("#btnSignInID").click(function (e) {
    //     //     e.preventDefault();
    //     //     let regEmail = /^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$/;



    //     //     if ($("#txtEmailID").val() == regEmail) {
    //     //         alert('hello');
    //     //     }
    //     // });

    $('#txtEmailID').focus(function (e) {
        e.preventDefault();
        $('#txtErrID').css('visibility', 'hidden');
    });

    $('#txtPasswordID').focus(function (e) {
        e.preventDefault();
        $('#txtErrID').css('visibility', 'hidden');
    });

});
