#pragma checksum "E:\ITI\MVC\MiniFacebook\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\AddComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00f1c627fe0bf92b4e6b0e03d814e2e04f4f9602"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_AddComment), @"mvc.1.0.view", @"/Views/Profile/AddComment.cshtml")]
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
#line 1 "E:\ITI\MVC\MiniFacebook\FaceBoom\MiniFacebook\MiniFacebook\Views\_ViewImports.cshtml"
using MiniFacebook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ITI\MVC\MiniFacebook\FaceBoom\MiniFacebook\MiniFacebook\Views\_ViewImports.cshtml"
using MiniFacebook.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\ITI\MVC\MiniFacebook\FaceBoom\MiniFacebook\MiniFacebook\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\ITI\MVC\MiniFacebook\FaceBoom\MiniFacebook\MiniFacebook\Views\_ViewImports.cshtml"
using MiniFacebook.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\ITI\MVC\MiniFacebook\FaceBoom\MiniFacebook\MiniFacebook\Views\_ViewImports.cshtml"
using MiniFacebook.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00f1c627fe0bf92b4e6b0e03d814e2e04f4f9602", @"/Views/Profile/AddComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"644a2df16fbc5366d82a51025a405f15a86c2fc5", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_AddComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Comment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/man58.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("circle img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left:5%; margin-top:2%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\" row \" style=\"border-bottom:1px solid lightgray\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "00f1c627fe0bf92b4e6b0e03d814e2e04f4f96024905", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <div class=\"col-8\">\r\n        <p class=\"usr-name ml-2\">Hazem Hammad</p>\r\n        <p style=\"margin-left:2.5%;margin-top:-5%\">");
#nullable restore
#line 9 "E:\ITI\MVC\MiniFacebook\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\AddComment.cshtml"
                                              Write(Model.CommentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <p style=\"margin-left:17%;\" class=\"col-8 mb-4\">");
#nullable restore
#line 11 "E:\ITI\MVC\MiniFacebook\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\AddComment.cshtml"
                                              Write(Model.CommentText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p class=\"btn btn-light offset-2\"");
            BeginWriteAttribute("id", " id=\"", 577, "\"", 607, 2);
            WriteAttributeValue("", 582, "likecomm_", 582, 9, true);
#nullable restore
#line 12 "E:\ITI\MVC\MiniFacebook\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\AddComment.cshtml"
WriteAttributeValue("", 591, Model.CommentID, 591, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-top:-4%\"");
            BeginWriteAttribute("onclick", " onclick=\"", 631, "\"", 670, 3);
            WriteAttributeValue("", 641, "likeComment(", 641, 12, true);
#nullable restore
#line 12 "E:\ITI\MVC\MiniFacebook\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\AddComment.cshtml"
WriteAttributeValue("", 653, Model.CommentID, 653, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 669, ")", 669, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-thumbs-up\"></i>Like</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Comment> Html { get; private set; }
    }
}
#pragma warning restore 1591
