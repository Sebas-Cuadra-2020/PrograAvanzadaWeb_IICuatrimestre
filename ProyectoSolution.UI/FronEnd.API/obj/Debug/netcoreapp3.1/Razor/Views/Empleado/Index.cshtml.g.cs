#pragma checksum "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad9e3ac858a8efa6446a1e1e23a02c63ad956680"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleado_Index), @"mvc.1.0.view", @"/Views/Empleado/Index.cshtml")]
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
#line 1 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\_ViewImports.cshtml"
using FronEnd.API;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\_ViewImports.cshtml"
using FronEnd.API.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad9e3ac858a8efa6446a1e1e23a02c63ad956680", @"/Views/Empleado/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8defad412e2c5e784cdcfb991a5d42a2bd754c8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleado_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FronEnd.API.Models.Empleado>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 7 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Index.cshtml"
   var vUser = Context.Session.GetString("_User");

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--Capturar la sesión en la variable vUser--> ");
#nullable restore
#line 8 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Index.cshtml"
 if (vUser != null && Context.Session.GetString("Rol") == "1")
{



#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Empleados</h1>\n");
            WriteLiteral("                <p>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad9e3ac858a8efa6446a1e1e23a02c63ad9566805538", async() => {
                WriteLiteral("Ingresar nuevo Empleado");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </p>
                                <div class=""card shadow mb-4"">

                                    <div class=""card-body"">
                                        <div class=""table-responsive"">
                                            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                                                <thead>
                                                    <tr>
                                                        <th>
                                                            Cedula

                                                        </th>
                                                        <th>
                                                            Fecha Ingreso

                                                        </th>
                                                        <th>
                                                            Nombre

                                                   ");
            WriteLiteral(@"     </th>
                                                        <th>
                                                            Apellido

                                                        </th>
                                                        <th>
                                                            Correo

                                                        </th>
                                                        <th>
                                                            Contraseña

                                                        </th>
                                                        <th>
                                                            Provincia

                                                        </th>
                                                        <th>
                                                            Canton

                                                        </th>
                                                 ");
            WriteLiteral(@"       <th>
                                                            Distrito

                                                        </th>
                                                        <th>
                                                            Telefono

                                                        </th>
                                                        <th>
                                                            Rol Empleado

                                                        </th>
                                                        <th>
                                                            Accion
                                                        </th>
                                                    </tr>
                                                </thead>
                                                <tbody>
");
#nullable restore
#line 74 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Index.cshtml"
                                                     foreach (var item in Model)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\n                                        <td>\n                                            ");
#nullable restore
#line 78 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.CedulaEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                        <td>\n                                            ");
#nullable restore
#line 81 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.FechaIngreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                        <td>\n                                            ");
#nullable restore
#line 84 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.NombreEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                        <td>\n                                            ");
#nullable restore
#line 87 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.ApellidoEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                        <td>\n                                            ");
#nullable restore
#line 90 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.CorreoEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                        <td>\n                                            ");
#nullable restore
#line 93 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.PasswordEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                        <td>\n                                            ");
#nullable restore
#line 96 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Provincia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                        <td>\n                                            ");
#nullable restore
#line 99 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Canton));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                        <td>\n                                            ");
#nullable restore
#line 102 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Distrito));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                        <td>\n                                            ");
#nullable restore
#line 105 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.TelefonoEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                        <td>\n                                            ");
#nullable restore
#line 108 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.IdRolNavigation.NombreRol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                        <td>\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad9e3ac858a8efa6446a1e1e23a02c63ad95668015133", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Index.cshtml"
                                                                   WriteLiteral(item.IdEmpleado);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad9e3ac858a8efa6446a1e1e23a02c63ad95668017383", async() => {
                WriteLiteral("Detalle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 112 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Index.cshtml"
                                                                      WriteLiteral(item.IdEmpleado);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad9e3ac858a8efa6446a1e1e23a02c63ad95668019637", async() => {
                WriteLiteral("Eliminar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 113 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Index.cshtml"
                                                                     WriteLiteral(item.IdEmpleado);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                        </td>\n                                    </tr>\n");
#nullable restore
#line 116 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </tbody>\n                                            </table>\n                                        </div>\n                                    </div>\n                                </div> ");
#nullable restore
#line 121 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Index.cshtml"
                                       }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h2>No Tienes Acceso a Esta Pagina</h2>");
#nullable restore
#line 124 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Index.cshtml"
                                                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FronEnd.API.Models.Empleado>> Html { get; private set; }
    }
}
#pragma warning restore 1591
