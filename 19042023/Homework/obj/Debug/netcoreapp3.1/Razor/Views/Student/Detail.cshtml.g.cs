#pragma checksum "C:\Users\Eagha\Desktop\CodeLessons\P328\3. 19-04-2023\19042023\Homework\Views\Student\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ca6b2d99a4e10cb433b58e943dfdf155dbd855c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Detail), @"mvc.1.0.view", @"/Views/Student/Detail.cshtml")]
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
#line 1 "C:\Users\Eagha\Desktop\CodeLessons\P328\3. 19-04-2023\19042023\Homework\Views\_ViewImports.cshtml"
using Homework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eagha\Desktop\CodeLessons\P328\3. 19-04-2023\19042023\Homework\Views\_ViewImports.cshtml"
using Homework.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ca6b2d99a4e10cb433b58e943dfdf155dbd855c", @"/Views/Student/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b2543360177ff1cea587bd9d468a8c0ac43589", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Student>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Eagha\Desktop\CodeLessons\P328\3. 19-04-2023\19042023\Homework\Views\Student\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detail</h1>\r\n\r\n<h3>Id: ");
#nullable restore
#line 8 "C:\Users\Eagha\Desktop\CodeLessons\P328\3. 19-04-2023\19042023\Homework\Views\Student\Detail.cshtml"
   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>FullName: ");
#nullable restore
#line 9 "C:\Users\Eagha\Desktop\CodeLessons\P328\3. 19-04-2023\19042023\Homework\Views\Student\Detail.cshtml"
         Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\Eagha\Desktop\CodeLessons\P328\3. 19-04-2023\19042023\Homework\Views\Student\Detail.cshtml"
                     Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Point: ");
#nullable restore
#line 10 "C:\Users\Eagha\Desktop\CodeLessons\P328\3. 19-04-2023\19042023\Homework\Views\Student\Detail.cshtml"
      Write(Model.Point);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Student> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
