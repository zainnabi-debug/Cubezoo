#pragma checksum "C:\Users\zaino\source\repos\ZainNabi-CubeZoo-Assessment\ZainNabi-CubeZoo-Assessment\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18655843de02a34439907c1855adada6270898ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\zaino\source\repos\ZainNabi-CubeZoo-Assessment\ZainNabi-CubeZoo-Assessment\Views\Home\Index.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18655843de02a34439907c1855adada6270898ae", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"069350d7c9fce8dd5d3ecc18b76415d61e2d04ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cubezoo_Models.ViewModels.UserDirectoryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_RenderSearchScreenCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("txtName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-msg", new global::Microsoft.AspNetCore.Html.HtmlString("Please enter a full name."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Full Name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("stSurname"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "email", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-msg", new global::Microsoft.AspNetCore.Html.HtmlString("Please enter a email address."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Email Address"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("js-validate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\zaino\source\repos\ZainNabi-CubeZoo-Assessment\ZainNabi-CubeZoo-Assessment\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Search Quotes";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main id=""content"" role=""main"" class=""main"">
    <div class=""content container-fluid"">
        <div class=""page-header"">
            <div class=""row align-items-end"">
                <div class=""col-sm mb-2 mb-sm-0"">
                    <nav aria-label=""breadcrumb"">
                        <ol class=""breadcrumb breadcrumb-no-gutter"">
                            <li class=""breadcrumb-item""><a class=""breadcrumb-link"" href=""javascript:;"">Diretory</a></li>
                            <li class=""breadcrumb-item""><a class=""breadcrumb-link"" href=""javascript:;"">Overview</a></li>
                        </ol>
                    </nav>

                    <h1 class=""page-header-title"">User Directory</h1>
                </div>
            </div>
            <!-- End Row -->
        </div>
");
#nullable restore
#line 27 "C:\Users\zaino\source\repos\ZainNabi-CubeZoo-Assessment\ZainNabi-CubeZoo-Assessment\Views\Home\Index.cshtml"
         if (Model.ShowReport == false)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "18655843de02a34439907c1855adada6270898ae10299", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 29 "C:\Users\zaino\source\repos\ZainNabi-CubeZoo-Assessment\ZainNabi-CubeZoo-Assessment\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = new ViewDataDictionary(ViewData) { { "TitleText", "Get Started..." },{ "TitleSubText", "Click on the Load Users button to get started..." } };

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\zaino\source\repos\ZainNabi-CubeZoo-Assessment\ZainNabi-CubeZoo-Assessment\Views\Home\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18655843de02a34439907c1855adada6270898ae12309", async() => {
                WriteLiteral("\r\n                <div class=\"card\">\r\n                    <div class=\"card-header\">\r\n                        <p class=\"card-header-title\">New User</p>\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n");
#nullable restore
#line 39 "C:\Users\zaino\source\repos\ZainNabi-CubeZoo-Assessment\ZainNabi-CubeZoo-Assessment\Views\Home\Index.cshtml"
                         if (Model.duplicateEmailAddress ==true)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"alert alert-soft-danger alert-dismissible fade show\" role=\"alert\">\r\n                                <strong>Duplicate email address found...please enter a unique email</strong>\r\n                            </div>\r\n");
#nullable restore
#line 44 "C:\Users\zaino\source\repos\ZainNabi-CubeZoo-Assessment\ZainNabi-CubeZoo-Assessment\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <!-- Input -->
                        <div class=""row"">
                            <div class=""col-sm-6"">
                                <!-- Form Group -->
                                <div class=""form-group"">
                                    <label for=""txtName"" class=""input-label"">Name</label>
                                    <div class=""js-form-message mb-3"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "18655843de02a34439907c1855adada6270898ae14103", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 53 "C:\Users\zaino\source\repos\ZainNabi-CubeZoo-Assessment\ZainNabi-CubeZoo-Assessment\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserDirectory.name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                                <!-- End Form Group -->
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-sm-6"">
                                <!-- Form Group -->
                                <div class=""form-group"">
                                    <label for=""vinNumberLabel"" class=""input-label"">Email</label>
                                    <div class=""js-form-message mb-3"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "18655843de02a34439907c1855adada6270898ae17154", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
