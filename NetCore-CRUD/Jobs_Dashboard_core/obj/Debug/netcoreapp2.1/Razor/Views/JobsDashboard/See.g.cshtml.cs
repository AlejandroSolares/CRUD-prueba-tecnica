#pragma checksum "C:\Users\Solares\Documents\CRUD_Prueba_Tecnica\CRUD-prueba-tecnica\NetCore-CRUD\Jobs_Dashboard_core\Views\JobsDashboard\See.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a4630e975ea97d416b5fa8b3384a0d92abca944"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JobsDashboard_See), @"mvc.1.0.view", @"/Views/JobsDashboard/See.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/JobsDashboard/See.cshtml", typeof(AspNetCore.Views_JobsDashboard_See))]
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
#line 1 "C:\Users\Solares\Documents\CRUD_Prueba_Tecnica\CRUD-prueba-tecnica\NetCore-CRUD\Jobs_Dashboard_core\Views\_ViewImports.cshtml"
using Jobs_Dashboard_core;

#line default
#line hidden
#line 2 "C:\Users\Solares\Documents\CRUD_Prueba_Tecnica\CRUD-prueba-tecnica\NetCore-CRUD\Jobs_Dashboard_core\Views\_ViewImports.cshtml"
using Jobs_Dashboard_core.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a4630e975ea97d416b5fa8b3384a0d92abca944", @"/Views/JobsDashboard/See.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69a8b811ebfd0288bc5dfd24246da21b2a9fcc33", @"/Views/_ViewImports.cshtml")]
    public class Views_JobsDashboard_See : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Jobs_Dashboard_core.Models.Job>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Solares\Documents\CRUD_Prueba_Tecnica\CRUD-prueba-tecnica\NetCore-CRUD\Jobs_Dashboard_core\Views\JobsDashboard\See.cshtml"
  
    ViewData["Title"] = "See";

#line default
#line hidden
            BeginContext(80, 113, true);
            WriteLiteral("\r\n<h2>See</h2>\r\n\r\n<div>\r\n    <h4>Job</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(194, 43, false);
#line 14 "C:\Users\Solares\Documents\CRUD_Prueba_Tecnica\CRUD-prueba-tecnica\NetCore-CRUD\Jobs_Dashboard_core\Views\JobsDashboard\See.cshtml"
       Write(Html.DisplayNameFor(model => model.JobTitl));

#line default
#line hidden
            EndContext();
            BeginContext(237, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(281, 39, false);
#line 17 "C:\Users\Solares\Documents\CRUD_Prueba_Tecnica\CRUD-prueba-tecnica\NetCore-CRUD\Jobs_Dashboard_core\Views\JobsDashboard\See.cshtml"
       Write(Html.DisplayFor(model => model.JobTitl));

#line default
#line hidden
            EndContext();
            BeginContext(320, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(364, 43, false);
#line 20 "C:\Users\Solares\Documents\CRUD_Prueba_Tecnica\CRUD-prueba-tecnica\NetCore-CRUD\Jobs_Dashboard_core\Views\JobsDashboard\See.cshtml"
       Write(Html.DisplayNameFor(model => model.JobDesc));

#line default
#line hidden
            EndContext();
            BeginContext(407, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(451, 39, false);
#line 23 "C:\Users\Solares\Documents\CRUD_Prueba_Tecnica\CRUD-prueba-tecnica\NetCore-CRUD\Jobs_Dashboard_core\Views\JobsDashboard\See.cshtml"
       Write(Html.DisplayFor(model => model.JobDesc));

#line default
#line hidden
            EndContext();
            BeginContext(490, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(534, 44, false);
#line 26 "C:\Users\Solares\Documents\CRUD_Prueba_Tecnica\CRUD-prueba-tecnica\NetCore-CRUD\Jobs_Dashboard_core\Views\JobsDashboard\See.cshtml"
       Write(Html.DisplayNameFor(model => model.JobCreat));

#line default
#line hidden
            EndContext();
            BeginContext(578, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(622, 40, false);
#line 29 "C:\Users\Solares\Documents\CRUD_Prueba_Tecnica\CRUD-prueba-tecnica\NetCore-CRUD\Jobs_Dashboard_core\Views\JobsDashboard\See.cshtml"
       Write(Html.DisplayFor(model => model.JobCreat));

#line default
#line hidden
            EndContext();
            BeginContext(662, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(706, 43, false);
#line 32 "C:\Users\Solares\Documents\CRUD_Prueba_Tecnica\CRUD-prueba-tecnica\NetCore-CRUD\Jobs_Dashboard_core\Views\JobsDashboard\See.cshtml"
       Write(Html.DisplayNameFor(model => model.JobExpi));

#line default
#line hidden
            EndContext();
            BeginContext(749, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(793, 39, false);
#line 35 "C:\Users\Solares\Documents\CRUD_Prueba_Tecnica\CRUD-prueba-tecnica\NetCore-CRUD\Jobs_Dashboard_core\Views\JobsDashboard\See.cshtml"
       Write(Html.DisplayFor(model => model.JobExpi));

#line default
#line hidden
            EndContext();
            BeginContext(832, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(876, 45, false);
#line 38 "C:\Users\Solares\Documents\CRUD_Prueba_Tecnica\CRUD-prueba-tecnica\NetCore-CRUD\Jobs_Dashboard_core\Views\JobsDashboard\See.cshtml"
       Write(Html.DisplayNameFor(model => model.Requestor));

#line default
#line hidden
            EndContext();
            BeginContext(921, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(965, 44, false);
#line 41 "C:\Users\Solares\Documents\CRUD_Prueba_Tecnica\CRUD-prueba-tecnica\NetCore-CRUD\Jobs_Dashboard_core\Views\JobsDashboard\See.cshtml"
       Write(Html.DisplayFor(model => model.Requestor.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1009, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1053, 46, false);
#line 44 "C:\Users\Solares\Documents\CRUD_Prueba_Tecnica\CRUD-prueba-tecnica\NetCore-CRUD\Jobs_Dashboard_core\Views\JobsDashboard\See.cshtml"
       Write(Html.DisplayNameFor(model => model.CreateDate));

#line default
#line hidden
            EndContext();
            BeginContext(1099, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1143, 42, false);
#line 47 "C:\Users\Solares\Documents\CRUD_Prueba_Tecnica\CRUD-prueba-tecnica\NetCore-CRUD\Jobs_Dashboard_core\Views\JobsDashboard\See.cshtml"
       Write(Html.DisplayFor(model => model.CreateDate));

#line default
#line hidden
            EndContext();
            BeginContext(1185, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1232, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9077bb4745b43cabdbdf5c8a0feb4aa", async() => {
                BeginContext(1278, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\Solares\Documents\CRUD_Prueba_Tecnica\CRUD-prueba-tecnica\NetCore-CRUD\Jobs_Dashboard_core\Views\JobsDashboard\See.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1286, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1294, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7e72508c8b641f89848054e17534bb3", async() => {
                BeginContext(1316, 12, true);
                WriteLiteral("Back to List");
                EndContext();
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
            EndContext();
            BeginContext(1332, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Jobs_Dashboard_core.Models.Job> Html { get; private set; }
    }
}
#pragma warning restore 1591
