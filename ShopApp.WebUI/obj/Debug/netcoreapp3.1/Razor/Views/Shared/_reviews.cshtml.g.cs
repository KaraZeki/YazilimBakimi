#pragma checksum "D:\Asp_NETMVC\SadikTuran\ShopApp\ShopApp.WebUI\Views\Shared\_reviews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bf5fc2ddfef22f0331f78fd5892a2bfaf427126"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__reviews), @"mvc.1.0.view", @"/Views/Shared/_reviews.cshtml")]
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
#line 1 "D:\Asp_NETMVC\SadikTuran\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Asp_NETMVC\SadikTuran\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Exensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Asp_NETMVC\SadikTuran\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bf5fc2ddfef22f0331f78fd5892a2bfaf427126", @"/Views/Shared/_reviews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4c41a374c6aa0555cf6c98adbfc89d8bcfa39ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__reviews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Review>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<div class=\"review-block  border-top mt-3 pt-3\">\r\n    <p class=\"review-text font-italic m-0\">");
#nullable restore
#line 6 "D:\Asp_NETMVC\SadikTuran\ShopApp\ShopApp.WebUI\Views\Shared\_reviews.cshtml"
                                      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <div class=\"rating-star mb-4\">\r\n");
#nullable restore
#line 8 "D:\Asp_NETMVC\SadikTuran\ShopApp\ShopApp.WebUI\Views\Shared\_reviews.cshtml"
         for (int x = 1; x <= Model.Star; x++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <i class=\"fa fa-fw fa-star\"></i>\r\n");
#nullable restore
#line 11 "D:\Asp_NETMVC\SadikTuran\ShopApp\ShopApp.WebUI\Views\Shared\_reviews.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("       \r\n    </div>\r\n    <span class=\"text-dark font-weight-bold\">");
#nullable restore
#line 14 "D:\Asp_NETMVC\SadikTuran\ShopApp\ShopApp.WebUI\Views\Shared\_reviews.cshtml"
                                        Write(Model.UserFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><small class=\"text-mute\"> (Company name)</small>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Review> Html { get; private set; }
    }
}
#pragma warning restore 1591
