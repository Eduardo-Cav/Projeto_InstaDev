#pragma checksum "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52a2cb6de50e059e773cb4517122d0f895e83598"
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
#line 1 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\_ViewImports.cshtml"
using InstaDev_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\_ViewImports.cshtml"
using InstaDev_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52a2cb6de50e059e773cb4517122d0f895e83598", @"/Views/Perfil/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6846e00dccae461b63969ae214900fe939ced91", @"/Views/_ViewImports.cshtml")]
    public class Views_Perfil_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Publicacao>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Link para deslogar o usuário", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Perfil", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletePost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletarComentario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52a2cb6de50e059e773cb4517122d0f895e835986548", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
    <script src=""https://kit.fontawesome.com/2b55e26e8a.js"" crossorigin=""anonymous""></script>
    <link rel=""stylesheet"" href=""/css/perfil.css"">
");
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
#line 16 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                 foreach (Usuario item in ViewBag.Usuario)
                {
                    
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"foto\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 692, "\"", 716, 2);
            WriteAttributeValue("", 698, "/img/", 698, 5, true);
#nullable restore
#line 21 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
WriteAttributeValue("", 703, ViewBag.Foto, 703, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Imagem de perfil do usuário\">\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"dados\">\r\n                        <h1>");
#nullable restore
#line 25 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                       Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n                        <div class=\"estatisticas\">\r\n                            <a href=\"#\">");
#nullable restore
#line 28 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                   Write(ViewBag.NumeroDePublicacoes);

#line default
#line hidden
#nullable disable
            WriteLiteral(" publicações</a>\r\n                            <a href=\"#\">1 seguindo</a>\r\n                            <a href=\"#\">1 seguidores</a>\r\n                        </div>\r\n\r\n                        <div class=\"nome-sair\">\r\n                            <h2>");
#nullable restore
#line 34 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                           Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            \r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52a2cb6de50e059e773cb4517122d0f895e8359810359", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52a2cb6de50e059e773cb4517122d0f895e8359811756", async() => {
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
#line 40 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
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
            BeginWriteAttribute("alt", " alt=\"", 1950, "\"", 1956, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h2>Publicações</h2>\r\n                </div>\r\n                \r\n");
#nullable restore
#line 58 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                 foreach (Publicacao item in ViewBag.Publicacoes){
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"publicacao\">\r\n                    <div class=\"imagem-pub\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "52a2cb6de50e059e773cb4517122d0f895e8359814666", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2252, "~/img_publicacao/", 2252, 17, true);
#nullable restore
#line 62 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
AddHtmlAttributeValue("", 2269, item.Imagem, 2269, 12, false);

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
            BeginWriteAttribute("src", " src=\"", 2496, "\"", 2520, 2);
            WriteAttributeValue("", 2502, "/img/", 2502, 5, true);
#nullable restore
#line 68 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
WriteAttributeValue("", 2507, ViewBag.Foto, 2507, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2521, "\"", 2527, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                            <div class=\"nome-endereco\">\r\n");
#nullable restore
#line 71 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                 foreach (Usuario u in ViewBag.Usuario)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>");
#nullable restore
#line 73 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                  Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 74 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
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
                                <a><img src=""/img/Vector.png"" alt=""Imagem de um coração""></a>
                                <a href=""#""><img src=""/img/Vector2.svg"" alt=""Imagem de um balão de comentário""></a>
                                <p>");
#nullable restore
#line 84 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                              Write(ViewBag.Likes);

#line default
#line hidden
#nullable disable
            WriteLiteral(" curtidas </p>\r\n                            </div>\r\n                            \r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52a2cb6de50e059e773cb4517122d0f895e8359818975", async() => {
                WriteLiteral("<i class=\"far fa-trash-alt\" style=\"font-size: 20px; color: #000; margin-bottom: 1em; margin-left: 0.3em;\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                                                                     WriteLiteral(item.IdPublicacao);

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
            WriteLiteral(@"
                                
                        </div>

                        <div class=""comentarios"">

                            <div class=""comentarios-recentes"">
                                <div class=""comentario"">
                                       
");
#nullable restore
#line 96 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                     foreach (Usuario user in ViewBag.Usuario)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p><a href=\"#\"> ");
#nullable restore
#line 98 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                                   Write(user.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a> ");
#nullable restore
#line 98 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                                                   Write(item.Legenda);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 99 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                        break;
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a href=\"#\"><img src=\"/img/Vector.png\"");
            BeginWriteAttribute("alt", " alt=\"", 4270, "\"", 4276, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                </div>\r\n                                \r\n");
#nullable restore
#line 104 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                 foreach(Comentario coment in ViewBag.COMMENTS){

                                    Publicacao p = new Publicacao();

                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                     if(item.IdPublicacao == coment.IdPublicacao)
                                    {   

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"comentario\">\r\n");
#nullable restore
#line 111 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                             foreach (Usuario u in ViewBag.Usuario)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <p href=\"#\"><a href=\"#\">");
#nullable restore
#line 113 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                                                   Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> ");
#nullable restore
#line 113 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                                                               Write(coment.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 114 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52a2cb6de50e059e773cb4517122d0f895e8359825705", async() => {
                WriteLiteral("<img src=\"/img/Vector.png\"");
                BeginWriteAttribute("alt", " alt=\"", 5153, "\"", 5159, 0);
                EndWriteAttribute();
                WriteLiteral(">");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 115 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                                                                                        WriteLiteral(item.IdPublicacao);

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
            WriteLiteral("                                        \r\n                                        </div>\r\n");
#nullable restore
#line 117 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                            
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
                                     
                                        
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                            
                        </div>                    
                        <a href=""#"">Ver todos os comentários </a>
                    </div>
                </div>
                <div class=""comentar"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52a2cb6de50e059e773cb4517122d0f895e8359829350", async() => {
                WriteLiteral("\r\n                        <input type=\"text\" name=\"comentario\" class=\"input-comentario\" placeholder=\"Escreva um comentário\">\r\n                        <input type=\"text\" name=\"idPublicacao\" class=\"input-comentario\" style=\"display: none;\"");
                BeginWriteAttribute("value", " value=\"", 5987, "\"", 6013, 1);
#nullable restore
#line 130 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
WriteAttributeValue("", 5995, item.IdPublicacao, 5995, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <button type=\"submit\" style=\"display: none;\"></button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 128 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
AddHtmlAttributeValue("", 5726, Url.Action("Comentar"), 5726, 23, false);

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
#line 134 "C:\Users\Vitor Manoel\Desktop\Atualizando-Comentario-Perfil\Projeto_InstaDev\InstaDev_MVC\Views\Perfil\Index.cshtml"
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
