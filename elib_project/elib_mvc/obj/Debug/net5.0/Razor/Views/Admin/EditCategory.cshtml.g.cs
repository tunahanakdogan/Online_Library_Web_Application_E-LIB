#pragma checksum "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84fb276dcff042e9335ef6e07b5758590df9a4d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditCategory), @"mvc.1.0.view", @"/Views/Admin/EditCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84fb276dcff042e9335ef6e07b5758590df9a4d2", @"/Views/Admin/EditCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02d29528eb9ea13f4a30cb44f8b101a3a1d0eb36", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "editcategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "deletebookfromcategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
  
    Layout = "_Layout2";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2 class=\"text-center\">Edit Category</h2>\r\n<hr>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84fb276dcff042e9335ef6e07b5758590df9a4d27726", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"categoryId\"");
                BeginWriteAttribute("value", " value=\"", 281, "\"", 306, 1);
#nullable restore
#line 10 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 289, Model.categoryId, 289, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <div class=\"form-group row\">\r\n                <label class=\"col-sm2 col-form-laber\">Name</label>\r\n                <div class=\"col-sm-10\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "84fb276dcff042e9335ef6e07b5758590df9a4d28601", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 14 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84fb276dcff042e9335ef6e07b5758590df9a4d210405", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 15 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group row\">\r\n                <label class=\"col-sm2 col-form-laber\">Name Url</label>\r\n                <div class=\"col-sm-10\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "84fb276dcff042e9335ef6e07b5758590df9a4d212292", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 23 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.url);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84fb276dcff042e9335ef6e07b5758590df9a4d214096", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 24 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.url);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
            </div>
            <div style=""background-color: white; color:white; heigth: 20px"" class=""container"">space</div>
            <div class=""form-group row"">
                <div class=""col-sm-10 offset-sm-2"">
                    <button style=""width:200px;"" type=""submit"" class=""btn btn-success"">Save</button>
                </div>
            </div>
            <div id=""books"">
");
#nullable restore
#line 34 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
                 for (int i = 0; i < Model.Books.Count; i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1521, "\"", 1544, 3);
                WriteAttributeValue("", 1528, "books[", 1528, 6, true);
#nullable restore
#line 36 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 1534, i, 1534, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1536, "].bookId", 1536, 8, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1545, "\"", 1576, 1);
#nullable restore
#line 36 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 1553, Model.Books[@i].bookId, 1553, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1620, "\"", 1641, 3);
                WriteAttributeValue("", 1627, "books[", 1627, 6, true);
#nullable restore
#line 37 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 1633, i, 1633, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1635, "].name", 1635, 6, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1642, "\"", 1671, 1);
#nullable restore
#line 37 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 1650, Model.Books[@i].name, 1650, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1715, "\"", 1738, 3);
                WriteAttributeValue("", 1722, "books[", 1722, 6, true);
#nullable restore
#line 38 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 1728, i, 1728, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1730, "].author", 1730, 8, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1739, "\"", 1770, 1);
#nullable restore
#line 38 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 1747, Model.Books[@i].author, 1747, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1814, "\"", 1842, 3);
                WriteAttributeValue("", 1821, "books[", 1821, 6, true);
#nullable restore
#line 39 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 1827, i, 1827, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1829, "].description", 1829, 13, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1843, "\"", 1879, 1);
#nullable restore
#line 39 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 1851, Model.Books[@i].description, 1851, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1923, "\"", 1946, 3);
                WriteAttributeValue("", 1930, "books[", 1930, 6, true);
#nullable restore
#line 40 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 1936, i, 1936, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1938, "].imgUrl", 1938, 8, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1947, "\"", 1978, 1);
#nullable restore
#line 40 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 1955, Model.Books[@i].imgUrl, 1955, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 41 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""col-md-8"">

        <table class=""table table-bordered table-sm"">
            <thead>
                <tr>
                    <td>Id</td>
                    <td>Name</td>
                    <td>Author</td>
                    <td>Description</td>
                    <td>Image Url</td>

                </tr>

            </thead>
            <tbody>
");
#nullable restore
#line 60 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
                 if (Model.Books.Count > 0)
                {

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
                     foreach (var item in Model.Books)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 66 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
                           Write(item.bookId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 67 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
                           Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 68 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
                           Write(item.author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 69 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
                           Write(item.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 70 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
                           Write(item.imgUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84fb276dcff042e9335ef6e07b5758590df9a4d225213", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
                                                                                  WriteLiteral(item.bookId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84fb276dcff042e9335ef6e07b5758590df9a4d227726", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"bookId\"");
                BeginWriteAttribute("value", " value=\"", 3322, "\"", 3342, 1);
#nullable restore
#line 76 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 3330, item.bookId, 3330, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <input type=\"hidden\" name=\"categoryId\"");
                BeginWriteAttribute("value", " value=\"", 3420, "\"", 3445, 1);
#nullable restore
#line 77 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 3428, Model.categoryId, 3428, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <button class=\"btn btn-danger btn-sm mr-2\" type=\"submit\">Delete</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 83 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-warning\">\r\n                        <h2>No Books Added</h2>\r\n                    </div>\r\n");
#nullable restore
#line 90 "C:\Users\tunah\Desktop\elib_project\elib_mvc\Views\Admin\EditCategory.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591