#pragma checksum "/Users/tammilee/Desktop/codingDojo/csharp/MvcII/FormSub/Views/Home/Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e33c8f0ca8a486fa6924a4f29be316790de3fed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Register.cshtml", typeof(AspNetCore.Views_Home_Register))]
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
#line 1 "/Users/tammilee/Desktop/codingDojo/csharp/MvcII/FormSub/Views/_ViewImports.cshtml"
using FormSub;

#line default
#line hidden
#line 2 "/Users/tammilee/Desktop/codingDojo/csharp/MvcII/FormSub/Views/_ViewImports.cshtml"
using FormSub.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e33c8f0ca8a486fa6924a4f29be316790de3fed", @"/Views/Home/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8f1bba8748ec96c2406f4dabf632a04f01e7201", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FormSub.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 26, true);
            WriteLiteral("\n<div>\n    <p>First Name: ");
            EndContext();
            BeginContext(54, 15, false);
#line 4 "/Users/tammilee/Desktop/codingDojo/csharp/MvcII/FormSub/Views/Home/Register.cshtml"
              Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(69, 23, true);
            WriteLiteral("</p>\n    <p>Last Name: ");
            EndContext();
            BeginContext(93, 14, false);
#line 5 "/Users/tammilee/Desktop/codingDojo/csharp/MvcII/FormSub/Views/Home/Register.cshtml"
             Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(107, 17, true);
            WriteLiteral("</p>\n    <p>Age: ");
            EndContext();
            BeginContext(125, 9, false);
#line 6 "/Users/tammilee/Desktop/codingDojo/csharp/MvcII/FormSub/Views/Home/Register.cshtml"
       Write(Model.Age);

#line default
#line hidden
            EndContext();
            BeginContext(134, 19, true);
            WriteLiteral("</p>\n    <p>Email: ");
            EndContext();
            BeginContext(154, 11, false);
#line 7 "/Users/tammilee/Desktop/codingDojo/csharp/MvcII/FormSub/Views/Home/Register.cshtml"
         Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(165, 11, true);
            WriteLiteral("</p>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FormSub.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591