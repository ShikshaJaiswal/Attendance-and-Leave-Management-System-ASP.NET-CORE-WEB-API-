#pragma checksum "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Project\ProjectDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2831c4f70a372322f745dafb2748ebdac8c240bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_ProjectDetails), @"mvc.1.0.view", @"/Views/Project/ProjectDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2831c4f70a372322f745dafb2748ebdac8c240bf", @"/Views/Project/ProjectDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94e882ceecf902ff373e0e873e2d167be3963b7a", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_ProjectDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ALMS.UI.Models.MsprojectDetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProjectIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Project\ProjectDetails.cshtml"
  
    ViewData["Title"] = "ProjectDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ProjectDetails</h1>\r\n\r\n<div>\r\n    <h4>MsprojectDetail</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Project\ProjectDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ProjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Project\ProjectDetails.cshtml"
       Write(Html.DisplayFor(model => model.ProjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Project\ProjectDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ProjectTechnology));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Project\ProjectDetails.cshtml"
       Write(Html.DisplayFor(model => model.ProjectTechnology));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Project\ProjectDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ProjectStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Project\ProjectDetails.cshtml"
       Write(Html.DisplayFor(model => model.ProjectStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Project\ProjectDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ProjectEndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Project\ProjectDetails.cshtml"
       Write(Html.DisplayFor(model => model.ProjectEndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Project\ProjectDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Project\ProjectDetails.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Project\ProjectDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Project\ProjectDetails.cshtml"
       Write(Html.DisplayFor(model => model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Project\ProjectDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Project\ProjectDetails.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Project\ProjectDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Project\ProjectDetails.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Project\ProjectDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Project\ProjectDetails.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
            WriteLiteral("    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 82 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Project\ProjectDetails.cshtml"
Write(Html.ActionLink("Edit", "EditProject", new { ProjectId = Model.ProjectId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2831c4f70a372322f745dafb2748ebdac8c240bf10210", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ALMS.UI.Models.MsprojectDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591