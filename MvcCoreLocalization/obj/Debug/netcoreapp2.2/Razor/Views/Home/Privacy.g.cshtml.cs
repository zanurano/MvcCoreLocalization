#pragma checksum "E:\Kerja\dotnet\Belajar\MvcCoreLocalization\MvcCoreLocalization\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31135a7095f6455f8cfee2b123390587be8065c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Privacy.cshtml", typeof(AspNetCore.Views_Home_Privacy))]
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
#line 1 "E:\Kerja\dotnet\Belajar\MvcCoreLocalization\MvcCoreLocalization\Views\_ViewImports.cshtml"
using MvcCoreLocalization;

#line default
#line hidden
#line 2 "E:\Kerja\dotnet\Belajar\MvcCoreLocalization\MvcCoreLocalization\Views\_ViewImports.cshtml"
using MvcCoreLocalization.Models;

#line default
#line hidden
#line 1 "E:\Kerja\dotnet\Belajar\MvcCoreLocalization\MvcCoreLocalization\Views\Home\Privacy.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 2 "E:\Kerja\dotnet\Belajar\MvcCoreLocalization\MvcCoreLocalization\Views\Home\Privacy.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31135a7095f6455f8cfee2b123390587be8065c5", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e78d7e3926a80a9322c5ac43aa619629cd4997f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "E:\Kerja\dotnet\Belajar\MvcCoreLocalization\MvcCoreLocalization\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(198, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(203, 17, false);
#line 8 "E:\Kerja\dotnet\Belajar\MvcCoreLocalization\MvcCoreLocalization\Views\Home\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(220, 13, true);
            WriteLiteral("</h1>\r\n\r\n<h4>");
            EndContext();
            BeginContext(234, 19, false);
#line 10 "E:\Kerja\dotnet\Belajar\MvcCoreLocalization\MvcCoreLocalization\Views\Home\Privacy.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(253, 19, true);
            WriteLiteral("</h4>\r\n<h4>Cookie: ");
            EndContext();
            BeginContext(273, 19, false);
#line 11 "E:\Kerja\dotnet\Belajar\MvcCoreLocalization\MvcCoreLocalization\Views\Home\Privacy.cshtml"
       Write(ViewData["Cookies"]);

#line default
#line hidden
            EndContext();
            BeginContext(292, 11, true);
            WriteLiteral("</h4>\r\n<h4>");
            EndContext();
            BeginContext(304, 20, false);
#line 12 "E:\Kerja\dotnet\Belajar\MvcCoreLocalization\MvcCoreLocalization\Views\Home\Privacy.cshtml"
Write(localizer["Walking"]);

#line default
#line hidden
            EndContext();
            BeginContext(324, 67, true);
            WriteLiteral("</h4>\r\n<p>Use this page to detail your site\'s privacy policy.</p>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer localizer { get; private set; }
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
