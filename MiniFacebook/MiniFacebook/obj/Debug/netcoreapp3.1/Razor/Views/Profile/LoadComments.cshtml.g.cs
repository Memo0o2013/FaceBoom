#pragma checksum "E:\ITI\MVC\MiniFacebook\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\LoadComments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b043abe65e03c30922ad35874c5a164c5aea48c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_LoadComments), @"mvc.1.0.view", @"/Views/Profile/LoadComments.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b043abe65e03c30922ad35874c5a164c5aea48c", @"/Views/Profile/LoadComments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"644a2df16fbc5366d82a51025a405f15a86c2fc5", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_LoadComments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Comment>>
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
            WriteLiteral("\r\n");
#nullable restore
#line 6 "E:\ITI\MVC\MiniFacebook\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\LoadComments.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\" row \" style=\"border-bottom:1px solid lightgray\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9b043abe65e03c30922ad35874c5a164c5aea48c5177", async() => {
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
            WriteLiteral("\r\n        <div class=\"col-8\">\r\n            <p class=\"usr-name ml-2\">Hazem Hammad</p>\r\n            <p style=\"margin-left:2.5%;margin-top:-5%\">");
#nullable restore
#line 12 "E:\ITI\MVC\MiniFacebook\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\LoadComments.cshtml"
                                                  Write(item.CommentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <p style=\"margin-left:17%;\" class=\"col-8 mb-4\">");
#nullable restore
#line 14 "E:\ITI\MVC\MiniFacebook\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\LoadComments.cshtml"
                                                  Write(item.CommentText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 15 "E:\ITI\MVC\MiniFacebook\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\LoadComments.cshtml"
          
            int flag = item.CommentLikes.Where(c => c.UserID == (string)ViewData["UID"]).ToList().Count;
            int x = 150;
            if (flag == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"btn btn-light offset-2\" style=\"margin-top:-4%\"");
            BeginWriteAttribute("id", " id=\"", 873, "\"", 902, 2);
            WriteAttributeValue("", 878, "likecomm_", 878, 9, true);
#nullable restore
#line 20 "E:\ITI\MVC\MiniFacebook\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\LoadComments.cshtml"
WriteAttributeValue("", 887, item.CommentID, 887, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 903, "\"", 941, 3);
            WriteAttributeValue("", 913, "likeComment(", 913, 12, true);
#nullable restore
#line 20 "E:\ITI\MVC\MiniFacebook\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\LoadComments.cshtml"
WriteAttributeValue("", 925, item.CommentID, 925, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 940, ")", 940, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-thumbs-up\"></i>Like</p>\r\n");
#nullable restore
#line 21 "E:\ITI\MVC\MiniFacebook\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\LoadComments.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"btn btn-primary offset-2\" style=\"margin-top:-4%\"");
            BeginWriteAttribute("id", " id=\"", 1106, "\"", 1135, 2);
            WriteAttributeValue("", 1111, "likecomm_", 1111, 9, true);
#nullable restore
#line 24 "E:\ITI\MVC\MiniFacebook\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\LoadComments.cshtml"
WriteAttributeValue("", 1120, item.CommentID, 1120, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1136, "\"", 1174, 3);
            WriteAttributeValue("", 1146, "likeComment(", 1146, 12, true);
#nullable restore
#line 24 "E:\ITI\MVC\MiniFacebook\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\LoadComments.cshtml"
WriteAttributeValue("", 1158, item.CommentID, 1158, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1173, ")", 1173, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-thumbs-up\"></i>Like</p>\r\n");
#nullable restore
#line 25 "E:\ITI\MVC\MiniFacebook\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\LoadComments.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 28 "E:\ITI\MVC\MiniFacebook\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\LoadComments.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
