#pragma checksum "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Reviews\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e69104cd3ad48a8132c3af7d18c533b039e1e2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reviews_All), @"mvc.1.0.view", @"/Views/Reviews/All.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e69104cd3ad48a8132c3af7d18c533b039e1e2e", @"/Views/Reviews/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f2066fee634286a2bcef9d7ed5b2e19847513c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Reviews_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ReviewServiceModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reviews", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure you want to delete?\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <div class=\"card-body text-center\">\r\n        <h4 class=\"card-title\">All Reviews</h4>\r\n    </div>\r\n    <div class=\"comment-widgets\">\r\n");
#nullable restore
#line 8 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Reviews\All.cshtml"
         foreach (var review in Model.Reverse())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""d-flex flex-row comment-row m-t-0 review-border"">
                <div class=""p-2""><img src=""https://i.imgur.com/Ur43esv.jpg"" alt=""user"" width=""50"" class=""rounded-circle""></div>
                <div>
                    <h6 class=""font-medium"">");
#nullable restore
#line 13 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Reviews\All.cshtml"
                                       Write(review.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6> <span>");
#nullable restore
#line 13 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Reviews\All.cshtml"
                                                                      Write(review.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span>\r\n");
#nullable restore
#line 15 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Reviews\All.cshtml"
                         if (this.User.Id() == review.UserId || User.IsAdmin())
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e69104cd3ad48a8132c3af7d18c533b039e1e2e8807", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Reviews\All.cshtml"
                                                                            WriteLiteral(review.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e69104cd3ad48a8132c3af7d18c533b039e1e2e11316", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Reviews\All.cshtml"
                                                                              WriteLiteral(review.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Reviews\All.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </span>\r\n                    <div class=\"comment-footer\">\r\n                        <span class=\"text-muted\">");
#nullable restore
#line 22 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Reviews\All.cshtml"
                                            Write(review.PostedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 26 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Reviews\All.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ReviewServiceModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
