#pragma checksum "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Publications\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3e78a5dd71fe8ba1a7973db6be97f3d7184a858"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebPhotoHostGeneral.Pages.Publications.Pages_Publications_Details), @"mvc.1.0.razor-page", @"/Pages/Publications/Details.cshtml")]
namespace WebPhotoHostGeneral.Pages.Publications
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
#line 1 "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\_ViewImports.cshtml"
using WebPhotoHostGeneral;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\_ViewImports.cshtml"
using WebPhotoHostL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3e78a5dd71fe8ba1a7973db6be97f3d7184a858", @"/Pages/Publications/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40fbac42564e672544463261dfe53d34467708b2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Publications_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top imageThumbnail border-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #dle7ff;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Publications", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:#ffffff"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Publications\Details.cshtml"
   ViewData["Title"] = "Publication Details";
				var photoPath = $"/images/{Model.Publication.PhotoPath ?? "noimage.png"}"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row text-center\">\n\t<div class=\"col\">\n\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e3e78a5dd71fe8ba1a7973db6be97f3d7184a8585909", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 8 "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Publications\Details.cshtml"
                                                                                            WriteLiteral(photoPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 8 "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Publications\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\t</div>\n</div>\n\n<div class=\"row justify-content-center m-3\">\n\n\t<div class=\"card cardBoxShadow\">\n\t\t<div class=\"card-body text-center\">\n\t\t\t<div class=\"row\">\n\t\t\t\t<div class=\"col col-lg-9\">\n\t\t\t\t\t<h4 class=\"cardTextLeftFloating\">Publication ID: ");
#nullable restore
#line 18 "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Publications\Details.cshtml"
                                                                Write(Model.Publication.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4><hr />\n\t\t\t\t\t<h4 class=\"cardTextLeftFloating\">Publication Email: ");
#nullable restore
#line 19 "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Publications\Details.cshtml"
                                                                   Write(Model.Publication.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4><hr />\n\t\t\t\t\t<h4 class=\"cardTextLeftFloating\">Publication Name: ");
#nullable restore
#line 20 "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Publications\Details.cshtml"
                                                                  Write(Model.Publication.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4><hr />\n\t\t\t\t\t<h4 class=\"cardTextLeftFloating\">Publication Department: <span class=\"text-danger font-weight-bold\">");
#nullable restore
#line 21 "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Publications\Details.cshtml"
                                                                                                                   Write(Model.Publication.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4>\n\n\t\t\t\t\t<div class=\"card-footer text-center\" style=\"background-color: rgb(255, 255, 255);\">\n");
#nullable restore
#line 24 "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Publications\Details.cshtml"
                         if (User.Identity.IsAuthenticated)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 1161, "\"", 1178, 1);
#nullable restore
#line 26 "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Publications\Details.cshtml"
WriteAttributeValue("", 1168, photoPath, 1168, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" download=\"Image\">Download image</a> <!--ЗАГРУЗКА ФАЙЛА--> ");
#nullable restore
#line 26 "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Publications\Details.cshtml"
                                                                                                                   }
		else
		{

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3e78a5dd71fe8ba1a7973db6be97f3d7184a85811306", async() => {
                WriteLiteral(" <span class=\"text-danger font-weight-bold\">You must be logged in to download</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 29 "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Publications\Details.cshtml"
                                                                                                                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3e78a5dd71fe8ba1a7973db6be97f3d7184a85812957", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\t\t\t\t\t\t<!--<a href=\"#\" class=\"btn-primary buttonShadow\">Edit</a>\n\t\t\t\t\t\t<a href=\"#\" class=\"btn-danger buttonShadow\">Delete</a>-->\n\t\t\t\t\t</div>\n\t\t\t\t</div>\n\t\t\t</div>\n\t\t</div>\n\t</div>\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebPhotoHostGeneral.Pages.Publications.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebPhotoHostGeneral.Pages.Publications.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebPhotoHostGeneral.Pages.Publications.DetailsModel>)PageContext?.ViewData;
        public WebPhotoHostGeneral.Pages.Publications.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
