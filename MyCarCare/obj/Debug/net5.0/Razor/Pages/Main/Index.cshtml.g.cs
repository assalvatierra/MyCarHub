#pragma checksum "C:\Abel\GitHub\MyCarHub\MyCarCare\Pages\Main\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3babd5fa6741bda6cbbf5cfcfb02f7b38ba892ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyCarCare.Pages.Main.Pages_Main_Index), @"mvc.1.0.razor-page", @"/Pages/Main/Index.cshtml")]
namespace MyCarCare.Pages.Main
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
#line 1 "C:\Abel\GitHub\MyCarHub\MyCarCare\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Abel\GitHub\MyCarHub\MyCarCare\Pages\_ViewImports.cshtml"
using MyCarCare;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Abel\GitHub\MyCarHub\MyCarCare\Pages\_ViewImports.cshtml"
using MyCarCare.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3babd5fa6741bda6cbbf5cfcfb02f7b38ba892ae", @"/Pages/Main/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"675f60744f245a99fe341d9dc04a8e4cb571fb37", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Main_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div>\r\n    <h1> Options for user </h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Abel\GitHub\MyCarHub\MyCarCare\Pages\Main\Index.cshtml"
     if (User.Identity.IsAuthenticated)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <p><a");
            BeginWriteAttribute("href", " href=\"", 172, "\"", 179, 0);
            EndWriteAttribute();
            WriteLiteral(@">Account Settings</a></p>
        <p><a href=""/Main/Login"">Login List</a></p>
        <p><a href=""/Main/Vehicle"">Vehicles</a></p>
        <p><a href=""/Main/Garage"">Garage</a></p>
        <p><a href=""/Main/Driver"">Drivers</a></p>
        <p><a href=""/Main/Reports"">Reports</a></p>

    </div>
");
#nullable restore
#line 21 "C:\Abel\GitHub\MyCarHub\MyCarCare\Pages\Main\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyCarCare.Pages.Main.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyCarCare.Pages.Main.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyCarCare.Pages.Main.IndexModel>)PageContext?.ViewData;
        public MyCarCare.Pages.Main.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
