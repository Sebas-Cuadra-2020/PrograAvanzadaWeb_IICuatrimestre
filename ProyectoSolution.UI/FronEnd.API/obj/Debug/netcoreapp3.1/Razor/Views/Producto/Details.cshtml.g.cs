#pragma checksum "C:\Users\picad\Desktop\Proyecto programacion\10-8-21\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21cecc1ae5108b1de11036b6f340dcefbbbb70bf"
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
#line 1 "C:\Users\picad\Desktop\Proyecto programacion\10-8-21\ProyectoSolution.UI\FronEnd.API\Views\_ViewImports.cshtml"
using FronEnd.API;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\picad\Desktop\Proyecto programacion\10-8-21\ProyectoSolution.UI\FronEnd.API\Views\_ViewImports.cshtml"
using FronEnd.API.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21cecc1ae5108b1de11036b6f340dcefbbbb70bf", @"/Views/Producto/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ed1c0487a0b9a95cb7d468f4bee76d8771ffa2e", @"/Views/_ViewImports.cshtml")]
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\picad\Desktop\Proyecto programacion\10-8-21\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""col-lg-6"">
    <div class=""card mb-4 py-3 border-left-primary"">
        <div class=""card-body"">

            <h4>Producto</h4>
            <hr />
            <dl class=""row"">
                <dt class=""col-sm-2"">
                    ");
#nullable restore
#line 17 "C:\Users\picad\Desktop\Proyecto programacion\10-8-21\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.CodigoBarras));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 20 "C:\Users\picad\Desktop\Proyecto programacion\10-8-21\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayFor(model => model.CodigoBarras));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 23 "C:\Users\picad\Desktop\Proyecto programacion\10-8-21\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.FechaIngreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 26 "C:\Users\picad\Desktop\Proyecto programacion\10-8-21\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayFor(model => model.FechaIngreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 29 "C:\Users\picad\Desktop\Proyecto programacion\10-8-21\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.NombreProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 32 "C:\Users\picad\Desktop\Proyecto programacion\10-8-21\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayFor(model => model.NombreProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 35 "C:\Users\picad\Desktop\Proyecto programacion\10-8-21\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.CantidadProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 38 "C:\Users\picad\Desktop\Proyecto programacion\10-8-21\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayFor(model => model.CantidadProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 41 "C:\Users\picad\Desktop\Proyecto programacion\10-8-21\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.PrecioUnitario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 44 "C:\Users\picad\Desktop\Proyecto programacion\10-8-21\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayFor(model => model.PrecioUnitario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 47 "C:\Users\picad\Desktop\Proyecto programacion\10-8-21\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.PrecioVenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 50 "C:\Users\picad\Desktop\Proyecto programacion\10-8-21\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayFor(model => model.PrecioVenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 53 "C:\Users\picad\Desktop\Proyecto programacion\10-8-21\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.IdFamiliaProductoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 56 "C:\Users\picad\Desktop\Proyecto programacion\10-8-21\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayFor(model => model.IdFamiliaProductoNavigation.NombreFamiliaProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 59 "C:\Users\picad\Desktop\Proyecto programacion\10-8-21\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.IdProveedorNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 62 "C:\Users\picad\Desktop\Proyecto programacion\10-8-21\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
               Write(Html.DisplayFor(model => model.IdProveedorNavigation.Canton));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21cecc1ae5108b1de11036b6f340dcefbbbb70bf10685", async() => {
                WriteLiteral("Editar");
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
#line 67 "C:\Users\picad\Desktop\Proyecto programacion\10-8-21\ProyectoSolution.UI\FronEnd.API\Views\Producto\Details.cshtml"
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
            WriteLiteral(" |\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21cecc1ae5108b1de11036b6f340dcefbbbb70bf12889", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
