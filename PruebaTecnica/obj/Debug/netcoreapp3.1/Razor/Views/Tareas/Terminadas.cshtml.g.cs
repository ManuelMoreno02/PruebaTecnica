#pragma checksum "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "108715fb9d51bb5f77924f8d83a26ea6605dcb14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tareas_Terminadas), @"mvc.1.0.view", @"/Views/Tareas/Terminadas.cshtml")]
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
#line 1 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\_ViewImports.cshtml"
using PruebaTecnica;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\_ViewImports.cshtml"
using PruebaTecnica.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"108715fb9d51bb5f77924f8d83a26ea6605dcb14", @"/Views/Tareas/Terminadas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a34b744f3ad62f6b7bc8573a11f2d93359075252", @"/Views/_ViewImports.cshtml")]
    public class Views_Tareas_Terminadas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PruebaTecnica.Models.Tarea>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
  
    ViewData["Title"] = "Lista de Tareas Terminadas";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\" id=\"modeltarea\">\r\n");
#nullable restore
#line 8 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
     if (TempData["mensaje"] != null)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">\r\n            ");
#nullable restore
#line 12 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
       Write(TempData["mensaje"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <button type=\"button\" class=\"close\" date-dismiss=\"alert\" aria-label=\"close\">\r\n                <span aria-hidden=\"true\">&times;</span>\r\n            </button>\r\n        </div>\r\n");
#nullable restore
#line 17 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-12\">\r\n\r\n            <h3>");
#nullable restore
#line 23 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n        </div>\r\n       \r\n    </div>\r\n    <br />\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 29 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
         if (Model.Count() > 0)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <table class=\"table table-bordered table-striped\">\r\n                <thead>\r\n                    <tr>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
                       Write(Html.DisplayNameFor(m => m.NTarea));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
                       Write(Html.DisplayNameFor(m => m.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 37 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
                       Write(Html.DisplayNameFor(m => m.Prioridad));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 38 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
                       Write(Html.DisplayNameFor(m => m.FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 39 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
                       Write(Html.DisplayNameFor(m => m.FechaFinal));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 40 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
                       Write(Html.DisplayNameFor(m => m.FechaEstimado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>Tiempo Estimado</td>\r\n                        <td>Tiempo Total</td>\r\n\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 47 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
                     foreach (var item in Model)
                    {
                        if (item.Estado == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 52 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
                       Write(item.NTarea);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 53 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
                       Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 54 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
                         if (item.Prioridad == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"text-danger\">ALTA</td>\r\n");
#nullable restore
#line 57 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
                        }
                        else if (item.Prioridad == 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"text-warning\">MEDIA</td>\r\n");
#nullable restore
#line 61 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"text-success\">BAJA</td>\r\n");
#nullable restore
#line 65 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <td>");
#nullable restore
#line 67 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
                       Write(item.FechaCreacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        <td>");
#nullable restore
#line 69 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
                       Write(item.FechaFinal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 70 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
                       Write(item.FechaEstimado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        <td>");
#nullable restore
#line 72 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
                       Write(item.TiempoEstimado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 73 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
                           string tiempoTotal = (item.FechaFinal - item.FechaCreacion).ToString(@"dd\.hh\:mm\:ss");

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 74 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
                       Write(tiempoTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 76 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
                        }

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 81 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"


        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>No existen registros aun</p>\r\n");
#nullable restore
#line 87 "C:\Users\PC\source\repos\PruebaTecnica\PruebaTecnica\Views\Tareas\Terminadas.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PruebaTecnica.Models.Tarea>> Html { get; private set; }
    }
}
#pragma warning restore 1591
