#pragma checksum "C:\Users\User1\Desktop\Form-Builder---Asp.net-core-master\UltimitAts.FormBuilder\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de0a485c4e2445fadcaace4a8f38ed071ad9b5e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de0a485c4e2445fadcaace4a8f38ed071ad9b5e9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fef473ca3b6a2937ac3022d62b0ef0aafc0c840c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User1\Desktop\Form-Builder---Asp.net-core-master\UltimitAts.FormBuilder\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">UltimitAts.FormBuilder</h1>
</div>
<div id=""build-wrap""></div>
<script>
    jQuery($ => {
        // on clicking save the form template button
        const fbEditor = document.getElementById(""build-wrap"");
        var options = {
            onSave: function (evt, formData) {
                $.ajax({
                url: '");
#nullable restore
#line 16 "C:\Users\User1\Desktop\Form-Builder---Asp.net-core-master\UltimitAts.FormBuilder\Views\Home\Index.cshtml"
                 Write(Url.Action("SaveFormTemplate"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                type: 'POST',
                data: { formData },
                    success: function (response) {
                        if (response) {
                            Swal.fire(
                                'Success!',
                                'The form is created successfully!',
                                'success'
                            ).then(function () {
                                window.location.replace(""");
#nullable restore
#line 26 "C:\Users\User1\Desktop\Form-Builder---Asp.net-core-master\UltimitAts.FormBuilder\Views\Home\Index.cshtml"
                                                    Write(Url.Action("Forms"));

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

            }
        };
        $(fbEditor).formBuilder(options);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
