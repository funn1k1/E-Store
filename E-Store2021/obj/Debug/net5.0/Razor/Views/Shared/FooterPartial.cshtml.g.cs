#pragma checksum "C:\Users\yukov\OneDrive\Рабочий стол\New folder (3)\E-Store\E-Store2021\Views\Shared\FooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "281fed4a07d47d0a9aa2053d483cc06314cc6ba3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_FooterPartial), @"mvc.1.0.view", @"/Views/Shared/FooterPartial.cshtml")]
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
#line 1 "C:\Users\yukov\OneDrive\Рабочий стол\New folder (3)\E-Store\E-Store2021\Views\_ViewImports.cshtml"
using E_Store2021;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yukov\OneDrive\Рабочий стол\New folder (3)\E-Store\E-Store2021\Views\_ViewImports.cshtml"
using E_Store2021.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"281fed4a07d47d0a9aa2053d483cc06314cc6ba3", @"/Views/Shared/FooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9974de800f0b85b0f53065412d75ec4433836cf7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_FooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("footer-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<footer class=""footer"">
    <div class=""container"">
        <div class=""footer_top"">
            <div class=""footer_top-inner"">
                <div class=""footer_top-item footer_top-newsletter"">
                    <h6 class=""footer_top-title"">
                        Subscribe to our newsletter and learn about promotions faster
                    </h6>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "281fed4a07d47d0a9aa2053d483cc06314cc6ba34404", async() => {
                WriteLiteral("\r\n                        <input class=\"footer-form_input\" type=\"text\" placeholder=\"Input your email\">\r\n                        <button class=\"submit footer-form_btn\">Submit</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""footer_top-item"">
                    <h6 class=""footer_top-title footer_top-drop"">
                        Information
                    </h6>
                    <ul class=""footer-list"">
                        <li class=""footer-list_item"">
                            <a href=""#"">About company</a>
                        </li>
                        <li class=""footer-list_item"">
                            <a href=""#"">Contacts</a>
                        </li>
                        <li class=""footer-list_item"">
                            <a href=""#"">Promotions</a>
                        </li>
                        <li class=""footer-list_item"">
                            <a href=""#"">Shops</a>
                        </li>
                    </ul>
                </div>
                <div class=""footer_top-item"">
                    <h6 class=""footer_top-title footer_top-drop"">
                        Online store
       ");
            WriteLiteral(@"             </h6>

                    <ul class=""footer-list"">
                        <li class=""footer-list_item"">
                            <a href=""#"">Delivery and pickup</a>
                        </li>
                        <li class=""footer-list_item"">
                            <a href=""#"">Payment</a>
                        </li>
                        <li class=""footer-list_item"">
                            <a href=""#"">Return-Exchange</a>
                        </li>
                        <li class=""footer-list_item"">
                            <a class=""btn btn-primary"" href=""#"">News</a>
                        </li>
                    </ul>

                </div>
                <div class=""footer_top-item footer_top-social"">
                    <ul class=""social-list"">
                        <li class=""social-list_item"">
                            <a href=""https://www.facebook.com/profile.php?id=100010815976516"">
                                <i class=""fa");
            WriteLiteral(@"b fa-facebook social-list_icon""></i>
                            </a>
                        </li>
                        <li class=""social-list_item"">
                            <a href=""#"">
                                <i class=""fab fa-google-plus social-list_icon""></i>
                            </a>
                        </li>
                        <li class=""social-list_item"">
                            <a href=""https://github.com/funn1k1"">
                                <i class=""fab fa-github social-list_icon""></i>
                            </a>
                        </li>
                        <li class=""social-list_item"">
                            <a href=""https://t.me/x_unity"">
                                <i class=""fab fa-telegram social-list_icon""></i>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""footer_bottom"">
            <a class");
            WriteLiteral("=\"footer_bottom-link\" href=\"#\">\r\n                Contract offer\r\n            </a>\r\n            <a class=\"footer_bottom-link\" href=\"#\">\r\n                Personal data processing policy\r\n            </a>\r\n        </div>\r\n    </div>\r\n</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
