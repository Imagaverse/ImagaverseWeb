#pragma checksum "C:\Users\ryana\Desktop\ImagaverseWeb\ImagaverseWeb\Pages\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f01075ef9181efa43e60a85e7ab1ff5ef9842216"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Login), @"mvc.1.0.razor-page", @"/Pages/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Login.cshtml", typeof(AspNetCore.Pages_Login), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f01075ef9181efa43e60a85e7ab1ff5ef9842216", @"/Pages/Login.cshtml")]
    public class Pages_Login : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\ryana\Desktop\ImagaverseWeb\ImagaverseWeb\Pages\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
            BeginContext(87, 60, true);
            WriteLiteral("<div class=\"PageContainer\">\r\n    <h1>Login Page</h1>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ImagaverseWeb.Pages.LoginModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ImagaverseWeb.Pages.LoginModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ImagaverseWeb.Pages.LoginModel>)PageContext?.ViewData;
        public ImagaverseWeb.Pages.LoginModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591