#pragma checksum "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Account\GEmployeePortal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "334f12a7aaf189d2c750a2d4006bae848ffe9ac7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_GEmployeePortal), @"mvc.1.0.view", @"/Views/Account/GEmployeePortal.cshtml")]
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
#nullable restore
#line 1 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Account\GEmployeePortal.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"334f12a7aaf189d2c750a2d4006bae848ffe9ac7", @"/Views/Account/GEmployeePortal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94e882ceecf902ff373e0e873e2d167be3963b7a", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_GEmployeePortal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Account\GEmployeePortal.cshtml"
  
    ViewBag.Title = "GEmployeePortal";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Account\GEmployeePortal.cshtml"
 if (Context.Session.GetString("UserName") != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Hello ");
#nullable restore
#line 9 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Account\GEmployeePortal.cshtml"
         Write(Context.Session.GetString("UserName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 10 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Account\GEmployeePortal.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Account\GEmployeePortal.cshtml"
  
    var un = ViewBag.Message1;
    var eid = ViewBag.Message2;

    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    body, html {
        height: 100%;
        color: #777;
        line-height: 1.8;
    }

    body, h1, h2, h3, h4, h5, h6 {
        font-family: ""Karma"", sans-serif
    }

    .bar-block {
        padding: 20px
    }

    .bgimg-1 {
        background-attachment: fixed;
        background-position: center;
        background-repeat: no-repeat;
        background-size: cover;
        background-image: url('https://www.capgemini.com/gb-en/wp-content/uploads/sites/3/2020/02/flash_invent.png');
        min-height: 100%;
        background-attachment: scroll;
        min-height: 200px;
    }

    .wide {
        letter-spacing: 10px;
    }

    .sidebar {
        z-index: 3;
        width: 250px;
        top: 200px;
        bottom: 0;
        height: inherit;
    }

    .header {
        background-color: none;
        padding: 60px;
        text-align: center;
        font-size: 45px;
        color: white;
    }

    .card {
        box-shadow: 0 4px 8px ");
            WriteLiteral(@"0 rgba(0,0,0,0.2);
        transition: 0.3s;
        margin-left: 20px;
        text-align: center;
    }

        .card:hover {
            box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2);
        }


    .tab1cards {
        display: flex;
        flex-direction: row;
    }

    .container {
        padding: 2px 16px;
    }

    .nav {
        float: left;
        width: 15%;
        background-color: lavender;
        padding: 20px;
    }

    .menu {
        float: left;
        padding: 20px;
        width: 75%;
        background-color: white;
        margin-top: 0px;
    }
</style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "334f12a7aaf189d2c750a2d4006bae848ffe9ac76265", async() => {
                WriteLiteral(@"

    <div class=""top  bgimg-1 container"" id=""home"">
        <div class=""header"" style=""white-space:nowrap;"">
            <b>Attendance and Leave Management</b>
        </div>
    </div>
    <section>
        <nav class=""nav"">
            <div class=""container"">
                <img src=""https://thumbs.dreamstime.com/b/businessman-avatar-flat-icon-white-series-caucasian-black-jacket-blue-tie-isolated-background-eps-file-available-95459476.jpg"" style=""width:100%; display:flex;""><br><br>
                <h4 style=""color:black""><b>Employee Information</b></h4>
                <p style=""color:black;"">
                    UserName: ");
#nullable restore
#line 112 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Account\GEmployeePortal.cshtml"
                         Write(un);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    Employee Id: ");
#nullable restore
#line 113 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Account\GEmployeePortal.cshtml"
                            Write(eid);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </p>
            </div>
        </nav>
        <menu class=""menu"">
            <div class=""main"">

                <!-- Header -->
                <header id=""MENU"">
                    <div class=""container"" style=""color:Black"">
                        <h1><b>Menu</b></h1>
                    </div>
                </header>
                <div class=""row tab1cards"" style=""padding-left:20px"">
                    <div class=""card"" style=""width:150px;"">
                        <img src=""https://www.iconshock.com/image/Brilliant/Education/attendance_list"" alt=""attendance"" style=""width:150px"">
                        <div class=""container"" style=""background-color:lavender"">
                            <p style=""color:black; text-align:center;""><b>LeaveRequest</b></p>
");
                WriteLiteral("                            <input type=\"button\" value=\"Create New\" id=\"myButton1\"");
                BeginWriteAttribute("onClick", " onClick=\"", 3640, "\"", 3719, 4);
                WriteAttributeValue("", 3650, "window.location=", 3650, 16, true);
                WriteAttributeValue(" ", 3666, "\'", 3667, 2, true);
#nullable restore
#line 132 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Account\GEmployeePortal.cshtml"
WriteAttributeValue("", 3668, Url.Action( "CreateLeaveRequest", "LeaveRequest"), 3668, 50, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3718, "\'", 3718, 1, true);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                    </div>
                    
                    <div class=""card"" style=""width:150px;"">
                        <img src=""https://previews.123rf.com/images/pratyaksa/pratyaksa1607/pratyaksa160700087/59777801-programming-or-coding-icon-programming-editor-symbol-.jpg"" alt=""project"" style=""width:150px"">
                        <div class=""container"" style=""background-color:lavender"">
                            <p style=""color:black; text-align:center;""><b>Project</b></p>

                            <input type=""button"" value=""Login"" id=""myButton1""");
                BeginWriteAttribute("onClick", " onClick=\"", 4336, "\"", 4404, 4);
                WriteAttributeValue("", 4346, "window.location=", 4346, 16, true);
                WriteAttributeValue(" ", 4362, "\'", 4363, 2, true);
#nullable restore
#line 141 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\Account\GEmployeePortal.cshtml"
WriteAttributeValue("", 4364, Url.Action( "ProjectLogin", "Account"), 4364, 39, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4403, "\'", 4403, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n");
                WriteLiteral("                </div>\r\n            </div>\r\n        </menu>\r\n    </section>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
