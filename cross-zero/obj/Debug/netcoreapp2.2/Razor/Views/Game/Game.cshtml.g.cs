#pragma checksum "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4ad45e3c8024ebd9aab4c1ad80b95a0b3e02358"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_Game), @"mvc.1.0.view", @"/Views/Game/Game.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Game/Game.cshtml", typeof(AspNetCore.Views_Game_Game))]
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
#line 1 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\_ViewImports.cshtml"
using cross_zero;

#line default
#line hidden
#line 2 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\_ViewImports.cshtml"
using cross_zero.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4ad45e3c8024ebd9aab4c1ad80b95a0b3e02358", @"/Views/Game/Game.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76702826d52b7b61bc8cf9cb0bc472937ba621d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_Game : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cross_zero.Common.ViewModels.GameViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/GameHub.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
  
    ViewData["Title"] = "Game";

#line default
#line hidden
            BeginContext(92, 125, true);
            WriteLiteral("\r\n<h1 class=\"text-center\">Game</h1>\r\n<br />\r\n\r\n            <div class=\"container\">\r\n                <div class=\"infoUsers\">\r\n");
            EndContext();
#line 11 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
                      

                        var user = Context.User.Identity.Name;

                        if (user == Model.UserNameOne)
                        {

#line default
#line hidden
            BeginContext(392, 64, true);
            WriteLiteral("                            <input type=\"hidden\" id=\"figureUser\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 456, "\"", 480, 1);
#line 17 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
WriteAttributeValue("", 464, Model.FigureOne, 464, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(481, 70, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" id=\"figureEnemy\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 551, "\"", 575, 1);
#line 18 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
WriteAttributeValue("", 559, Model.FigureTwo, 559, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(576, 53, true);
            WriteLiteral(" />\r\n                            <div id=\"userFigure\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 629, "\"", 655, 1);
#line 19 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
WriteAttributeValue("", 637, Model.FigureOne, 637, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(656, 74, true);
            WriteLiteral("></div>\r\n                            <h3 class=\"text-center\"><u id=\"user\">");
            EndContext();
            BeginContext(731, 17, false);
#line 20 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
                                                            Write(Model.UserNameOne);

#line default
#line hidden
            EndContext();
            BeginContext(748, 70, true);
            WriteLiteral(" </u><b>&ensp;&ensp;&ensp; VS &ensp;&ensp;&ensp;</b> <span id=\"enemy\">");
            EndContext();
            BeginContext(819, 17, false);
#line 20 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
                                                                                                                                                    Write(Model.UserNameTwo);

#line default
#line hidden
            EndContext();
            BeginContext(836, 63, true);
            WriteLiteral("</span></h3>\r\n                            <div id=\"enemyFigure\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 899, "\"", 925, 1);
#line 21 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
WriteAttributeValue("", 907, Model.FigureTwo, 907, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(926, 9, true);
            WriteLiteral("></div>\r\n");
            EndContext();
#line 22 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1019, 64, true);
            WriteLiteral("                            <input type=\"hidden\" id=\"figureUser\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1083, "\"", 1107, 1);
#line 25 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
WriteAttributeValue("", 1091, Model.FigureTwo, 1091, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1108, 70, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" id=\"figureEnemy\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1178, "\"", 1202, 1);
#line 26 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
WriteAttributeValue("", 1186, Model.FigureOne, 1186, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1203, 53, true);
            WriteLiteral(" />\r\n                            <div id=\"userFigure\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1256, "\"", 1282, 1);
#line 27 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
WriteAttributeValue("", 1264, Model.FigureTwo, 1264, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1283, 74, true);
            WriteLiteral("></div>\r\n                            <h3 class=\"text-center\"><u id=\"user\">");
            EndContext();
            BeginContext(1358, 17, false);
#line 28 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
                                                            Write(Model.UserNameTwo);

#line default
#line hidden
            EndContext();
            BeginContext(1375, 70, true);
            WriteLiteral(" </u><b>&ensp;&ensp;&ensp; VS &ensp;&ensp;&ensp;</b> <span id=\"enemy\">");
            EndContext();
            BeginContext(1446, 17, false);
#line 28 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
                                                                                                                                                    Write(Model.UserNameOne);

#line default
#line hidden
            EndContext();
            BeginContext(1463, 63, true);
            WriteLiteral("</span></h3>\r\n                            <div id=\"enemyFigure\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1526, "\"", 1552, 1);
#line 29 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
WriteAttributeValue("", 1534, Model.FigureOne, 1534, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1553, 9, true);
            WriteLiteral("></div>\r\n");
            EndContext();
#line 30 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(1612, 732, true);
            WriteLiteral(@"                </div>



                <div class=""gameBox"">

                    <div class=""gameCell"" id=""11""></div>
                    <div class=""gameCell middleVerticalCell"" id=""12""></div>
                    <div class=""gameCell"" id=""13""></div>

                    <div class=""gameCell middleGorizontCell"" id=""21""></div>
                    <div class=""gameCell centerCell"" id=""22""></div>
                    <div class=""gameCell middleGorizontCell"" id=""23""></div>

                    <div class=""gameCell"" id=""31""></div>
                    <div class=""gameCell middleVerticalCell"" id=""32""></div>
                    <div class=""gameCell"" id=""33""></div>

                </div>

            </div>
");
            EndContext();
            BeginContext(2344, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4ad45e3c8024ebd9aab4c1ad80b95a0b3e0235811604", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cross_zero.Common.ViewModels.GameViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
