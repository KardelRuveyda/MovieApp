#pragma checksum "C:\Users\KardelRuveyda\Desktop\Projects\MovieApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f9f85fb86f8277b568399e5e76a58ad6241aef3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\KardelRuveyda\Desktop\Projects\MovieApp\Views\_ViewImports.cshtml"
using MovieApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f9f85fb86f8277b568399e5e76a58ad6241aef3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3fd1543014ab08bb53b07398d8ea7f79632394b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieCategoryModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 55, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");
            EndContext();
            BeginContext(83, 38, false);
#line 4 "C:\Users\KardelRuveyda\Desktop\Projects\MovieApp\Views\Home\Index.cshtml"
   Write(Html.Partial("_menu",Model.Categories));

#line default
#line hidden
            EndContext();
            BeginContext(121, 50, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        ");
            EndContext();
            BeginContext(172, 36, false);
#line 7 "C:\Users\KardelRuveyda\Desktop\Projects\MovieApp\Views\Home\Index.cshtml"
   Write(Html.Partial("_movies",Model.Movies));

#line default
#line hidden
            EndContext();
            BeginContext(208, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieCategoryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
