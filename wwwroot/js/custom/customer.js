
$(document).ready(function () {
    $("#customer").DataTable();
    $("#customer").on("click", ".js-delete", function () {
       var deleteButton = $(this);
        bootbox.confirm("Are you sure you want to delete this customer?", function (result)
        {
           if (result) {
               $.ajax
                   ({
                       url: "/customer/delete/" + deleteButton.attr("data-customer-id"),
                       success: function () {
                           deleteButton.parents("tr").remove();
                       }
                   });
           }
        });
      });
});
