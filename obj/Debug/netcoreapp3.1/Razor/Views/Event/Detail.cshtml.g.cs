#pragma checksum "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\Event\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a88dbcd2c050b58a3cafc402c2d688e50ad2b12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_Detail), @"mvc.1.0.view", @"/Views/Event/Detail.cshtml")]
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
#line 1 "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\_ViewImports.cshtml"
using EvantPlanner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\_ViewImports.cshtml"
using EvantPlanner.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a88dbcd2c050b58a3cafc402c2d688e50ad2b12", @"/Views/Event/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eba9d641d3b3b71a9d3a2c94d66654e56c1ca11c", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Event>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"header\">\r\n    <h2>");
#nullable restore
#line 3 "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\Event\Detail.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <p><a href=\"/dashboard\">Dashboard</a> | <a href=\"/logout\">Logout</a></p>\r\n</div>\r\n<div class=\"body\">\r\n    <h3>");
#nullable restore
#line 7 "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\Event\Detail.cshtml"
   Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <p>");
#nullable restore
#line 8 "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\Event\Detail.cshtml"
  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h3>Guests</h3>\r\n");
#nullable restore
#line 10 "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\Event\Detail.cshtml"
      
        foreach (Attendee guest in Model.Attendees)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>");
#nullable restore
#line 13 "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\Event\Detail.cshtml"
          Write(guest.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\Event\Detail.cshtml"
                                Write(guest.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 14 "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\Event\Detail.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 411, "\"", 444, 2);
            WriteAttributeValue("", 418, "/event/edit/", 418, 12, true);
#nullable restore
#line 17 "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\Event\Detail.cshtml"
WriteAttributeValue("", 430, Model.EventId, 430, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button>Edit Event</button></a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Event> Html { get; private set; }
    }
}
#pragma warning restore 1591
