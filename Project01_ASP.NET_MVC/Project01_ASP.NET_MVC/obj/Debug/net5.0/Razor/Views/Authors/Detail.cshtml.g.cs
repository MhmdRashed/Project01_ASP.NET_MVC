#pragma checksum "D:\Tuwaiq\dotNET\projects\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Views\Authors\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bca22321728c683e4f6aad4f910db4a4a270dc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authors_Detail), @"mvc.1.0.view", @"/Views/Authors/Detail.cshtml")]
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
#nullable restore
#line 1 "D:\Tuwaiq\dotNET\projects\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Views\_ViewImports.cshtml"
using Project01_ASP.NET_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tuwaiq\dotNET\projects\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Views\_ViewImports.cshtml"
using Project01_ASP.NET_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bca22321728c683e4f6aad4f910db4a4a270dc1", @"/Views/Authors/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a562ef60ea4f8851e3395d8edff6930b4909edb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Authors_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Tuwaiq\dotNET\projects\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Views\Authors\Detail.cshtml"
  

    var author = (Author)ViewData["author"];
    Layout = "_myLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<div class=\"ml-5\">\r\n\r\n    <h1>");
#nullable restore
#line 9 "D:\Tuwaiq\dotNET\projects\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Views\Authors\Detail.cshtml"
   Write(author.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n    <div>Contact the author: </div>\r\n\r\n    <ul>\r\n        <li>Email: ");
#nullable restore
#line 14 "D:\Tuwaiq\dotNET\projects\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Views\Authors\Detail.cshtml"
              Write(author.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Phone: ");
#nullable restore
#line 15 "D:\Tuwaiq\dotNET\projects\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Views\Authors\Detail.cshtml"
              Write(author.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ul>\r\n    <br />\r\n    <a class=\"btn btn-secondary\" href=\"/books\" role=\"button\">Go Back</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
