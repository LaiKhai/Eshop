#pragma checksum "D:\DoAnKTPM\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\ProductTypes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9abd199c02d360f653d300f33641a418911d2ecc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductTypes_Details), @"mvc.1.0.view", @"/Views/ProductTypes/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9abd199c02d360f653d300f33641a418911d2ecc", @"/Views/ProductTypes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cde83794b1b5c30b44aa092e569c441790afaa01", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductTypes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Eshop_Bookstore.Models.ProductType>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ProductTypes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("primary_img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\DoAnKTPM\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\ProductTypes\Details.cshtml"
  
    ViewData["Title"] = Model.Name;
    IEnumerable<Product> lstProducts = ViewBag.lstProduct as IEnumerable<Product>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!--breadcrumbs area start-->\r\n<div class=\"breadcrumbs_area\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <div class=\"breadcrumb_content\">\r\n                    <h3>");
#nullable restore
#line 15 "D:\DoAnKTPM\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\ProductTypes\Details.cshtml"
                   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <ul>\r\n                        <li><a href=\"index.html\">Trang Ch???</a></li>\r\n                        <li>");
#nullable restore
#line 18 "D:\DoAnKTPM\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\ProductTypes\Details.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
<!--breadcrumbs area end-->
<!--shop  area start-->
<div class=""shop_area shop_reverse mt-100 mb-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3 col-md-12"">
                <!--sidebar widget start-->
                <aside class=""sidebar_widget"">
                    <div class=""widget_inner"">
                        <div class=""widget_list widget_categories"">
                            <h3>C??c lo???i s??ch</h3>
");
#nullable restore
#line 36 "D:\DoAnKTPM\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\ProductTypes\Details.cshtml"
                             foreach (var item in ViewBag.lstProductTypes)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <ul>\r\n\r\n                                    <li>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9abd199c02d360f653d300f33641a418911d2ecc7136", async() => {
#nullable restore
#line 41 "D:\DoAnKTPM\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\ProductTypes\Details.cshtml"
                                                                                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "D:\DoAnKTPM\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\ProductTypes\Details.cshtml"
                                                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </li>\r\n\r\n                                </ul>\r\n");
