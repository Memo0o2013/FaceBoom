#pragma checksum "E:\ITI\MVC\MiniFacebookApp\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\whoLikePost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e164560bf3a219c518c5b7cff600940ce4a5f1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_whoLikePost), @"mvc.1.0.view", @"/Views/Profile/whoLikePost.cshtml")]
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
#line 1 "E:\ITI\MVC\MiniFacebookApp\FaceBoom\MiniFacebook\MiniFacebook\Views\_ViewImports.cshtml"
using MiniFacebook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ITI\MVC\MiniFacebookApp\FaceBoom\MiniFacebook\MiniFacebook\Views\_ViewImports.cshtml"
using MiniFacebook.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\ITI\MVC\MiniFacebookApp\FaceBoom\MiniFacebook\MiniFacebook\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\ITI\MVC\MiniFacebookApp\FaceBoom\MiniFacebook\MiniFacebook\Views\_ViewImports.cshtml"
using MiniFacebook.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\ITI\MVC\MiniFacebookApp\FaceBoom\MiniFacebook\MiniFacebook\Views\_ViewImports.cshtml"
using MiniFacebook.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e164560bf3a219c518c5b7cff600940ce4a5f1e", @"/Views/Profile/whoLikePost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"644a2df16fbc5366d82a51025a405f15a86c2fc5", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_whoLikePost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("circle img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 5 "E:\ITI\MVC\MiniFacebookApp\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\whoLikePost.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12\" style=\"margin-top:3%;padding:3%\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4e164560bf3a219c518c5b7cff600940ce4a5f1e4771", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 258, "~/Images/", 258, 9, true);
            AddHtmlAttributeValue("", 267, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
                                             
#nullable restore
#line 8 "E:\ITI\MVC\MiniFacebookApp\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\whoLikePost.cshtml"
                        Write(item.ProfilePic);

#line default
#line hidden
#nullable disable
                                                             
                PopWriter();
            }
            ), 267, 19, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <a href=\"#\" class=\"btn-link\" style=\"float:left;margin-left:2%;margin-top:2%;\"><h6");
            BeginWriteAttribute("class", " class=\"", 425, "\"", 433, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 9 "E:\ITI\MVC\MiniFacebookApp\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\whoLikePost.cshtml"
                                                                                              Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "E:\ITI\MVC\MiniFacebookApp\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\whoLikePost.cshtml"
                                                                                                              Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></a>\r\n    </div>\r\n");
#nullable restore
#line 11 "E:\ITI\MVC\MiniFacebookApp\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\whoLikePost.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
