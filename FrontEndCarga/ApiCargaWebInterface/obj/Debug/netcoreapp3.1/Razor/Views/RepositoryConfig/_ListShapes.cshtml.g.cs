#pragma checksum "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\_ListShapes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b8c1ad743a03782dadfde7674cf9d105b4fabe6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RepositoryConfig__ListShapes), @"mvc.1.0.view", @"/Views/RepositoryConfig/_ListShapes.cshtml")]
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
#line 1 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\_ViewImports.cshtml"
using ApiCargaWebInterface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\_ViewImports.cshtml"
using ApiCargaWebInterface.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b8c1ad743a03782dadfde7674cf9d105b4fabe6", @"/Views/RepositoryConfig/_ListShapes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ea611a92e380a82377bf0950bf072fffae47c15", @"/Views/_ViewImports.cshtml")]
    public class Views_RepositoryConfig__ListShapes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApiCargaWebInterface.ViewModels.ShapeConfigViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\_ListShapes.cshtml"
 if (Model != null && Model.Count() > 0)
{
     int i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""items tabla"">
        <div class=""cabecera"">
            <div class=""columna"">
                <p>Nombre</p>
            </div>
            <div class=""columna acciones"">
                <p>Acciones</p>
            </div>
        </div>
");
#nullable restore
#line 15 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\_ListShapes.cshtml"
         foreach (var shape in Model)
        {
            string idModal = $"modalEliminarShape{i}";
            string target = $"#{idModal}";
            i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"fila\">\r\n                <div class=\"columna principal\">\r\n                    <p>");
#nullable restore
#line 22 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\_ListShapes.cshtml"
                  Write(shape.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"columna acciones\">\r\n                    <ul>\r\n                        <li>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 847, "\"", 925, 1);
#nullable restore
#line 27 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\_ListShapes.cshtml"
WriteAttributeValue("", 854, Url.Action("Details", "ShapeConfig", new {  id=shape.ShapeConfigID  }), 854, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"ver\">\r\n                                <i class=\"material-icons\">remove_red_eye</i>\r\n                            </a>\r\n                        </li>\r\n                        <li>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1144, "\"", 1219, 1);
#nullable restore
#line 32 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\_ListShapes.cshtml"
WriteAttributeValue("", 1151, Url.Action("Edit", "ShapeConfig", new {  id=shape.ShapeConfigID  }), 1151, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""editar"">
                                <i class=""material-icons"">mode_edit</i>
                            </a>
                        </li>
                        <li>
                            <a href=""javascript: void(0);"" class=""borrar"" data-toggle=""modal"" data-target=""");
#nullable restore
#line 37 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\_ListShapes.cshtml"
                                                                                                      Write(target);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                <i class=""material-icons"">delete</i>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
            <div class=""modal fade top-modal eliminar""");
            BeginWriteAttribute("id", " id=\"", 1784, "\"", 1797, 1);
#nullable restore
#line 44 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\_ListShapes.cshtml"
WriteAttributeValue("", 1789, idModal, 1789, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\" role=\"dialog\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 1826, "\"", 1844, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""display: none;"" aria-hidden=""true"">
                <div class=""modal-dialog"" role=""document"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5 class=""modal-title"">Eliminar</h5>
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                <span aria-hidden=""true"">×</span>
                            </button>
                        </div>
                        <div class=""modal-body"">
                            <div style=""display: block;"" id=""despAccionRec"">
                                <div style=""display: block;"" class=""stateShowForm"" id=""panels"">
                                    <div class=""loading"" id=""loading"" style=""display: none;"">
                                        <p>Cargando formulario, un momento por favor</p>
                                    </div>
                                    <div id=""menssage");
            WriteLiteral(@"s"" style=""display: none;"">
                                        <div class=""ok""></div>
                                        <div class=""ko""></div>
                                    </div>
                                    <div class=""box form activeForm"" id=""action"" style=""display: block;"">
                                        <div>
                                            <fieldset>
                                                <legend>¿Está seguro que quiere eliminar la validación ");
#nullable restore
#line 66 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\_ListShapes.cshtml"
                                                                                                  Write(shape.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("?</legend>\r\n                                                <div id=\"eliminar\">\r\n                                                    <p>\r\n                                                        <a");
            BeginWriteAttribute("href", " href=\"", 3589, "\"", 3666, 1);
#nullable restore
#line 69 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\_ListShapes.cshtml"
WriteAttributeValue("", 3596, Url.Action("Delete", "ShapeConfig", new {  id=shape.ShapeConfigID  }), 3596, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><input type=\"text\" class=\"button btn-principal\" value=\"Eliminar\"></a>\r\n");
            WriteLiteral(@"                                                        <input type=""button"" value=""Cancelar"" data-dismiss=""modal"">
                                                    </p>
                                                </div>
                                            </fieldset>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 83 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\_ListShapes.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 85 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\_ListShapes.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApiCargaWebInterface.ViewModels.ShapeConfigViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591