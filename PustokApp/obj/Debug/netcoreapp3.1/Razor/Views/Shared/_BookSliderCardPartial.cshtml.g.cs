#pragma checksum "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\_BookSliderCardPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03c177263886623fcbc34fdb07315cc29071f112"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BookSliderCardPartial), @"mvc.1.0.view", @"/Views/Shared/_BookSliderCardPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03c177263886623fcbc34fdb07315cc29071f112", @"/Views/Shared/_BookSliderCardPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e04c2e4027830ac030fc2da82e69c5a112f26c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BookSliderCardPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\_BookSliderCardPartial.cshtml"
 foreach (var item in Model)
{
    BookPhoto poster = item.BookPhotos.FirstOrDefault(x => x.PosterStatus == true);
    BookPhoto posterHover = item.BookPhotos.FirstOrDefault(x => x.PosterStatus == false);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"single-slide\">\r\n        <div class=\"product-card\">\r\n            <div class=\"product-header\">\r\n                <a href=\"#\" class=\"author\">\r\n                    ");
#nullable restore
#line 11 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\_BookSliderCardPartial.cshtml"
               Write(item.Author.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n                <h3>\r\n                    <a href=\"product-details.html\">\r\n                        ");
#nullable restore
#line 15 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\_BookSliderCardPartial.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                </h3>\r\n            </div>\r\n            <div class=\"product-card--body\">\r\n                <div class=\"card-image\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "03c177263886623fcbc34fdb07315cc29071f1124960", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 748, "~/assets/image/products/", 748, 24, true);
#nullable restore
#line 21 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\_BookSliderCardPartial.cshtml"
AddHtmlAttributeValue("", 772, poster==null?"":poster.Name, 772, 30, false);

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
            WriteLiteral("*\r\n                    <div class=\"hover-contents\">\r\n                        <a href=\"product-details.html\" class=\"hover-image\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "03c177263886623fcbc34fdb07315cc29071f1126733", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 979, "~/assets/image/products/", 979, 24, true);
#nullable restore
#line 24 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\_BookSliderCardPartial.cshtml"
AddHtmlAttributeValue("", 1003, posterHover==null?"":posterHover.Name, 1003, 40, false);

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
                <div class=""price-block"">
");
#nullable restore
#line 45 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\_BookSliderCardPartial.cshtml"
                     if (item.DiscountPercent > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"price\">£");
#nullable restore
#line 47 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\_BookSliderCardPartial.cshtml"
                                        Write(item.DiscountedPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <del class=\"price-old\">£");
#nullable restore
#line 48 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\_BookSliderCardPartial.cshtml"
                                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n                        <span class=\"price-discount\">");
#nullable restore
#line 49 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\_BookSliderCardPartial.cshtml"
                                                Write(item.DiscountPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n");
#nullable restore
#line 50 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\_BookSliderCardPartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <del class=\"price-old\">£");
#nullable restore
#line 53 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\_BookSliderCardPartial.cshtml"
                                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n");
#nullable restore
#line 54 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\_BookSliderCardPartial.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 61 "C:\Users\User\OneDrive\Masaüstü\PustokApp\PustokApp\Views\Shared\_BookSliderCardPartial.cshtml"

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
