#pragma checksum "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Personal\detallepedido.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "358c364fca2360d008bcae37ec595a522d16c8dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_detallepedido), @"mvc.1.0.view", @"/Views/Personal/detallepedido.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"358c364fca2360d008bcae37ec595a522d16c8dc", @"/Views/Personal/detallepedido.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f5d13c591dd1a3d9b3dded1f0bf0e2993e45585", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_detallepedido : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Personal\detallepedido.cshtml"
   Layout = "_AdminLayout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<a href=\"/Personal/Moso\">volver</a>\n<div class=\"container\">\n    <a");
            BeginWriteAttribute("href", " href=\"", 96, "\"", 162, 2);
            WriteAttributeValue("", 103, "/Personal/AgregarProducto_Moso?idreserva=", 103, 41, true);
#nullable restore
#line 4 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Personal\detallepedido.cshtml"
WriteAttributeValue("", 144, ViewBag.Idreserva, 144, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary pull-right"">Agregar producto</a>
</div>
<br />
<table class=""table table-hover"">
    <thead>
        <tr>
            <th>Producto</th>
            <th>Cantidad</th>
            <th>Precio</th>
            <th>Subtotal</th>
            <th>Eliminar</th>

        </tr>

    </thead>
    <tbody>
");
#nullable restore
#line 20 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Personal\detallepedido.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 23 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Personal\detallepedido.cshtml"
               Write(item.productos.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 24 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Personal\detallepedido.cshtml"
               Write(item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 25 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Personal\detallepedido.cshtml"
               Write(item.productos.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 26 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Personal\detallepedido.cshtml"
               Write(item.Subtotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                <td><a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 768, "\"", 825, 2);
            WriteAttributeValue("", 775, "/Personal/EliminarDetallePedido?iddetalle=", 775, 42, true);
#nullable restore
#line 28 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Personal\detallepedido.cshtml"
WriteAttributeValue("", 817, item.Id, 817, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Eliminar</a></td>\n            </tr>\n");
#nullable restore
#line 30 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Personal\detallepedido.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
