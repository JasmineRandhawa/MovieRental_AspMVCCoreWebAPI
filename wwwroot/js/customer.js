
    $(document).ready(function () {
        $("#customer").on("click", ".js-delete", function () {
            var deleteButton = $(this);
            if (confirm("Are you sure you want to delete this customer?")) {
                $.ajax(
                    {
                        url: "/customer/delete/" + deleteButton.attr("data-customer-id"),
                        success: function () {
                            deleteButton.parents("tr").remove();
                        }
                    });
            }
        })
    });
