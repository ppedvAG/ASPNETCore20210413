#pragma checksum "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\StateManagementMVCSample\Views\StateManagement\ThirdTempDataSample.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "730e0e6e743f557b3581eeafe74b44bda2430a91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StateManagement_ThirdTempDataSample), @"mvc.1.0.view", @"/Views/StateManagement/ThirdTempDataSample.cshtml")]
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
#line 1 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\StateManagementMVCSample\Views\_ViewImports.cshtml"
using StateManagementMVCSample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\StateManagementMVCSample\Views\_ViewImports.cshtml"
using StateManagementMVCSample.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"730e0e6e743f557b3581eeafe74b44bda2430a91", @"/Views/StateManagement/ThirdTempDataSample.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4df46e40df80757cef87a6bdcda14238c9adfabb", @"/Views/_ViewImports.cshtml")]
    public class Views_StateManagement_ThirdTempDataSample : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\StateManagementMVCSample\Views\StateManagement\ThirdTempDataSample.cshtml"
  
    ViewData["Title"] = "SecondTempDataSample";

    string email = TempData["EmailAddress"].ToString();
    int id = Convert.ToInt32(TempData["Id"]);
    TempData.Keep(); //Bezieht sich auf das komplette TempData Directory

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>SecondTempDataSample</h1>\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\StateManagementMVCSample\Views\StateManagement\ThirdTempDataSample.cshtml"
Write(email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 18 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\StateManagementMVCSample\Views\StateManagement\ThirdTempDataSample.cshtml"
Write(id);

#line default
#line hidden
#nullable disable
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
