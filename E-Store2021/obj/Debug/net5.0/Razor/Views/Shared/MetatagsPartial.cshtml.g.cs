#pragma checksum "C:\Users\yukov\OneDrive\Рабочий стол\New folder (3)\E-Store\E-Store2021\Views\Shared\MetatagsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bce0341ffd0d8adc3b3d1f7d82478ce11151702"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MetatagsPartial), @"mvc.1.0.view", @"/Views/Shared/MetatagsPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bce0341ffd0d8adc3b3d1f7d82478ce11151702", @"/Views/Shared/MetatagsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9974de800f0b85b0f53065412d75ec4433836cf7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MetatagsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<meta charset=\"UTF-8\">\r\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n");
#nullable restore
#line 3 "C:\Users\yukov\OneDrive\Рабочий стол\New folder (3)\E-Store\E-Store2021\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Title != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>");
#nullable restore
#line 5 "C:\Users\yukov\OneDrive\Рабочий стол\New folder (3)\E-Store\E-Store2021\Views\Shared\MetatagsPartial.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 6 "C:\Users\yukov\OneDrive\Рабочий стол\New folder (3)\E-Store\E-Store2021\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\yukov\OneDrive\Рабочий стол\New folder (3)\E-Store\E-Store2021\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Description != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"description\"");
            BeginWriteAttribute("content", " content=\"", 232, "\"", 262, 1);
#nullable restore
#line 9 "C:\Users\yukov\OneDrive\Рабочий стол\New folder (3)\E-Store\E-Store2021\Views\Shared\MetatagsPartial.cshtml"
WriteAttributeValue("", 242, ViewBag.Description, 242, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 10 "C:\Users\yukov\OneDrive\Рабочий стол\New folder (3)\E-Store\E-Store2021\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\yukov\OneDrive\Рабочий стол\New folder (3)\E-Store\E-Store2021\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Keywords != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"keywords\"");
            BeginWriteAttribute("content", " content=\"", 331, "\"", 358, 1);
#nullable restore
#line 13 "C:\Users\yukov\OneDrive\Рабочий стол\New folder (3)\E-Store\E-Store2021\Views\Shared\MetatagsPartial.cshtml"
WriteAttributeValue("", 341, ViewBag.Keywords, 341, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 14 "C:\Users\yukov\OneDrive\Рабочий стол\New folder (3)\E-Store\E-Store2021\Views\Shared\MetatagsPartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
