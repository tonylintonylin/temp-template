#pragma checksum "C:\Users\tonyl\Desktop\temp\temp\Areas\_Base\_Alert.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6119ab6cb657ecb977ab8f3688f61d4a8d152f34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas__Base__Alert), @"mvc.1.0.view", @"/Areas/_Base/_Alert.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6119ab6cb657ecb977ab8f3688f61d4a8d152f34", @"/Areas/_Base/_Alert.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"213736d78864afa6f1a98a1ff5a7a50860a25802", @"/Areas/_ViewImports.cshtml")]
    public class Areas__Base__Alert : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\tonyl\Desktop\temp\temp\Areas\_Base\_Alert.cshtml"
 if (TempData["Success"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"alert-success\" class=\"alert alert-success alert-absolute\">\r\n        ");
#nullable restore
#line 4 "C:\Users\tonyl\Desktop\temp\temp\Areas\_Base\_Alert.cshtml"
   Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\">&times;</button>\r\n    </div>\r\n");
#nullable restore
#line 7 "C:\Users\tonyl\Desktop\temp\temp\Areas\_Base\_Alert.cshtml"

    TempData["Success"] = null;      // prevents redisplay following a non-redirect
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\tonyl\Desktop\temp\temp\Areas\_Base\_Alert.cshtml"
 if (TempData["Failure"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"alert-failure\" class=\"alert alert-error alert-absolute\">\r\n        ");
#nullable restore
#line 14 "C:\Users\tonyl\Desktop\temp\temp\Areas\_Base\_Alert.cshtml"
   Write(TempData["Failure"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\">&times;</button>\r\n    </div>\r\n");
#nullable restore
#line 17 "C:\Users\tonyl\Desktop\temp\temp\Areas\_Base\_Alert.cshtml"

    TempData["Failure"] = null;      // prevents redisplay following a non-redirect
}

#line default
#line hidden
#nullable disable
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