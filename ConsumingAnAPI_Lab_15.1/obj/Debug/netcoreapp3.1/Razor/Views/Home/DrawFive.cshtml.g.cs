#pragma checksum "C:\Users\skatrivesis\OneDrive - KNEX\Documents\GrandCircus\Labs\ConsumingAnAPI_Lab_15.1\ConsumingAnAPI_Lab_15.1\Views\Home\DrawFive.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e135e6a8512a12b07a5b40dd6c9b8a23d08fa35f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DrawFive), @"mvc.1.0.view", @"/Views/Home/DrawFive.cshtml")]
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
#line 1 "C:\Users\skatrivesis\OneDrive - KNEX\Documents\GrandCircus\Labs\ConsumingAnAPI_Lab_15.1\ConsumingAnAPI_Lab_15.1\Views\_ViewImports.cshtml"
using ConsumingAnAPI_Lab_15._1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\skatrivesis\OneDrive - KNEX\Documents\GrandCircus\Labs\ConsumingAnAPI_Lab_15.1\ConsumingAnAPI_Lab_15.1\Views\_ViewImports.cshtml"
using ConsumingAnAPI_Lab_15._1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e135e6a8512a12b07a5b40dd6c9b8a23d08fa35f", @"/Views/Home/DrawFive.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02ec4869c1d029f413fbb958d95927d9793e5dd6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DrawFive : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Deck>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\skatrivesis\OneDrive - KNEX\Documents\GrandCircus\Labs\ConsumingAnAPI_Lab_15.1\ConsumingAnAPI_Lab_15.1\Views\Home\DrawFive.cshtml"
  
    ViewData["Title"] = "DrawFive";
    int numItems = Model.Cards.Length;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>DrawFive</h1>\r\n\r\n<table>\r\n");
#nullable restore
#line 10 "C:\Users\skatrivesis\OneDrive - KNEX\Documents\GrandCircus\Labs\ConsumingAnAPI_Lab_15.1\ConsumingAnAPI_Lab_15.1\Views\Home\DrawFive.cshtml"
     for (int i = 0; i < numItems; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td><img title=\"Playing Card\"");
            BeginWriteAttribute("src", " src=\"", 244, "\"", 271, 1);
#nullable restore
#line 13 "C:\Users\skatrivesis\OneDrive - KNEX\Documents\GrandCircus\Labs\ConsumingAnAPI_Lab_15.1\ConsumingAnAPI_Lab_15.1\Views\Home\DrawFive.cshtml"
WriteAttributeValue("", 250, Model.Cards[i].Image, 250, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n            </tr>\r\n");
#nullable restore
#line 15 "C:\Users\skatrivesis\OneDrive - KNEX\Documents\GrandCircus\Labs\ConsumingAnAPI_Lab_15.1\ConsumingAnAPI_Lab_15.1\Views\Home\DrawFive.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
