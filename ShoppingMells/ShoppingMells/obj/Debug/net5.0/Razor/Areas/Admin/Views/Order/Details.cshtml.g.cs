#pragma checksum "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\Order\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2943d1fedbd0e2d39f43886bf4ef859a094647c618cf91788892fc0a73bbca71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Order_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Order/Details.cshtml")]
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
#line 1 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\_ViewImports.cshtml"
using ShoppingMells

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\_ViewImports.cshtml"
using ShoppingMells.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2943d1fedbd0e2d39f43886bf4ef859a094647c618cf91788892fc0a73bbca71", @"/Areas/Admin/Views/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c941c1e5c898e4b686053c7fe1c039a7d30f8d9f65479f48bf29ab0055665926", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingMells.Models.OrderDetailsVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\Order\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2943d1fedbd0e2d39f43886bf4ef859a094647c618cf91788892fc0a73bbca714217", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2943d1fedbd0e2d39f43886bf4ef859a094647c618cf91788892fc0a73bbca714503", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.
#nullable restore
#line 8 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\Order\Details.cshtml"
                           OrderHeader.Id

#line default
#line hidden
#nullable disable
                );
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <div class=""container"">
        <div class=""row"">
           
            <div class=""col-md-6"">
                
                <div>

                    <dl class=""row"">
                        <dt class=""col-sm-4"">
                            Adı
                        </dt>
                        <dd class=""col-sm-8"">
                            ");
                Write(
#nullable restore
#line 21 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\Order\Details.cshtml"
                             Model.OrderHeader.Name

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-4\">\r\n                            Soyadı\r\n                        </dt>\r\n                        <dd class=\"col-sm-8\">\r\n                            ");
                Write(
#nullable restore
#line 27 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\Order\Details.cshtml"
                             Model.OrderHeader.Surname

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-4\">\r\n                            Telefon\r\n                        </dt>\r\n                        <dd class=\"col-sm-8\">\r\n                            ");
                Write(
#nullable restore
#line 33 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\Order\Details.cshtml"
                             Model.OrderHeader.PhoneNumber

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-4\">\r\n                            Adres\r\n                        </dt>\r\n                        <dd class=\"col-sm-8\">\r\n                            ");
                Write(
#nullable restore
#line 39 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\Order\Details.cshtml"
                             Model.OrderHeader.Adres

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-4\">\r\n                            Semt\r\n                        </dt>\r\n                        <dd class=\"col-sm-8\">\r\n                            ");
                Write(
#nullable restore
#line 45 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\Order\Details.cshtml"
                             Model.OrderHeader.Semt

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-4\">\r\n                            Şehir\r\n                        </dt>\r\n                        <dd class=\"col-sm-8\">\r\n                            ");
                Write(
#nullable restore
#line 51 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\Order\Details.cshtml"
                             Model.OrderHeader.Sehir

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-4\">\r\n                            Posta Kodu\r\n                        </dt>\r\n                        <dd class=\"col-sm-8\">\r\n                            ");
                Write(
#nullable restore
#line 57 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\Order\Details.cshtml"
                             Model.OrderHeader.PostaKodu

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-4\">\r\n                            Sipariş Tarihi\r\n                        </dt>\r\n                        <dd class=\"col-sm-8\">\r\n                            ");
                Write(
#nullable restore
#line 63 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\Order\Details.cshtml"
                             Model.OrderHeader.OrderDate.ToShortDateString()

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                        </dd>\r\n                    </dl>\r\n\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <div class=\"col-md-12\">\r\n\r\n                    <ul class=\"list-group mb-3\">\r\n");
#nullable restore
#line 73 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\Order\Details.cshtml"
                         foreach (var item in Model.OrderDetails)
                        {

#line default
#line hidden
#nullable disable

                WriteLiteral("                            <li class=\"list-group-item d-flex justify-content-between lh-sm\">\r\n                                <div>\r\n                                    <h6 class=\"my-0\">");
                Write(
#nullable restore
#line 77 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\Order\Details.cshtml"
                                                      item.Product.Title

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</h6>\r\n                                    <small class=\"text-muted\">Adet:");
                Write(
#nullable restore
#line 78 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\Order\Details.cshtml"
                                                                    item.Count

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</small>\r\n                                </div>\r\n                                <span class=\"text-muted\">");
                Write(
#nullable restore
#line 80 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\Order\Details.cshtml"
                                                           (item.Count*item.Product.Price).ToString("0.00")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(" ₺</span>\r\n                            </li>\r\n");
#nullable restore
#line 82 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\Order\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable

                WriteLiteral(@"

                        <li class=""list-group-item d-flex justify-content-between bg-light"">
                            <div class=""text-success"">
                                <h6 class=""my-0"">Toplam Tutar:</h6>

                            </div>
                            <span class=""text-success"">");
                Write(
#nullable restore
#line 90 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\Order\Details.cshtml"
                                                         Model.OrderHeader.OrderTotal.ToString("0.00")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(" ₺</span>\r\n                        </li>\r\n\r\n                    </ul>\r\n");
#nullable restore
#line 94 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\Order\Details.cshtml"
                     if (User.IsInRole(Diger.Role_User))
                    {




#line default
#line hidden
#nullable disable

                WriteLiteral("                        <br />\r\n");
#nullable restore
#line 100 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\Order\Details.cshtml"
                         if (Model.OrderHeader.OrderStatus == Diger.Durum_Onaylandi)
                        {

#line default
#line hidden
#nullable disable

                WriteLiteral(@"                            <input type=""submit"" value=""Kargoya Ver""
                                   class=""btn btn-primary form-control""
                                   formaction=""/Admin/Order/KargoyaVer""
                                   formmethod=""post"" />
");
#nullable restore
#line 106 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\Order\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable

#nullable restore
#line 107 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\Order\Details.cshtml"
                         if (Model.OrderHeader.OrderStatus == Diger.Durum_Beklemede)
                        {

#line default
#line hidden
#nullable disable

                WriteLiteral(@"                            <input type=""submit"" value=""Onayla""
                                   class=""btn btn-primary form-control""
                                   formaction=""/Admin/Order/Onaylandi""
                                   formmethod=""post"" />
");
#nullable restore
#line 113 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\Order\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable

#nullable restore
#line 113 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\Order\Details.cshtml"
                         
                    }
                     else
                      {

#line default
#line hidden
#nullable disable

                WriteLiteral("                        <label  class=\"btn btn-primary form-control\">");
                Write(
#nullable restore
#line 117 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\Order\Details.cshtml"
                                                                      Model.OrderHeader.OrderStatus

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</label>\r\n");
#nullable restore
#line 118 "C:\Users\Melisa\source\repos\ShoppingMells\ShoppingMells\Areas\Admin\Views\Order\Details.cshtml"
                      }

#line default
#line hidden
#nullable disable

                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingMells.Models.OrderDetailsVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
