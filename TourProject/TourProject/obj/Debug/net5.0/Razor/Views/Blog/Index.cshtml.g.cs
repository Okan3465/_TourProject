#pragma checksum "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b5e16ba73e384024f53f14c823a34c8a71acbb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\_ViewImports.cshtml"
using TourProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\_ViewImports.cshtml"
using TourProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\_ViewImports.cshtml"
using EntityLayer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b5e16ba73e384024f53f14c823a34c8a71acbb8", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a566ea08b216d4cfd8340b85b7a8468ae3d2cb0c", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"

<div class=""packages"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""titlepage text_align_center "">
                    <h2>Şehirler</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
");
#nullable restore
#line 20 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Blog\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\" col-md-6\">\r\n                    <div id=\"ho_img\" class=\"packages_box\" data-aos=\"fade-right\">\r\n                        <figure><img");
            BeginWriteAttribute("src", " src=\"", 634, "\"", 651, 1);
#nullable restore
#line 24 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Blog\Index.cshtml"
WriteAttributeValue("", 640, item.Image, 640, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"#\" /></figure>\r\n                        <div class=\"tuscany\">\r\n                            <div class=\"tusc text_align_left\">\r\n                                <div class=\"italy\">\r\n                                    <h3>");
#nullable restore
#line 28 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Blog\Index.cshtml"
                                   Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    \r\n                                </div>\r\n                            </div>\r\n                            <p> ");
#nullable restore
#line 32 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Blog\Index.cshtml"
                           Write(item.BlogContent.Substring(0,515));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <div class=\"tusc\">\r\n                                <a class=\"read_more\"");
            BeginWriteAttribute("href", " href=\"", 1186, "\"", 1228, 3);
            WriteAttributeValue("", 1193, "/Blog/BlogReadDetails/", 1193, 22, true);
#nullable restore
#line 34 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1215, item.BlogID, 1215, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1227, ")", 1227, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Devamını Oku</a>\r\n                             \r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 40 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Blog\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n            </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
