#pragma checksum "C:\Users\yukov\OneDrive\Рабочий стол\New folder (3)\E-Store\E-Store2021\Views\CouponsManager\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c16054179aec4227371e151f271c45d6ca47f8b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CouponsManager_Index), @"mvc.1.0.view", @"/Views/CouponsManager/Index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\yukov\OneDrive\Рабочий стол\New folder (3)\E-Store\E-Store2021\Views\CouponsManager\Index.cshtml"
using E_Store2021.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yukov\OneDrive\Рабочий стол\New folder (3)\E-Store\E-Store2021\Views\CouponsManager\Index.cshtml"
using E_Store2021.Models.StaticModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c16054179aec4227371e151f271c45d6ca47f8b5", @"/Views/CouponsManager/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9974de800f0b85b0f53065412d75ec4433836cf7", @"/Views/_ViewImports.cshtml")]
    public class Views_CouponsManager_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Coupon>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\yukov\OneDrive\Рабочий стол\New folder (3)\E-Store\E-Store2021\Views\CouponsManager\Index.cshtml"
  
    ViewData["Title"] = "Product";
    Layout = "~/Views/Shared/AdminLTE/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Coupons Manager</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c16054179aec4227371e151f271c45d6ca47f8b54677", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n");
#nullable restore
#line 13 "C:\Users\yukov\OneDrive\Рабочий стол\New folder (3)\E-Store\E-Store2021\Views\CouponsManager\Index.cshtml"
             if (ViewBag.TextMess != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"text-success\">");
#nullable restore
#line 15 "C:\Users\yukov\OneDrive\Рабочий стол\New folder (3)\E-Store\E-Store2021\Views\CouponsManager\Index.cshtml"
                                     Write(ViewBag.TextMess);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 16 "C:\Users\yukov\OneDrive\Рабочий стол\New folder (3)\E-Store\E-Store2021\Views\CouponsManager\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"text-danger\">");
#nullable restore
#line 19 "C:\Users\yukov\OneDrive\Рабочий стол\New folder (3)\E-Store\E-Store2021\Views\CouponsManager\Index.cshtml"
                                    Write(ViewBag.TextMess);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 20 "C:\Users\yukov\OneDrive\Рабочий стол\New folder (3)\E-Store\E-Store2021\Views\CouponsManager\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <div class=""form-group"">
                <label>Coupon Name</label>
                <input name=""couponName"" type=""text"" class=""form-control"" />
            </div>
            <div class=""form-group"">
                <label>Coupon Discount</label>
                <input name=""discount"" type=""text"" class=""form-control"" />
            </div>
            <div class=""form-group"">
                <label>Coupon Expiration Date</label>
                <input name=""dateTime"" type=""datetime-local"" class=""form-control"" />
            </div>
            <input id=""update-profile-button"" type=""submit"" class=""btn btn-primary"" />
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Coupon>> Html { get; private set; }
    }
}
#pragma warning restore 1591