#pragma checksum "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "079b99163f290e5e6ff72dec9bc70218f9e4f3e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserRegister), @"mvc.1.0.view", @"/Views/Home/UserRegister.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"079b99163f290e5e6ff72dec9bc70218f9e4f3e5", @"/Views/Home/UserRegister.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e15daf7e18aef2d9c638becf41959d2d1f8b0938", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserRegister : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PAIMVC.Models.Requests.UserRegisterRequest>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
  
    ViewData["Title"] = "UserRegister";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1><center>USER REGISTER</center></h1>\r\n<br />\r\n<div class=\"page-content container-fluid\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 204, "\"", 212, 0);
            EndWriteAttribute();
            WriteLiteral(" data-plugin=\"matchHeight\" data-by-row=\"true\">\r\n");
#nullable restore
#line 11 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
         using (Html.BeginForm("PUserRegister", "Home", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"panel\">\r\n                <div class=\"panel-body\">\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 446, "\"", 454, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"form-group row\">\r\n                            <div class=\"col-sm-12\">\r\n\r\n\r\n                                <div class=\"form-group row\">\r\n                                    ");
#nullable restore
#line 21 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                               Write(Html.LabelFor(model => model.Email, new { @class = "col-sm-3 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-sm-9\">\r\n                                        ");
#nullable restore
#line 23 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                                   Write(Html.TextBoxFor(model => model.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 24 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"form-group row\">\r\n                                    ");
#nullable restore
#line 28 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                               Write(Html.LabelFor(model => model.Password, new { @class = "col-sm-3 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-sm-9\">\r\n                                        ");
#nullable restore
#line 30 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                                   Write(Html.TextBoxFor(model => model.Password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 31 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"form-group row\">\r\n                                    ");
#nullable restore
#line 35 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                               Write(Html.LabelFor(model => model.Status, new { @class = "col-sm-3 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-sm-9\">\r\n                                        ");
#nullable restore
#line 37 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                                   Write(Html.TextBoxFor(model => model.Status, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 38 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"form-group row\">\r\n                                    ");
#nullable restore
#line 42 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                               Write(Html.LabelFor(model => model.UserType, new { @class = "col-sm-3 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-sm-9\">\r\n                                        ");
#nullable restore
#line 44 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                                   Write(Html.TextBoxFor(model => model.UserType, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 45 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.UserType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"form-group row\">\r\n                                    ");
#nullable restore
#line 49 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                               Write(Html.LabelFor(model => model.PersonName, new { @class = "col-sm-3 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-sm-9\">\r\n                                        ");
#nullable restore
#line 51 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                                   Write(Html.TextBoxFor(model => model.PersonName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 52 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.PersonName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"form-group row\">\r\n                                    ");
#nullable restore
#line 56 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                               Write(Html.LabelFor(model => model.PhoneNumber, new { @class = "col-sm-3 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-sm-9\">\r\n                                        ");
#nullable restore
#line 58 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                                   Write(Html.TextBoxFor(model => model.PhoneNumber, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 59 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"form-group row\">\r\n                                    ");
#nullable restore
#line 63 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                               Write(Html.LabelFor(model => model.City, new { @class = "col-sm-3 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-sm-9\">\r\n                                        ");
#nullable restore
#line 65 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                                   Write(Html.TextBoxFor(model => model.City, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 66 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"form-group row\">\r\n                                    ");
#nullable restore
#line 70 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                               Write(Html.LabelFor(model => model.ZipCode, new { @class = "col-sm-3 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-sm-9\">\r\n                                        ");
#nullable restore
#line 72 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                                   Write(Html.TextBoxFor(model => model.ZipCode, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 73 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.ZipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"form-group row\">\r\n                                    ");
#nullable restore
#line 77 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                               Write(Html.LabelFor(model => model.Address, new { @class = "col-sm-3 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-sm-9\">\r\n                                        ");
#nullable restore
#line 79 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                                   Write(Html.TextBoxFor(model => model.Address, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 80 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"form-group row\">\r\n                                    ");
#nullable restore
#line 84 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                               Write(Html.LabelFor(model => model.Country, new { @class = "col-sm-3 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-sm-9\">\r\n                                        ");
#nullable restore
#line 86 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                                   Write(Html.TextBoxFor(model => model.Country, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 87 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"rowError\">");
#nullable restore
#line 93 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
                                         Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n                        <div class=\"text-right\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 6143, "\"", 6178, 1);
#nullable restore
#line 96 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
WriteAttributeValue("", 6150, Url.Action("Index", "Home"), 6150, 28, false);

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
#line 102 "C:\Users\DRAGON\source\repos\PAIMVC\PAIMVC\Views\Home\UserRegister.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PAIMVC.Models.Requests.UserRegisterRequest> Html { get; private set; }
    }
}
#pragma warning restore 1591