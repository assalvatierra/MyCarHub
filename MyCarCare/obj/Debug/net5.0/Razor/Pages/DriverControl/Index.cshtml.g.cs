#pragma checksum "C:\Abel\GitHub\MyCarHub\MyCarCare\Pages\DriverControl\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d529ed577d219416813a0391194fde83b08424e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyCarCare.Pages.DriverControl.Pages_DriverControl_Index), @"mvc.1.0.razor-page", @"/Pages/DriverControl/Index.cshtml")]
namespace MyCarCare.Pages.DriverControl
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d529ed577d219416813a0391194fde83b08424e6", @"/Pages/DriverControl/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"675f60744f245a99fe341d9dc04a8e4cb571fb37", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DriverControl_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <h1>Driver\'s Panel</h1>\r\n\r\n    <div>\r\n        <p>Information:</p>\r\n        <p>Latest and important movements</p>\r\n    </div>\r\n\r\n    <h3>Options</h3>\r\n");
#nullable restore
#line 15 "C:\Abel\GitHub\MyCarHub\MyCarCare\Pages\DriverControl\Index.cshtml"
     if (User.Identity.IsAuthenticated)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <p><a href=\"/Garage/Movement\">Movement List</a></p>\r\n            <p><a href=\"/Garage/Movement/Create\">Add Movement</a></p>\r\n            <p><a href=\"/Garage/Movement/Create\">Add Reminder</a></p>\r\n\r\n        </div>\r\n");
#nullable restore
#line 23 "C:\Abel\GitHub\MyCarHub\MyCarCare\Pages\DriverControl\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyCarCare.Pages.DriverControl.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyCarCare.Pages.DriverControl.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyCarCare.Pages.DriverControl.IndexModel>)PageContext?.ViewData;
        public MyCarCare.Pages.DriverControl.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
