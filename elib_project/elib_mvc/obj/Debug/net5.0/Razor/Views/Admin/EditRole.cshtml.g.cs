#pragma checksum "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31bc40091dd2f08c2902443cac16b14e4ee139e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditRole), @"mvc.1.0.view", @"/Views/Admin/EditRole.cshtml")]
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
#line 1 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\_ViewImports.cshtml"
using elib_mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\_ViewImports.cshtml"
using elib_mvc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\_ViewImports.cshtml"
using elib_entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\_ViewImports.cshtml"
using elib_mvc.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31bc40091dd2f08c2902443cac16b14e4ee139e7", @"/Views/Admin/EditRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02d29528eb9ea13f4a30cb44f8b101a3a1d0eb36", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "editrole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditRole.cshtml"
  
    Layout = "_Layout2";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2 class=\"text-center\">Edit Role</h2>\r\n<hr>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31bc40091dd2f08c2902443cac16b14e4ee139e74579", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"RoleId\"");
                BeginWriteAttribute("value", " value=\"", 190, "\"", 212, 1);
#nullable restore
#line 8 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditRole.cshtml"
WriteAttributeValue("", 198, Model.Role.Id, 198, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <input type=\"hidden\" name=\"RoleName\"");
                BeginWriteAttribute("value", " value=\"", 256, "\"", 280, 1);
#nullable restore
#line 9 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditRole.cshtml"
WriteAttributeValue("", 264, Model.Role.Name, 264, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <h6 class=\"bg-info text-white p-1\">Add to ");
#nullable restore
#line 10 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditRole.cshtml"
                                         Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n    <table class=\"table table-bordered table-sm\">\r\n");
#nullable restore
#line 12 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditRole.cshtml"
         if (Model.NonMembers.Count() == 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td colspan=\"2\">All users have a role</td>\r\n            </tr>\r\n");
#nullable restore
#line 17 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditRole.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditRole.cshtml"
             foreach (var user in Model.NonMembers)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditRole.cshtml"
                   Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td><input type=\"checkbox\" name=\"IdsToAdd\"");
                BeginWriteAttribute("value", " value=\"", 790, "\"", 806, 1);
#nullable restore
#line 24 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditRole.cshtml"
WriteAttributeValue("", 798, user.Id, 798, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></td>\r\n                </tr>\r\n");
#nullable restore
#line 26 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditRole.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditRole.cshtml"
             
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n    <hr>\r\n    <h6 class=\"bg-info text-white p-1\">Remove from ");
#nullable restore
#line 30 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditRole.cshtml"
                                              Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n    <table class=\"table table-bordered table-sm\">\r\n");
#nullable restore
#line 32 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditRole.cshtml"
         if (Model.Members.Count() == 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td colspan=\"2\">No User In This Role</td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditRole.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditRole.cshtml"
             foreach (var user in Model.Members)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 43 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditRole.cshtml"
                   Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td><input type=\"checkbox\" name=\"IdsToDelete\"");
                BeginWriteAttribute("value", " value=\"", 1395, "\"", 1411, 1);
#nullable restore
#line 44 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditRole.cshtml"
WriteAttributeValue("", 1403, user.Id, 1403, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></td>\r\n                </tr>\r\n");
#nullable restore
#line 46 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditRole.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditRole.cshtml"
             
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n    <button type=\"submit\" style=\"width: 400px; margin-left: 400px;\" class=\"btn btn-success\">Save</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
