#pragma checksum "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\ConsumingAnAPI_Lab_15.1\ConsumingAnAPI_Lab_15.1\Views\Home\CreateDeck.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09a0c798e429001003c10cd56c89d6b6bdf02b12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CreateDeck), @"mvc.1.0.view", @"/Views/Home/CreateDeck.cshtml")]
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
#line 1 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\ConsumingAnAPI_Lab_15.1\ConsumingAnAPI_Lab_15.1\Views\_ViewImports.cshtml"
using ConsumingAnAPI_Lab_15._1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\ConsumingAnAPI_Lab_15.1\ConsumingAnAPI_Lab_15.1\Views\_ViewImports.cshtml"
using ConsumingAnAPI_Lab_15._1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09a0c798e429001003c10cd56c89d6b6bdf02b12", @"/Views/Home/CreateDeck.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02ec4869c1d029f413fbb958d95927d9793e5dd6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CreateDeck : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Deck>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DrawFive", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("deckId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\ConsumingAnAPI_Lab_15.1\ConsumingAnAPI_Lab_15.1\Views\Home\CreateDeck.cshtml"
  
    ViewData["Title"] = "CreateDeck";
    ViewData["Deck_Id"] = Model.Deck_id;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>CreateDeck</h1>\r\n\r\n<table>\r\n    <tr>\r\n        <td>Deck ID: ");
#nullable restore
#line 11 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\ConsumingAnAPI_Lab_15.1\ConsumingAnAPI_Lab_15.1\Views\Home\CreateDeck.cshtml"
                Write(Model.Deck_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>Deck ID: ");
#nullable restore
#line 12 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\ConsumingAnAPI_Lab_15.1\ConsumingAnAPI_Lab_15.1\Views\Home\CreateDeck.cshtml"
                Write(Model.Deck_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 264, "\"", 300, 2);
            WriteAttributeValue("", 271, "/Home/DrawFive/", 271, 15, true);
#nullable restore
#line 15 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\ConsumingAnAPI_Lab_15.1\ConsumingAnAPI_Lab_15.1\Views\Home\CreateDeck.cshtml"
WriteAttributeValue("", 286, Model.Deck_id, 286, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title =\"deckId\"");
            BeginWriteAttribute("value", " value=\"", 317, "\"", 339, 1);
#nullable restore
#line 15 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\ConsumingAnAPI_Lab_15.1\ConsumingAnAPI_Lab_15.1\Views\Home\CreateDeck.cshtml"
WriteAttributeValue("", 325, Model.Deck_id, 325, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Draw five cards!</a></td>\r\n        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09a0c798e429001003c10cd56c89d6b6bdf02b126267", async() => {
                WriteLiteral("Draw Five");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "value", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 16 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\ConsumingAnAPI_Lab_15.1\ConsumingAnAPI_Lab_15.1\Views\Home\CreateDeck.cshtml"
AddHtmlAttributeValue("", 439, Model.Deck_id, 439, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<td>\r\n    </tr>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Deck> Html { get; private set; }
    }
}
#pragma warning restore 1591
