#pragma checksum "E:\RCL\RazorClassLibrary\Pages\Shared\test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3c18322638b6707a2f88e8917528eff16f97a9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Shared_test), @"mvc.1.0.view", @"/Pages/Shared/test.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/test.cshtml", typeof(AspNetCore.Pages_Shared_test))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3c18322638b6707a2f88e8917528eff16f97a9e", @"/Pages/Shared/test.cshtml")]
    public class Pages_Shared_test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RazorClassLibrary.Model.TestModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 80, true);
            WriteLiteral("<h3>\r\n    This is test page from Razor Class Library.\r\n</h3>\r\n<br />\r\n<h4>Hello ");
            EndContext();
            BeginContext(123, 10, false);
#line 6 "E:\RCL\RazorClassLibrary\Pages\Shared\test.cshtml"
     Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(133, 9, true);
            WriteLiteral("!!! </h4>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorClassLibrary.Model.TestModel> Html { get; private set; }
    }
}
#pragma warning restore 1591