#pragma checksum "C:\Users\ENZO\Desktop\DEV\Senai.Financas.Mvc.Web\Views\Usuario\Cadastro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5989ac79fd7dcfa3d7a77ddd4596b1a4292e9527"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Cadastro), @"mvc.1.0.view", @"/Views/Usuario/Cadastro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Cadastro.cshtml", typeof(AspNetCore.Views_Usuario_Cadastro))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5989ac79fd7dcfa3d7a77ddd4596b1a4292e9527", @"/Views/Usuario/Cadastro.cshtml")]
    public class Views_Usuario_Cadastro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 55, true);
            WriteLiteral("<html>\r\n    <h1>Formulário de Cadastro</h1>\r\n\r\n        ");
            EndContext();
            BeginContext(56, 16, false);
#line 4 "C:\Users\ENZO\Desktop\DEV\Senai.Financas.Mvc.Web\Views\Usuario\Cadastro.cshtml"
   Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(72, 564, true);
            WriteLiteral(@"


    <form  action=""/Usuario/Cadastro"" method=""POST"">
    
        <label>
            nome
            <input type=""text"" name=""nome"">
        </label>
        <label>
            Email
            <input type=""email"" name=""email"">
        </label>
        
        <label>
            Senha
            <input type=""password"" name=""senha"">
        </label>
        <label>
            Data de Nascimento
            <input type=""text"" name=""dataNascimento"">
        </label>
    <button type=""submit"">SALVAR</button>
    </form>
</html>");
            EndContext();
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
