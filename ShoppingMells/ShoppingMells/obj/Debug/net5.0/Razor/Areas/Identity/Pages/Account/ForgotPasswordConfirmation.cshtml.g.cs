#pragma checksum "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6cca4e98ecffd649ecb8fb7baa4a1e11a3075c130b170abf8f90bf4a6cad0831"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_ForgotPasswordConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/ForgotPasswordConfirmation.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Identity\Pages\_ViewImports.cshtml"
using ShoppingMells.Areas.Identity

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Identity\Pages\_ViewImports.cshtml"
using ShoppingMells.Areas.Identity.Pages

#nullable disable
    ;
#nullable restore
#line 1 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using ShoppingMells.Areas.Identity.Pages.Account

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6cca4e98ecffd649ecb8fb7baa4a1e11a3075c130b170abf8f90bf4a6cad0831", @"/Areas/Identity/Pages/Account/ForgotPasswordConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c368cf298438a7c1458ae60b24f921ead8ccfc1a81e476ab231e02b30d6bfcfe", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4b8e9a7cda1a0275c6bb634ede0252aeb54c5e544f0c7bc6cf53f8d18390f446", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Identity_Pages_Account_ForgotPasswordConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml"
  
    ViewData["Title"] = "Forgot password confirmation";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1>");
            Write(
#nullable restore
#line 7 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml"
     ViewData["Title"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h1>\r\n<p>\r\n    Please check your email to reset your password.\r\n</p>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ForgotPasswordConfirmation> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ForgotPasswordConfirmation> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ForgotPasswordConfirmation>)PageContext?.ViewData;
        public ForgotPasswordConfirmation Model => ViewData.Model;
    }
}
#pragma warning restore 1591
