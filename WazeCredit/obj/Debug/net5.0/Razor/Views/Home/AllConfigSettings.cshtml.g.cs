#pragma checksum "C:\Users\ERNESTO\Desktop\Cursos\Udemy - Dependency Injection\WazeCredit\WazeCredit\Views\Home\AllConfigSettings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "459d7f697b96b4410026c6e7124fad3ec9e5f83d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AllConfigSettings), @"mvc.1.0.view", @"/Views/Home/AllConfigSettings.cshtml")]
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
#line 1 "C:\Users\ERNESTO\Desktop\Cursos\Udemy - Dependency Injection\WazeCredit\WazeCredit\Views\_ViewImports.cshtml"
using WazeCredit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ERNESTO\Desktop\Cursos\Udemy - Dependency Injection\WazeCredit\WazeCredit\Views\_ViewImports.cshtml"
using WazeCredit.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ERNESTO\Desktop\Cursos\Udemy - Dependency Injection\WazeCredit\WazeCredit\Views\Home\AllConfigSettings.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"459d7f697b96b4410026c6e7124fad3ec9e5f83d", @"/Views/Home/AllConfigSettings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e21229da0337b715e9a399cae495185b9e47312", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AllConfigSettings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <h1>List of data from AppSettings </h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\ERNESTO\Desktop\Cursos\Udemy - Dependency Injection\WazeCredit\WazeCredit\Views\Home\AllConfigSettings.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h5>");
#nullable restore
#line 10 "C:\Users\ERNESTO\Desktop\Cursos\Udemy - Dependency Injection\WazeCredit\WazeCredit\Views\Home\AllConfigSettings.cshtml"
       Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 11 "C:\Users\ERNESTO\Desktop\Cursos\Udemy - Dependency Injection\WazeCredit\WazeCredit\Views\Home\AllConfigSettings.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n    <p>Current Market Prediction Status: ");
#nullable restore
#line 13 "C:\Users\ERNESTO\Desktop\Cursos\Udemy - Dependency Injection\WazeCredit\WazeCredit\Views\Home\AllConfigSettings.cshtml"
                                     Write(wazeForeCasting.Value.ForecastTrackerEnabled ? "Online" : "Offline");

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<WazeCredit.Utility.AppSettings.WazeForecastSettings> wazeForeCasting { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
