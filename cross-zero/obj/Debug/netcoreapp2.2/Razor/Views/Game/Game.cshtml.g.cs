#pragma checksum "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e522f4c40a3d8071924832c8a154f2539c916c7"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e522f4c40a3d8071924832c8a154f2539c916c7", @"/Views/Game/Game.cshtml")]
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
            BeginContext(92, 101, true);
            WriteLiteral("\r\n<h1 class=\"text-center\">Game</h1>\r\n<br />\r\n\r\n<div class=\"container\">\r\n    <div class=\"infoUsers\">\r\n");
            EndContext();
#line 11 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
          

            var user = Context.User.Identity.Name;

            if (user == Model.UserNameOne)
            {

#line default
#line hidden
            BeginContext(320, 52, true);
            WriteLiteral("                <input type=\"hidden\" id=\"figureUser\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 372, "\"", 396, 1);
#line 17 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
WriteAttributeValue("", 380, Model.FigureOne, 380, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(397, 58, true);
            WriteLiteral(" />\r\n                <input type=\"hidden\" id=\"figureEnemy\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 455, "\"", 479, 1);
#line 18 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
WriteAttributeValue("", 463, Model.FigureTwo, 463, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(480, 41, true);
            WriteLiteral(" />\r\n                <div id=\"userFigure\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 521, "\"", 547, 1);
#line 19 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
WriteAttributeValue("", 529, Model.FigureOne, 529, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(548, 62, true);
            WriteLiteral("></div>\r\n                <h3 class=\"text-center\"><u id=\"user\">");
            EndContext();
            BeginContext(611, 17, false);
#line 20 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
                                                Write(Model.UserNameOne);

#line default
#line hidden
            EndContext();
            BeginContext(628, 70, true);
            WriteLiteral(" </u><b>&ensp;&ensp;&ensp; VS &ensp;&ensp;&ensp;</b> <span id=\"enemy\">");
            EndContext();
            BeginContext(699, 17, false);
#line 20 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
                                                                                                                                        Write(Model.UserNameTwo);

#line default
#line hidden
            EndContext();
            BeginContext(716, 51, true);
            WriteLiteral("</span></h3>\r\n                <div id=\"enemyFigure\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 767, "\"", 793, 1);
#line 21 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
WriteAttributeValue("", 775, Model.FigureTwo, 775, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(794, 9, true);
            WriteLiteral("></div>\r\n");
            EndContext();
#line 22 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"

            }
            else
            {

#line default
#line hidden
            BeginContext(853, 52, true);
            WriteLiteral("                <input type=\"hidden\" id=\"figureUser\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 905, "\"", 929, 1);
#line 26 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
WriteAttributeValue("", 913, Model.FigureTwo, 913, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(930, 58, true);
            WriteLiteral(" />\r\n                <input type=\"hidden\" id=\"figureEnemy\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 988, "\"", 1012, 1);
#line 27 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
WriteAttributeValue("", 996, Model.FigureOne, 996, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1013, 41, true);
            WriteLiteral(" />\r\n                <div id=\"userFigure\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1054, "\"", 1080, 1);
#line 28 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
WriteAttributeValue("", 1062, Model.FigureTwo, 1062, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1081, 62, true);
            WriteLiteral("></div>\r\n                <h3 class=\"text-center\"><u id=\"user\">");
            EndContext();
            BeginContext(1144, 17, false);
#line 29 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
                                                Write(Model.UserNameTwo);

#line default
#line hidden
            EndContext();
            BeginContext(1161, 70, true);
            WriteLiteral(" </u><b>&ensp;&ensp;&ensp; VS &ensp;&ensp;&ensp;</b> <span id=\"enemy\">");
            EndContext();
            BeginContext(1232, 17, false);
#line 29 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
                                                                                                                                        Write(Model.UserNameOne);

#line default
#line hidden
            EndContext();
            BeginContext(1249, 51, true);
            WriteLiteral("</span></h3>\r\n                <div id=\"enemyFigure\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1300, "\"", 1326, 1);
#line 30 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
WriteAttributeValue("", 1308, Model.FigureOne, 1308, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1327, 9, true);
            WriteLiteral("></div>\r\n");
            EndContext();
#line 31 "C:\Users\sasch\source\repos\cross-zero\cross-zero\Views\Game\Game.cshtml"
            }


#line default
#line hidden
            BeginContext(1353, 47, true);
            WriteLiteral("            <input type=\"hidden\" id=\"move\" />\r\n");
            EndContext();
            BeginContext(1413, 791, true);
            WriteLiteral(@"    </div>

    <br />

    <div id=""timer"" style=""font-size:20px;    margin-left: 44%;"">
        <p id=""moveUser"" class=""float-left"" ></p><span id=""my_timer"" style=""font-weight: bold;"">01:00</span>
    </div>

    <br />

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
            BeginContext(2204, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e522f4c40a3d8071924832c8a154f2539c916c711514", async() => {
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
            BeginContext(2266, 582, true);
            WriteLiteral(@"
<script type=""text/javascript"">

    $(document.body).ready(function () {

        if ($('#figureUser').val() == ""cross"") {

            $('#move').val(""user"");
            $('#moveUser').append(""You move : "");


        }
        else {

            $('#move').val(""enemy"");
            $('#moveUser').append(""Enemy move : "");

            var cells = $('.gameCell');

            for (var i = 0; i < cells.length; i++) {

                cells[i].classList.add('cellDisabled');

            }


        }

        startTimer();

    });

</script>");
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
