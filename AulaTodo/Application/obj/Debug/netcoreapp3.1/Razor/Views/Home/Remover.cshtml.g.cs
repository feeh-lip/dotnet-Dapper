#pragma checksum "D:\Estudos\.Net\Dapper\dotnet-Dapper\AulaTodo\Application\Views\Home\Remover.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc65a2039373d66460a02a70f444e7a2984c6444"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Remover), @"mvc.1.0.view", @"/Views/Home/Remover.cshtml")]
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
#line 1 "D:\Estudos\.Net\Dapper\dotnet-Dapper\AulaTodo\Application\Views\_ViewImports.cshtml"
using Application;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Estudos\.Net\Dapper\dotnet-Dapper\AulaTodo\Application\Views\_ViewImports.cshtml"
using Application.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc65a2039373d66460a02a70f444e7a2984c6444", @"/Views/Home/Remover.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03ea476b5db410d4405042b0a5ed991b4e6710c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Remover : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.ToDo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        Cadastrar Tarefa\r\n    </div>\r\n    <div class=\"card-body\">\r\n       Você deseja remover a tarefa ");
#nullable restore
#line 8 "D:\Estudos\.Net\Dapper\dotnet-Dapper\AulaTodo\Application\Views\Home\Remover.cshtml"
                               Write(Model.Tarefa);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n        ");
#nullable restore
#line 10 "D:\Estudos\.Net\Dapper\dotnet-Dapper\AulaTodo\Application\Views\Home\Remover.cshtml"
   Write(Html.ActionLink("Sim", "ConfirmaRemover", "Home", new { id = Model.Id }, new { @class = "btn btn-danger btn-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 11 "D:\Estudos\.Net\Dapper\dotnet-Dapper\AulaTodo\Application\Views\Home\Remover.cshtml"
   Write(Html.ActionLink("Voltar", "index", "Home", null, new { @class="btn btn-light btn-sm"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.ToDo> Html { get; private set; }
    }
}
#pragma warning restore 1591
