$(document).ready(function () {
    $("#movie").on("click", ".js-delete", function (result) {
        var deleteButton = $(this);
        //if (confirm("Are you sure you want to delete this movie?")) {

        //}
        bootbox.confirm("Are you sure you want to delete this movie?", function () {
            if (result) {
                $.ajax
                    ({
                        url: "/movie/delete/" + deleteButton.attr("data-movie-id"),
                        success: function () {
                            deleteButton.parents("tr").remove();
                        }

                    });
            }
            });
    });
});