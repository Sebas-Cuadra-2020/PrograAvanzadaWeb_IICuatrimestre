#pragma checksum "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb225dc6678596f5c5fd638d1a33066465bd2d28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleado_Details), @"mvc.1.0.view", @"/Views/Empleado/Details.cshtml")]
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
#line 4 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb225dc6678596f5c5fd638d1a33066465bd2d28", @"/Views/Empleado/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8defad412e2c5e784cdcfb991a5d42a2bd754c8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleado_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FronEnd.API.Models.Empleado>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
   ViewData["Title"] = "Details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 6 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
   var vUser = Context.Session.GetString("_User");

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--Capturar la sesi??n en la variable vUser--> ");
#nullable restore
#line 7 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
 if (vUser != null && Context.Session.GetString("Rol") == "1")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-lg-6"">
    <div class=""card mb-4 py-3 border-left-primary"">
        <div class=""card-body"">
            <h4>Informacion Empleado</h4>
            <hr />
            <dl class=""row"">
                <dt class=""col-sm-2"">
                    ");
#nullable restore
#line 16 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.CedulaEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 19 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
               Write(Html.DisplayFor(model => model.CedulaEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 22 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.FechaIngreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 25 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
               Write(Html.DisplayFor(model => model.FechaIngreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 28 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.NombreEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 31 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
               Write(Html.DisplayFor(model => model.NombreEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 34 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.ApellidoEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 37 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
               Write(Html.DisplayFor(model => model.ApellidoEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 40 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.CorreoEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 43 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
               Write(Html.DisplayFor(model => model.CorreoEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 46 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.PasswordEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 49 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
               Write(Html.DisplayFor(model => model.PasswordEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 52 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Provincia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 55 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
               Write(Html.DisplayFor(model => model.Provincia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 58 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Canton));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 61 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
               Write(Html.DisplayFor(model => model.Canton));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 64 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Distrito));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 67 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
               Write(Html.DisplayFor(model => model.Distrito));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 70 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.TelefonoEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 73 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
               Write(Html.DisplayFor(model => model.TelefonoEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 76 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.IdRolNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 79 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
               Write(Html.DisplayFor(model => model.IdRolNavigation.NombreRol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n            </dl>\n        </div>\n        <div>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb225dc6678596f5c5fd638d1a33066465bd2d2813259", async() => {
                WriteLiteral("Editar Datos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
                                   WriteLiteral(Model.IdEmpleado);

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
            WriteLiteral(" |\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb225dc6678596f5c5fd638d1a33066465bd2d2815453", async() => {
                WriteLiteral("Ver Empleados");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n</div> ");
#nullable restore
#line 88 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
       }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>No Tienes Acceso a esta pagina</h2>");
#nullable restore
#line 91 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Empleado\Details.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FronEnd.API.Models.Empleado> Html { get; private set; }
    }
}
#pragma warning restore 1591
