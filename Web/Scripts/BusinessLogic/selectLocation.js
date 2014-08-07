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
    success: function(data) {
        var items = "";
        $.each(data, function(i, item) {
            items += "<option value=\"" + item.Value + "\">" + item.Text + "</option>";
        });

        $("#City").html(items);
    }
});
}

// при смене страны меняем список городов
$(document).ready(function(){
    $("#Country").change(function() {
        var countryId = $("#Country").val();

        getCities(countryId);
    });
});