#pragma checksum "C:\Users\RTC9911\Documents\GitHub\BlogProject-Asp.Net-Core\CoreDemo\Views\Shared\Components\LastThreePost\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cfd4dfb1878aa05ba52ed2dd410064eacad472a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_LastThreePost_Default), @"mvc.1.0.view", @"/Views/Shared/Components/LastThreePost/Default.cshtml")]
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
#line 1 "C:\Users\RTC9911\Documents\GitHub\BlogProject-Asp.Net-Core\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RTC9911\Documents\GitHub\BlogProject-Asp.Net-Core\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cfd4dfb1878aa05ba52ed2dd410064eacad472a", @"/Views/Shared/Components/LastThreePost/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_LastThreePost_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-lg-4 footer-grid-agileits-w3ls text-left\">\r\n\r\n    <div class=\"tech-btm\">\r\n        <h3>Son Postlar</h3>\r\n");
#nullable restore
#line 7 "C:\Users\RTC9911\Documents\GitHub\BlogProject-Asp.Net-Core\CoreDemo\Views\Shared\Components\LastThreePost\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"blog-grids row mb-3\">\r\n                <div class=\"col-md-5 blog-grid-left\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 343, "\"", 380, 2);
            WriteAttributeValue("", 350, "/Blog/BlogReadAll/", 350, 18, true);
#nullable restore
#line 11 "C:\Users\RTC9911\Documents\GitHub\BlogProject-Asp.Net-Core\CoreDemo\Views\Shared\Components\LastThreePost\Default.cshtml"
WriteAttributeValue("", 368, item.BlogID, 368, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 412, "\"", 434, 2);
#nullable restore
#line 12 "C:\Users\RTC9911\Documents\GitHub\BlogProject-Asp.Net-Core\CoreDemo\Views\Shared\Components\LastThreePost\Default.cshtml"
WriteAttributeValue("", 418, item.BlogImage, 418, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 433, "", 434, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 466, "\"", 472, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </a>\r\n                </div>\r\n                <div class=\"col-md-7 blog-grid-right\">\r\n\r\n                    <h5>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 636, "\"", 673, 2);
            WriteAttributeValue("", 643, "/Blog/BlogReadAll/", 643, 18, true);
#nullable restore
#line 18 "C:\Users\RTC9911\Documents\GitHub\BlogProject-Asp.Net-Core\CoreDemo\Views\Shared\Components\LastThreePost\Default.cshtml"
WriteAttributeValue("", 661, item.BlogID, 661, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "C:\Users\RTC9911\Documents\GitHub\BlogProject-Asp.Net-Core\CoreDemo\Views\Shared\Components\LastThreePost\Default.cshtml"
                                                            Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </h5>\r\n                    <div class=\"sub-meta\">\r\n                        <span>\r\n                            <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 22 "C:\Users\RTC9911\Documents\GitHub\BlogProject-Asp.Net-Core\CoreDemo\Views\Shared\Components\LastThreePost\Default.cshtml"
                                                     Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n");
#nullable restore
#line 28 "C:\Users\RTC9911\Documents\GitHub\BlogProject-Asp.Net-Core\CoreDemo\Views\Shared\Components\LastThreePost\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
