#pragma checksum "C:\Users\jaral\source\repos\Project4SAD\Project4SAD\Views\Admin\Orders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f26c1dd96d8a56f9aaf8ec2713c7d4e2b6d406f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Orders), @"mvc.1.0.view", @"/Views/Admin/Orders.cshtml")]
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
#line 1 "C:\Users\jaral\source\repos\Project4SAD\Project4SAD\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jaral\source\repos\Project4SAD\Project4SAD\Views\_ViewImports.cshtml"
using Project4SAD.Areas.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f26c1dd96d8a56f9aaf8ec2713c7d4e2b6d406f5", @"/Views/Admin/Orders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72a686a68a7d7df028d1d0128dbd8cf60c4e513f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Orders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Project4SAD.Models.CustomerOrder>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\jaral\source\repos\Project4SAD\Project4SAD\Views\Admin\Orders.cshtml"
  
    ViewData["Title"] = "Orders";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <div class=""row justify-content-center"">
        <div class=""col-md-10"">
            <table class=""table"">
                <thead>
                    <tr>
                        <td>Order Number</td>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 16 "C:\Users\jaral\source\repos\Project4SAD\Project4SAD\Views\Admin\Orders.cshtml"
                     foreach(var i in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 19 "C:\Users\jaral\source\repos\Project4SAD\Project4SAD\Views\Admin\Orders.cshtml"
                           Write(i.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 21 "C:\Users\jaral\source\repos\Project4SAD\Project4SAD\Views\Admin\Orders.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Project4SAD.Models.CustomerOrder>> Html { get; private set; }
    }
}
#pragma warning restore 1591
