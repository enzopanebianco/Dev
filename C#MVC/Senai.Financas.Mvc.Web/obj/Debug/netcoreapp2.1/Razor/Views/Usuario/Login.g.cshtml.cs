#pragma checksum "C:\Users\ENZO\Desktop\DEV\Senai.Financas.Mvc.Web\Views\Usuario\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d4f3609bf80eecdf84c549d83d388a36ef8c662"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Login), @"mvc.1.0.view", @"/Views/Usuario/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Login.cshtml", typeof(AspNetCore.Views_Usuario_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d4f3609bf80eecdf84c549d83d388a36ef8c662", @"/Views/Usuario/Login.cshtml")]
    public class Views_Usuario_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 54, true);
            WriteLiteral("<html>\r\n    <h1>\r\n        Login\r\n    </h1>\r\n    \r\n    ");
            EndContext();
            BeginContext(55, 16, false);
#line 6 "C:\Users\ENZO\Desktop\DEV\Senai.Financas.Mvc.Web\Views\Usuario\Login.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(71, 316, true);
            WriteLiteral(@"
    <form action=""/Usuario/Login"" method=""Post"">
<label>
    Email:
<input type=""email"" name=""email"" required maxlength=""50"">
</label>
<label>
    Senha:
    <input type=""password "" name=""senha"" required maxlength=""20"">
</label>
<button type=""submit"">ENTRAR NO SISTEMA</button>

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
