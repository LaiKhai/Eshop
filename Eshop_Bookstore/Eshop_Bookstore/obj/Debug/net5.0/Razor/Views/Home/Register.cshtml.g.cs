#pragma checksum "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab74eaefaed5bf7b7ac3b51a4e660d48fadd70bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
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
#line 1 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\_ViewImports.cshtml"
using Eshop_Bookstore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\_ViewImports.cshtml"
using Eshop_Bookstore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab74eaefaed5bf7b7ac3b51a4e660d48fadd70bd", @"/Views/Home/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cde83794b1b5c30b44aa092e569c441790afaa01", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Eshop_Bookstore.Models.Account>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
  
    ViewBag.Title = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row justify-content-md-center\">\r\n    <div class=\"col-md-5\">\r\n");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab74eaefaed5bf7b7ac3b51a4e660d48fadd70bd4783", async() => {
                WriteLiteral("\r\n            <!-- Input and Submit elements -->\r\n            ");
#nullable restore
#line 14 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
       Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 15 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

            <div class=""card"">
                <div class=""card-header"">
                    <div class=""card-title"">Register</div>
                </div>
                <div class=""card-body"">
                    <div class=""form-group"">
                        <br />
                        ");
#nullable restore
#line 24 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
                   Write(Html.LabelFor(m => m.Username));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 25 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
                   Write(Html.TextBoxFor(m => m.Username, "", new { @class = "form-control", @placeholder = "User Name" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 26 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Username, "", new { @class = "badge badge-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <br />\r\n                        ");
#nullable restore
#line 30 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
                   Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 31 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
                   Write(Html.PasswordFor(m => m.Password, new { @class = "form-control", @placeholder = "Password" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 32 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "badge badge-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <br />\r\n                        ");
#nullable restore
#line 36 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
                   Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 37 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
                   Write(Html.TextBoxFor(m => m.Email, "", new { @class = "form-control", @placeholder = "Email" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 38 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "badge badge-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 39 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
                         if (ViewBag.error != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <span class=\"badge badge-danger\">");
#nullable restore
#line 41 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
                                                        Write(ViewBag.error);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 42 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                    <div class=\"form-group\">\r\n                        <br />\r\n                        ");
#nullable restore
#line 46 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
                   Write(Html.LabelFor(m => m.Phone));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 47 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
                   Write(Html.TextBoxFor(m => m.Phone, new { @class = "form-control", @placeholder = "Phone" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 48 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Phone, "", new { @class = "badge badge-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <br />\r\n                        ");
#nullable restore
#line 52 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
                   Write(Html.LabelFor(m => m.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 53 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
                   Write(Html.TextBoxFor(m => m.Address, "", new { @class = "form-control", @placeholder = "Address" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 54 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Address, "", new { @class = "badge badge-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <br />\r\n                        ");
#nullable restore
#line 58 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
                   Write(Html.LabelFor(m => m.FullName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 59 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
                   Write(Html.TextBoxFor(m => m.FullName, "", new { @class = "form-control", @placeholder = "FullName" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 60 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
                   Write(Html.ValidationMessageFor(m => m.FullName, "", new { @class = "badge badge-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <br />\r\n                        ");
#nullable restore
#line 64 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
                   Write(Html.LabelFor(m => m.IsAdmin));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 65 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
                   Write(Html.TextBoxFor(m => m.IsAdmin, "", new { @class = "form-control", @placeholder = "IsAdmin" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 66 "D:\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Register.cshtml"
                   Write(Html.ValidationMessageFor(m => m.IsAdmin, "", new { @class = "badge badge-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n\r\n\r\n");
                WriteLiteral(@"                    <div class=""form-group"">
                        <br />
                        <input type=""submit"" name=""submit"" class=""btn btn-danger"" value=""Register"" />
                    </div>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Eshop_Bookstore.Models.Account> Html { get; private set; }
    }
}
#pragma warning restore 1591
