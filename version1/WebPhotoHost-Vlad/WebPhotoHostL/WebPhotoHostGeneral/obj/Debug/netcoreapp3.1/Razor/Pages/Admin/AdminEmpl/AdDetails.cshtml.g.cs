#pragma checksum "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Admin\AdminEmpl\AdDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52f2f7e45a716298c43d522eacdebc019b4b5a64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebPhotoHostGeneral.Pages.Admin.AdminEmpl.Pages_Admin_AdminEmpl_AdDetails), @"mvc.1.0.razor-page", @"/Pages/Admin/AdminEmpl/AdDetails.cshtml")]
namespace WebPhotoHostGeneral.Pages.Admin.AdminEmpl
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52f2f7e45a716298c43d522eacdebc019b4b5a64", @"/Pages/Admin/AdminEmpl/AdDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40fbac42564e672544463261dfe53d34467708b2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_AdminEmpl_AdDetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private global::WebPhotoHostGeneral.Pages.Admin.AdminEmpl.Pages_Admin_AdminEmpl_AdDetails.__Generated__HeadCountViewComponentTagHelper __HeadCountViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cardTextLeftFloating"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top imageThumbnail border-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #dle7ff;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/AdminEmpl/AdPublications", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-success buttonShadow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Admin\AdminEmpl\AdDetails.cshtml"
  
    ViewData["Title"] = "Publication Details";
    var photoPath = $"/images/{Model.Publication.PhotoPath ?? "noimage.png"}";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row justify-content-center m-3\">\n    <div class=\"col col-lg-8\">\n");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:head-count", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52f2f7e45a716298c43d522eacdebc019b4b5a646222", async() => {
            }
            );
            __HeadCountViewComponentTagHelper = CreateTagHelper<global::WebPhotoHostGeneral.Pages.Admin.AdminEmpl.Pages_Admin_AdminEmpl_AdDetails.__Generated__HeadCountViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__HeadCountViewComponentTagHelper);
#nullable restore
#line 11 "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Admin\AdminEmpl\AdDetails.cshtml"
__HeadCountViewComponentTagHelper.department = Model.Publication.Department;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("department", __HeadCountViewComponentTagHelper.department, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>\n\n<div class=\"row justify-content-center m-3\">\n    <div class=\"col col-lg-8\">\n        <div class=\"card cardBoxShadow\">\n\n            <div class=\"card-header cardHeaderStyle text-center\">\n                <h1>");
#nullable restore
#line 20 "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Admin\AdminEmpl\AdDetails.cshtml"
               Write(Model.Publication.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n            </div>\n\n            <div class=\"card-body cardBoxShadow text-center\">\n                <div class=\"row\">\n                    <div class=\"col col-lg-9\">\n                        <h4 class=\"cardTextLeftFloating\">Publication ID: ");
#nullable restore
#line 26 "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Admin\AdminEmpl\AdDetails.cshtml"
                                                                    Write(Model.Publication.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4><hr />\n                        <h4 class=\"cardTextLeftFloating\">Publication Email: ");
#nullable restore
#line 27 "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Admin\AdminEmpl\AdDetails.cshtml"
                                                                       Write(Model.Publication.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4><hr />\n                        <h4 class=\"cardTextLeftFloating\">Publication Department: <span class=\"text-danger font-weight-bold\">");
#nullable restore
#line 28 "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Admin\AdminEmpl\AdDetails.cshtml"
                                                                                                                       Write(Model.Publication.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4><hr />\n");
#nullable restore
#line 29 "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Admin\AdminEmpl\AdDetails.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"cardTextLeftFloating\"");
            BeginWriteAttribute("href", " href=\"", 1423, "\"", 1440, 1);
#nullable restore
#line 31 "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Admin\AdminEmpl\AdDetails.cshtml"
WriteAttributeValue("", 1430, photoPath, 1430, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" download=\"Image\">Загрузить файл</a> <!--ЗАГРУЗКА ФАЙЛА-->\n");
#nullable restore
#line 32 "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Admin\AdminEmpl\AdDetails.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52f2f7e45a716298c43d522eacdebc019b4b5a6410866", async() => {
                WriteLiteral("Для скачивания необходимо <span class=\"text-danger font-weight-bold\">Войти</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 36 "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Admin\AdminEmpl\AdDetails.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n\n                    <div class=\"col col-lg-3\">\n                        <div style=\"border-right: 1px solid rgba(0,0,0,.1);\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "52f2f7e45a716298c43d522eacdebc019b4b5a6412618", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Admin\AdminEmpl\AdDetails.cshtml"
                                                                                                                WriteLiteral(photoPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 41 "C:\Users\User\Desktop\WebPhotoHost-Vlad\WebPhotoHostL\WebPhotoHostGeneral\Pages\Admin\AdminEmpl\AdDetails.cshtml"
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
            WriteLiteral(@"
                        </div>
                    </div>

                </div>

                <div class=""row"">
                    <div class=""col"">
                        <div class=""card-footer text-center"" style=""background-color: rgba(0,0,0,0.25);"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52f2f7e45a716298c43d522eacdebc019b4b5a6415259", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            WriteLiteral(@"
                            <!--<a href=""#"" class=""btn-primary buttonShadow"">Edit</a>
                            <a href=""#"" class=""btn-danger buttonShadow"">Delete</a>-->
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebPhotoHostGeneral.Pages.Admin.AdminEmpl.AdDetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebPhotoHostGeneral.Pages.Admin.AdminEmpl.AdDetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebPhotoHostGeneral.Pages.Admin.AdminEmpl.AdDetailsModel>)PageContext?.ViewData;
        public WebPhotoHostGeneral.Pages.Admin.AdminEmpl.AdDetailsModel Model => ViewData.Model;
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:head-count")]
        public class __Generated__HeadCountViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__HeadCountViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public WebPhotoHostL.Models.Dept? department { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("HeadCount", new { department });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
