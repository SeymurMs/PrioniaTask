#pragma checksum "C:\Users\devel0per\source\repos\ProniaWepCoreApp\ProniaWepCoreApp\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b3827d7f05c1d881705e31996fa3ba59aeca2d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b3827d7f05c1d881705e31996fa3ba59aeca2d0", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05be3374f0c774b4795ebf1387f25d5ae7db13fa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "5", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "6", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ProductPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\devel0per\source\repos\ProniaWepCoreApp\ProniaWepCoreApp\Views\Shop\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"     
     

            <div class=""breadcrumb-area breadcrumb-height"" data-bg-image=""assets/images/breadcrumb/bg/1-1-1919x388.jpg"">
                <div class=""container h-100"">
                    <div class=""row h-100"">
                        <div class=""col-lg-12"">
                            <div class=""breadcrumb-item"">
                                <h2 class=""breadcrumb-heading"">Shop</h2>
                                <ul>
                                    <li>
                                        <a href=""index.html"">Home</a>
                                    </li>
                                    <li>Shop Grid Fullwidth</li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""shop-area section-space-y-axis-100"">
                <div class=""container"">
                    <div class=""row"">
                        <div cl");
            WriteLiteral(@"ass=""col-lg-12"">
                            <div class=""product-topbar"">
                                <ul>
                                    <li class=""page-count"">
                                        <span>12</span> Product Found of <span>30</span>
                                    </li>
                                    <li class=""product-view-wrap"">
                                        <ul class=""nav"" role=""tablist"">
                                            <li class=""grid-view"" role=""presentation"">
                                                <a class=""active"" id=""grid-view-tab"" data-bs-toggle=""tab"" href=""#grid-view"" role=""tab"" aria-selected=""true"">
                                                    <i class=""fa fa-th""></i>
                                                </a>
                                            </li>
                                            <li class=""list-view"" role=""presentation"">
                                                <a id=""lis");
            WriteLiteral(@"t-view-tab"" data-bs-toggle=""tab"" href=""#list-view"" role=""tab"" aria-selected=""true"">
                                                    <i class=""fa fa-th-list""></i>
                                                </a>
                                            </li>
                                        </ul>
                                    </li>
                                    <li class=""short"">
                                        <select class=""nice-select"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b3827d7f05c1d881705e31996fa3ba59aeca2d08274", async() => {
                WriteLiteral("Sort by Default");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b3827d7f05c1d881705e31996fa3ba59aeca2d09486", async() => {
                WriteLiteral("Sort by Popularity");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b3827d7f05c1d881705e31996fa3ba59aeca2d010701", async() => {
                WriteLiteral("Sort by Rated");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b3827d7f05c1d881705e31996fa3ba59aeca2d011912", async() => {
                WriteLiteral("Sort by Latest");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b3827d7f05c1d881705e31996fa3ba59aeca2d013124", async() => {
                WriteLiteral("Sort by High Price");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b3827d7f05c1d881705e31996fa3ba59aeca2d014340", async() => {
                WriteLiteral("Sort by Low Price");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </select>
                                    </li>
                                </ul>
                            </div>
                            <div class=""tab-content"">
                                <div class=""tab-pane fade show active"" id=""grid-view"" role=""tabpanel"" aria-labelledby=""grid-view-tab"">
                                    <div class=""product-grid-view row g-y-20"">
                             
                                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0b3827d7f05c1d881705e31996fa3ba59aeca2d016030", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                     <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 3740, "\"", 3769, 1);
#nullable restore
#line 65 "C:\Users\devel0per\source\repos\ProniaWepCoreApp\ProniaWepCoreApp\Views\Shop\Index.cshtml"
WriteAttributeValue("", 3748, ViewBag.ProductCount, 3748, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""PCount""/>
                                  
                                    </div>
                                </div>
                                <div class=""tab-pane fade"" id=""list-view"" role=""tabpanel"" aria-labelledby=""list-view-tab"">
                                    <div class=""product-list-view row g-y-30"">
                                        <div class=""col-12"">
                                            <div class=""product-item"">
                                                <div class=""product-img"">
                                                    <a href=""single-product-variable.html"">
                                                        <img class=""primary-img"" src=""assets/images/product/medium-size/1-1-270x300.jpg"" alt=""Product Images"">
                                                        <img class=""secondary-img"" src=""assets/images/product/medium-size/1-2-270x300.jpg"" alt=""Product Images"">
                                                    </a>
  ");
            WriteLiteral(@"                                              </div>
                                                <div class=""product-content"">
                                                    <a class=""product-name"" href=""single-product-variable.html"">American
                                                        Marigold</a>
                                                    <div class=""price-box pb-1"">
                                                        <span class=""new-price"">$23.45</span>
                                                    </div>
                                                    <div class=""rating-box"">
                                                        <ul>
                                                            <li><i class=""fa fa-star""></i></li>
                                                            <li><i class=""fa fa-star""></i></li>
                                                            <li><i class=""fa fa-star""></i></li>
                               ");
            WriteLiteral(@"                             <li><i class=""fa fa-star""></i></li>
                                                            <li><i class=""fa fa-star""></i></li>
                                                        </ul>
                                                    </div>
                                                    <p class=""short-desc mb-0"">Proin nec ligula dolor. Mauris mollis turpis
                                                        vitae viverra viverra. Mauris at lacus commodo, dictum eros in, interdum
                                                        diam. Sed lorem orci, maximus nec efficitur, mattis sed tortor.
                                                        Voluptates repudiandae nulla rhoncus varius eget id eros.
                                                    </p>
                                                    <div class=""product-add-action"">
                                                        <ul>
                                         ");
            WriteLiteral(@"                   <li>
                                                                <a href=""wishlist.html"" data-tippy=""Add to wishlist"" data-tippy-inertia=""true"" data-tippy-animation=""shift-away"" data-tippy-delay=""50"" data-tippy-arrow=""true"" data-tippy-theme=""sharpborder"">
                                                                    <i class=""pe-7s-like""></i>
                                                                </a>
                                                            </li>
                                                            <li class=""quuickview-btn"" data-bs-toggle=""modal"" data-bs-target=""#quickModal"">
                                                                <a href=""#"" data-tippy=""Quickview"" data-tippy-inertia=""true"" data-tippy-animation=""shift-away"" data-tippy-delay=""50"" data-tippy-arrow=""true"" data-tippy-theme=""sharpborder"">
                                                                    <i class=""pe-7s-look""></i>
                                   ");
            WriteLiteral(@"                             </a>
                                                            </li>
                                                            <li>
                                                                <a href=""cart.html"" data-tippy=""Add to cart"" data-tippy-inertia=""true"" data-tippy-animation=""shift-away"" data-tippy-delay=""50"" data-tippy-arrow=""true"" data-tippy-theme=""sharpborder"">
                                                                    <i class=""pe-7s-cart""></i>
                                                                </a>
                                                            </li>
                                                        </ul>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                   
                                    </div>
               ");
            WriteLiteral(@"                 </div>
                            </div>
                            <div class=""pagination-area"">
                                <nav aria-label=""Page navigation example"">
                                   <button class=""btn btn-primary Load-More"" id=""LoadMore"">LoadMore</button>
                                </nav>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).on(""click"",""#LoadMore"",function(){
            let skip =$("".product-grid-view"").children().length

            let PCount = $(""#PCount"").val();
            console.log(PCount);
            
            $.ajax({
                url:'/Shop/LoadMore',
                method:'GET',
                data: {
                    skip:skip
                },
                success: function(res) {
                    $("".product-grid-view"").append(res)
                    if ($("".product-grid-view"").children().length >= PCount)
                        $(""#LoadMore"").remove();
                }
            })
        })
    </script>
");
            }
            );
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
