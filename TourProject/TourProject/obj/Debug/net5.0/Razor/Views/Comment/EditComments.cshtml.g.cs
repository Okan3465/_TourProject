#pragma checksum "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\EditComments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e29ca90498f1cb7979c2b8c8ca909eda2d4f5c1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_EditComments), @"mvc.1.0.view", @"/Views/Comment/EditComments.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e29ca90498f1cb7979c2b8c8ca909eda2d4f5c1a", @"/Views/Comment/EditComments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a566ea08b216d4cfd8340b85b7a8468ae3d2cb0c", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_EditComments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Comment>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\EditComments.cshtml"
  
    ViewData["Title"] = "EditComments";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<div class=\"d-flex justify-content-center\"> <h1>Blog Düzenleme Sayfası</h1></div>\r\n<br />\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\EditComments.cshtml"
 using (Html.BeginForm("EditComments", "Comment", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"d-flex justify-content-center\"> ");
#nullable restore
#line 12 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\EditComments.cshtml"
                                       Write(Html.Label("Yorum ID"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n");
#nullable restore
#line 13 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\EditComments.cshtml"
Write(Html.TextBoxFor(x => x.CommentID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <div class=\"d-flex justify-content-center\">  ");
#nullable restore
#line 16 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\EditComments.cshtml"
                                            Write(Html.Label("Kullanıcı Adı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 17 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\EditComments.cshtml"
Write(Html.TextBoxFor(x => x.CommenUserName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <div class=\"d-flex justify-content-center\">  ");
#nullable restore
#line 19 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\EditComments.cshtml"
                                            Write(Html.Label("Kullanıcı Görseli"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 20 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\EditComments.cshtml"
Write(Html.TextBoxFor(x => x.CommentImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <div class=\"d-flex justify-content-center\">   ");
#nullable restore
#line 22 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\EditComments.cshtml"
                                             Write(Html.Label("Yorum Başlığı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 23 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\EditComments.cshtml"
Write(Html.TextBoxFor(x => x.CommentTitle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <div class=\"d-flex justify-content-center\">  ");
#nullable restore
#line 25 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\EditComments.cshtml"
                                            Write(Html.Label("Yorum İçeriği"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 26 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\EditComments.cshtml"
Write(Html.TextAreaFor(x => x.CommentContent, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <div class=\"d-flex justify-content-center\">  <button class=\"btn btn-danger\">Değişiklikleri Kaydet</button></div>\r\n");
#nullable restore
#line 31 "C:\Users\Okan Karakoç\Documents\GitHub\TourProject\TourProject\Views\Comment\EditComments.cshtml"
   
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Comment> Html { get; private set; }
    }
}
#pragma warning restore 1591
