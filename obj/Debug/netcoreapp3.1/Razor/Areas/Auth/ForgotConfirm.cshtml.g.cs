#pragma checksum "C:\Users\tonyl\Desktop\temp\temp\Areas\Auth\ForgotConfirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e148c0af8e508a3ef69fb8c3d10df4f6e6f1ce6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Auth_ForgotConfirm), @"mvc.1.0.view", @"/Areas/Auth/ForgotConfirm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e148c0af8e508a3ef69fb8c3d10df4f6e6f1ce6", @"/Areas/Auth/ForgotConfirm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"213736d78864afa6f1a98a1ff5a7a50860a25802", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Auth_ForgotConfirm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\tonyl\Desktop\temp\temp\Areas\Auth\ForgotConfirm.cshtml"
  
    ViewBag.Title = "Forgot Confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"m-auto my-120 bg-light rounded p-25 width-500 border\">\r\n\r\n    <h3>Forgot Confirmation</h3>\r\n\r\n    <p class=\"pt-15\">\r\n        We\'ve sent you an email on how to reset your password.<br />\r\n        It should arrive shortly.\r\n    </p>\r\n    <p");
            BeginWriteAttribute("class", " class=\"", 303, "\"", 311, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <a class=\"underline\" href=\"/\">Click here</a>&nbsp;to go back to the landing page.\r\n    </p>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
