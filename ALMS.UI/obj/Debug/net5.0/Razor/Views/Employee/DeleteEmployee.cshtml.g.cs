#pragma checksum "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03d9dd00ea0c9d97c7c0aa6e72336a0d97d85512"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_DeleteEmployee), @"mvc.1.0.view", @"/Views/Employee/DeleteEmployee.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\_ViewImports.cshtml"
using ALMS.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\_ViewImports.cshtml"
using ALMS.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03d9dd00ea0c9d97c7c0aa6e72336a0d97d85512", @"/Views/Employee/DeleteEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94e882ceecf902ff373e0e873e2d167be3963b7a", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_DeleteEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ALMS.API.Models.MsemployeeDetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EmployeeIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteEmployee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n");
#nullable restore
#line 5 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
   ViewData["Title"] = "DeleteEmployee"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<h1>DeleteEmployee</h1>\n\n\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>MsemployeeDetail</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 19 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 22 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 25 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeDob));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 28 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeDob));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 31 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeAge));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 34 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeAge));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 37 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeePhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 40 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayFor(model => model.EmployeePhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 43 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeEmailId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 46 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeEmailId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 49 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 52 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 55 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeDesignation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 58 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeDesignation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 61 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeJoiningDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 64 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeJoiningDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 67 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayNameFor(model => model.ManagerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 70 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayFor(model => model.ManagerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 73 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 76 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 79 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 82 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayFor(model => model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 85 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 88 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 91 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 94 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 97 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 100 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 103 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayNameFor(model => model.DeletedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 106 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayFor(model => model.DeletedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 109 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayNameFor(model => model.DeletedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 112 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
       Write(Html.DisplayFor(model => model.DeletedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03d9dd00ea0c9d97c7c0aa6e72336a0d97d8551215381", async() => {
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "03d9dd00ea0c9d97c7c0aa6e72336a0d97d8551215646", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 117 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Employee\DeleteEmployee.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.EmployeeId);

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
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03d9dd00ea0c9d97c7c0aa6e72336a0d97d8551217448", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ALMS.API.Models.MsemployeeDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
