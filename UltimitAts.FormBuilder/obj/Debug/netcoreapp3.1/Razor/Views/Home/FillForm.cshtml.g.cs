#pragma checksum "C:\Users\User1\Desktop\Form-Builder---Asp.net-core-master\UltimitAts.FormBuilder\Views\Home\FillForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdfae37a642baa0f646e9cfaf8f6b027678c4384"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FillForm), @"mvc.1.0.view", @"/Views/Home/FillForm.cshtml")]
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
#line 1 "C:\Users\User1\Desktop\Form-Builder---Asp.net-core-master\UltimitAts.FormBuilder\Views\_ViewImports.cshtml"
using Form_Builder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User1\Desktop\Form-Builder---Asp.net-core-master\UltimitAts.FormBuilder\Views\_ViewImports.cshtml"
using Form_Builder.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdfae37a642baa0f646e9cfaf8f6b027678c4384", @"/Views/Home/FillForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fef473ca3b6a2937ac3022d62b0ef0aafc0c840c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FillForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Form_Builder.Models.Form>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Forms", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\User1\Desktop\Form-Builder---Asp.net-core-master\UltimitAts.FormBuilder\Views\Home\FillForm.cshtml"
  
    ViewData["Title"] = "Submit Form";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Fill The Form</h1>\n\n<div>\n    <hr />\n    <div class=\"text-center row w-100\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdfae37a642baa0f646e9cfaf8f6b027678c43844849", async() => {
                WriteLiteral("\n            <div id=\"form-render-wrap\" class=\"w-100\">\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdfae37a642baa0f646e9cfaf8f6b027678c43846360", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>


<script>
    function htmlDecode(input) {
        var doc = new DOMParser().parseFromString(input, ""text/html"");
        return doc.documentElement.textContent;
    }
    jQuery($ => {
        // get the form content and render it
        let formData = '");
#nullable restore
#line 31 "C:\Users\User1\Desktop\Form-Builder---Asp.net-core-master\UltimitAts.FormBuilder\Views\Home\FillForm.cshtml"
                   Write(Html.DisplayFor(model => model.FormContent));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        formData = htmlDecode(formData)
        $('#form-render-wrap').formRender(
            {
                formData,
                dataType: 'json'
            }
        );
        // save the submission
        $('#form').on('submit', function (e) {
            e.preventDefault();
            // Collect form data
            var submissionData = $(this).serializeArray();
            // Send data to server
            $.ajax({
                url: '");
#nullable restore
#line 46 "C:\Users\User1\Desktop\Form-Builder---Asp.net-core-master\UltimitAts.FormBuilder\Views\Home\FillForm.cshtml"
                 Write(Url.Action("SubmitForm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\n                type: \'POST\',\n                data: {\n                    formId: ");
#nullable restore
#line 49 "C:\Users\User1\Desktop\Form-Builder---Asp.net-core-master\UltimitAts.FormBuilder\Views\Home\FillForm.cshtml"
                       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
                    submissionData: JSON.stringify(submissionData),
                },
                success: function (response) {
                    if (response) {
                        Swal.fire(
                            'Success!',
                            'The form is submitted successfully!',
                            'success'
                        ).then(function () {
                            window.location.replace(""");
#nullable restore
#line 59 "C:\Users\User1\Desktop\Form-Builder---Asp.net-core-master\UltimitAts.FormBuilder\Views\Home\FillForm.cshtml"
                                                Write(Url.Action("ListFormSubmissions", "Home", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""");
                        });
                    }
                    else {
                        Swal.fire({
                            icon: 'error',
                            title: 'Error',
                            text: 'Something went wrong, please try again!',
                        });
                    }
                },
                error: function (XMLHttpRequest, textStatus, errorThrown) {
                    Swal.fire({
                        icon: 'error',
                        title: 'Error',
                        text: 'Something went wrong, please try again!',
                    });
                }
            });
            // Prevent form submission
            return false;
        });
    })

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Form_Builder.Models.Form> Html { get; private set; }
    }
}
#pragma warning restore 1591
