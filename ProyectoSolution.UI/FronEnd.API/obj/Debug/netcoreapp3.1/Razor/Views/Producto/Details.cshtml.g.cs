#pragma checksum "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c48c5a0ae9d2168a91373766c891af34f305f728"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_Details), @"mvc.1.0.view", @"/Views/Producto/Details.cshtml")]
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
#line 5 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c48c5a0ae9d2168a91373766c891af34f305f728", @"/Views/Producto/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8defad412e2c5e784cdcfb991a5d42a2bd754c8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Producto_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FronEnd.API.Models.Producto>
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
#line 3 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
   ViewData["Title"] = "Details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 7 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
   var vUser = Context.Session.GetString("_User");

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--Capturar la sesión en la variable vUser--> ");
#nullable restore
#line 8 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
 if (vUser != null && Context.Session.GetString("Rol") == "1" || Context.Session.GetString("Rol") == "2")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-lg-6"">
    <div class=""card mb-4 py-3 border-left-primary"">
        <div class=""card-body"">

            <h4>Informacion Producto</h4>
            <hr />
            <dl class=""row"">
                <dt class=""col-sm-2"">
                    ");
#nullable restore
#line 18 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.CodigoBarras));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 21 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayFor(model => model.CodigoBarras));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 24 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.FechaIngreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 27 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayFor(model => model.FechaIngreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 30 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.NombreProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 33 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayFor(model => model.NombreProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 36 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.CantidadProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 39 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayFor(model => model.CantidadProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 42 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.PrecioUnitario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 45 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayFor(model => model.PrecioUnitario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 48 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.PrecioVenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 51 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayFor(model => model.PrecioVenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 54 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.IdFamiliaProductoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 57 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayFor(model => model.IdFamiliaProductoNavigation.NombreFamiliaProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 60 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.IdProveedorNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 63 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayFor(model => model.IdProveedorNavigation.Canton));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n            </dl>\n        </div>\n        <div>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c48c5a0ae9d2168a91373766c891af34f305f72811178", async() => {
                WriteLiteral("Editas Datos");
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
#line 68 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
                                   WriteLiteral(Model.IdProducto);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c48c5a0ae9d2168a91373766c891af34f305f72813372", async() => {
                WriteLiteral("Ver Productos");
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
#line 72 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
       }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>No tienes acceso a esta pagina</h2>");
#nullable restore
#line 75 "C:\Users\Joshu\Downloads\Nueva carpeta\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FronEnd.API.Models.Producto> Html { get; private set; }
    }
}
#pragma warning restore 1591
