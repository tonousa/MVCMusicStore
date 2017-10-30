$(function () {
    //$(".table tr").mouseover(function () {
    //    $(this).animate({ height: '+=25', width: '+=25' })
    //           .animate({ height: '-=25', width: '-=25' });
    //});

    $(".table tr").mouseover(function () {
        $(this).effect("bounce");
    });
});

function searchFailed() {
    $("#searchResults").html("Problems with the search");
}

$(document).ready(function () {

    $("input[data-autocomplete-source]").each(function () {
        var target = $(this);
        target.autocomplete({ source: target.attr("data-autocomplete-source") });
    });

});