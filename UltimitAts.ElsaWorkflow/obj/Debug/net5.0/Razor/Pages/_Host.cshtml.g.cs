#pragma checksum "C:\Users\User1\Desktop\ElsaWorkflowSample-main\DocumentApprovalWorkflow\DocumentApprovalWorkflowApp\DocumentApprovalWorkflowApp\Pages\_Host.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "140a020fbbe4089e2750fd5b944bcdb23299e5de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UltimitAts.ElsaWorkflow.Pages.Pages__Host), @"mvc.1.0.razor-page", @"/Pages/_Host.cshtml")]
namespace UltimitAts.ElsaWorkflow.Pages
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
#line 1 "C:\Users\User1\Desktop\ElsaWorkflowSample-main\DocumentApprovalWorkflow\DocumentApprovalWorkflowApp\DocumentApprovalWorkflowApp\Pages\_ViewImports.cshtml"
using UltimitAts.ElsaWorkflow;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User1\Desktop\ElsaWorkflowSample-main\DocumentApprovalWorkflow\DocumentApprovalWorkflowApp\DocumentApprovalWorkflowApp\Pages\_ViewImports.cshtml"
using UltimitAts.ElsaWorkflow.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"140a020fbbe4089e2750fd5b944bcdb23299e5de", @"/Pages/_Host.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5078cfd36b406745fd5bb45a6d4e445de53741e", @"/Pages/_ViewImports.cshtml")]
    public class Pages__Host : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User1\Desktop\ElsaWorkflowSample-main\DocumentApprovalWorkflow\DocumentApprovalWorkflowApp\DocumentApprovalWorkflowApp\Pages\_Host.cshtml"
  
    var serverUrl = $"{Request.Scheme}://{Request.Host}";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "140a020fbbe4089e2750fd5b944bcdb23299e5de3895", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <title>Elsa Workflows</title>
    <link rel=""icon"" type=""image/png"" sizes=""32x32"" href=""/_content/Elsa.Designer.Components.Web/elsa-workflows-studio/assets/images/favicon-32x32.png"">
    <link rel=""icon"" type=""image/png"" sizes=""16x16"" href=""/_content/Elsa.Designer.Components.Web/elsa-workflows-studio/assets/images/favicon-16x16.png"">
    <link rel=""stylesheet"" href=""/_content/Elsa.Designer.Components.Web/elsa-workflows-studio/assets/fonts/inter/inter.css"">
    <link rel=""stylesheet"" href=""/_content/Elsa.Designer.Components.Web/elsa-workflows-studio/elsa-workflows-studio.css"">
    <script src=""/_content/Elsa.Designer.Components.Web/monaco-editor/min/vs/loader.js""></script>
    <script type=""module"" src=""/_content/Elsa.Designer.Components.Web/elsa-workflows-studio/elsa-workflows-studio.esm.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "140a020fbbe4089e2750fd5b944bcdb23299e5de5816", async() => {
                WriteLiteral("\n    <elsa-studio-root");
                BeginWriteAttribute("server-url", " server-url=\"", 1072, "\"", 1095, 1);
#nullable restore
#line 19 "C:\Users\User1\Desktop\ElsaWorkflowSample-main\DocumentApprovalWorkflow\DocumentApprovalWorkflowApp\DocumentApprovalWorkflowApp\Pages\_Host.cshtml"
WriteAttributeValue("", 1085, serverUrl, 1085, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" monaco-lib-path=\"_content/Elsa.Designer.Components.Web/monaco-editor/min\">\n        <elsa-studio-dashboard></elsa-studio-dashboard>\n    </elsa-studio-root>\n");
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
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages__Host> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages__Host> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages__Host>)PageContext?.ViewData;
        public Pages__Host Model => ViewData.Model;
    }
}
#pragma warning restore 1591