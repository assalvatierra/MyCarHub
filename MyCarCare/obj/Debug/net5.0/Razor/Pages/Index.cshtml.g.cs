#pragma checksum "C:\Abel\GitHub\MyCarHub\MyCarCare\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0798c41381a492fcb9ee183917bc3f05e749cb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyCarCare.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace MyCarCare.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0798c41381a492fcb9ee183917bc3f05e749cb1", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"675f60744f245a99fe341d9dc04a8e4cb571fb37", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Abel\GitHub\MyCarHub\MyCarCare\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome to MyCarCare</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">managing your fleet</a>.</p>\r\n</div>\r\n\r\n");
#nullable restore
#line 13 "C:\Abel\GitHub\MyCarHub\MyCarCare\Pages\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div>
    <p><a href=""/Main"">Main Control</a> for Admin user</p>
    <p><a href=""/GarageControl"">Garage Control</a> for garage user</p>
    <p><a href=""/VehicleControl"">Vehicle Control</a> for driver</p>
    <p><a href=""/DriverControl"">Driver Control</a> for fleet manager</p>

</div>
");
#nullable restore
#line 22 "C:\Abel\GitHub\MyCarHub\MyCarCare\Pages\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
