jQuery(document).ready(function ($) {
    Refresh($);
    
    // Для передачи данных c дерева критериев в контроллер
    $(function () {
        $("#saveProfile").click(function (event) {
            event.preventDefault();
            submitMe();
        });

        $.fn.serializeObject = function () {
            var o = {};
            var a = this.serializeArray();
            $.each(a, function () {
                if (o[this.name]) {
                    if (!o[this.name].push) {
                        o[this.name] = [o[this.name]];
                    }
                    o[this.name].push(this.value || '');
                } else {
                    o[this.name] = this.value || '';
                }
            });
            return o;
        };

        function submitMe() {
            var checkedIds = [];
            var selectedNodes = $("#TreeTmp").jstree(true).get_selected();
            selectedNodes.forEach(function (item) {
                var pathArr = $("#TreeTmp").jstree(true).get_path(item, false);
                var levelOfNode = pathArr.length;
                var obj = {};
                obj['id'] = item;
                obj['level'] = levelOfNode;
                checkedIds.push(obj);
            });

            var form = $('#ProfileForm');
            $.ajax({
                url: "/Profile/Profile",
                async: false,
                type: "POST",
                traditional: true,
                data: { values: JSON.stringify(checkedIds), model: JSON.stringify(form.serializeObject()) },
                cache: false,
                dataType: "json"
            });
        }

    });
});

// initialize criteria tree
function Refresh($) {
    $('#TreeTmp')
        .bind("before.jstree", function(e, data) {
        })
        .jstree({
            "core": {
                'data': {
                    "url": function(node) {
                        var url = "../Scripts/Data/jsonData.js"; // all nodes for tree
                        return url;
                    },
                    "type": "GET",
                    "dataType": "json",
                    "contentType": "application/json"
                }
            },

            "plugins": ["themes", "checkbox", "unique"]
        })
        .on('loaded.jstree', function (e, data) {
            getCriteria($);
        });
}

// load current user's criterias for tree
function getCriteria($) {
    $.ajax({
        url: "/Profile/GetCriteria",
        dataType: "json",
        type: "POST",
        error: function () {
            alert("An error occurred.");
        },
        success: function (listCriteriaIds) {
            listCriteriaIds.forEach(function (id) {
                $('#TreeTmp').jstree("select_node", id);
            });
            $('#TreeTmp').jstree('close_all'); // сворачиваем дерево (возможно будет красиво не сворачивать его)
        }
    });
}

