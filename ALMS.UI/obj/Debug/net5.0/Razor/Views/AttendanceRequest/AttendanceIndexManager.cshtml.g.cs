#pragma checksum "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\AttendanceRequest\AttendanceIndexManager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b3d4b23f7faf78517f699ada9771849e591d2e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AttendanceRequest_AttendanceIndexManager), @"mvc.1.0.view", @"/Views/AttendanceRequest/AttendanceIndexManager.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b3d4b23f7faf78517f699ada9771849e591d2e0", @"/Views/AttendanceRequest/AttendanceIndexManager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94e882ceecf902ff373e0e873e2d167be3963b7a", @"/Views/_ViewImports.cshtml")]
    public class Views_AttendanceRequest_AttendanceIndexManager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ALMS.UI.Models.TrattendanceDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\AttendanceRequest\AttendanceIndexManager.cshtml"
  
    ViewData["Title"] = "AttendanceIndex";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<center>\r\n   \r\n    <h2>Attendance Records</h2>\r\n    <hr />\r\n\r\n\r\n\r\n");
#nullable restore
#line 14 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\AttendanceRequest\AttendanceIndexManager.cshtml"
     using (Html.BeginForm("Index", "ManagerGetAllAttendance", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>Start Date :</span>\r\n        <input type=\"date\" name=\"startdate\" />\r\n        <span>End Date :</span>\r\n        <input type=\"date\" name=\"enddate\" />\r\n        <input type=\"submit\" value=\"Get Records Between Dates\" />\r\n");
            WriteLiteral("        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 27 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\AttendanceRequest\AttendanceIndexManager.cshtml"
                   Write(Html.DisplayNameFor(model => model.AttendanceId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 30 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\AttendanceRequest\AttendanceIndexManager.cshtml"
                   Write(Html.DisplayNameFor(model => model.ProjectId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 33 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\AttendanceRequest\AttendanceIndexManager.cshtml"
                   Write(Html.DisplayNameFor(model => model.EmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 36 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\AttendanceRequest\AttendanceIndexManager.cshtml"
                   Write(Html.DisplayNameFor(model => model.AttedanceDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 39 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\AttendanceRequest\AttendanceIndexManager.cshtml"
                   Write(Html.DisplayNameFor(model => model.AttendanceStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 42 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\AttendanceRequest\AttendanceIndexManager.cshtml"
                   Write(Html.DisplayNameFor(model => model.StatusUpdateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 45 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\AttendanceRequest\AttendanceIndexManager.cshtml"
                   Write(Html.DisplayNameFor(model => model.StatusUpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 51 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\AttendanceRequest\AttendanceIndexManager.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 55 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\AttendanceRequest\AttendanceIndexManager.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AttendanceId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 58 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\AttendanceRequest\AttendanceIndexManager.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ProjectId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 61 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\AttendanceRequest\AttendanceIndexManager.cshtml"
                       Write(Html.DisplayFor(modelItem => item.EmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 64 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\AttendanceRequest\AttendanceIndexManager.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AttedanceDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 67 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\AttendanceRequest\AttendanceIndexManager.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AttendanceStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 70 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\AttendanceRequest\AttendanceIndexManager.cshtml"
                       Write(Html.DisplayFor(modelItem => item.StatusUpdateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 73 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\AttendanceRequest\AttendanceIndexManager.cshtml"
                       Write(Html.DisplayFor(modelItem => item.StatusUpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                       \r\n\r\n                    </tr>\r\n");
#nullable restore
#line 78 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\AttendanceRequest\AttendanceIndexManager.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 81 "C:\Users\hp\Desktop\issue\Final\Sprint2\ALMS\ALMS.UI\Views\AttendanceRequest\AttendanceIndexManager.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</center>>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ALMS.UI.Models.TrattendanceDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591