// Подгружаем список городов выбранной страны
function getCities(countryId) {
    $.ajax({
        url: "/Location/Cities",
        data: { CountryId: countryId },
        dataType: "json",
        type: "POST",
        error: function() {
            alert("An error occurred.");
        },
        success: function(object) {
            var items = "";
            var city = $("#City");
            $.each(object.data, function(i, item) {
                items += "<option value=\"" + item.Value + "\">" + item.Text + "</option>";
            });

            city.html(items);

            /* get City for this profile
             * $('#City').val(object.cityId); Just this command not work
             * It's not beautiful but it's working */
            $('#City').val(object.cityId);
            var textToShow = $('#City').find(":selected").text();
            $('#City').parent().find("span").find("input").val(textToShow);
        }
    });
}

/*
// при смене страны меняем список городов
$(document).ready(function () {
    var country = $("#Country");

    var countryId = country.val();
    if (countryId.length > 0) {
        getCities(countryId);
    }

    country.change(function () {
        var newCountryId = $("#Country").val();

        getCities(newCountryId);
    });
});*/


