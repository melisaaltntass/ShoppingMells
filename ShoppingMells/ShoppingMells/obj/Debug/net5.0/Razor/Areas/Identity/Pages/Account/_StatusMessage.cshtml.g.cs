#pragma checksum "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Identity\Pages\Account\_StatusMessage.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3ea66531accd599c3d4db3fd03e7d7f385f5172f975919dcd9a91f84dcb329c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account__StatusMessage), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/_StatusMessage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3ea66531accd599c3d4db3fd03e7d7f385f5172f975919dcd9a91f84dcb329c6", @"/Areas/Identity/Pages/Account/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c368cf298438a7c1458ae60b24f921ead8ccfc1a81e476ab231e02b30d6bfcfe", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4b8e9a7cda1a0275c6bb634ede0252aeb54c5e544f0c7bc6cf53f8d18390f446", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Identity_Pages_Account__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 144, "\"", 201, 4);
            WriteAttributeValue("", 152, "alert", 152, 5, true);
            WriteAttributeValue(" ", 157, "alert-", 158, 7, true);
            WriteAttributeValue("", 164, 
#nullable restore
#line 6 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
                             statusMessageClass

#line default
#line hidden
#nullable disable
            , 164, 19, false);
            WriteAttributeValue(" ", 183, "alert-dismissible", 184, 18, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n        ");
            Write(
#nullable restore
#line 8 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
         Model

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 10 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
}

#line default
#line hidden
#nullable disable

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
