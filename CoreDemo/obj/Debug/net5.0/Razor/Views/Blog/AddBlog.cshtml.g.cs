#pragma checksum "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a6e2ebbd70448675790ec2e538241c34cb6e226"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_AddBlog), @"mvc.1.0.view", @"/Views/Blog/AddBlog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a6e2ebbd70448675790ec2e538241c34cb6e226", @"/Views/Blog/AddBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_AddBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
  
    ViewData["Title"] = "AddBlog";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Yeni Blog Girişi</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
 using (Html.BeginForm("AddBlog", "Blog", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
Write(Html.Label("Blog başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogTitle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
Write(Html.ValidationMessageFor(x => x.BlogTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 15 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
Write(Html.Label("Blog görseli"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
Write(Html.ValidationMessageFor(x => x.BlogImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 19 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
Write(Html.Label("Blog küçük görsel"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogThambnailImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
Write(Html.ValidationMessageFor(x => x.BlogThambnailImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 23 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
Write(Html.Label("Blog kategori"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
Write(Html.DropDownListFor(x => x.CategoryID, (List<SelectListItem>)ViewBag.CategoryValues, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 26 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
Write(Html.Label("Blog içerik"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
Write(Html.TextAreaFor(x => x.BlogContent, 3, 10, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
Write(Html.ValidationMessageFor(x => x.BlogContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\">Bloğu Ekle</button>\r\n");
#nullable restore
#line 31 "C:\Users\kizil\Source\Repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
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