#pragma checksum "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fa4d516df70e1311d22375250bc903f7b947bec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_VcBook_Default), @"mvc.1.0.view", @"/Views/Shared/Components/VcBook/Default.cshtml")]
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
#line 4 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\_ViewImports.cshtml"
using PustokApp.View_Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\_ViewImports.cshtml"
using PustokApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fa4d516df70e1311d22375250bc903f7b947bec", @"/Views/Shared/Components/VcBook/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e04c2e4027830ac030fc2da82e69c5a112f26c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_VcBook_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addbasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outlined"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml"
 foreach (var item in Model)
{
    BookPhoto poster = item.BookPhotos.FirstOrDefault(x => x.PosterStatus == true);
    BookPhoto posterHover = item.BookPhotos.FirstOrDefault(x => x.PosterStatus == false);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""col-lg-4 col-sm-6"">
        <div class=""product-card card-style-list"">
            <div class=""product-grid-content"">
                <div class=""product-header"">
                    <a href=""#"" class=""author"">
                        ");
#nullable restore
#line 11 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml"
                   Write(item.Author.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                    <h3><a href=\"product-details.html\">");
#nullable restore
#line 13 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml"
                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                </div>\r\n                <div class=\"product-card--body\">\r\n                    <div class=\"card-image\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0fa4d516df70e1311d22375250bc903f7b947bec6432", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 763, "~/uploads/books/", 763, 16, true);
#nullable restore
#line 17 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml"
AddHtmlAttributeValue("", 779, poster==null?"":poster.Name, 779, 30, false);

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
            WriteLiteral("\r\n                        <div class=\"hover-contents\">\r\n                            <a href=\"product-details.html\" class=\"hover-image\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0fa4d516df70e1311d22375250bc903f7b947bec8211", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 997, "~/uploads/books/", 997, 16, true);
#nullable restore
#line 20 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml"
AddHtmlAttributeValue("", 1013, posterHover==null?"":posterHover.Name, 1013, 40, false);

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
            WriteLiteral(@"
                            </a>
                            <div class=""hover-btns"">
                                <a href=""cart.html"" class=""single-btn"">
                                    <i class=""fas fa-shopping-basket""></i>
                                </a>
                                <a href=""wishlist.html"" class=""single-btn"">
                                    <i class=""fas fa-heart""></i>
                                </a>
                                <a href=""compare.html"" class=""single-btn"">
                                    <i class=""fas fa-random""></i>
                                </a>
                                <a href=""#"" data-bs-toggle=""modal"" data-bs-target=""#quickModal""
                                   class=""single-btn"">
                                    <i class=""fas fa-eye""></i>
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class=""pr");
            WriteLiteral("ice-block\">\r\n");
#nullable restore
#line 40 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml"
                         if (item.DiscountPercent > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"price\">£");
#nullable restore
#line 42 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml"
                                            Write(item.DiscountedPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <del class=\"price-old\">£");
#nullable restore
#line 43 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml"
                                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n                            <span class=\"price-discount\">");
#nullable restore
#line 44 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml"
                                                    Write(item.DiscountPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n");
#nullable restore
#line 45 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"price-discount\">£");
#nullable restore
#line 48 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml"
                                                     Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 49 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"product-list-content\">\r\n                <div class=\"card-image\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0fa4d516df70e1311d22375250bc903f7b947bec13354", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2805, "~/uploads/books/", 2805, 16, true);
#nullable restore
#line 57 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml"
AddHtmlAttributeValue("", 2821, poster==null?"":poster.Name, 2821, 30, false);

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
            WriteLiteral("\r\n                </div>\r\n                <div class=\"product-card--body\">\r\n                    <div class=\"product-header\">\r\n                        <a href=\"#\" class=\"author\">\r\n                            ");
#nullable restore
#line 62 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml"
                       Write(item.Author.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                        <h3>\r\n                            <a href=\"product-details.html\" tabindex=\"0\">\r\n                                ");
#nullable restore
#line 66 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </h3>\r\n                    </div>\r\n                    <article>\r\n                        <h2 class=\"sr-only\">Card List Article</h2>\r\n                        <p>\r\n                            ");
#nullable restore
#line 73 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml"
                       Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </article>\r\n                    <div class=\"price-block\">\r\n");
#nullable restore
#line 77 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml"
                         if (item.DiscountPercent > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"price\">£");
#nullable restore
#line 79 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml"
                                            Write(item.DiscountedPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <del class=\"price-old\">£");
#nullable restore
#line 80 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml"
                                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n                            <span class=\"price-discount\">");
#nullable restore
#line 81 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml"
                                                    Write(item.DiscountPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n");
#nullable restore
#line 82 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"price-discount\">£");
#nullable restore
#line 85 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml"
                                                     Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 86 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <div class=""rating-block"">
                        <span class=""fas fa-star star_on""></span>
                        <span class=""fas fa-star star_on""></span>
                        <span class=""fas fa-star star_on""></span>
                        <span class=""fas fa-star star_on""></span>
                        <span class=""fas fa-star ""></span>
                    </div>
                    <div class=""btn-block"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fa4d516df70e1311d22375250bc903f7b947bec19267", async() => {
                WriteLiteral("Add To Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml"
                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <a href=\"#\" class=\"card-link\">\r\n                            <i class=\"fas fa-heart\"></i> Add To\r\n                            Wishlist\r\n                        </a>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fa4d516df70e1311d22375250bc903f7b947bec21991", async() => {
                WriteLiteral("\r\n                            <i class=\"fas fa-random\"></i> Add To\r\n                            Cart\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml"
                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 111 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\Components\VcBook\Default.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
