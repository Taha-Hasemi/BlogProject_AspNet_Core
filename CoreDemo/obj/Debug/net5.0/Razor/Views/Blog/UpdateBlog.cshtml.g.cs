#pragma checksum "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\UpdateBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44d6a1d7f634c36f4084491a149dd78a8643bd9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_UpdateBlog), @"mvc.1.0.view", @"/Views/Blog/UpdateBlog.cshtml")]
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
#line 1 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44d6a1d7f634c36f4084491a149dd78a8643bd9e", @"/Views/Blog/UpdateBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_UpdateBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\UpdateBlog.cshtml"
  
    ViewData["Title"] = "UpdateBlog";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Bloğu düzenle</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\UpdateBlog.cshtml"
 using (Html.BeginForm("UpdateBlog", "Blog", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\UpdateBlog.cshtml"
Write(Html.Label("Blog başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\UpdateBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogTitle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\UpdateBlog.cshtml"
Write(Html.ValidationMessageFor(x => x.BlogTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 16 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\UpdateBlog.cshtml"
Write(Html.Label("Blog görseli"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\UpdateBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\UpdateBlog.cshtml"
Write(Html.ValidationMessageFor(x => x.BlogImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 20 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\UpdateBlog.cshtml"
Write(Html.Label("Blog küçük görsel"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\UpdateBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogThambnailImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\UpdateBlog.cshtml"
Write(Html.ValidationMessageFor(x => x.BlogThambnailImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 24 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\UpdateBlog.cshtml"
Write(Html.Label("Blog kategori"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\UpdateBlog.cshtml"
Write(Html.DropDownListFor(x => x.CategoryID, (List<SelectListItem>)ViewBag.CategoryValues, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 27 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\UpdateBlog.cshtml"
Write(Html.Label("Blog içerik"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\UpdateBlog.cshtml"
Write(Html.TextAreaFor(x => x.BlogContent, 3, 10, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\UpdateBlog.cshtml"
Write(Html.ValidationMessageFor(x => x.BlogContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 31 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\UpdateBlog.cshtml"
Write(Html.HiddenFor(x => x.BlogCreateDate));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\UpdateBlog.cshtml"
Write(Html.HiddenFor(x => x.CategoryID));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\UpdateBlog.cshtml"
Write(Html.HiddenFor(x => x.WriterID));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\UpdateBlog.cshtml"
Write(Html.HiddenFor(x => x.BlogID));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\UpdateBlog.cshtml"
Write(Html.HiddenFor(x => x.BlogStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button class=\"btn btn-success\">Bloğu Güncelle</button>\r\n");
#nullable restore
#line 37 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\UpdateBlog.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591