#pragma checksum "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Personal\listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee8db7cfce7bc1ea9a32ba394b323f0d22e05490"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_listar), @"mvc.1.0.view", @"/Views/Personal/listar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee8db7cfce7bc1ea9a32ba394b323f0d22e05490", @"/Views/Personal/listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f5d13c591dd1a3d9b3dded1f0bf0e2993e45585", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n\n");
#nullable restore
#line 5 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Personal\listar.cshtml"
   Layout = "_AdminLayout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section class=\"content\">\n    <table class=\"table table-hover\">\n        <thead>\n            <tr>\n                <th>Usuario</th>\n                <th>Rol</th>\n            </tr>\n\n        </thead>\n        <tbody>\n");
#nullable restore
#line 17 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Personal\listar.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 20 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Personal\listar.cshtml"
                   Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 21 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Personal\listar.cshtml"
                     foreach (var rol in ViewBag.rol)
                    {
                        if (rol.Id == item.Id_Rol)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 25 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Personal\listar.cshtml"
                           Write(rol.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 26 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Personal\listar.cshtml"

                        }

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\n");
#nullable restore
#line 31 "C:\Users\HP\Downloads\Proyecto_diars-master\Proyecto_diars\Views\Personal\listar.cshtml"


            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n\n</section>");
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
