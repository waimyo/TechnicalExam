#pragma checksum "D:\wmo\TechnicalExam\TechnicalExam\TechnicalExam\Views\Inventory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "572d5889d397fd38dc8781ad95c9ae2c8a0bb57c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventory_Index), @"mvc.1.0.view", @"/Views/Inventory/Index.cshtml")]
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
#line 1 "D:\wmo\TechnicalExam\TechnicalExam\TechnicalExam\Views\_ViewImports.cshtml"
using TechnicalExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\wmo\TechnicalExam\TechnicalExam\TechnicalExam\Views\_ViewImports.cshtml"
using TechnicalExam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"572d5889d397fd38dc8781ad95c9ae2c8a0bb57c", @"/Views/Inventory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eac85a1447f311bf4a2f898d1c2fd9ab46f87ed", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Inventory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Inventory>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\wmo\TechnicalExam\TechnicalExam\TechnicalExam\Views\Inventory\Index.cshtml"
  
    ViewData["Title"] = "Inventory Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h3");
            BeginWriteAttribute("class", " class=\"", 115, "\"", 123, 0);
            EndWriteAttribute();
            WriteLiteral(">Inventory Lists</h3>\r\n    \r\n    <table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 12 "D:\wmo\TechnicalExam\TechnicalExam\TechnicalExam\Views\Inventory\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "D:\wmo\TechnicalExam\TechnicalExam\TechnicalExam\Views\Inventory\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "D:\wmo\TechnicalExam\TechnicalExam\TechnicalExam\Views\Inventory\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Qty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "D:\wmo\TechnicalExam\TechnicalExam\TechnicalExam\Views\Inventory\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Available_Qty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n           \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 27 "D:\wmo\TechnicalExam\TechnicalExam\TechnicalExam\Views\Inventory\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 31 "D:\wmo\TechnicalExam\TechnicalExam\TechnicalExam\Views\Inventory\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 34 "D:\wmo\TechnicalExam\TechnicalExam\TechnicalExam\Views\Inventory\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "D:\wmo\TechnicalExam\TechnicalExam\TechnicalExam\Views\Inventory\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Qty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "D:\wmo\TechnicalExam\TechnicalExam\TechnicalExam\Views\Inventory\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Available_Qty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n               \r\n            </tr>\r\n");
#nullable restore
#line 44 "D:\wmo\TechnicalExam\TechnicalExam\TechnicalExam\Views\Inventory\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Inventory>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
