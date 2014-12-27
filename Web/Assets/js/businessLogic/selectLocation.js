jQuery(document).ready(function ($) {
    $(function () {
        
        // автодополнение стран и городов
        var countryId = $("#Country").val();
        if (countryId.length > 0) {
            getCities(countryId);
        }

        $("#BirthDay").select2({ minimumResultsForSearch: -1, placeholder: "Day", allowClear: true });
        $("#BirthMonth").select2({ minimumResultsForSearch: -1, placeholder: "Month", allowClear: true });
        $("#BirthYear").select2({ minimumResultsForSearch: -1, placeholder: "Year", allowClear: true });
        $("#UserSocialStatus").select2({ minimumResultsForSearch: -1, placeholder: "Social status", allowClear: true });
        $("#Country").select2({ placeholder: "Your country", allowClear: true });
        $("#City").select2({ placeholder: "Your city", allowClear: true });
        
        $('#Country').change(function (event) {
            if (this.value) {
                getCities(this.value);
            }
        });
    });
});

// Подгружаем список городов выбранной страны
function getCities(countryId) {
    $.ajax({
        url: "/Location/Cities",
        data: { CountryId: countryId },
        dataType: "json",
        type: "POST",
        error: function () {
            alert("An error occurred.");
        },
        success: function (object) {
            var items = "";
            var city = $("#City");
            $.each(object.data, function (i, item) {
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
