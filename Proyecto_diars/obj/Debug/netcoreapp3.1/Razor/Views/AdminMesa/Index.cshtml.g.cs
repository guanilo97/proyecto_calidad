#pragma checksum "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\AdminMesa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88e2367556127e2c82e47ca6486f9fbb6429c1e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminMesa_Index), @"mvc.1.0.view", @"/Views/AdminMesa/Index.cshtml")]
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
#line 1 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\_ViewImports.cshtml"
using Proyecto_diars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\_ViewImports.cshtml"
using Proyecto_diars.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88e2367556127e2c82e47ca6486f9fbb6429c1e4", @"/Views/AdminMesa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f5d13c591dd1a3d9b3dded1f0bf0e2993e45585", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminMesa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\AdminMesa\Index.cshtml"
   Layout = "_AdminLayout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row page-title clearfix"">
        <div class=""page-title-left"">
            <h6 class=""page-title-heading mr-0 mr-r-5"">Mesas registradas</h6>
            <a class=""float-right btn btn-primary mt-3"" href=""/adminmesa/create"">Registrar mesa</a>
        </div>
    </div>
    <div class=""row"">
        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th>N??</th>
                    <th>Descripci??n</th>
                    <th>Estado</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 20 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\AdminMesa\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 23 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\AdminMesa\Index.cshtml"
                   Write(item.N_mesa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 24 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\AdminMesa\Index.cshtml"
                   Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("                </tr>\n");
#nullable restore
#line 27 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\AdminMesa\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>\n");
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
