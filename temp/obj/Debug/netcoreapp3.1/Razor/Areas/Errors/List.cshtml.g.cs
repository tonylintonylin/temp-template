#pragma checksum "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07cef7afda35a259d6ae88bbed0f2e659a9599d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Errors_List), @"mvc.1.0.view", @"/Areas/Errors/List.cshtml")]
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
#line 1 "C:\Users\tonyl\Desktop\temp\temp\Areas\_ViewImports.cshtml"
using temp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07cef7afda35a259d6ae88bbed0f2e659a9599d4", @"/Areas/Errors/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"213736d78864afa6f1a98a1ff5a7a50860a25802", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Errors_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<temp.Areas.Errors.List>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AdminMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control width-170"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/errors/delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Pager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml"
  
    ViewBag.Title = "Errors";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-box\">\r\n\r\n    <div class=\"d-flex\">\r\n        <div class=\"page-box-icon\">\r\n            <a href=\"/admin\"><i");
            BeginWriteAttribute("class", " class=\"", 191, "\"", 215, 1);
#nullable restore
#line 10 "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml"
WriteAttributeValue("", 199, Cache.AdminIcon, 199, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a> Admin\r\n        </div>\r\n        <div class=\"page-box-admin-menu\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "07cef7afda35a259d6ae88bbed0f2e659a9599d46048", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n<div class=\"py-10\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07cef7afda35a259d6ae88bbed0f2e659a9599d47243", async() => {
                WriteLiteral("\r\n        <div class=\"d-flex\">\r\n            <div class=\"page-box-filter\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07cef7afda35a259d6ae88bbed0f2e659a9599d47598", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 23 "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DeleteCount);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 23 "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Filter.ErrorItems;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n            <div class=\"page-box-button\"><button class=\"btn btn-sm btn-light\" type=\"submit\">Submit</button></div>\r\n            <div class=\"page-box-items\">");
#nullable restore
#line 26 "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml"
                                   Write(Model.TotalRows);

#line default
#line hidden
#nullable disable
                WriteLiteral(" &nbsp;Items</div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 20 "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-antiforgery", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<div");
            BeginWriteAttribute("class", " class=\"", 920, "\"", 928, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07cef7afda35a259d6ae88bbed0f2e659a9599d411944", async() => {
                WriteLiteral("\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "07cef7afda35a259d6ae88bbed0f2e659a9599d412215", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 34 "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Page);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n        <table class=\"table table-hover table-sm table-list\">\r\n\r\n");
#nullable restore
#line 38 "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml"
             if (Model.Items.Count() == 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td colspan=\"5\" class=\"no-records\">No records to display</td>\r\n                </tr>\r\n");
#nullable restore
#line 43 "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 45 "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml"
             foreach (var error in Model.Items)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td class=\"width-80\"><a class=\"view btn btn-light btn-xs\" data-id=\"");
#nullable restore
#line 48 "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml"
                                                                                  Write(error.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" href=\"javascript:void(0);\">Details</a></td>\r\n\r\n                    <td>");
#nullable restore
#line 50 "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml"
                   Write(error.CreatedDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 51 "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml"
                   Write(error.Message.Ellipsify(90));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 52 "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml"
                   Write(error.IpAddress);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 53 "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml"
                   Write(error.Url.Ellipsify(20));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n");
                WriteLiteral("                <tr");
                BeginWriteAttribute("id", " id=\"", 1750, "\"", 1773, 2);
                WriteAttributeValue("", 1755, "detail-", 1755, 7, true);
#nullable restore
#line 56 "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml"
WriteAttributeValue("", 1762, error.Id, 1762, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"display:none;\">\r\n                    <td colspan=\"5\" class=\"pl-90\">\r\n                        <div class=\"py-10\"><strong>Message:</strong> ");
#nullable restore
#line 58 "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml"
                                                                Write(error.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <div class=\"py-10\"><strong>User:</strong> ");
#nullable restore
#line 59 "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml"
                                                             Write(error.UserId);

#line default
#line hidden
#nullable disable
                WriteLiteral(": ");
#nullable restore
#line 59 "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml"
                                                                            Write(error.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <div class=\"py-10\"><strong>Url:</strong> ");
#nullable restore
#line 60 "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml"
                                                            Write(error.Url);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <div class=\"py-10\"><strong>Referrer:</strong> ");
#nullable restore
#line 61 "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml"
                                                                 Write(error.HttpReferer);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <div class=\"py-10\"><strong>UTC Date:</strong> ");
#nullable restore
#line 62 "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml"
                                                                 Write(error.CreatedDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <div class=\"py-10\"><strong>User Agent:</strong> ");
#nullable restore
#line 63 "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml"
                                                                   Write(error.UserAgent);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <div class=\"py-10\"><strong>Server Name:</strong> ");
#nullable restore
#line 64 "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml"
                                                                    Write(error.ServerName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <div class=\"py-10\"><strong>Full Exception:</strong> ");
#nullable restore
#line 65 "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml"
                                                                       Write(error.Exception);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 68 "C:\Users\tonyl\Desktop\temp\temp\Areas\Errors\List.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </table>\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "07cef7afda35a259d6ae88bbed0f2e659a9599d420147", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
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
            WriteLiteral("\r\n</div>\r\n\r\n<br /><br />\r\n<br /><br />\r\n<br /><br />\r\n<br /><br />\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">

        Dofactory.namespace(""Local"").Page = (function () {

            var start = function () {

                // toggle visibility of error details

                $("".view"").on('click', function () {
                    var id = $(this).data('id');
                    $(""#detail-"" + id).toggle();
                    $(this).blur();
                });
            };

            return { start: start };
        })();

        $(function () {

            Dofactory.Local.Page.start();

        });
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ITypeahead Typeahead { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IFilter Filter { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ILookup Lookup { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICache Cache { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICurrentUser CurrentUser { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<temp.Areas.Errors.List> Html { get; private set; }
    }
}
#pragma warning restore 1591
