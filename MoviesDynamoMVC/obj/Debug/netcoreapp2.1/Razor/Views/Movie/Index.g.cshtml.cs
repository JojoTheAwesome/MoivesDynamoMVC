#pragma checksum "C:\Users\User\source\repos\MoviesDynamoMVC\MoviesDynamoMVC\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20f7221a7145f6e8e24ede17ee7bcedf39e73121"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/Index.cshtml", typeof(AspNetCore.Views_Movie_Index))]
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
#line 1 "C:\Users\User\source\repos\MoviesDynamoMVC\MoviesDynamoMVC\Views\_ViewImports.cshtml"
using MoviesDynamoMVC;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\MoviesDynamoMVC\MoviesDynamoMVC\Views\_ViewImports.cshtml"
using MoviesDynamoMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20f7221a7145f6e8e24ede17ee7bcedf39e73121", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a9ce235449b6622a0298d56a2e8b802e188b661", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieRank.Libs.Models.MovieDb>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\source\repos\MoviesDynamoMVC\MoviesDynamoMVC\Views\Movie\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(94, 20, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\User\source\repos\MoviesDynamoMVC\MoviesDynamoMVC\Views\Movie\Index.cshtml"
 if (User.Identity.IsAuthenticated) {

#line default
#line hidden
            BeginContext(153, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(160, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cd705b4fd0e4736a09caa4b56208ebd", async() => {
                BeginContext(183, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(197, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 11 "C:\Users\User\source\repos\MoviesDynamoMVC\MoviesDynamoMVC\Views\Movie\Index.cshtml"
}

#line default
#line hidden
            BeginContext(206, 84, true);
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(291, 45, false);
#line 16 "C:\Users\User\source\repos\MoviesDynamoMVC\MoviesDynamoMVC\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MovieName));

#line default
#line hidden
            EndContext();
            BeginContext(336, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(392, 47, false);
#line 19 "C:\Users\User\source\repos\MoviesDynamoMVC\MoviesDynamoMVC\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(439, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(495, 45, false);
#line 22 "C:\Users\User\source\repos\MoviesDynamoMVC\MoviesDynamoMVC\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MainActor));

#line default
#line hidden
            EndContext();
            BeginContext(540, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(596, 43, false);
#line 25 "C:\Users\User\source\repos\MoviesDynamoMVC\MoviesDynamoMVC\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ranking));

#line default
#line hidden
            EndContext();
            BeginContext(639, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(695, 50, false);
#line 28 "C:\Users\User\source\repos\MoviesDynamoMVC\MoviesDynamoMVC\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RankedDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(745, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "C:\Users\User\source\repos\MoviesDynamoMVC\MoviesDynamoMVC\Views\Movie\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(863, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(912, 44, false);
#line 37 "C:\Users\User\source\repos\MoviesDynamoMVC\MoviesDynamoMVC\Views\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MovieName));

#line default
#line hidden
            EndContext();
            BeginContext(956, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1012, 46, false);
#line 40 "C:\Users\User\source\repos\MoviesDynamoMVC\MoviesDynamoMVC\Views\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1058, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1114, 44, false);
#line 43 "C:\Users\User\source\repos\MoviesDynamoMVC\MoviesDynamoMVC\Views\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MainActor));

#line default
#line hidden
            EndContext();
            BeginContext(1158, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1214, 42, false);
#line 46 "C:\Users\User\source\repos\MoviesDynamoMVC\MoviesDynamoMVC\Views\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ranking));

#line default
#line hidden
            EndContext();
            BeginContext(1256, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1312, 49, false);
#line 49 "C:\Users\User\source\repos\MoviesDynamoMVC\MoviesDynamoMVC\Views\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RankedDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(1361, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1418, "\"", 1468, 4);
            WriteAttributeValue("", 1425, "/Movie/Details/", 1425, 15, true);
#line 52 "C:\Users\User\source\repos\MoviesDynamoMVC\MoviesDynamoMVC\Views\Movie\Index.cshtml"
WriteAttributeValue("", 1440, item.UserId, 1440, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1452, "/", 1452, 1, true);
#line 52 "C:\Users\User\source\repos\MoviesDynamoMVC\MoviesDynamoMVC\Views\Movie\Index.cshtml"
WriteAttributeValue("", 1453, item.MovieName, 1453, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1469, 14, true);
            WriteLiteral(">Details</a>\r\n");
            EndContext();
#line 53 "C:\Users\User\source\repos\MoviesDynamoMVC\MoviesDynamoMVC\Views\Movie\Index.cshtml"
                 if (User.Identity.IsAuthenticated && (MoviesDynamoMVC.Controllers.AuthController.current.UserId == item.UserId || MoviesDynamoMVC.Controllers.AuthController.current.IsAdmin)) {
                    

#line default
#line hidden
            BeginContext(1699, 85, false);
#line 54 "C:\Users\User\source\repos\MoviesDynamoMVC\MoviesDynamoMVC\Views\Movie\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.UserId, movieName = item.MovieName }));

#line default
#line hidden
            EndContext();
#line 54 "C:\Users\User\source\repos\MoviesDynamoMVC\MoviesDynamoMVC\Views\Movie\Index.cshtml"
                                                                                                          
                }

#line default
#line hidden
            BeginContext(1805, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 56 "C:\Users\User\source\repos\MoviesDynamoMVC\MoviesDynamoMVC\Views\Movie\Index.cshtml"
                 if (User.Identity.IsAuthenticated && (MoviesDynamoMVC.Controllers.AuthController.current.UserId == item.UserId || MoviesDynamoMVC.Controllers.AuthController.current.IsAdmin)) {
                    

#line default
#line hidden
            BeginContext(2021, 89, false);
#line 57 "C:\Users\User\source\repos\MoviesDynamoMVC\MoviesDynamoMVC\Views\Movie\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.UserId, movieName = item.MovieName }));

#line default
#line hidden
            EndContext();
#line 57 "C:\Users\User\source\repos\MoviesDynamoMVC\MoviesDynamoMVC\Views\Movie\Index.cshtml"
                                                                                                              
                }

#line default
#line hidden
            BeginContext(2131, 52, true);
            WriteLiteral("                \r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 62 "C:\Users\User\source\repos\MoviesDynamoMVC\MoviesDynamoMVC\Views\Movie\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2186, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MovieRank.Libs.Models.MovieDb>> Html { get; private set; }
    }
}
#pragma warning restore 1591