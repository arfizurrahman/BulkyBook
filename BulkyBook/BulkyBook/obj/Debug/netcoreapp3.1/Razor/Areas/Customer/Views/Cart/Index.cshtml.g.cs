#pragma checksum "C:\Projects\Asp.net Core\BulkyBook\BulkyBook\BulkyBook\Areas\Customer\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68a186c2d8039d5b0ec795890d96142409fae76b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Cart_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Projects\Asp.net Core\BulkyBook\BulkyBook\BulkyBook\Areas\Customer\Views\_ViewImports.cshtml"
using BulkyBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\Asp.net Core\BulkyBook\BulkyBook\BulkyBook\Areas\Customer\Views\_ViewImports.cshtml"
using BulkyBook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68a186c2d8039d5b0ec795890d96142409fae76b", @"/Areas/Customer/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b283f6c8c7163b5f5d1f909d7b66a1ed4e3ccc1", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BulkyBook.Models.ViewModels.ShoppingCartVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Summary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Projects\Asp.net Core\BulkyBook\BulkyBook\BulkyBook\Areas\Customer\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Shopping Cart";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68a186c2d8039d5b0ec795890d96142409fae76b6341", async() => {
                WriteLiteral("\r\n    <br />\r\n");
#nullable restore
#line 11 "C:\Projects\Asp.net Core\BulkyBook\BulkyBook\BulkyBook\Areas\Customer\Views\Cart\Index.cshtml"
     if (Model.ListCart.Any())
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <div class=""backgroundWhiteBorder"">
            <div class=""container"">
                <div class=""card"">
                    <div class=""card-header bg-dark text-light ml-0 row container"">
                        <div class=""col-6"">
                            <i class=""fa fa-shopping-cart""></i> &nbsp;
                            Shopping Cart
                        </div>
                        <div class=""col-6 text-right"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68a186c2d8039d5b0ec795890d96142409fae76b7356", async() => {
                    WriteLiteral("Continue Shopping");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"card-body\">\r\n");
#nullable restore
#line 27 "C:\Projects\Asp.net Core\BulkyBook\BulkyBook\BulkyBook\Areas\Customer\Views\Cart\Index.cshtml"
                         foreach (var cart in Model.ListCart)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"row\">\r\n                                <div class=\"d-none d-lg-block col-lg-1 text-center py-2\">\r\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 1200, "\"", 1228, 1);
#nullable restore
#line 31 "C:\Projects\Asp.net Core\BulkyBook\BulkyBook\BulkyBook\Areas\Customer\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1206, cart.Product.ImageUrl, 1206, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded\" width=\"100%\"/>\r\n                                </div>\r\n                                <div class=\"col-12 text-sm-center col-lg-6 text-lg-left\">\r\n                                    <h5><strong>");
#nullable restore
#line 34 "C:\Projects\Asp.net Core\BulkyBook\BulkyBook\BulkyBook\Areas\Customer\Views\Cart\Index.cshtml"
                                           Write(cart.Product.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></h5>\r\n                                    <p><small>");
#nullable restore
#line 35 "C:\Projects\Asp.net Core\BulkyBook\BulkyBook\BulkyBook\Areas\Customer\Views\Cart\Index.cshtml"
                                         Write(cart.Product.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</small></p>
                                </div>
                                <div class=""col-12 text-sm-center col-lg-5 text-lg-right row"">
                                    <div class=""col-4 text-md-right"" style=""padding-top: 5px;"">
                                        <h6><strong>$ ");
#nullable restore
#line 39 "C:\Projects\Asp.net Core\BulkyBook\BulkyBook\BulkyBook\Areas\Customer\Views\Cart\Index.cshtml"
                                                 Write(cart.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("<span class=\"text-muted\">x</span>");
#nullable restore
#line 39 "C:\Projects\Asp.net Core\BulkyBook\BulkyBook\BulkyBook\Areas\Customer\Views\Cart\Index.cshtml"
                                                                                             Write(cart.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</strong></h6>
                                    </div>
                                    <div class=""col-6 col-sm-4 col-lg-6"">
                                        <div class=""float-right mx-1"">
                                            <button type=""submit"" class=""btn btn-primary"">
                                                <i class=""fas fa-plus""></i>
                                            </button>
                                        </div>
                                        <div class=""float-right mx-1"">
                                            <button type=""submit"" class=""btn btn-secondary"">
                                                <i class=""fas fa-minus""></i>
                                            </button>
                                        </div>
                                    </div>
                                    <div class=""col-2 col-sm-4 col-lg-2 text-right"">
                                        <button type=""submit"" class=");
                WriteLiteral(@"""btn btn-outline-danger"">
                                            <i class=""fas fa-trash""></i>
                                        </button>
                                    </div>
                                </div>
                            </div>
                            <hr/>
");
#nullable restore
#line 61 "C:\Projects\Asp.net Core\BulkyBook\BulkyBook\BulkyBook\Areas\Customer\Views\Cart\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-12 col-md-6 offset-md-6 col-lg-4 offset-lg-8 pr-4"">
                                <ul class=""list-group"">
                                    <li class=""list-group-item d-flex justify-content-between bg-light"">
                                        <span class=""text-info""> Total (USD)</span>
                                        <strong class=""text-info"">$ <span id=""txtOrderTotal"">");
#nullable restore
#line 68 "C:\Projects\Asp.net Core\BulkyBook\BulkyBook\BulkyBook\Areas\Customer\Views\Cart\Index.cshtml"
                                                                                        Write(Model.OrderHeader.OrderTotal);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></strong>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>

                    <div class=""card-footer"">
                        <div class=""row"">
");
#nullable restore
#line 77 "C:\Projects\Asp.net Core\BulkyBook\BulkyBook\BulkyBook\Areas\Customer\Views\Cart\Index.cshtml"
                             if (!Model.OrderHeader.ApplicationUser.EmailConfirmed
                                 && Model.OrderHeader.ApplicationUser.CompanyId != null
                                 && Model.OrderHeader.ApplicationUser.Company.IsAuthorizedCompany)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <div class=""col-8 text-danger"">
                                    Email must be confirmed for authorized customers!
                                </div>
                                <div class=""col-4"">
                                    <button type=""submit"" class=""btn btn-outline-warning btn-sm"">
                                        Click here to resend Confirmation Email
                                    </button>
                                </div>
");
#nullable restore
#line 89 "C:\Projects\Asp.net Core\BulkyBook\BulkyBook\BulkyBook\Areas\Customer\Views\Cart\Index.cshtml"
                            }
                            else{

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"col-sm-12 col-lg-4 col-md-6 offset-lg-8 offset-md-6 \">\r\n\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68a186c2d8039d5b0ec795890d96142409fae76b16107", async() => {
                    WriteLiteral("Summary");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 95 "C:\Projects\Asp.net Core\BulkyBook\BulkyBook\BulkyBook\Areas\Customer\Views\Cart\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 101 "C:\Projects\Asp.net Core\BulkyBook\BulkyBook\BulkyBook\Areas\Customer\Views\Cart\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>No items available in the shopping cart!</div>\r\n");
#nullable restore
#line 105 "C:\Projects\Asp.net Core\BulkyBook\BulkyBook\BulkyBook\Areas\Customer\Views\Cart\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BulkyBook.Models.ViewModels.ShoppingCartVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
