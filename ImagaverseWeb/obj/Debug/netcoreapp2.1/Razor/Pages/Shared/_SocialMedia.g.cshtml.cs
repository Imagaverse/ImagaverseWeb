#pragma checksum "C:\Users\ryana\Desktop\ImagaverseWeb\ImagaverseWeb\Pages\Shared\_SocialMedia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7a3ec58863c7f3ffc81f09b67bd9f045b67c8cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Shared__SocialMedia), @"mvc.1.0.razor-page", @"/Pages/Shared/_SocialMedia.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Shared/_SocialMedia.cshtml", typeof(AspNetCore.Pages_Shared__SocialMedia), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7a3ec58863c7f3ffc81f09b67bd9f045b67c8cc", @"/Pages/Shared/_SocialMedia.cshtml")]
    public class Pages_Shared__SocialMedia : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(68, 1002, true);
            WriteLiteral(@"<ul class=""SocialMedia"">
    <li class=""Twitter"">
        <a href=""https://mobile.twitter.com/imagaverse"">
            <i class=""fab fa-twitter""></i>
        </a>
    </li>
    <li class=""Facebook"">
        <a href=""https://www.facebook.com/Imagaverse/"">
            <i class=""fab fa-facebook-f""></i>
        </a>
    </li>
    <li class=""Instagram"">
        <a href=""https://www.instagram.com/imagaverse/"">
            <i class=""fab fa-instagram""></i>
        </a>
    </li>
    <li class=""YouTube"">
        <a href=""https://www.youtube.com/channel/UCi8GAd2J8wOe7C-vVLXg5_Q"">
            <i class=""fab fa-youtube""></i>
        </a>
    </li>
    <li class=""GooglePlus"">
        <a href=""https://plus.google.com/106114664161955542119"">
            <i class=""fab fa-google-plus-g""></i>
        </a>
    </li>
    <li class=""SoundCloud"">
        <a href=""https://soundcloud.com/user-148126880"">
            <i class=""fab fa-soundcloud""></i>
        </a>
    </li>
</ul>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ImagaverseWeb.Shared._SocialMediaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ImagaverseWeb.Shared._SocialMediaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ImagaverseWeb.Shared._SocialMediaModel>)PageContext?.ViewData;
        public ImagaverseWeb.Shared._SocialMediaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
