#pragma checksum "E:\IES Final Project\code\AspNetCore.Docs\aspnetcore\security\authorization\secure-data\samples\final3\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f2b320a3e5786642fcf7391f5b24dc952a00a21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ContactManager.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ContactManager.Pages
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
#line 1 "E:\IES Final Project\code\AspNetCore.Docs\aspnetcore\security\authorization\secure-data\samples\final3\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\IES Final Project\code\AspNetCore.Docs\aspnetcore\security\authorization\secure-data\samples\final3\Pages\_ViewImports.cshtml"
using ContactManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\IES Final Project\code\AspNetCore.Docs\aspnetcore\security\authorization\secure-data\samples\final3\Pages\_ViewImports.cshtml"
using ContactManager.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\IES Final Project\code\AspNetCore.Docs\aspnetcore\security\authorization\secure-data\samples\final3\Pages\_ViewImports.cshtml"
using ContactManager.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\IES Final Project\code\AspNetCore.Docs\aspnetcore\security\authorization\secure-data\samples\final3\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\IES Final Project\code\AspNetCore.Docs\aspnetcore\security\authorization\secure-data\samples\final3\Pages\_ViewImports.cshtml"
using ContactManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f2b320a3e5786642fcf7391f5b24dc952a00a21", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bb6fdb648ca6b1d4ab1f75553ac21b43bfd10d7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\IES Final Project\code\AspNetCore.Docs\aspnetcore\security\authorization\secure-data\samples\final3\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Contact Manager</h1>
    <b> Application by Shivansh Rupali and Harshdeep</b>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591