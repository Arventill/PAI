#pragma checksum "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ba05b7ceaa177741a98e37a07e8801ae664366e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TaskDelete), @"mvc.1.0.view", @"/Views/Home/TaskDelete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ba05b7ceaa177741a98e37a07e8801ae664366e", @"/Views/Home/TaskDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e15daf7e18aef2d9c638becf41959d2d1f8b0938", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TaskDelete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PAIMVC.Models.Requests.TaskRegisterRequest>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskDelete.cshtml"
  
    ViewData["Title"] = "TaskDelete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1><center>TASK DELETE</center></h1>\r\n<br />\r\n<div class=\"page-content container-fluid\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 198, "\"", 206, 0);
            EndWriteAttribute();
            WriteLiteral(" data-plugin=\"matchHeight\" data-by-row=\"true\">\r\n");
#nullable restore
#line 10 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskDelete.cshtml"
         using (Html.BeginForm("PTaskDelete", "Home", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"panel\">\r\n                <div class=\"panel-body\">\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 438, "\"", 446, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"form-group row\">\r\n                            <div class=\"col-sm-12\">\r\n\r\n                                <div class=\"form-group row\">\r\n                                    ");
#nullable restore
#line 19 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskDelete.cshtml"
                               Write(Html.LabelFor(model => model.Id, new { @class = "col-sm-3 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-sm-9\">\r\n                                        ");
#nullable restore
#line 21 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskDelete.cshtml"
                                   Write(Html.TextBoxFor(model => model.Id, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 22 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskDelete.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"form-group row\">\r\n                                    ");
#nullable restore
#line 26 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskDelete.cshtml"
                               Write(Html.LabelFor(model => model.Title, new { @class = "col-sm-3 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-sm-9\">\r\n                                        ");
#nullable restore
#line 28 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskDelete.cshtml"
                                   Write(Html.TextBoxFor(model => model.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 29 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskDelete.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"form-group row\">\r\n                                    ");
#nullable restore
#line 33 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskDelete.cshtml"
                               Write(Html.LabelFor(model => model.Description, new { @class = "col-sm-3 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-sm-9\">\r\n                                        ");
#nullable restore
#line 35 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskDelete.cshtml"
                                   Write(Html.TextBoxFor(model => model.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 36 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskDelete.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"form-group row\">\r\n                                    ");
#nullable restore
#line 40 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskDelete.cshtml"
                               Write(Html.LabelFor(model => model.ExpirationDate, new { @class = "col-sm-3 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-sm-9\">\r\n                                        ");
#nullable restore
#line 42 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskDelete.cshtml"
                                   Write(Html.TextBoxFor(model => model.ExpirationDate, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 43 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskDelete.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.ExpirationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"form-group row\">\r\n                                    ");
#nullable restore
#line 47 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskDelete.cshtml"
                               Write(Html.LabelFor(model => model.Type, new { @class = "col-sm-3 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-sm-9\">\r\n                                        ");
#nullable restore
#line 49 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskDelete.cshtml"
                                   Write(Html.TextBoxFor(model => model.Type, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 50 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskDelete.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"form-group row\">\r\n                                    ");
#nullable restore
#line 54 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskDelete.cshtml"
                               Write(Html.LabelFor(model => model.Status, new { @class = "col-sm-3 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-sm-9\">\r\n                                        ");
#nullable restore
#line 56 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskDelete.cshtml"
                                   Write(Html.TextBoxFor(model => model.Status, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 57 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskDelete.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"rowError\">");
#nullable restore
#line 63 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskDelete.cshtml"
                                         Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n                        <div class=\"text-right\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3992, "\"", 4027, 1);
#nullable restore
#line 66 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskDelete.cshtml"
WriteAttributeValue("", 3999, Url.Action("Index", "Home"), 3999, 28, false);

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
#line 72 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskDelete.cshtml"
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