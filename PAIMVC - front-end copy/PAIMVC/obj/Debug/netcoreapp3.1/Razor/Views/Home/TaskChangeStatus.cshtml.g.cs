#pragma checksum "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskChangeStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0a646695bcd394ff226c7b483224f2924771a10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TaskChangeStatus), @"mvc.1.0.view", @"/Views/Home/TaskChangeStatus.cshtml")]
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
#line 1 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\_ViewImports.cshtml"
using PAIMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\_ViewImports.cshtml"
using PAIMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0a646695bcd394ff226c7b483224f2924771a10", @"/Views/Home/TaskChangeStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e15daf7e18aef2d9c638becf41959d2d1f8b0938", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TaskChangeStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PAIMVC.Models.Requests.TaskRegisterRequest>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskChangeStatus.cshtml"
  
    ViewData["Title"] = "TaskStatusChange";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1><center>TASK CHANGE STATUS</center></h1>\r\n<br />\r\n<div class=\"page-content container-fluid\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 211, "\"", 219, 0);
            EndWriteAttribute();
            WriteLiteral(" data-plugin=\"matchHeight\" data-by-row=\"true\">\r\n");
#nullable restore
#line 10 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskChangeStatus.cshtml"
         using (Html.BeginForm("PTaskStatusChange", "Home", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"panel\">\r\n                <div class=\"panel-body\">\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 457, "\"", 465, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"form-group row\">\r\n                            <div class=\"col-sm-12\">\r\n\r\n\r\n                                <div class=\"form-group row\">\r\n                                    ");
#nullable restore
#line 20 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskChangeStatus.cshtml"
                               Write(Html.LabelFor(model => model.Id, new { @class = "col-sm-3 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-sm-9\">\r\n                                        ");
#nullable restore
#line 22 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskChangeStatus.cshtml"
                                   Write(Html.TextBoxFor(model => model.Id, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 23 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskChangeStatus.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"form-group row\">\r\n                                    ");
#nullable restore
#line 27 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskChangeStatus.cshtml"
                               Write(Html.LabelFor(model => model.Status, new { @class = "col-sm-3 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-sm-9\">\r\n                                        ");
#nullable restore
#line 29 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskChangeStatus.cshtml"
                                   Write(Html.TextBoxFor(model => model.Status, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 30 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskChangeStatus.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"rowError\">");
#nullable restore
#line 36 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskChangeStatus.cshtml"
                                         Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n                        <div class=\"text-right\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1863, "\"", 1898, 1);
#nullable restore
#line 39 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskChangeStatus.cshtml"
WriteAttributeValue("", 1870, Url.Action("Index", "Home"), 1870, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""button"" style=""margin-right: 10px;"">Powrót</a>
                            <button type=""submit"" value=""True"" class=""btn btn-primary"" id=""validateButton2"">Zapisz zmiany</button>
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 45 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskChangeStatus.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PAIMVC.Models.Requests.TaskRegisterRequest> Html { get; private set; }
    }
}
#pragma warning restore 1591