#nullable restore
#line 66 "C:\Users\zaino\source\repos\ZainNabi-CubeZoo-Assessment\ZainNabi-CubeZoo-Assessment\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserDirectory.email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                                <!-- End Form Group -->
                            </div>
                        </div>
                        <!-- End Input -->
                        <div class=""w-100""></div>
                        <!-- End Form -->
                    </div>
                    <!-- Footer -->
                    <div class=""card-footer d-flex justify-content-end"">
                        <a class=""btn btn-white""");
                BeginWriteAttribute("href", " href=\"", 4072, "\"", 4133, 1);
#nullable restore
#line 78 "C:\Users\zaino\source\repos\ZainNabi-CubeZoo-Assessment\ZainNabi-CubeZoo-Assessment\Views\Home\Index.cshtml"
WriteAttributeValue("", 4079, Url.Action("Index", "Home", new { showReport = true}), 4079, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Cancel</a>\r\n                        <input type=\"submit\" value=\"Save\" class=\"btn btn-primary ml-2\" id=\"btnSave\" />\r\n                    </div>\r\n                    <!-- End Footer -->\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <hr />
            <div class=""card"">
                <!-- Header -->
                <div class=""card-header"">
                    <div class=""row justify-content-between align-items-center flex-grow-1"">
                        <div class=""col-lg-6 mb-3 mb-lg-0"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18655843de02a34439907c1855adada6270898ae22862", async() => {
                WriteLiteral(@"
                                <!-- Search -->
                                <div class=""input-group input-group-merge input-group-flush"">
                                    <div class=""input-group-prepend"">
                                        <div class=""input-group-text"">
                                            <i class=""tio-search""></i>
                                        </div>
                                    </div>
                                    <input id=""datatableSearch"" type=""search"" class=""form-control"" placeholder=""Search for a user"" aria-label=""Search for a user"">
                                </div>
                                <!-- End Search -->
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
                    <!-- End Row -->
                </div>
                <!-- End Header -->
                <!-- Table -->
                <div class=""table-responsive datatable-custom"">
                    <div id=""datatable_wrapper"" class=""dataTables_wrapper no-footer"">
                        <table id=""datatable"" class=""table table-borderless table-thead-bordered table-nowrap table-align-middle card-table""
                               data-hs-datatables-options='{
                     ""order"": [],
                     ""info"": {
                       ""totalQty"": ""#datatableWithPaginationInfoTotalQty""
                     },
                     ""search"": ""#datatableSearch"",
                     ""entries"": ""#datatableEntries"",
                     ""pageLength"": 8,
                     ""isResponsive"": false,
                     ""isShowPaging"": false,
                     ""pagination"": ""datatablePagination""
               ");
            WriteLiteral(@"    }'>
                            <thead class=""thead-light"">
                                <tr role=""row"">
                                    <th>Ref</th>
                                    <th>Email</th>
                                </tr>
                            </thead>

                            <tbody>
");
#nullable restore
#line 131 "C:\Users\zaino\source\repos\ZainNabi-CubeZoo-Assessment\ZainNabi-CubeZoo-Assessment\Views\Home\Index.cshtml"
                                 foreach (var item in Model.UserDirectoriesList)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr");
            BeginWriteAttribute("class", " class=\"", 6940, "\"", 6948, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        <td class=""align-middle"">
                                            <a class=""d-flex align-items-center"">
                                                <div class=""avatar avatar-soft-primary avatar-circle"">
                                                    <span class=""avatar-initials"">");
#nullable restore
#line 137 "C:\Users\zaino\source\repos\ZainNabi-CubeZoo-Assessment\ZainNabi-CubeZoo-Assessment\Views\Home\Index.cshtml"
                                                                             Write(item.name.Substring(0, 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                </div>\r\n                                                <div class=\"ml-3\">\r\n                                                    <span class=\"d-block h5 text-hover-primary mb-0\">");
#nullable restore
#line 140 "C:\Users\zaino\source\repos\ZainNabi-CubeZoo-Assessment\ZainNabi-CubeZoo-Assessment\Views\Home\Index.cshtml"
                                                                                                Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                </div>
                                            </a>
                                        </td>
                                        <td class=""align-middle"">
                                            <div class=""media align-items-center"">
                                                <span>");
#nullable restore
#line 146 "C:\Users\zaino\source\repos\ZainNabi-CubeZoo-Assessment\ZainNabi-CubeZoo-Assessment\Views\Home\Index.cshtml"
                                                 Write(item.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            </div>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 150 "C:\Users\zaino\source\repos\ZainNabi-CubeZoo-Assessment\ZainNabi-CubeZoo-Assessment\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>
                <!-- End Table -->
                <!-- Footer -->
                <div class=""card-footer"">
                    <!-- Pagination -->
                    <div class=""row justify-content-center justify-content-sm-between align-items-sm-center"">
                        <div class=""col-sm mb-2 mb-sm-0"">
                            <div class=""d-flex justify-content-center justify-content-sm-start align-items-center"">
                                <span class=""mr-2"">Showing:</span>

                                <span class=""text-secondary mr-2"">of</span>

                                <!-- Pagination Quantity -->
                                <span id=""datatableWithPaginationInfoTotalQty""></span>
                            </div>
                        </div>

                        <div class=""col-sm-auto"">
                            <div class=""");
            WriteLiteral(@"d-flex justify-content-center justify-content-sm-end"">
                                <!-- Pagination -->
                                <nav id=""datatablePagination"" aria-label=""Activity pagination""></nav>
                            </div>
                        </div>
                    </div>
                    <!-- End Pagination -->
                </div>
                <!-- End Footer -->
                <!-- End Footer -->
            </div>
");
#nullable restore
#line 183 "C:\Users\zaino\source\repos\ZainNabi-CubeZoo-Assessment\ZainNabi-CubeZoo-Assessment\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</main>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cubezoo_Models.ViewModels.UserDirectoryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
