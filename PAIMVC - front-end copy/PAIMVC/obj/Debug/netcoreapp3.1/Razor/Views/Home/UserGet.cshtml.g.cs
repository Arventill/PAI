#pragma checksum "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserGet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39c2d9dcdbdd7b71c19bf667bd165c98c9a74028"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserGet), @"mvc.1.0.view", @"/Views/Home/UserGet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c2d9dcdbdd7b71c19bf667bd165c98c9a74028", @"/Views/Home/UserGet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e15daf7e18aef2d9c638becf41959d2d1f8b0938", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserGet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PAIMVC.Models.Requests.UserRegisterRequest>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserGet.cshtml"
  
    ViewData["Title"] = "UserGet";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1><center>USER GET</center></h1>\r\n<br />\r\n<div class=\"page-content container-fluid\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 192, "\"", 200, 0);
            EndWriteAttribute();
            WriteLiteral(" data-plugin=\"matchHeight\" data-by-row=\"true\">\r\n");
#nullable restore
#line 10 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserGet.cshtml"
         using (Html.BeginForm("PGetUser", "Home", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"panel\">\r\n                <div class=\"panel-body\">\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 429, "\"", 437, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""form-group row"">
                            <div class=""col-sm-12"">
                                <div>
                                    <h4><center>Get user by Email or Hash</center></h4>
                                </div>

                                <div class=""form-group row"">
                                    ");
#nullable restore
#line 22 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserGet.cshtml"
                               Write(Html.LabelFor(model => model.Email, new { @class = "col-sm-3 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-sm-9\">\r\n                                        ");
#nullable restore
#line 24 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserGet.cshtml"
                                   Write(Html.TextBoxFor(model => model.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 25 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserGet.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"form-group row\">\r\n                                    ");
#nullable restore
#line 29 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserGet.cshtml"
                               Write(Html.LabelFor(model => model.Hash, new { @class = "col-sm-3 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-sm-9\">\r\n                                        ");
#nullable restore
#line 31 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserGet.cshtml"
                                   Write(Html.TextBoxFor(model => model.Hash, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 32 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserGet.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Hash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"rowError\">");
#nullable restore
#line 38 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserGet.cshtml"
                                         Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n                        <div class=\"text-right\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2004, "\"", 2039, 1);
#nullable restore
#line 41 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserGet.cshtml"
WriteAttributeValue("", 2011, Url.Action("Index", "Home"), 2011, 28, false);

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
#line 47 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserGet.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PAIMVC.Models.Requests.UserRegisterRequest> Html { get; private set; }
    }
}
#pragma warning restore 1591
