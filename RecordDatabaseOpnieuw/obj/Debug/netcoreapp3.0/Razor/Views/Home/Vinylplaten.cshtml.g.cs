#pragma checksum "C:\Users\rondi\source\repos\RecordDatabaseOpnieuw\RecordDatabaseOpnieuw\Views\Home\Vinylplaten.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94cf4c842ed7076b8d1dc01528ebc481592677e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Vinylplaten), @"mvc.1.0.view", @"/Views/Home/Vinylplaten.cshtml")]
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
#line 1 "C:\Users\rondi\source\repos\RecordDatabaseOpnieuw\RecordDatabaseOpnieuw\Views\_ViewImports.cshtml"
using RecordDatabaseOpnieuw;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rondi\source\repos\RecordDatabaseOpnieuw\RecordDatabaseOpnieuw\Views\_ViewImports.cshtml"
using RecordDatabaseOpnieuw.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94cf4c842ed7076b8d1dc01528ebc481592677e2", @"/Views/Home/Vinylplaten.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53380daf88f49aa4d6092aeed91a2f88be127d26", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Vinylplaten : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RecordDatabaseOpnieuw.Models.VinylplatenModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\rondi\source\repos\RecordDatabaseOpnieuw\RecordDatabaseOpnieuw\Views\Home\Vinylplaten.cshtml"
  
    ViewData["Title"] = "Vinylplaten";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h1>Vinyl database</h1>



<table class=""table"">

    <tr class=""header"">
        <th class=""cell""></th>
        <th class=""cell"">Artist</th>
        <th class=""cell"">Album</th>
        <th class=""cell"">Release Date</th>
        <th class=""cell"">Genre</th>
        <th class=""cell"">In Possesion?</th>
        <th class=""cell""> Edit</th>
        <th class=""cell"">Delete</th>

    </tr>


    ");
#nullable restore
#line 28 "C:\Users\rondi\source\repos\RecordDatabaseOpnieuw\RecordDatabaseOpnieuw\Views\Home\Vinylplaten.cshtml"
Write(Html.DisplayForModel());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</table>\r\n<br />\r\n\r\n\r\n");
#nullable restore
#line 34 "C:\Users\rondi\source\repos\RecordDatabaseOpnieuw\RecordDatabaseOpnieuw\Views\Home\Vinylplaten.cshtml"
Write(Html.ActionLink("Create vinyl", "Create", "Home", "", new { id = "button" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RecordDatabaseOpnieuw.Models.VinylplatenModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
