#pragma checksum "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\AdminCategoria\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da3c41343cfd20c62cc7ea4331c5e43984e3c423"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminCategoria_Index), @"mvc.1.0.view", @"/Views/AdminCategoria/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da3c41343cfd20c62cc7ea4331c5e43984e3c423", @"/Views/AdminCategoria/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f5d13c591dd1a3d9b3dded1f0bf0e2993e45585", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminCategoria_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\AdminCategoria\Index.cshtml"
   Layout = "_AdminLayout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container-fluid"">
    <div class=""row page-title clearfix"">
        <div class=""page-title-left"">
            <h6 class=""page-title-heading mr-0 mr-r-5"">Categorias</h6>
            <a class=""float-right btn btn-primary mt-3"" href=""/admincategoria/create"">Registrar categoria</a>
        </div>
    </div>
    <div class=""row"">
        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Nombre</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 21 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\AdminCategoria\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 24 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\AdminCategoria\Index.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 25 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\AdminCategoria\Index.cshtml"
                       Write(item.Nombre_Categoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 831, "\"", 871, 2);
            WriteAttributeValue("", 838, "/admincategoria/eliminar/", 838, 25, true);
#nullable restore
#line 26 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\AdminCategoria\Index.cshtml"
WriteAttributeValue("", 863, item.Id, 863, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Eliminar </a></td>\n                    </tr>\n");
#nullable restore
#line 28 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\AdminCategoria\Index.cshtml"
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
