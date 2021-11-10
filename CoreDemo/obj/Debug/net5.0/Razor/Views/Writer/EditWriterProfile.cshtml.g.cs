#pragma checksum "C:\Users\kizil\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Writer\EditWriterProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b48ae956fd85e1eb3dc0eaa7af3db4fa84c3ddfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writer_EditWriterProfile), @"mvc.1.0.view", @"/Views/Writer/EditWriterProfile.cshtml")]
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
#line 1 "C:\Users\kizil\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kizil\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b48ae956fd85e1eb3dc0eaa7af3db4fa84c3ddfe", @"/Views/Writer/EditWriterProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Writer_EditWriterProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Writer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\kizil\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Writer\EditWriterProfile.cshtml"
  
    ViewData["Title"] = "EditWriterProfile";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\kizil\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Writer\EditWriterProfile.cshtml"
 using (Html.BeginForm("EditWriterProfile", "Writer", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">Yazar Profile Bilgileri Düzenleme</h4>\r\n                <br />\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b48ae956fd85e1eb3dc0eaa7af3db4fa84c3ddfe4490", async() => {
                WriteLiteral("\r\n\r\n                    ");
#nullable restore
#line 16 "C:\Users\kizil\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Writer\EditWriterProfile.cshtml"
               Write(Html.HiddenFor(x => x.WriterID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputName1\">Ad Ve Soyad</label>\r\n                        ");
#nullable restore
#line 20 "C:\Users\kizil\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Writer\EditWriterProfile.cshtml"
                   Write(Html.TextBoxFor(x => x.WriterName, new { @class = "form-control", @id = "exampleInputName1", @placeholder = "Ad Ve Soyad" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputEmail3\">Mail adresi</label>\r\n                        ");
#nullable restore
#line 24 "C:\Users\kizil\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Writer\EditWriterProfile.cshtml"
                   Write(Html.TextBoxFor(x => x.WriterMail, new { @class = "form-control", @id = "exampleInputEmail3", @placeholder = "Mail Adresi" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputPassword4\">Şifre</label>\r\n                        ");
#nullable restore
#line 28 "C:\Users\kizil\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Writer\EditWriterProfile.cshtml"
                   Write(Html.PasswordFor(x => x.WriterPassword, new { @class = "form-control", @id = "exampleInputPassword4", @placeholder = "Şifre" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                    <div class=""form-group"">
                        <label>File upload</label>
                        <input type=""file"" name=""img[]"" class=""file-upload-default"">
                        <div class=""input-group col-xs-12"">
                            <input type=""text"" class=""form-control file-upload-info"" disabled placeholder=""Upload Image"">
                            <span class=""input-group-append"">
                                <button class=""file-upload-browse btn btn-gradient-primary"" type=""button"">Upload</button>
                            </span>
                        </div>
                    </div>
");
                WriteLiteral("                    <div class=\"form-group\">\r\n                        <label for=\"exampleTextarea1\">Yazar Hakkında</label>\r\n                        ");
#nullable restore
#line 46 "C:\Users\kizil\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Writer\EditWriterProfile.cshtml"
                   Write(Html.TextAreaFor(x => x.WriterAbout, 10, 3, new { @class = "form-control", @id = "exampleTextarea1", @placeholder = "Yazar Hakkında" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <button type=\"submit\" class=\"btn btn-gradient-primary mr-2\">Kaydet</button>\r\n                    <button class=\"btn btn-light\">Iptal et</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 54 "C:\Users\kizil\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Writer\EditWriterProfile.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Writer> Html { get; private set; }
    }
}
#pragma warning restore 1591
