jQuery(document).ready(function ($) {
    Refresh($);
});

// initialize criteria tree
function Refresh($) {
    $('#TreeTmp')
        .bind("before.jstree", function(e, data) {
        })
        .jstree({
            "core": {
                'data':  [
                           { "id" : "ajson1", "parent" : "#", "text" : "Parent1" },
                           { "id" : "ajson1_1", "parent" : "ajson1", "text" : "Child 1" },
                           { "id" : "ajson1_2", "parent" : "ajson1", "text" : "Child 2" },                           
                           { "id" : "ajson2", "parent" : "#", "text" : "Parent2" },
                           { "id" : "ajson2_1", "parent" : "ajson2", "text" : "Child 1" },
                           { "id" : "ajson2_2", "parent" : "ajson2", "text" : "Child 2" },
                        ]
            },

            "plugins": ["themes", "checkbox", "unique"]
        })
        /*.on('loaded.jstree', function (e, data) {
            getCriteria($);
        })*/;
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

