jQuery(document).ready(function ($) {
    $(function () {
        
        // автодополнение стран и городов
        var countryId = $("#Country").val();
        if (countryId.length > 0) {
            getCities(countryId);
        }

        $("#Country").combobox();
        $("#City").combobox();


        // флаги для стран
        var items = $('#Country').children();
        items.each(function (index) {
            $(this).addClass('flag.flag-ad');
            $(this).css('color', '#FF0000');
            var tmp = $(this);
            $(this)[0].style = '.flag.flag-ag';
            var res = tmp[0].style;
        });

        //.flag.flag-an

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

(function ($) {
    $.widget("custom.combobox", {
        _create: function () {
            this.wrapper = $("<span>")
              .addClass("custom-combobox")
              .insertAfter(this.element);

            this.element.hide();
            this._createAutocomplete();
            this._createShowAllButton();
        },

        _createAutocomplete: function () {
            var selected = this.element.children(":selected"),
              value = selected.val() ? selected.text() : "";

            this.input = $("<input>")
              .appendTo(this.wrapper)
              .val(value)
              .attr("title", "")
              .addClass("custom-combobox-input ui-widget ui-widget-content ui-state-default ui-corner-left")
              .autocomplete({
                  delay: 0,
                  minLength: 0,
                  source: $.proxy(this, "_source")
              })
              .tooltip({
                  tooltipClass: "ui-state-highlight"
              });

            this._on(this.input, {
                autocompleteselect: function (event, ui) {
                    ui.item.option.selected = true;
                    var typeCombo = ui.item.option.parentNode.name; // get Country or City combobox
                    if (typeCombo == "Country") {
                        var countryId = ui.item.option.value;
                        if (countryId.length > 0) {
                            getCities(countryId); // reload Cities for selected Country
                        }
                    }

                    this._trigger("select", event, {
                        item: ui.item.option
                    });
                },

                autocompletechange: "_removeIfInvalid"
            });
        },

        _createShowAllButton: function () {
            var input = this.input,
              wasOpen = false;

            $("<a>")
              .attr("tabIndex", -1)
              .attr("title", "Show All Items")
              .tooltip()
              .appendTo(this.wrapper)
              .button({
                  icons: {
                      primary: "ui-icon-triangle-1-s"
                  },
                  text: false
              })
              .removeClass("ui-corner-all")
              .addClass("custom-combobox-toggle ui-corner-right")
              .mousedown(function () {
                  wasOpen = input.autocomplete("widget").is(":visible");
              })
              .click(function () {
                  input.focus();

                  // Close if already visible
                  if (wasOpen) {
                      return;
                  }

                  // Pass empty string as value to search for, displaying all results
                  input.autocomplete("search", "");
              });
        },

        _source: function (request, response) {
            var matcher = new RegExp($.ui.autocomplete.escapeRegex(request.term), "i");
            response(this.element.children("option").map(function () {
                var text = $(this).text();
                if (this.value && (!request.term || matcher.test(text)))
                    return {
                        label: text,
                        value: text,
                        option: this
                    };
            }));
        },

        _removeIfInvalid: function (event, ui) {

            // Selected an item, nothing to do
            if (ui.item) {
                return;
            }

            // Search for a match (case-insensitive)
            var value = this.input.val(),
              valueLowerCase = value.toLowerCase(),
              valid = false;
            this.element.children("option").each(function () {
                if ($(this).text().toLowerCase() === valueLowerCase) {
                    this.selected = valid = true;
                    return false;
                }
            });

            // Found a match, nothing to do
            if (valid) {
                return;
            }

            // Remove invalid value
            this.input
              .val("")
              .attr("title", value + " didn't match any item")
              .tooltip("open");
            this.element.val("");
            this._delay(function () {
                this.input.tooltip("close").attr("title", "");
            }, 2500);
            this.input.autocomplete("instance").term = "";
        },

        _destroy: function () {
            this.wrapper.remove();
            this.element.show();
        }
    });
})(jQuery);
