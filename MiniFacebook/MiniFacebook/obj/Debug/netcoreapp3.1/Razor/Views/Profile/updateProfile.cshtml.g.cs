#pragma checksum "E:\ITI\MVC\MiniFacebookApp\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\updateProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5bf977243fdc7cdb8dc720cc35fb187ab8121e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_updateProfile), @"mvc.1.0.view", @"/Views/Profile/updateProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5bf977243fdc7cdb8dc720cc35fb187ab8121e9", @"/Views/Profile/updateProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"644a2df16fbc5366d82a51025a405f15a86c2fc5", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_updateProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("circle img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("newProfilePic"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"container\" style=\"padding:6%;\">\r\n    <div class=\"row\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b5bf977243fdc7cdb8dc720cc35fb187ab8121e95610", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 221, "~/Images/", 221, 9, true);
            AddHtmlAttributeValue("", 230, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
                                             
#nullable restore
#line 7 "E:\ITI\MVC\MiniFacebookApp\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\updateProfile.cshtml"
                        Write(Model.ProfilePic);

#line default
#line hidden
#nullable disable
                                                              
                PopWriter();
            }
            ), 230, 20, false);
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
            WriteLiteral("\r\n        <div class=\"row d-inline-block\" style=\"margin-left:2px ;float:left;\">\r\n            <a href=\"#\" class=\"btn-link\"><h6 class=\"col-12\">");
#nullable restore
#line 9 "E:\ITI\MVC\MiniFacebookApp\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\updateProfile.cshtml"
                                                       Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "E:\ITI\MVC\MiniFacebookApp\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\updateProfile.cshtml"
                                                                        Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></a>\r\n            <p class=\"col-12 \">");
#nullable restore
#line 10 "E:\ITI\MVC\MiniFacebookApp\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\updateProfile.cshtml"
                          Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-6 mb-2\">\r\n            <input class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 667, "\"", 691, 1);
#nullable restore
#line 16 "E:\ITI\MVC\MiniFacebookApp\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\updateProfile.cshtml"
WriteAttributeValue("", 675, Model.FirstName, 675, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"newFname\" />\r\n        </div>\r\n        <div class=\"col-6 mb-2\">\r\n            <input class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 800, "\"", 823, 1);
#nullable restore
#line 19 "E:\ITI\MVC\MiniFacebookApp\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\updateProfile.cshtml"
WriteAttributeValue("", 808, Model.LastName, 808, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"newLname\" />\r\n        </div>\r\n        <div class=\"col-12 mb-2\">\r\n            <input class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 933, "\"", 951, 1);
#nullable restore
#line 22 "E:\ITI\MVC\MiniFacebookApp\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\updateProfile.cshtml"
WriteAttributeValue("", 941, Model.Bio, 941, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"newBio\" />\r\n        </div>\r\n        <div class=\"col-12 mb-2\">\r\n            <input class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1059, "\"", 1085, 1);
#nullable restore
#line 25 "E:\ITI\MVC\MiniFacebookApp\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\updateProfile.cshtml"
WriteAttributeValue("", 1067, Model.PhoneNumber, 1067, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"newPhone\" />\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 28 "E:\ITI\MVC\MiniFacebookApp\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\updateProfile.cshtml"
      
        if (Model.ProfilePic != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b5bf977243fdc7cdb8dc720cc35fb187ab8121e911068", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1213, "~/Images/", 1213, 9, true);
#nullable restore
#line 31 "E:\ITI\MVC\MiniFacebookApp\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\updateProfile.cshtml"
AddHtmlAttributeValue("", 1222, Model.ProfilePic, 1222, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 32 "E:\ITI\MVC\MiniFacebookApp\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\updateProfile.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img");
            BeginWriteAttribute("src", " src=\"", 1341, "\"", 1347, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"newProfilePic\" width=\"200\" height=\"200\" style=\"display:none\" />\r\n");
#nullable restore
#line 36 "E:\ITI\MVC\MiniFacebookApp\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\updateProfile.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr />\r\n    <input type=\"button\" class=\"btn animated-button\" value=\"Update\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1515, "\"", 1551, 3);
            WriteAttributeValue("", 1525, "updateProfile(\'", 1525, 15, true);
#nullable restore
#line 39 "E:\ITI\MVC\MiniFacebookApp\FaceBoom\MiniFacebook\MiniFacebook\Views\Profile\updateProfile.cshtml"
WriteAttributeValue("", 1540, Model.Id, 1540, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1549, "\')", 1549, 2, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
