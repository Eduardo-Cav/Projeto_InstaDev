#pragma checksum "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35894443b9ae8bcb97f602373ac0af853fd1e25a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Perfil_Index), @"mvc.1.0.view", @"/Views/Perfil/Index.cshtml")]
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
#line 1 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\_ViewImports.cshtml"
using InstaDev_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\_ViewImports.cshtml"
using InstaDev_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35894443b9ae8bcb97f602373ac0af853fd1e25a", @"/Views/Perfil/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6846e00dccae461b63969ae214900fe939ced91", @"/Views/_ViewImports.cshtml")]
    public class Views_Perfil_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Publicacao>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Link para deslogar o usuário", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Perfil", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35894443b9ae8bcb97f602373ac0af853fd1e25a5877", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Document</title>\r\n    <link rel=\"stylesheet\" href=\"/css/perfil.css\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <main>\r\n        <!--Início da Section PERFIL -->\r\n        <section class=\"perfil\">\r\n            <div class=\"content display-jc-center\">\r\n                <div class=\"dados-perfil\">\r\n");
#nullable restore
#line 15 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                 foreach (Usuario item in ViewBag.Usuario)
                {
                    
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"foto\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 597, "\"", 621, 2);
            WriteAttributeValue("", 603, "/img/", 603, 5, true);
#nullable restore
#line 20 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
WriteAttributeValue("", 608, ViewBag.Foto, 608, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Imagem de perfil do usuário\">\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"dados\">\r\n                        <h1>");
#nullable restore
#line 24 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                       Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n                        <div class=\"estatisticas\">\r\n                            <a href=\"#\">");
#nullable restore
#line 27 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                   Write(ViewBag.NumeroDePublicacoes);

#line default
#line hidden
#nullable disable
            WriteLiteral(" publicações</a>\r\n                            <a href=\"#\">1 seguindo</a>\r\n                            <a href=\"#\">1 seguidores</a>\r\n                        </div>\r\n\r\n                        <div class=\"nome-sair\">\r\n                            <h2>");
#nullable restore
#line 33 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                           Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            \r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35894443b9ae8bcb97f602373ac0af853fd1e25a9508", async() => {
                WriteLiteral("Editar Perfil");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35894443b9ae8bcb97f602373ac0af853fd1e25a10904", async() => {
                WriteLiteral("Sair");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 39 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                    break;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </section> 
        
        <!--Fim da Section PERFIL -->
        

        <!--Início da Section Publicações-->

        <section class=""publicacoes""> 
            <div class=""content"">
                <div class=""img-pub"">
                    <img src=""/img/image 1.svg""");
            BeginWriteAttribute("alt", " alt=\"", 1855, "\"", 1861, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h2>Publicações</h2>\r\n                </div>\r\n                \r\n");
#nullable restore
#line 57 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                 foreach (Publicacao item in ViewBag.Publicacoes){
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"publicacao\">\r\n                    <div class=\"imagem-pub\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "35894443b9ae8bcb97f602373ac0af853fd1e25a13782", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2161, "~/img_publicacao/", 2161, 17, true);
#nullable restore
#line 61 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
AddHtmlAttributeValue("", 2178, item.Imagem, 2178, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    \r\n                    <div class=\"conteudo\">\r\n                        <div class=\"usuario\">\r\n                            \r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2405, "\"", 2429, 2);
            WriteAttributeValue("", 2411, "/img/", 2411, 5, true);
#nullable restore
#line 67 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
WriteAttributeValue("", 2416, ViewBag.Foto, 2416, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2430, "\"", 2436, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                            <div class=\"nome-endereco\">\r\n");
#nullable restore
#line 70 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                 foreach (Usuario u in ViewBag.Usuario)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>");
#nullable restore
#line 72 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                  Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 73 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                    break;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <p></p>
                            </div>
                        </div>

                        <div class=""curtida"">
                            <div class=""curtir"">
                                <a><img src=""/img/Vector.png""");
            BeginWriteAttribute("alt", " alt=\"", 3007, "\"", 3013, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                <a href=\"#\"><img src=\"/img/Vector2.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 3092, "\"", 3098, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                <p>");
#nullable restore
#line 83 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                              Write(ViewBag.Likes);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" curtidas </p>
                            </div>
                        </div>

                        <div class=""comentarios"">

                            <div class=""comentarios-recentes"">
                                <div class=""comentario"">
                                       
");
#nullable restore
#line 92 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                     foreach (Usuario user in ViewBag.Usuario)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p><a href=\"#\"> ");
#nullable restore
#line 94 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                                   Write(user.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a> ");
#nullable restore
#line 94 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                                                   Write(item.Legenda);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 95 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                        break;
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a href=\"#\"><img src=\"/img/Vector.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3829, "\"", 3835, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                </div>\r\n                                \r\n");
#nullable restore
#line 100 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                 foreach(Comentario coment in ViewBag.Comentarios){
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                     foreach (Usuario usu in ViewBag.Usuario)
                                    {   

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"comentario\">\r\n                                            <p><a href=\"#\">");
#nullable restore
#line 104 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                                      Write(usu.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>");
#nullable restore
#line 104 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                                                       Write(coment.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                            <a href=\"#\"><img src=\"/img/Vector.png\"");
            BeginWriteAttribute("alt", " alt=\"", 4370, "\"", 4376, 0);
            EndWriteAttribute();
            WriteLiteral("></a>                                        \r\n                                        </div>\r\n");
#nullable restore
#line 107 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                        break;
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                     
                                        
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                            
                        </div>                    
                        <a href=""#"">Ver todos os 580 comentários </a>
                    </div>
                </div>
                <div class=""comentar"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35894443b9ae8bcb97f602373ac0af853fd1e25a22559", async() => {
                WriteLiteral("\r\n                        <input type=\"text\" name=\"comentario\" class=\"input-comentario\" placeholder=\"Escreva um comentário\">\r\n                        <button type=\"submit\" style=\"display: none;\"></button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 118 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
AddHtmlAttributeValue("", 4965, Url.Action("Comentar"), 4965, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 123 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n        </section>\r\n        <!-- Fim da Section publicações -->\r\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Publicacao> Html { get; private set; }
    }
}
#pragma warning restore 1591
