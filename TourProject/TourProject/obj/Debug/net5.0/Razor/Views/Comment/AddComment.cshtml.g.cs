#pragma checksum "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\AddComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36662500f7803f43ba9453c50f6506cc4ccb1a76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_AddComment), @"mvc.1.0.view", @"/Views/Comment/AddComment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36662500f7803f43ba9453c50f6506cc4ccb1a76", @"/Views/Comment/AddComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a566ea08b216d4cfd8340b85b7a8468ae3d2cb0c", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_AddComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Comment>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\AddComment.cshtml"
  
    ViewData["Title"] = "AddComment";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<br />\r\n<h1 class=\"d-flex justify-content-center\">Yeni Yorum Yap</h1>\r\n<br />\r\n\r\n\r\n\r\n");
#nullable restore
#line 15 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\AddComment.cshtml"
 using (Html.BeginForm("AddComment", "Comment", FormMethod.Post))
{



#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"d-flex justify-content-center\"> ");
#nullable restore
#line 19 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\AddComment.cshtml"
                                           Write(Html.Label("Kullanıcı Adı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 20 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\AddComment.cshtml"
Write(Html.TextBoxFor(x => x.CommenUserName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\AddComment.cshtml"
Write(Html.ValidationMessageFor(x => x.CommenUserName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <div class=\"d-flex justify-content-center\"> ");
#nullable restore
#line 24 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\AddComment.cshtml"
                                           Write(Html.Label("Yorum Başlığı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 25 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\AddComment.cshtml"
Write(Html.TextBoxFor(x => x.CommentTitle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\AddComment.cshtml"
Write(Html.ValidationMessageFor(x => x.CommentTitle, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("<div class=\"d-flex justify-content-center\">   ");
#nullable restore
#line 30 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\AddComment.cshtml"
                                         Write(Html.Label("Yorum İçeriği"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 31 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\AddComment.cshtml"
Write(Html.TextBoxFor(x => x.CommentContent, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\AddComment.cshtml"
Write(Html.ValidationMessageFor(x => x.CommentContent, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <br />\r\n    <div class=\"d-flex justify-content-center\">\r\n        <button type=\"submit\" class=\"btn btn-outline-dark\">Yorum Yap</button>\r\n\r\n    </div>\r\n");
#nullable restore
#line 43 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\AddComment.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Comment> Html { get; private set; }
    }
}
#pragma warning restore 1591
