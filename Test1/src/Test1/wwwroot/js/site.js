/// <reference path="../lib/jquery/dist/jquery.min.js" />
/// <reference path="contact.js" />
(function () {
    "use strict";
    var mainPageItems = [];
    
    $.getJSON("/js/myData.json")
    .done(function (response) {
        $('#contactInfo').append('<b>This is coming from JSON directly</b></br>');
        $.each(response, function (index, value) {
            var c1 = new ContactManager();
            c1.FirstName = value.firstName;
            c1.LastName = value.lastName;
            mainPageItems.push(c1);
            $('#contactInfo').append('<b>'+c1.GetContactDetails() + '</b></br>');
        });

        $('#contactInfo').append('<hr /><b>This is coming form the Array we created</b></br>');
        $.each(mainPageItems, function (index, value) {
            $('#contactInfo').append('<b>' + value.GetContactDetails() + '</b></br>');
        });


    })
    .fail(function () {
        alert("We failed");
    });
})();