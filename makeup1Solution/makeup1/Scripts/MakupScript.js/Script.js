$(function () {
    console.log("Ble");

    $("#searchBox").on("keyup", function () {
        Search($(this).val());
    });
});

function Search(query) {

    if (query.length == 0) {
        $("#searchResults").html("");
        return;
    }

    $.ajax('/Search/SearchForUser?query=' + query, {
        type: 'Get',
        dataType: 'json',
        error: function (jqXHR, textStatus, errorThrown) {
            $("#errorMessage").text("Error occured, please contact support");
        },
        success: function (data, textStatus, jqXHR) {
            $("#searchResults").html("");
            $(data).each(function() {
                console.log($(this)[0].username);
                $("<div/>", {
                    text: $(this)[0].username
                }).appendTo("#searchResults");
            })
        }
    });
}