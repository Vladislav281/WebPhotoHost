#pragma checksum "C:\Users\snake\Desktop\Last\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Components\HeadCount\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa4a19b1bf9d2b79c7e5949dfa1bfeabf041f5f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebPhotoHostGeneral.Pages.Components.HeadCount.Pages_Components_HeadCount_Default), @"mvc.1.0.view", @"/Pages/Components/HeadCount/Default.cshtml")]
namespace WebPhotoHostGeneral.Pages.Components.HeadCount
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
#line 1 "C:\Users\snake\Desktop\Last\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\_ViewImports.cshtml"
using WebPhotoHostGeneral;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\snake\Desktop\Last\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\_ViewImports.cshtml"
using WebPhotoHostL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa4a19b1bf9d2b79c7e5949dfa1bfeabf041f5f9", @"/Pages/Components/HeadCount/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"428baa6ea948cb13f391ad52e550ec5074610f73", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Components_HeadCount_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DeptHeadCount>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<table class=\"table table-hover rounded-pill\">\n    <thead class=\"thead-light\">\n        <tr>\n            <th>Department</th>\n            <th>Head Count</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 11 "C:\Users\snake\Desktop\Last\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Components\HeadCount\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 14 "C:\Users\snake\Desktop\Last\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Components\HeadCount\Default.cshtml"
               Write(item.Deptepartment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 15 "C:\Users\snake\Desktop\Last\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Components\HeadCount\Default.cshtml"
               Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 17 "C:\Users\snake\Desktop\Last\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Components\HeadCount\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DeptHeadCount>> Html { get; private set; }
    }
}
#pragma warning restore 1591
