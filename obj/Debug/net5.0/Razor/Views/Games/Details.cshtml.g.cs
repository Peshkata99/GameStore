#pragma checksum "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd0e29a63445763662c1ce75781b48c7e3397332"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Games_Details), @"mvc.1.0.view", @"/Views/Games/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd0e29a63445763662c1ce75781b48c7e3397332", @"/Views/Games/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c0964be9e4de5800193ae8e63bdf449180f3a8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Games_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GameDetailsServiceModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reviews", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DownloadableContents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "All", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure you want to delete?\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-6\">\n        <div class=\"project-info-box mt-0\">\n            <h1>");
#nullable restore
#line 7 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Details.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n        </div><!-- / project-info-box -->\n        <div class=\"project-info-box\">\n            <p><b>Seller:</b> ");
#nullable restore
#line 10 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Details.cshtml"
                         Write(Model.SellerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p><b>Release Date:</b> ");
#nullable restore
#line 11 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Details.cshtml"
                               Write(Model.ReleaseDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p><b>Developer:</b> ");
#nullable restore
#line 12 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Details.cshtml"
                            Write(Model.Developer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p><b>Genre:</b> ");
#nullable restore
#line 13 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Details.cshtml"
                        Write(Model.GenreName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p><b>Price:</b> ");
#nullable restore
#line 14 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Details.cshtml"
                        Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</p>\n            <div>\n                <p>");
#nullable restore
#line 16 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Details.cshtml"
              Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </div>    \n        </div><!-- / project-info-box -->\n\n    </div>\n    <div class=\"col-md-6\">\n        <img");
            BeginWriteAttribute("src", " src=\"", 674, "\"", 695, 1);
#nullable restore
#line 22 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Details.cshtml"
WriteAttributeValue("", 680, Model.ImageUrl, 680, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"project-image\" class=\"rounded card-size-2\">\n        <div class=\"project-info-box\">\n            \n        </div><!-- / project-info-box -->\n    </div><!-- / column -->\n</div>\n\n<div>\n    <div>\n        <div class=\"custom-button\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd0e29a63445763662c1ce75781b48c7e339733211172", async() => {
                WriteLiteral("Add Review");
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
#line 32 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Details.cshtml"
                                                           WriteLiteral(Model.Id);

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
            WriteLiteral("\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd0e29a63445763662c1ce75781b48c7e339733213654", async() => {
                WriteLiteral("All Dlcs");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Details.cshtml"
                                                                        WriteLiteral(Model.Id);

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
            WriteLiteral("\n        </div>    \n");
#nullable restore
#line 35 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Details.cshtml"
         if (Model.Reviews.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h2 class=\"text-center\">There are currently no reviews.</h2>\r\n");
#nullable restore
#line 38 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Details.cshtml"

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Details.cshtml"
         if(Model.Reviews.Count() > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\n                 <div class=\"card-body text-center\">\n                     <h4 class=\"card-title\">Latest Reviews</h4>\n                 </div>\n                 <div class=\"comment-widgets\">\n");
#nullable restore
#line 47 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Details.cshtml"
                      foreach (var review in Model.Reviews.Reverse().Take(3))
                     {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""d-flex flex-row comment-row m-t-0 review-border"">
                            <div class=""p-2""><img src=""https://i.imgur.com/Ur43esv.jpg"" alt=""user"" width=""50"" class=""rounded-circle""></div>
                            <div>
                                <h6 class=""font-medium"">");
#nullable restore
#line 52 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Details.cshtml"
                                                   Write(review.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6> <span>");
#nullable restore
#line 52 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Details.cshtml"
                                                                                  Write(review.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                <span>\n");
#nullable restore
#line 54 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Details.cshtml"
                                 if (this.User.Id() == review.UserId || User.IsAdmin())
                                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd0e29a63445763662c1ce75781b48c7e339733218788", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Details.cshtml"
                                                                                    WriteLiteral(review.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd0e29a63445763662c1ce75781b48c7e339733221314", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Details.cshtml"
                                                                                      WriteLiteral(review.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 58 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Details.cshtml"
                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </span>\n                            <div class=\"comment-footer\">\n                                <span class=\"text-muted\">");
#nullable restore
#line 61 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Details.cshtml"
                                                    Write(review.PostedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                            </div>\n                            </div>\n                        </div>\n");
#nullable restore
#line 65 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                 </div> <!-- Card -->\n            <div class=\"custom-button\">\n                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd0e29a63445763662c1ce75781b48c7e339733224993", async() => {
                WriteLiteral("View All ");
#nullable restore
#line 68 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Details.cshtml"
                                                                                                                       Write(Model.Reviews.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral(" Reviews");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Details.cshtml"
                                                                    WriteLiteral(Model.Id);

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
            WriteLiteral("\n                </div>\n            </div>\r\n");
#nullable restore
#line 71 "C:\Users\Petar\Desktop\Project\GameStore\GameStore\GameStore\Views\Games\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \n    </div>\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GameDetailsServiceModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