#nullable restore
#line 45 "D:\DoAnKTPM\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\ProductTypes\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n");
            WriteLiteral(@"
                    </div>
                </aside>
                <!--sidebar widget end-->
            </div>
            <div class=""col-lg-9 col-md-12"">
                <!--shop wrapper start-->
                <!--shop toolbar start-->
                <div class=""shop_toolbar_wrapper"">
                    <div class=""shop_toolbar_btn"">

                        <button data-role=""grid_3"" type=""button"" class=""active btn-grid-3"" data-bs-toggle=""tooltip""
                                title=""3""></button>

                        <button data-role=""grid_4"" type=""button"" class="" btn-grid-4"" data-bs-toggle=""tooltip""
                                title=""4""></button>

                        <button data-role=""grid_list"" type=""button"" class=""btn-list"" data-bs-toggle=""tooltip""
                                title=""List""></button>
                    </div>
");
            WriteLiteral("                </div>\r\n                <!--shop toolbar end-->\r\n                <div class=\"row shop_wrapper\">\r\n");
#nullable restore
#line 95 "D:\DoAnKTPM\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\ProductTypes\Details.cshtml"
                     foreach (var item in ViewBag.lstProduct)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-lg-4 col-md-4 col-12 "">
                            <article class=""single_product"">
                                <figure>
                                    <div class=""product_thumb"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9abd199c02d360f653d300f33641a418911d2ecc11868", async() => {
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9abd199c02d360f653d300f33641a418911d2ecc12168", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4511, "~/EshopView/assets/img/product/", 4511, 31, true);
#nullable restore
#line 102 "D:\DoAnKTPM\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\ProductTypes\Details.cshtml"
AddHtmlAttributeValue("", 4542, item.Image, 4542, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "D:\DoAnKTPM\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\ProductTypes\Details.cshtml"
                                                                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        <div class=""action_links"">
                                            <ul>
                                                <li class=""add_to_cart"">
                                                    <a href=""cart.html"" title=""Add to cart"">
                                                        <i class=""icon-shopping-bag""></i>
                                                    </a>
                                                </li>
                                                <li class=""quick_button"">
                                                    <a href=""#"" data-bs-toggle=""modal""
                                                       data-bs-target=""#modal_box"" title=""quick view"">
                                                        <i class=""icon-eye""></i>
                                                    </a>
                                                </li>
                                            </ul>
                   ");
            WriteLiteral(@"                     </div>
                                        <div class=""action_links list_action"">
                                            <ul>
                                                <li class=""quick_button"">
                                                    <a href=""#"" data-bs-toggle=""modal""
                                                       data-bs-target=""#modal_box"" title=""quick view"">
                                                        <i class=""icon-eye""></i>
                                                    </a>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                    <div class=""product_content grid_content"">
                                        <div class=""product_price_rating"">
                                            <div class=""product_rating"">
                              ");
            WriteLiteral("              </div>\r\n                                            <h4 class=\"product_name\">\r\n                                                <a href=\"product-details.html\">\r\n                                                    ");
#nullable restore
#line 136 "D:\DoAnKTPM\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\ProductTypes\Details.cshtml"
                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </a>
                                            </h4>
                                            <h6 class=""price_box"">
                                                <a href=""product-details.html"">
                                                    ");
#nullable restore
#line 141 "D:\DoAnKTPM\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\ProductTypes\Details.cshtml"
                                               Write(item.Actor);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </a>\r\n                                            </h6>\r\n                                            <div class=\"price_box\">\r\n                                                <span class=\"current_price\">");
#nullable restore
#line 145 "D:\DoAnKTPM\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\ProductTypes\Details.cshtml"
                                                                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""product_content list_content"">
                                        <div class=""product_rating"">
                                            <ul>
                                                <li><a href=""#""><i class=""icon-star""></i></a></li>
                                                <li><a href=""#""><i class=""icon-star""></i></a></li>
                                                <li><a href=""#""><i class=""icon-star""></i></a></li>
                                                <li><a href=""#""><i class=""icon-star""></i></a></li>
                                                <li><a href=""#""><i class=""icon-star""></i></a></li>
                                            </ul>
                                        </div>
                                        <h4 class=""product_name"">
     ");
            WriteLiteral(@"                                       <a href=""product-details.html"">commodo augue nisi</a>
                                        </h4>
                                        <div class=""price_box"">
                                            <span class=""current_price"">??69.00</span>
                                            <span class=""old_price"">??74.00</span>
                                        </div>
                                        <div class=""product_desc"">
                                            <p>
                                                Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
                                                tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim
                                                veniam, quis nostrud exercitation ullamco???
                                            </p>
                                        </div>
                                        <div class=""a");
            WriteLiteral(@"ction_links list_action_right"">
                                            <ul>
                                                <li class=""add_to_cart"">
                                                    <a href=""cart.html"" title=""Add to cart"">
                                                        Add to
                                                        cart
                                                    </a>
                                                </li>
                                                <li class=""wishlist"">
                                                    <a href=""wishlist.html"" title=""Add to Wishlist"">
                                                        <i class=""icon-heart""></i>
                                                    </a>
                                                </li>
                                                <li class=""compare"">
                                                    <a href=""#"" title=""Add to Compare"">
     ");
            WriteLiteral(@"                                                   <i class=""icon-sliders""></i>
                                                    </a>
                                                </li>

                                            </ul>
                                        </div>
                                    </div>
                                </figure>
                            </article>
                        </div>
");
#nullable restore
#line 198 "D:\DoAnKTPM\Eshop\Eshop_Bookstore\Eshop_Bookstore\Views\ProductTypes\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n");
            WriteLiteral("                <!--shop toolbar end-->\r\n                <!--shop wrapper end-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!--shop  area end-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Eshop_Bookstore.Models.ProductType> Html { get; private set; }
    }
}
#pragma warning restore 1591
