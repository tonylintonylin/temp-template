#pragma checksum "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4e64f32564a46bdabd724c7bf9ff44d81bad70d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ThingsB_Detail), @"mvc.1.0.view", @"/Areas/ThingsB/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4e64f32564a46bdabd724c7bf9ff44d81bad70d", @"/Areas/ThingsB/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"213736d78864afa6f1a98a1ff5a7a50860a25802", @"/Areas/_ViewImports.cshtml")]
    public class Areas_ThingsB_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<temp.Areas.ThingsB.Detail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "Owner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("label", "Thing B Owner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("querystring", "tab=details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("label", "Money", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("label", "Date Time", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ThingA", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::temp.TagHelpers.OutputLinkTagHelper __temp_TagHelpers_OutputLinkTagHelper;
        private global::temp.TagHelpers.OutputFieldTagHelper __temp_TagHelpers_OutputFieldTagHelper;
        private global::temp.TagHelpers.OutputCheckBoxTagHelper __temp_TagHelpers_OutputCheckBoxTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml"
  
    ViewBag.Title = "Thing B Detail";
    string thingsa = $"<span class='tab-badge'>{Model.TotalThingsA}</span>";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-box d-flex\">\r\n\r\n    <div>\r\n        <div class=\"page-box-icon\"><a href=\"/thingsb\"><i");
            BeginWriteAttribute("class", " class=\"", 260, "\"", 285, 1);
#nullable restore
#line 10 "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml"
WriteAttributeValue("", 268, Cache.ThingBIcon, 268, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a> Thing B</div>\r\n        <div class=\"page-box-name\">");
#nullable restore
#line 11 "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml"
                              Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n\r\n    <div class=\"d-flex\">\r\n        <div class=\"page-box-data-first\">Money<br />");
#nullable restore
#line 15 "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml"
                                               Write(Model.Money);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"page-box-data\">Status<br />");
#nullable restore
#line 16 "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml"
                                          Write(Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"page-box-data-last\">Lookup<br />");
#nullable restore
#line 17 "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml"
                                               Write(Model.Lookup);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n\r\n    <div class=\"ml-auto\">\r\n        <div class=\"page-box-buttons\">\r\n            <a class=\"btn btn-sm btn-light js-edit\"");
            BeginWriteAttribute("href", " href=\"", 750, "\"", 780, 2);
            WriteAttributeValue("", 757, "/thingsb/edit/", 757, 14, true);
#nullable restore
#line 22 "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml"
WriteAttributeValue("", 771, Model.Id, 771, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n            <a class=\"btn btn-sm btn-light js-delete\" href=\"/thingsb/delete\" data-return-url=\"/thingsb\" data-id=\"");
#nullable restore
#line 23 "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml"
                                                                                                            Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n               data-dependencies=\"");
#nullable restore
#line 24 "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml"
                             Write(Model.TotalThingsA);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Delete</a>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n<div class=\"tabs\">\r\n    <ul class=\"nav nav-tabs nav-tabs-related\">\r\n        <li class=\'nav-item\'><a");
            BeginWriteAttribute("class", " class=\'", 1123, "\'", 1181, 2);
            WriteAttributeValue("", 1131, "nav-link", 1131, 8, true);
#nullable restore
#line 32 "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml"
WriteAttributeValue(" ", 1139, Model.Tab == "details" ? "active" : "", 1140, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tab\" href=\"#details\">Details</a></li>\r\n        <li class=\'nav-item\'><a");
            BeginWriteAttribute("class", " class=\'", 1266, "\'", 1324, 2);
            WriteAttributeValue("", 1274, "nav-link", 1274, 8, true);
#nullable restore
#line 33 "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml"
WriteAttributeValue(" ", 1282, Model.Tab == "thingsa" ? "active" : "", 1283, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tab\" href=\"#thingsa\">Things A");
#nullable restore
#line 33 "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml"
                                                                                                                                 Write(Html.Raw(thingsa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n    </ul>\r\n</div>\r\n\r\n<div class=\"tab-content\">\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\'", 1457, "\'", 1515, 2);
            WriteAttributeValue("", 1465, "tab-pane", 1465, 8, true);
#nullable restore
#line 39 "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml"
WriteAttributeValue(" ", 1473, Model.Tab == "details" ? "active" : "", 1474, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"details\">\r\n        <div class=\"tab-pane-row row\">\r\n\r\n            <div class=\"col-12 col-md-6\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("outputLink", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4e64f32564a46bdabd724c7bf9ff44d81bad70d10398", async() => {
            }
            );
            __temp_TagHelpers_OutputLinkTagHelper = CreateTagHelper<global::temp.TagHelpers.OutputLinkTagHelper>();
            __tagHelperExecutionContext.Add(__temp_TagHelpers_OutputLinkTagHelper);
#nullable restore
#line 43 "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml"
__temp_TagHelpers_OutputLinkTagHelper.Value = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OwnerId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __temp_TagHelpers_OutputLinkTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 43 "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml"
__temp_TagHelpers_OutputLinkTagHelper.Name = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OwnerName);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("name", __temp_TagHelpers_OutputLinkTagHelper.Name, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __temp_TagHelpers_OutputLinkTagHelper.Type = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __temp_TagHelpers_OutputLinkTagHelper.Label = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __temp_TagHelpers_OutputLinkTagHelper.QueryString = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("outputField", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4e64f32564a46bdabd724c7bf9ff44d81bad70d12799", async() => {
            }
            );
            __temp_TagHelpers_OutputFieldTagHelper = CreateTagHelper<global::temp.TagHelpers.OutputFieldTagHelper>();
            __tagHelperExecutionContext.Add(__temp_TagHelpers_OutputFieldTagHelper);
