#pragma checksum "D:\Tuwaiq\dotNET\projects\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Views\Books\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd4e974ff3b4c9e5f4849032f4b28fbf1a4bff06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Index), @"mvc.1.0.view", @"/Views/Books/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd4e974ff3b4c9e5f4849032f4b28fbf1a4bff06", @"/Views/Books/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a562ef60ea4f8851e3395d8edff6930b4909edb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Project01_ASP.NET_MVC.Models.Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Tuwaiq\dotNET\projects\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Views\Books\Index.cshtml"
  
    var allBooks = (List<Book>)ViewData["allBooks"];
    Layout = "_myLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<br />\r\n\r\n<div class=\"row\">\r\n\r\n");
#nullable restore
#line 14 "D:\Tuwaiq\dotNET\projects\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Views\Books\Index.cshtml"
     foreach (var book in allBooks)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-3 mb-5\">\r\n\r\n            <div class=\"card bg-light text-dark\">\r\n\r\n                <img");
            BeginWriteAttribute("src", " src=", 340, "", 356, 1);
#nullable restore
#line 21 "D:\Tuwaiq\dotNET\projects\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Views\Books\Index.cshtml"
WriteAttributeValue("", 345, book.image, 345, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                     class=""card-img-top p-1""
                     alt=""book image""
                     width=""200px""
                     height=""250px"" />

                <div class=""card-body"">
                    <h5 class=""card-title book-name"">");
#nullable restore
#line 28 "D:\Tuwaiq\dotNET\projects\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Views\Books\Index.cshtml"
                                                Write(book.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <b>Author: <a");
            BeginWriteAttribute("href", " href=\"", 666, "\"", 704, 2);
            WriteAttributeValue("", 673, "/authors/detail/", 673, 16, true);
#nullable restore
#line 29 "D:\Tuwaiq\dotNET\projects\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Views\Books\Index.cshtml"
WriteAttributeValue("", 689, book.author.Id, 689, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 29 "D:\Tuwaiq\dotNET\projects\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Views\Books\Index.cshtml"
                                                                     Write(book.author.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a> </b>\r\n                    <p class=\"card-text text-right price-tag\">$");
#nullable restore
#line 30 "D:\Tuwaiq\dotNET\projects\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Views\Books\Index.cshtml"
                                                          Write(book.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <div class=\"text-center\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 893, "\"", 922, 2);
            WriteAttributeValue("", 900, "/books/detail/", 900, 14, true);
#nullable restore
#line 32 "D:\Tuwaiq\dotNET\projects\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Views\Books\Index.cshtml"
WriteAttributeValue("", 914, book.Id, 914, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary \">\r\n                            More Info\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 40 "D:\Tuwaiq\dotNET\projects\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\Views\Books\Index.cshtml"


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n\r\n\r\n    <br />\r\n    <br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Project01_ASP.NET_MVC.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
