#pragma checksum "C:\Users\zaino\source\repos\ZainNabi-CubeZoo-Assessment\ZainNabi-CubeZoo-Assessment\Views\Shared\_RenderSearchScreenCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70ef1ebd14f21e7093ea0d6ff72aa16063b7405f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__RenderSearchScreenCard), @"mvc.1.0.view", @"/Views/Shared/_RenderSearchScreenCard.cshtml")]
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
#line 1 "C:\Users\zaino\source\repos\ZainNabi-CubeZoo-Assessment\ZainNabi-CubeZoo-Assessment\Views\_ViewImports.cshtml"
using ZainNabi_CubeZoo_Assessment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zaino\source\repos\ZainNabi-CubeZoo-Assessment\ZainNabi-CubeZoo-Assessment\Views\_ViewImports.cshtml"
using ZainNabi_CubeZoo_Assessment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70ef1ebd14f21e7093ea0d6ff72aa16063b7405f", @"/Views/Shared/_RenderSearchScreenCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"069350d7c9fce8dd5d3ecc18b76415d61e2d04ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__RenderSearchScreenCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/front-dashboard-v1.1/dist/assets/svg/illustrations/knowledgebase-community-1.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image Description"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\zaino\source\repos\ZainNabi-CubeZoo-Assessment\ZainNabi-CubeZoo-Assessment\Views\Shared\_RenderSearchScreenCard.cshtml"
  
    string title = this.ViewData.ContainsKey("TitleText") ? this.ViewData["TitleText"].ToString() : "Report";
    string titleSubText = this.ViewData.ContainsKey("TitleSubText") ? this.ViewData["TitleSubText"].ToString() : "Report information will be shown here";   

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


    <div class=""card"">
        <div class=""card-body"">
            <!-- Hero Section -->
            <div class=""container space-2"">
                <div class=""row justify-content-lg-between align-items-lg-center"">
                    <div class=""col-sm-10 col-lg-5 mb-7 mb-lg-0"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "70ef1ebd14f21e7093ea0d6ff72aa16063b7405f5241", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"col-md-6\">\r\n                        <div class=\"mb-5\">\r\n                            <h1 class=\"display-4 mb-3\">\r\n                                ");
#nullable restore
#line 20 "C:\Users\zaino\source\repos\ZainNabi-CubeZoo-Assessment\ZainNabi-CubeZoo-Assessment\Views\Shared\_RenderSearchScreenCard.cshtml"
                           Write(title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                <br>
                                <span class=""text-primary font-weight-bold"">
                                    <span class=""js-text-animation""></span>
                                </span>
                            </h1>
                            <p class=""lead"">");
#nullable restore
#line 26 "C:\Users\zaino\source\repos\ZainNabi-CubeZoo-Assessment\ZainNabi-CubeZoo-Assessment\Views\Shared\_RenderSearchScreenCard.cshtml"
                                       Write(titleSubText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1311, "\"", 1371, 1);
#nullable restore
#line 27 "C:\Users\zaino\source\repos\ZainNabi-CubeZoo-Assessment\ZainNabi-CubeZoo-Assessment\Views\Shared\_RenderSearchScreenCard.cshtml"
WriteAttributeValue("", 1318, Url.Action("Index","Home", new { showReport = true}), 1318, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"anchorjs-link\">Load Users</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <!-- End Hero Section -->\r\n        </div>\r\n    </div>");
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