#nullable restore
#line 44 "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml"
__temp_TagHelpers_OutputFieldTagHelper.Value = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __temp_TagHelpers_OutputFieldTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("outputField", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4e64f32564a46bdabd724c7bf9ff44d81bad70d14168", async() => {
            }
            );
            __temp_TagHelpers_OutputFieldTagHelper = CreateTagHelper<global::temp.TagHelpers.OutputFieldTagHelper>();
            __tagHelperExecutionContext.Add(__temp_TagHelpers_OutputFieldTagHelper);
#nullable restore
#line 45 "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml"
__temp_TagHelpers_OutputFieldTagHelper.Value = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Text);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __temp_TagHelpers_OutputFieldTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("outputField", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4e64f32564a46bdabd724c7bf9ff44d81bad70d15537", async() => {
            }
            );
            __temp_TagHelpers_OutputFieldTagHelper = CreateTagHelper<global::temp.TagHelpers.OutputFieldTagHelper>();
            __tagHelperExecutionContext.Add(__temp_TagHelpers_OutputFieldTagHelper);
#nullable restore
#line 46 "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml"
__temp_TagHelpers_OutputFieldTagHelper.Value = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LongText);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __temp_TagHelpers_OutputFieldTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("outputField", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4e64f32564a46bdabd724c7bf9ff44d81bad70d16910", async() => {
            }
            );
            __temp_TagHelpers_OutputFieldTagHelper = CreateTagHelper<global::temp.TagHelpers.OutputFieldTagHelper>();
            __tagHelperExecutionContext.Add(__temp_TagHelpers_OutputFieldTagHelper);
#nullable restore
#line 47 "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml"
__temp_TagHelpers_OutputFieldTagHelper.Value = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Money);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __temp_TagHelpers_OutputFieldTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __temp_TagHelpers_OutputFieldTagHelper.Label = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("outputField", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4e64f32564a46bdabd724c7bf9ff44d81bad70d18466", async() => {
            }
            );
            __temp_TagHelpers_OutputFieldTagHelper = CreateTagHelper<global::temp.TagHelpers.OutputFieldTagHelper>();
            __tagHelperExecutionContext.Add(__temp_TagHelpers_OutputFieldTagHelper);
#nullable restore
#line 48 "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml"
__temp_TagHelpers_OutputFieldTagHelper.Value = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Lookup);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __temp_TagHelpers_OutputFieldTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-12 col-md-6\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("outputField", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4e64f32564a46bdabd724c7bf9ff44d81bad70d19910", async() => {
            }
            );
            __temp_TagHelpers_OutputFieldTagHelper = CreateTagHelper<global::temp.TagHelpers.OutputFieldTagHelper>();
            __tagHelperExecutionContext.Add(__temp_TagHelpers_OutputFieldTagHelper);
#nullable restore
#line 52 "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml"
__temp_TagHelpers_OutputFieldTagHelper.Value = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DateTime);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __temp_TagHelpers_OutputFieldTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __temp_TagHelpers_OutputFieldTagHelper.Label = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("outputField", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4e64f32564a46bdabd724c7bf9ff44d81bad70d21469", async() => {
            }
            );
            __temp_TagHelpers_OutputFieldTagHelper = CreateTagHelper<global::temp.TagHelpers.OutputFieldTagHelper>();
            __tagHelperExecutionContext.Add(__temp_TagHelpers_OutputFieldTagHelper);
#nullable restore
#line 53 "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml"
__temp_TagHelpers_OutputFieldTagHelper.Value = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Status);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __temp_TagHelpers_OutputFieldTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("outputCheckBox", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4e64f32564a46bdabd724c7bf9ff44d81bad70d22840", async() => {
            }
            );
            __temp_TagHelpers_OutputCheckBoxTagHelper = CreateTagHelper<global::temp.TagHelpers.OutputCheckBoxTagHelper>();
            __tagHelperExecutionContext.Add(__temp_TagHelpers_OutputCheckBoxTagHelper);
#nullable restore
#line 54 "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml"
__temp_TagHelpers_OutputCheckBoxTagHelper.Value = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Boolean);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __temp_TagHelpers_OutputCheckBoxTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("outputField", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4e64f32564a46bdabd724c7bf9ff44d81bad70d24230", async() => {
            }
            );
            __temp_TagHelpers_OutputFieldTagHelper = CreateTagHelper<global::temp.TagHelpers.OutputFieldTagHelper>();
            __tagHelperExecutionContext.Add(__temp_TagHelpers_OutputFieldTagHelper);
#nullable restore
#line 55 "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml"
__temp_TagHelpers_OutputFieldTagHelper.Value = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Integer);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __temp_TagHelpers_OutputFieldTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\'", 2458, "\'", 2516, 2);
            WriteAttributeValue("", 2466, "tab-pane", 2466, 8, true);
#nullable restore
#line 61 "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml"
WriteAttributeValue(" ", 2474, Model.Tab == "thingsa" ? "active" : "", 2475, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"thingsa\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b4e64f32564a46bdabd724c7bf9ff44d81bad70d26129", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 62 "C:\Users\tonyl\Desktop\temp\temp\Areas\ThingsB\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.ThingsA;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(function () {\r\n\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<temp.Areas.ThingsB.Detail> Html { get; private set; }
    }
}
#pragma warning restore 1591
