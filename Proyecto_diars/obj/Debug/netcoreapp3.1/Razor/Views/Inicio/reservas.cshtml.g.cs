#pragma checksum "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Inicio\reservas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e593b5cfc403261928308fb3aaef02a6af4fc8b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inicio_reservas), @"mvc.1.0.view", @"/Views/Inicio/reservas.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e593b5cfc403261928308fb3aaef02a6af4fc8b0", @"/Views/Inicio/reservas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f5d13c591dd1a3d9b3dded1f0bf0e2993e45585", @"/Views/_ViewImports.cshtml")]
    public class Views_Inicio_reservas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n\n\n");
#nullable restore
#line 6 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Inicio\reservas.cshtml"
   Layout = "_LayoutUsuario"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-hover\">\n    <thead>\n        <tr>\n            <th>Nª Personas</th>\n            <th>Fecha</th>\n            <th>Hora</th>\n            <th>Mesa</th>\n            <th>Pedido</th>\n\n        </tr>\n\n    </thead>\n    <tbody>\n");
#nullable restore
#line 20 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Inicio\reservas.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 23 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Inicio\reservas.cshtml"
               Write(item.N_personas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 24 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Inicio\reservas.cshtml"
               Write(item.Fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 25 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Inicio\reservas.cshtml"
               Write(item.Hora);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 26 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Inicio\reservas.cshtml"
               Write(item.mesa.N_Mesa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 523, "\"", 563, 2);
            WriteAttributeValue("", 530, "/inicio/detallepedido?id=", 530, 25, true);
#nullable restore
#line 29 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Inicio\reservas.cshtml"
WriteAttributeValue("", 555, item.Id, 555, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Detalle Pedido</a></td>\n            </tr>\n");
#nullable restore
#line 31 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Inicio\reservas.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
