$(document).ready(function () {
    $("#movie").DataTable();
    $("#movie").on("click", ".js-delete", function () {
        var deleteButton = $(this);
        bootbox.confirm("Are you sure you want to delete this movie?", function (result) {
            if (result) {
                $.ajax
                    ({
                        url: "/movie/delete/" + deleteButton.attr("data-movie-id"),
                        success: function () {
                            deleteButton.parents("tr").remove();
                        }

                    });
            }
            else {

            }
         });
    });
});