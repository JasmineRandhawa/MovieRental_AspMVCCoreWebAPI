#pragma checksum "C:\vs\GitHub\MovieRental_AspMVCCoreWebAPI\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03196b88a830467db556a4958ab00a1103f7647d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03196b88a830467db556a4958ab00a1103f7647d", @"/Views/Customer/Index.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieRental.Models.Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\vs\GitHub\MovieRental_AspMVCCoreWebAPI\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "Customers";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Customers</h1>\r\n    <div class=\"form-group\" style=\"width: 180px; text-align: start\">\r\n        ");
#nullable restore
#line 9 "C:\vs\GitHub\MovieRental_AspMVCCoreWebAPI\Views\Customer\Index.cshtml"
   Write(Html.ActionLink(" + New Customer", "New", "Customer", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <br />
    <table id=""customer"" class=""table table-bordered table-hover"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Name</th>
                <th>Email</th>
                <th>Birth Date</th>
                <th>Membership Type</th>
                <th>Discount Rate</th>
                <th>Subscribed To NewsLetter?</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
        </tbody>
    </table>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $(""#customer"").DataTable({
                ajax: {
                    url: ""/customer/getall/"",
                    dataSrc: """"
                },
                columns:
                    [
                        {
                            data: ""id""
                        },
                        {
                            data: ""name"",
                            render: function (data, type, customer) {
                                return ""<a href='/customer/edit/"" + customer.id + ""'>"" + customer.name + ""</a>"";
                            }
                        },
                        {
                            data: ""email""
                        },
                        {
                            data: ""email""
                        },
                        {
                            data: ""birthDate""
                        },
                        {
                   ");
                WriteLiteral(@"         data: ""birthDate"",
                            ""render"": function (data) {
                                var date = new Date(data);
                                var monthShortNames = [""Jan"", ""Feb"", ""Mar"", ""Apr"", ""May"", ""Jun"",
                                    ""Jul"", ""Aug"", ""Sep"", ""Oct"", ""Nov"", ""Dec""
                                ];
                                var month = monthShortNames[date.getMonth() + 1]+"""";
                                return date.getDate() + "" "" + month +"" , "" + date.getFullYear();
                            }
                        },
                        {
                            data: ""isSubscribedToNewsLetter"",
                            render: function (data) {
                                var value = ""Yes"";
                                if (data == ""false"" || data == false)
                                    value = ""No"";
                                return "" <label>"" + value + ""</label>"";
                            }
");
                WriteLiteral(@"                        },
                        {
                            data: ""id"",
                            render: function (data) {
                                return ""<button data-customer-id="" + data + "" "" +
                                    "" class='btn js-delete' style='height: 40px; width: 40px; font-size: medium; color:red; border:hidden; background:none;'>X</button > "";
                            }
                        }
                    ]
            });
            $(""#customer"").on(""click"", "".js-delete"", function () {
                var deleteButton = $(this);
                bootbox.confirm(""Are you sure you want to delete this customer?"", function (result) {
                    if (result) {
                        $.ajax
                            ({
                                url: ""/customer/delete/"" + deleteButton.attr(""data-customer-id""),
                                success: function () {
                                    deleteButton.");
                WriteLiteral("parents(\"tr\").remove();\r\n                                }\r\n                            });\r\n                    }\r\n                });\r\n            });\r\n        });\r\n\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MovieRental.Models.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
