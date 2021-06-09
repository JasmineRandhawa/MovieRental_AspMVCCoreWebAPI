#pragma checksum "C:\vs\GitHub\MovieRental_AspMVCCoreWebAPI\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "868c748794fac28a0b085c530c580a9cea09617c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"868c748794fac28a0b085c530c580a9cea09617c", @"/Views/Movie/Index.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieRental.Models.Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\vs\GitHub\MovieRental_AspMVCCoreWebAPI\Views\Movie\Index.cshtml"
      
        ViewData["Title"] = "Movies";
        Layout = "~/Views/Shared/_Layout.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Movies</h1>\r\n    <div class=\"form-group\" style=\"width: 180px; text-align: start\">\r\n        ");
#nullable restore
#line 10 "C:\vs\GitHub\MovieRental_AspMVCCoreWebAPI\Views\Movie\Index.cshtml"
   Write(Html.ActionLink(" + New Movie", "New", "Movie", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <br />
    <table class=""table table-bordered table-hover"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Name</th>
                <th>Genre</th>
                <th>Number Of Stock</th>
                <th>Release Date</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 25 "C:\vs\GitHub\MovieRental_AspMVCCoreWebAPI\Views\Movie\Index.cshtml"
             foreach (var movie in @Model.ToList())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 28 "C:\vs\GitHub\MovieRental_AspMVCCoreWebAPI\Views\Movie\Index.cshtml"
               Write(movie.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\vs\GitHub\MovieRental_AspMVCCoreWebAPI\Views\Movie\Index.cshtml"
               Write(Html.ActionLink(movie.Name, "Edit", "Movie", new { id = movie.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\vs\GitHub\MovieRental_AspMVCCoreWebAPI\Views\Movie\Index.cshtml"
               Write(movie.Genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\vs\GitHub\MovieRental_AspMVCCoreWebAPI\Views\Movie\Index.cshtml"
               Write(movie.NumberOfStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\vs\GitHub\MovieRental_AspMVCCoreWebAPI\Views\Movie\Index.cshtml"
               Write(movie.ReleaseDate.ToString("d MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\vs\GitHub\MovieRental_AspMVCCoreWebAPI\Views\Movie\Index.cshtml"
               Write(Html.ActionLink("Delete", "Remove", "Movie", new { id = movie.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            </tr>\r\n");
#nullable restore
#line 35 "C:\vs\GitHub\MovieRental_AspMVCCoreWebAPI\Views\Movie\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MovieRental.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
