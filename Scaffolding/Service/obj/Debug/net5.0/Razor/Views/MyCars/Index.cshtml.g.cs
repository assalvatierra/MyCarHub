#pragma checksum "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da5b3fe2194eceb5373674232e4ded3e6cc56a94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyCars_Index), @"mvc.1.0.view", @"/Views/MyCars/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da5b3fe2194eceb5373674232e4ded3e6cc56a94", @"/Views/MyCars/Index.cshtml")]
    public class Views_MyCars_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Domain.Entities.MyCar>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Variant));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PlateNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Conduction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Vin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MyCarModel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MyCarFuel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MyCarTransmission));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MyCarDrivetrain));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MyAccount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 49 "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Variant));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PlateNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Conduction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Vin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MyCarModel.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MyCarFuel.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MyCarTransmission.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MyCarDrivetrain.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MyAccount.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2402, "\"", 2425, 1);
#nullable restore
#line 82 "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml"
WriteAttributeValue("", 2417, item.Id, 2417, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2478, "\"", 2501, 1);
#nullable restore
#line 83 "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml"
WriteAttributeValue("", 2493, item.Id, 2493, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2556, "\"", 2579, 1);
#nullable restore
#line 84 "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml"
WriteAttributeValue("", 2571, item.Id, 2571, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 87 "C:\Abel\GitHub\MyCarHub\Scaffolding\Service\Views\MyCars\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Domain.Entities.MyCar>> Html { get; private set; }
    }
}
#pragma warning restore 1591
