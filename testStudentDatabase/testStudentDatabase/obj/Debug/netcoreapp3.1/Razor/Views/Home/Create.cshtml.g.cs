#pragma checksum "C:\Users\os\source\repos\testStudentDatabase\testStudentDatabase\Views\Home\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97f6048bf928554ae4f562ababd1c8ce50b960cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Create), @"mvc.1.0.view", @"/Views/Home/Create.cshtml")]
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
#line 1 "C:\Users\os\source\repos\testStudentDatabase\testStudentDatabase\Views\_ViewImports.cshtml"
using testStudentDatabase;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\os\source\repos\testStudentDatabase\testStudentDatabase\Views\_ViewImports.cshtml"
using testStudentDatabase.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97f6048bf928554ae4f562ababd1c8ce50b960cd", @"/Views/Home/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f427c77193c8bdf6039a3524c3a242b3c1307d16", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/home/createstudent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\os\source\repos\testStudentDatabase\testStudentDatabase\Views\Home\Create.cshtml"
  
    ViewData["Title"] = "ds hoc sinh";
    string[] TableHeader = new string[] {"ID",
          "Name",
          "Adress","DiemTB","Class"};


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h2>them  sinh vien</h2>\r\n");
#nullable restore
#line 12 "C:\Users\os\source\repos\testStudentDatabase\testStudentDatabase\Views\Home\Create.cshtml"
Write(ViewBag.error);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div");
            BeginWriteAttribute("class", " class=\"", 209, "\"", 217, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97f6048bf928554ae4f562ababd1c8ce50b960cd4666", async() => {
                WriteLiteral("\r\n\r\n        <div");
                BeginWriteAttribute("class", " class=\"", 290, "\"", 298, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            <label>\r\n                ID\r\n            </label>\r\n\r\n            <input type=\"number\" name=\"ID\"");
                BeginWriteAttribute("value", " value=\"", 409, "\"", 417, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n        <div");
                BeginWriteAttribute("class", " class=\"", 451, "\"", 459, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            <label>\r\n                Name\r\n            </label>\r\n\r\n            <input type=\"text\" name=\"Name\"");
                BeginWriteAttribute("value", " value=\"", 572, "\"", 580, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n        <div");
                BeginWriteAttribute("class", " class=\"", 614, "\"", 622, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            <label>\r\n                Adress\r\n            </label>\r\n\r\n            <input type=\"text\" name=\"Adress\"");
                BeginWriteAttribute("value", " value=\"", 739, "\"", 747, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n        <div");
                BeginWriteAttribute("class", " class=\"", 781, "\"", 789, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            <label>\r\n                DiemTB\r\n            </label>\r\n\r\n            <input type=\"number\" name=\"DiemTB\"");
                BeginWriteAttribute("value", " value=\"", 908, "\"", 916, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n        <div");
                BeginWriteAttribute("class", " class=\"", 950, "\"", 958, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            <label>\r\n                Class\r\n            </label>\r\n\r\n            <input type=\"text\" name=\"Class\"");
                BeginWriteAttribute("value", " value=\"", 1073, "\"", 1081, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n\r\n        <input type=\"submit\"");
                BeginWriteAttribute("name", " name=\"", 1133, "\"", 1140, 0);
                EndWriteAttribute();
                WriteLiteral(" value=\"them\">\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<style>\r\n");
            WriteLiteral("</style>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
