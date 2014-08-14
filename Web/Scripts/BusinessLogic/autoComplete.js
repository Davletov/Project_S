$(document).ready(function () {
    var $country = $('#Country');
    $country.autocomplete(
    {
        source: function (request, response) {
            $.ajax(
            {
                url: "/Location/FindByName", type: "GET", dataType: "json",
                data: { searchText: request.term, maxResults: 10 },
                contentType: "application/json; charset=utf-8",
                success: function (data) {
                    var t = data;
                },

            });
        },
        select: function (event, ui) {
            $('#Country').val(ui.item.id);
        },
        minLength: 1
    });

});