#pragma checksum "D:\HocTap\HKIV\KiemThuPhanMem\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Carts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00927185604e857f201e7bff70127559ae208e8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carts_Index), @"mvc.1.0.view", @"/Views/Carts/Index.cshtml")]
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
#line 1 "D:\HocTap\HKIV\KiemThuPhanMem\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\_ViewImports.cshtml"
using Eshop_Bookstore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HocTap\HKIV\KiemThuPhanMem\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\_ViewImports.cshtml"
using Eshop_Bookstore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00927185604e857f201e7bff70127559ae208e8d", @"/Views/Carts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cde83794b1b5c30b44aa092e569c441790afaa01", @"/Views/_ViewImports.cshtml")]
    public class Views_Carts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Eshop_Bookstore.Models.Cart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\HocTap\HKIV\KiemThuPhanMem\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Carts\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""breadcrumbs_area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""breadcrumb_content"">
                    <h3>Cart</h3>
                    <ul>
                        <li><a href=""index.html"">home</a></li>
                        <li>Shopping Cart</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""shopping_cart_area mt-100"">
    <div class=""container"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00927185604e857f201e7bff70127559ae208e8d4928", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""table_desc"">
                        <div class=""cart_page table-responsive"">
                            <table>
                                <thead>
                                    <tr>
                                        <th class=""product_remove"">Delete</th>
                                        <th class=""product_thumb"">Image</th>
                                        <th class=""product_name"">Product</th>
                                        <th class=""product-price"">Price</th>
                                        <th class=""product_quantity"">Quantity</th>
                                        <th class=""product_total"">Total</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 40 "D:\HocTap\HKIV\KiemThuPhanMem\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Carts\Index.cshtml"
                                     foreach(var item in Model) { 

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <tr>
                                        <td class=""product_remove"">
                                            <a href=""#""><i class=""fa fa-trash-o""></i></a>
                                        </td>
                                        <td class=""product_thumb""><a href=""#"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "00927185604e857f201e7bff70127559ae208e8d6724", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1950, "~/images/product/", 1950, 17, true);
#nullable restore
#line 45 "D:\HocTap\HKIV\KiemThuPhanMem\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Carts\Index.cshtml"
AddHtmlAttributeValue("", 1967, Html.DisplayFor(modelItem => item.Product.Image), 1967, 49, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</a></td>\r\n                                        <td class=\"product_name\"><a href=\"#\"></a>");
#nullable restore
#line 46 "D:\HocTap\HKIV\KiemThuPhanMem\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Carts\Index.cshtml"
                                                                            Write(Html.DisplayFor(modelItem => item.Product.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td class=\"product-price\">");
#nullable restore
#line 47 "D:\HocTap\HKIV\KiemThuPhanMem\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Carts\Index.cshtml"
                                                             Write(Html.DisplayFor(modelItem => item.Product.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td class=\"product_quantity\"><input min=\"1\" max=\"100\"");
                BeginWriteAttribute("value", " value=\"", 2387, "\"", 2439, 1);
#nullable restore
#line 48 "D:\HocTap\HKIV\KiemThuPhanMem\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Carts\Index.cshtml"
WriteAttributeValue("", 2395, Html.DisplayFor(modelItem => item.Quantity), 2395, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"number\"></td>\r\n                                        <td class=\"product_total\">");
#nullable restore
#line 49 "D:\HocTap\HKIV\KiemThuPhanMem\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Carts\Index.cshtml"
                                                             Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 51 "D:\HocTap\HKIV\KiemThuPhanMem\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\Carts\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                        <div class=""cart_submit"">
                            <button type=""submit"">update cart</button>
                        </div>
                    </div>
                </div>
            </div>
            <!--coupon code area start-->
            <div class=""coupon_area"">
                <div class=""row"">
                    <div class=""col-lg-6 col-md-6"">
                        <div class=""coupon_code left"">
                            <h3>Coupon</h3>
                            <div class=""coupon_inner"">
                                <p>Enter your coupon code if you have one.</p>
                                <input placeholder=""Coupon code"" type=""text"">
                                <button type=""submit"">Apply coupon</button>
                            </div>
                        </div>
                    </div>
                    <div c");
                WriteLiteral(@"lass=""col-lg-6 col-md-6"">
                        <div class=""coupon_code right"">
                            <h3>Cart Totals</h3>
                            <div class=""coupon_inner"">
                                <div class=""cart_subtotal"">
                                    <p>Subtotal</p>
                                    <p class=""cart_amount"">£215.00</p>
                                </div>
                                <div class=""cart_subtotal "">
                                    <p>Shipping</p>
                                    <p class=""cart_amount""><span>Flat Rate:</span> £255.00</p>
                                </div>
                                <a href=""#"">Calculate shipping</a>

                                <div class=""cart_subtotal"">
                                    <p>Total</p>
                                    <p class=""cart_amount"">£215.00</p>
                                </div>
                                <div class=""checkout_btn"">
    ");
                WriteLiteral(@"                                <a href=""#"">Proceed to Checkout</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!--coupon code area end-->
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Eshop_Bookstore.Models.Cart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
