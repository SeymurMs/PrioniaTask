#pragma checksum "C:\Users\devel0per\source\repos\ProniaWepCoreApp\ProniaWepCoreApp\Views\Shared\_ProductPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00dd120171d7891967ad00ff090422a6c3c607b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductPartial), @"mvc.1.0.view", @"/Views/Shared/_ProductPartial.cshtml")]
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
#line 1 "C:\Users\devel0per\source\repos\ProniaWepCoreApp\ProniaWepCoreApp\Views\_ViewImports.cshtml"
using ProniaWepCoreApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\devel0per\source\repos\ProniaWepCoreApp\ProniaWepCoreApp\Views\_ViewImports.cshtml"
using ProniaWepCoreApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00dd120171d7891967ad00ff090422a6c3c607b2", @"/Views/Shared/_ProductPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05be3374f0c774b4795ebf1387f25d5ae7db13fa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__ProductPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:250px;height:250px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("primary-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product Images"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\devel0per\source\repos\ProniaWepCoreApp\ProniaWepCoreApp\Views\Shared\_ProductPartial.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-lg-3 col-md-4 col-sm-6\">\r\n        <div class=\"product-item\">\r\n            <div class=\"product-img\">\r\n                <a href=\"shop.html\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "00dd120171d7891967ad00ff090422a6c3c607b24763", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 307, "~/products/", 307, 11, true);
#nullable restore
#line 9 "C:\Users\devel0per\source\repos\ProniaWepCoreApp\ProniaWepCoreApp\Views\Shared\_ProductPartial.cshtml"
AddHtmlAttributeValue("", 318, item.PImages.Find(p=>p.IsMain == true).Image, 318, 45, false);

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
            WriteLiteral(@"
                </a>
                <div class=""product-add-action"">
                    <ul>
                        <li>
                            <a href=""wishlist.html"" data-tippy=""Add to wishlist"" data-tippy-inertia=""true"" data-tippy-animation=""shift-away"" data-tippy-delay=""50"" data-tippy-arrow=""true"" data-tippy-theme=""sharpborder"">
                                <i class=""pe-7s-like""></i>
                            </a>
                        </li>
                        <li class=""quuickview-btn"" data-bs-toggle=""modal"" data-bs-target=""#quickModal"">
                            <a href=""#"" data-tippy=""Quickview"" data-tippy-inertia=""true"" data-tippy-animation=""shift-away"" data-tippy-delay=""50"" data-tippy-arrow=""true"" data-tippy-theme=""sharpborder"">
                                <i class=""pe-7s-look""></i>
                            </a>
                        </li>
                        <li>
                            <a href=""cart.html"" data-tippy=""Add to cart"" data-tippy-ine");
            WriteLiteral(@"rtia=""true"" data-tippy-animation=""shift-away"" data-tippy-delay=""50"" data-tippy-arrow=""true"" data-tippy-theme=""sharpborder"">
                                <i class=""pe-7s-cart""></i>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
            <div class=""product-content"">
                <a class=""product-name"" href=""shop.html"">");
#nullable restore
#line 32 "C:\Users\devel0per\source\repos\ProniaWepCoreApp\ProniaWepCoreApp\Views\Shared\_ProductPartial.cshtml"
                                                    Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                <div class=\"price-box pb-1\">\r\n                    <span class=\"new-price\">$");
#nullable restore
#line 34 "C:\Users\devel0per\source\repos\ProniaWepCoreApp\ProniaWepCoreApp\Views\Shared\_ProductPartial.cshtml"
                                        Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"rating-box\">\r\n                    <ul>\r\n");
#nullable restore
#line 38 "C:\Users\devel0per\source\repos\ProniaWepCoreApp\ProniaWepCoreApp\Views\Shared\_ProductPartial.cshtml"
                         for (int i = 0; i < item.Raiting; i++)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><i class=\"fa fa-star\"></i></li>\r\n");
#nullable restore
#line 42 "C:\Users\devel0per\source\repos\ProniaWepCoreApp\ProniaWepCoreApp\Views\Shared\_ProductPartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\devel0per\source\repos\ProniaWepCoreApp\ProniaWepCoreApp\Views\Shared\_ProductPartial.cshtml"
                         for (int i = 0; i < 5 - @item.Raiting; i++)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><i class=\"fa fa-star\" style=\"color:black;\"></i></li>\r\n");
#nullable restore
#line 47 "C:\Users\devel0per\source\repos\ProniaWepCoreApp\ProniaWepCoreApp\Views\Shared\_ProductPartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 54 "C:\Users\devel0per\source\repos\ProniaWepCoreApp\ProniaWepCoreApp\Views\Shared\_ProductPartial.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
