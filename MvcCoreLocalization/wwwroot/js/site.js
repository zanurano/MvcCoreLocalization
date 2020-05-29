// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $("#SetLanguage").change(function () {
        $.get("/Helper/SetCulture", { culture: this.value }, function (res) {
            location.reload();
            //console.log(res);
        });
        //$.getJSON("/Home/SetCulture/123", function (res) {
        //    //location.reload();
        //    console.log(res)
        //})
        //$.ajax({
        //    url: '/Home/SetCulture/',
        //    data: {},
        //    contentType: 'application/json',
        //    type: 'POST',
        //    success: function (data) {

        //    }
        //});
    });
});
