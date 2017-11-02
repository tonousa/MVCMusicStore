$(function () {
    //$(".table tr").mouseover(function () {
    //    $(this).animate({ height: '+=25', width: '+=25' })
    //           .animate({ height: '-=25', width: '-=25' });
    //});

    $(".table tr").mouseover(function () {
        $(this).effect("highlight");
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

    //$("#artistSeach").submit(function (event) {
    //    event.preventDefault();
    //    var form = $(this);
    //    //$("#searchResults").load(form.attr("action"), form.serialize());
    //    $.getJSON(form.attr("action"), form.serialize(), function (data) {
    //        var html = Mustache.to_html(
    //            $("#artistTemplate").html(),
    //            { artists: data });
    //        $("#searchResults").empty().append(html);
    //    });
    //});

    $("#artistSeach").submit(function (event) {
        event.preventDefault();

        var form = $(this);
        $.ajax({
            url: form.attr("action"),
            data: form.serialize(),
            beforeSend: function () {
                $("#ajax-loader").show();
            },
            // complete is called when request finishes
            complete: function () {
                $("#ajax-loader").hide();
            },
            error: searchFailed(),
            success: function (data) {
                var html = Mustache.to_html($("#artistTemplate").html(),
                    { artists: data });
                $("#searchResults").empty().append(html);
            }
        });
    });
});