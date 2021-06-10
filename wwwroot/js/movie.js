
    $(document).ready(function () {
        $("#movie").on("click", ".js-delete", function () {
            var deleteButton = $(this);
            if (confirm("Are you sure you want to delete this movie?")) {
                $.ajax(
                    {
                        url: "/movie/delete/" + deleteButton.attr("data-movie-id"),
                        success: function () {
                            deleteButton.parents("tr").remove();
                        }
                    });
            }
        })
    });
