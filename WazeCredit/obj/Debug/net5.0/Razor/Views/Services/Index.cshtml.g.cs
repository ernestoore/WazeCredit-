#pragma checksum "C:\Users\ERNESTO\Desktop\Cursos\Udemy - Dependency Injection\WazeCredit\WazeCredit\Views\Services\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ee993675f8b7c8e81131020366b911a478f3d5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Index), @"mvc.1.0.view", @"/Views/Services/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ee993675f8b7c8e81131020366b911a478f3d5e", @"/Views/Services/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e21229da0337b715e9a399cae495185b9e47312", @"/Views/_ViewImports.cshtml")]
    public class Views_Services_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<String>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\ERNESTO\Desktop\Cursos\Udemy - Dependency Injection\WazeCredit\WazeCredit\Views\Services\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>LifeTime Services</h1>\r\n");
#nullable restore
#line 9 "C:\Users\ERNESTO\Desktop\Cursos\Udemy - Dependency Injection\WazeCredit\WazeCredit\Views\Services\Index.cshtml"
  
    var count = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ERNESTO\Desktop\Cursos\Udemy - Dependency Injection\WazeCredit\WazeCredit\Views\Services\Index.cshtml"
 foreach (string mess in Model)
{
    if (count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"font-size:20px;padding-top:20px;\">\r\n            Transient Lifetime will be different for every request!\r\n        </div>\r\n");
#nullable restore
#line 19 "C:\Users\ERNESTO\Desktop\Cursos\Udemy - Dependency Injection\WazeCredit\WazeCredit\Views\Services\Index.cshtml"
    }
    if (count == 2)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"font-size:20px;padding-top:20px;\">\r\n            Scoped Lifetime will be different when you refresh!\r\n        </div>\r\n");
#nullable restore
#line 25 "C:\Users\ERNESTO\Desktop\Cursos\Udemy - Dependency Injection\WazeCredit\WazeCredit\Views\Services\Index.cshtml"
    }
    if (count == 4)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"font-size:20px;padding-top:20px;\">\r\n            Singleton Lifetime will be same for your application! It changes when the application restarts!\r\n        </div>\r\n");
#nullable restore
#line 31 "C:\Users\ERNESTO\Desktop\Cursos\Udemy - Dependency Injection\WazeCredit\WazeCredit\Views\Services\Index.cshtml"
    }
    count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 34 "C:\Users\ERNESTO\Desktop\Cursos\Udemy - Dependency Injection\WazeCredit\WazeCredit\Views\Services\Index.cshtml"
   Write(mess);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 36 "C:\Users\ERNESTO\Desktop\Cursos\Udemy - Dependency Injection\WazeCredit\WazeCredit\Views\Services\Index.cshtml"
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<String>> Html { get; private set; }
    }
}
#pragma warning restore 1591