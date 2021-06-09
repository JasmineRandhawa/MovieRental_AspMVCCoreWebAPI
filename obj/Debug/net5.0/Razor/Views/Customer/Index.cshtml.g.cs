#pragma checksum "C:\vs\MVCAPI\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "340e5e68f576c32a13757b4ac7791d465f296f42"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"340e5e68f576c32a13757b4ac7791d465f296f42", @"/Views/Customer/Index.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieRental.Models.Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\vs\MVCAPI\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "Customers";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Customers</h1>\r\n    <div class=\"form-group\" style=\"width: 180px; text-align: start\">\r\n        ");
#nullable restore
#line 11 "C:\vs\MVCAPI\Views\Customer\Index.cshtml"
   Write(Html.ActionLink(" + New Customer", "New", "Customer", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <br />
    <table class=""table table-bordered table-hover"">
        <thead>
            <tr>
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
");
#nullable restore
#line 27 "C:\vs\MVCAPI\Views\Customer\Index.cshtml"
             foreach (var customer in @Model.ToList())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 30 "C:\vs\MVCAPI\Views\Customer\Index.cshtml"
               Write(Html.ActionLink(customer.Name, "Edit", "Customer", new { id = customer.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\vs\MVCAPI\Views\Customer\Index.cshtml"
               Write(customer.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 32 "C:\vs\MVCAPI\Views\Customer\Index.cshtml"
                 if (customer.BirthDate != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 34 "C:\vs\MVCAPI\Views\Customer\Index.cshtml"
                Write(((DateTime)customer.BirthDate).ToString("d MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 35 "C:\vs\MVCAPI\Views\Customer\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td></td>\r\n");
#nullable restore
#line 39 "C:\vs\MVCAPI\Views\Customer\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 40 "C:\vs\MVCAPI\Views\Customer\Index.cshtml"
               Write(customer.MembershipType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "C:\vs\MVCAPI\Views\Customer\Index.cshtml"
               Write(customer.MembershipType.DiscountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n");
#nullable restore
#line 42 "C:\vs\MVCAPI\Views\Customer\Index.cshtml"
                 if (customer.IsSubscribedToNewsLetter)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Yes</td>\r\n");
#nullable restore
#line 45 "C:\vs\MVCAPI\Views\Customer\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>No</td>\r\n");
#nullable restore
#line 49 "C:\vs\MVCAPI\Views\Customer\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 50 "C:\vs\MVCAPI\Views\Customer\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", "Customer", new { id = customer.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            </tr>\r\n");
#nullable restore
#line 52 "C:\vs\MVCAPI\Views\Customer\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
