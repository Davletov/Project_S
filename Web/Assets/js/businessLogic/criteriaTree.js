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
                var parentNode = $("#TreeTmp").jstree('get_parent', item);
                var isSelectedParentNode = $("#TreeTmp").jstree('is_selected', parentNode);

                var obj = {};
                var isExist = -1;
                if (isSelectedParentNode) {
                    
                    var pathParentArr = $("#TreeTmp").jstree(true).get_path(parentNode, false);
                    var levelOfParentNode = pathParentArr.length;
                    
                    obj['id'] = parentNode;
                    obj['level'] = levelOfParentNode;

                    isExist = checkedIds.map(function(x) { return x.id; }).indexOf(parentNode);
                    if (isExist < 0) {
                        checkedIds.push(obj);
                    }
                    
                } else {
                    
                    var pathArr = $("#TreeTmp").jstree(true).get_path(item, false);
                    var levelOfNode = pathArr.length;
                    obj['id'] = item;
                    obj['level'] = levelOfNode;

                    isExist = checkedIds.map(function (x) { return x.id; }).indexOf(item);
                    if (isExist < 0) {
                        checkedIds.push(obj);
                    }
                }
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

