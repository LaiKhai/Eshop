#pragma checksum "D:\DoAnKTPM\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb4a1e72f423e97e689050675de60b6996584da7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
#line 1 "D:\DoAnKTPM\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\_ViewImports.cshtml"
using Eshop_Bookstore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DoAnKTPM\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\_ViewImports.cshtml"
using Eshop_Bookstore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb4a1e72f423e97e689050675de60b6996584da7", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cde83794b1b5c30b44aa092e569c441790afaa01", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Eshop_Bookstore.Models.Account>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\DoAnKTPM\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Login.cshtml"
  
    ViewBag.Title = "Login";


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row justify-content-md-center\">\r\n    <div class=\"col-md-4\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header\">\r\n                Login\r\n            </div>\r\n            <div class=\"card-body\">\r\n");
#nullable restore
#line 16 "D:\DoAnKTPM\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Login.cshtml"
                 using (Html.BeginForm("Login", "Home", FormMethod.Post))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\DoAnKTPM\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Login.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 20 "D:\DoAnKTPM\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Login.cshtml"
                   Write(Html.LabelFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 21 "D:\DoAnKTPM\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Login.cshtml"
                   Write(Html.TextBoxFor(m => m.Username, "", new { @class = "form-control", @placeholder = "Username" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"form-group\">\r\n                        <br />\r\n                        ");
#nullable restore
#line 27 "D:\DoAnKTPM\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Login.cshtml"
                   Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 28 "D:\DoAnKTPM\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Login.cshtml"
                   Write(Html.PasswordFor(m => m.Password, new { @class = "form-control", @placeholder = "Password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"form-group\">\r\n                        <br />\r\n                        <input type=\"submit\" name=\"submit\" class=\"btn btn-primary\" value=\"Login\" />\r\n                    </div>\r\n");
#nullable restore
#line 35 "D:\DoAnKTPM\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Home\Login.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
