#pragma checksum "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9eee049e66a0c5a387247da43e9a5cc62d86cd09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Games_Edit), @"mvc.1.0.view", @"/Views/Games/Edit.cshtml")]
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
#line 1 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\_ViewImports.cshtml"
using GameStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\_ViewImports.cshtml"
using GameStore.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\_ViewImports.cshtml"
using GameStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\_ViewImports.cshtml"
using GameStore.Models.Games;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\_ViewImports.cshtml"
using GameStore.Models.Sellers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\_ViewImports.cshtml"
using GameStore.Models.Reviews;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\_ViewImports.cshtml"
using GameStore.Models.DownloadableContents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\_ViewImports.cshtml"
using GameStore.Services.Games;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\_ViewImports.cshtml"
using GameStore.Services.Sellers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\_ViewImports.cshtml"
using GameStore.Services.DownloadableContents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\_ViewImports.cshtml"
using GameStore.Services.Reviews;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\_ViewImports.cshtml"
using GameStore.Services.ShoppingCart;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9eee049e66a0c5a387247da43e9a5cc62d86cd09", @"/Views/Games/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7da3dc87d729748a39a058ba958a3ef6859a6493", @"/Views/_ViewImports.cshtml")]
    public class Views_Games_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GameFormModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_GameFormPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Edit.cshtml"
  
    ViewBag.Title = "Edit Game";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9eee049e66a0c5a387247da43e9a5cc62d86cd095985", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 7 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9eee049e66a0c5a387247da43e9a5cc62d86cd097658", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GameFormModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
