#pragma checksum "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskGetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2862b9b32dd7b7395122804279541c4780c431e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TaskGetAll), @"mvc.1.0.view", @"/Views/Home/TaskGetAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2862b9b32dd7b7395122804279541c4780c431e1", @"/Views/Home/TaskGetAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e15daf7e18aef2d9c638becf41959d2d1f8b0938", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TaskGetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PAIMVC.Models.Requests.TaskRegisterRequest>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskGetAll.cshtml"
  
    ViewData["Title"] = "TaskGetAll";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1><center>TASK GET ALL</center></h1>\r\n<br />\r\n<div class=\"page-content container-fluid\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 199, "\"", 207, 0);
            EndWriteAttribute();
            WriteLiteral(" data-plugin=\"matchHeight\" data-by-row=\"true\">\r\n");
#nullable restore
#line 10 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskGetAll.cshtml"
         using (Html.BeginForm("PTaskGetAll", "Home", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"panel\">\r\n                <div class=\"panel-body\">\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 439, "\"", 447, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""form-group row"">
                            <div class=""col-sm-12"">
                                
                            </div>
                        </div>

                        <div class=""rowError"">");
#nullable restore
#line 21 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskGetAll.cshtml"
                                         Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n                        <div class=\"text-right\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 827, "\"", 862, 1);
#nullable restore
#line 24 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskGetAll.cshtml"
WriteAttributeValue("", 834, Url.Action("Index", "Home"), 834, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""button"" style=""margin-right: 10px;"">Powrót</a>
                            <button type=""submit"" value=""True"" class=""btn btn-primary"" id=""validateButton2"">Pobierz wszystkie</button>
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 30 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\TaskGetAll.cshtml"
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
