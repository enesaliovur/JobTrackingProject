#pragma checksum "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dad35cd9ad66eb6196cfc0f713ea3be200adc500"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AssignDuty_ListEmployees), @"mvc.1.0.view", @"/Areas/Admin/Views/AssignDuty/ListEmployees.cshtml")]
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
#line 2 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\_ViewImports.cshtml"
using JobTrackingProject.Web.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dad35cd9ad66eb6196cfc0f713ea3be200adc500", @"/Areas/Admin/Views/AssignDuty/ListEmployees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8c63c4c13124bc018a2a70ecd597e7765c256a9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AssignDuty_ListEmployees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DutyViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListEmployees", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:8rem; height:8rem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AssignEmplooyes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary float-right btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::JobTrackingProject.Web.TagHelpers.DutyAppUserIdTagHelper __JobTrackingProject_Web_TagHelpers_DutyAppUserIdTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
  
    ViewData["Title"] = "AssignPersonnel";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    string s = (string)ViewBag.search;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-md-12 mb-2\">\r\n");
#nullable restore
#line 10 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
         if (!string.IsNullOrWhiteSpace(s))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"border border-dark p-3 mb-2\">\r\n                <strong>");
#nullable restore
#line 13 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
                   Write(s);

#line default
#line hidden
#nullable disable
            WriteLiteral(" için sonuçlar </strong>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dad35cd9ad66eb6196cfc0f713ea3be200adc5007901", async() => {
                WriteLiteral("Filtreyi Kaldır");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "asp-rout-id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 14 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
AddHtmlAttributeValue("", 459, Model.Id, 459, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 16 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dad35cd9ad66eb6196cfc0f713ea3be200adc5009950", async() => {
                WriteLiteral("\r\n            <input type=\"text\" name=\"s\" class=\"form-control-sm border border-primary border-left-0 border-right-0 border-top-0\" />\r\n            <button type=\"submit\" class=\"btn btn-primary btn-sm\">Ara</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""col-md-4"">
        <div class=""card border-primary"">
            <div class=""card-header"">
                <h4 class=""text-center lead pt-2"">Görev Bilgileri</h4>
            </div>

            <div class=""card-body"">
                <h5 class=""card-title"">");
#nullable restore
#line 30 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
                                  Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 31 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
                                Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">\r\n                    <strong>Aciliyet Durumu:</strong><span class=\"badge badge-info\">");
#nullable restore
#line 33 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
                                                                               Write(Model.Importance.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </p>\r\n                <p class=\" card-text\">\r\n                    ");
#nullable restore
#line 36 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
               Write(Model.CreationDate.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n                </p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-8\">\r\n\r\n\r\n\r\n");
#nullable restore
#line 46 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
         foreach (var item in (List<AppUserViewModel>)ViewBag.Employees)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card mb-3 border-primary\">\r\n                <div class=\"row no-gutters\">\r\n                    <div class=\"col-md-4\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dad35cd9ad66eb6196cfc0f713ea3be200adc50014390", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1864, "~/img/", 1864, 6, true);
#nullable restore
#line 51 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
AddHtmlAttributeValue("", 1870, item.ImageUrl, 1870, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 51 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
AddHtmlAttributeValue("", 1922, item.Name, 1922, 10, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 1932, "", 1933, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-8\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 55 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 55 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
                                                         Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("getDutyAppUserId", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dad35cd9ad66eb6196cfc0f713ea3be200adc50017523", async() => {
            }
            );
            __JobTrackingProject_Web_TagHelpers_DutyAppUserIdTagHelper = CreateTagHelper<global::JobTrackingProject.Web.TagHelpers.DutyAppUserIdTagHelper>();
            __tagHelperExecutionContext.Add(__JobTrackingProject_Web_TagHelpers_DutyAppUserIdTagHelper);
#nullable restore
#line 56 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
__JobTrackingProject_Web_TagHelpers_DutyAppUserIdTagHelper.AppUserId = item.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("app-user-id", __JobTrackingProject_Web_TagHelpers_DutyAppUserIdTagHelper.AppUserId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                      \r\n                            <p class=\"card-text\">\r\n                                <small class=\"text-muted\">");
#nullable restore
#line 59 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
                                                     Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dad35cd9ad66eb6196cfc0f713ea3be200adc50019497", async() => {
                WriteLiteral("Görevlendir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-EmplooyeId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["EmplooyeId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-EmplooyeId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["EmplooyeId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
                                                                                                      WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["DutyId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-DutyId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["DutyId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div> \r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 66 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <nav aria-label=\"Page navigation example\">\r\n            <ul class=\"pagination\">\r\n");
#nullable restore
#line 71 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
                 if (!string.IsNullOrWhiteSpace(s))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
                     for (int i = 1; i <= ViewBag.TotalPages; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li");
            BeginWriteAttribute("class", " class=\"", 3035, "\"", 3091, 2);
            WriteAttributeValue("", 3043, "page-item", 3043, 9, true);
#nullable restore
#line 75 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
WriteAttributeValue(" ", 3052, ViewBag.ActivePage == i?"active":"", 3053, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dad35cd9ad66eb6196cfc0f713ea3be200adc50024410", async() => {
#nullable restore
#line 77 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
                                                                                                                                           Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
                                                                              WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
                                                                                                               WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activePage"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activePage", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activePage"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
                                                                                                                                WriteLiteral(s);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["s"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-s", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["s"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 79 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
                     
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
                     for (int i = 1; i <= ViewBag.TotalPages; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li");
            BeginWriteAttribute("class", " class=\"", 3481, "\"", 3537, 2);
            WriteAttributeValue("", 3489, "page-item", 3489, 9, true);
#nullable restore
#line 85 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
WriteAttributeValue(" ", 3498, ViewBag.ActivePage == i?"active":"", 3499, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dad35cd9ad66eb6196cfc0f713ea3be200adc50030233", async() => {
#nullable restore
#line 87 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
                                                                                                                          Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
                                                                              WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
                                                                                                               WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activePage"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activePage", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activePage"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 89 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\enesa\OneDrive\Masaüstü\Desktop\JobTrackingProject\JobTrackingProject.Web\Areas\Admin\Views\AssignDuty\ListEmployees.cshtml"
                     

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </ul>\r\n        </nav>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DutyViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591