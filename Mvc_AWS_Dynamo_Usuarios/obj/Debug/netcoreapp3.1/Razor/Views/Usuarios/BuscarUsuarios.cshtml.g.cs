#pragma checksum "C:\Users\SergioArribasSanchez\source\repos\Mvc_AWS_Dynamo_Usuarios\Mvc_AWS_Dynamo_Usuarios\Views\Usuarios\BuscarUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa4c3052d4ad5cca0511a77886d268d70f132b28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_BuscarUsuarios), @"mvc.1.0.view", @"/Views/Usuarios/BuscarUsuarios.cshtml")]
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
#line 1 "C:\Users\SergioArribasSanchez\source\repos\Mvc_AWS_Dynamo_Usuarios\Mvc_AWS_Dynamo_Usuarios\Views\_ViewImports.cshtml"
using Mvc_AWS_Dynamo_Usuarios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SergioArribasSanchez\source\repos\Mvc_AWS_Dynamo_Usuarios\Mvc_AWS_Dynamo_Usuarios\Views\_ViewImports.cshtml"
using Mvc_AWS_Dynamo_Usuarios.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa4c3052d4ad5cca0511a77886d268d70f132b28", @"/Views/Usuarios/BuscarUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf8cc56893b14e4453d03fe46138df0f410f7152", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_BuscarUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Mvc_AWS_Dynamo_Usuarios.Models.Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\SergioArribasSanchez\source\repos\Mvc_AWS_Dynamo_Usuarios\Mvc_AWS_Dynamo_Usuarios\Views\Usuarios\BuscarUsuarios.cshtml"
  
    ViewData["Title"] = "BuscarUsuarios";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>BuscarUsuarios</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa4c3052d4ad5cca0511a77886d268d70f132b284073", async() => {
                WriteLiteral("\r\n    <input type=\"text\" name=\"coso\" class=\"form-control\" />\r\n\r\n    <button type=\"submit\" class=\"btn btn-primary\">Buscar</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 15 "C:\Users\SergioArribasSanchez\source\repos\Mvc_AWS_Dynamo_Usuarios\Mvc_AWS_Dynamo_Usuarios\Views\Usuarios\BuscarUsuarios.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 21 "C:\Users\SergioArribasSanchez\source\repos\Mvc_AWS_Dynamo_Usuarios\Mvc_AWS_Dynamo_Usuarios\Views\Usuarios\BuscarUsuarios.cshtml"
               Write(Html.DisplayNameFor(model => model.idusuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 24 "C:\Users\SergioArribasSanchez\source\repos\Mvc_AWS_Dynamo_Usuarios\Mvc_AWS_Dynamo_Usuarios\Views\Usuarios\BuscarUsuarios.cshtml"
               Write(Html.DisplayNameFor(model => model.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 27 "C:\Users\SergioArribasSanchez\source\repos\Mvc_AWS_Dynamo_Usuarios\Mvc_AWS_Dynamo_Usuarios\Views\Usuarios\BuscarUsuarios.cshtml"
               Write(Html.DisplayNameFor(model => model.descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 30 "C:\Users\SergioArribasSanchez\source\repos\Mvc_AWS_Dynamo_Usuarios\Mvc_AWS_Dynamo_Usuarios\Views\Usuarios\BuscarUsuarios.cshtml"
               Write(Html.DisplayNameFor(model => model.fechaalta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 36 "C:\Users\SergioArribasSanchez\source\repos\Mvc_AWS_Dynamo_Usuarios\Mvc_AWS_Dynamo_Usuarios\Views\Usuarios\BuscarUsuarios.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 40 "C:\Users\SergioArribasSanchez\source\repos\Mvc_AWS_Dynamo_Usuarios\Mvc_AWS_Dynamo_Usuarios\Views\Usuarios\BuscarUsuarios.cshtml"
                   Write(Html.DisplayFor(modelItem => item.idusuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 43 "C:\Users\SergioArribasSanchez\source\repos\Mvc_AWS_Dynamo_Usuarios\Mvc_AWS_Dynamo_Usuarios\Views\Usuarios\BuscarUsuarios.cshtml"
                   Write(Html.DisplayFor(modelItem => item.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 46 "C:\Users\SergioArribasSanchez\source\repos\Mvc_AWS_Dynamo_Usuarios\Mvc_AWS_Dynamo_Usuarios\Views\Usuarios\BuscarUsuarios.cshtml"
                   Write(Html.DisplayFor(modelItem => item.descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 49 "C:\Users\SergioArribasSanchez\source\repos\Mvc_AWS_Dynamo_Usuarios\Mvc_AWS_Dynamo_Usuarios\Views\Usuarios\BuscarUsuarios.cshtml"
                   Write(Html.DisplayFor(modelItem => item.fechaalta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 52 "C:\Users\SergioArribasSanchez\source\repos\Mvc_AWS_Dynamo_Usuarios\Mvc_AWS_Dynamo_Usuarios\Views\Usuarios\BuscarUsuarios.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 53 "C:\Users\SergioArribasSanchez\source\repos\Mvc_AWS_Dynamo_Usuarios\Mvc_AWS_Dynamo_Usuarios\Views\Usuarios\BuscarUsuarios.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 54 "C:\Users\SergioArribasSanchez\source\repos\Mvc_AWS_Dynamo_Usuarios\Mvc_AWS_Dynamo_Usuarios\Views\Usuarios\BuscarUsuarios.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 57 "C:\Users\SergioArribasSanchez\source\repos\Mvc_AWS_Dynamo_Usuarios\Mvc_AWS_Dynamo_Usuarios\Views\Usuarios\BuscarUsuarios.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 60 "C:\Users\SergioArribasSanchez\source\repos\Mvc_AWS_Dynamo_Usuarios\Mvc_AWS_Dynamo_Usuarios\Views\Usuarios\BuscarUsuarios.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 style=\"color:blue\">No existe coches en DynamoDb</h1>\r\n");
#nullable restore
#line 64 "C:\Users\SergioArribasSanchez\source\repos\Mvc_AWS_Dynamo_Usuarios\Mvc_AWS_Dynamo_Usuarios\Views\Usuarios\BuscarUsuarios.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Mvc_AWS_Dynamo_Usuarios.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
