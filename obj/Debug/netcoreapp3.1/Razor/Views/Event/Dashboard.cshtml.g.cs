#pragma checksum "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\Event\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5983c314fda035c67873ddbc52e02cdbc1dedeb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_Dashboard), @"mvc.1.0.view", @"/Views/Event/Dashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5983c314fda035c67873ddbc52e02cdbc1dedeb1", @"/Views/Event/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eba9d641d3b3b71a9d3a2c94d66654e56c1ca11c", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Event>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\Event\Dashboard.cshtml"
  
    int UserID = (int)Context.Session.GetInt32("uid");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""header"">
    <h3>Welcome to the Event Planner</h3>
    <p><a href=""/logout"">Log Out</a></p>
</div>
<div class=""content"">
    <table class=""table table-striped"">
        <thead>
            <tr>
                <td>Event</td>
                <td>Date</td>
                <td>Attendees</td>
                <td>Action</td>
            </tr>
        </thead>
<tbody>
");
#nullable restore
#line 21 "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\Event\Dashboard.cshtml"
              
                foreach (Event e in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 613, "\"", 637, 2);
            WriteAttributeValue("", 620, "/event/", 620, 7, true);
#nullable restore
#line 25 "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\Event\Dashboard.cshtml"
WriteAttributeValue("", 627, e.EventId, 627, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\Event\Dashboard.cshtml"
                                                   Write(e.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                        <td>");
#nullable restore
#line 26 "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\Event\Dashboard.cshtml"
                       Write(e.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\Event\Dashboard.cshtml"
                       Write(e.Attendees.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 29 "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\Event\Dashboard.cshtml"
                              
                                // if this user is creator, delete button
                                if (e.Creator.UserId == UserID)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 1028, "\"", 1059, 2);
            WriteAttributeValue("", 1035, "/event/delete/", 1035, 14, true);
#nullable restore
#line 33 "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\Event\Dashboard.cshtml"
WriteAttributeValue("", 1049, e.EventId, 1049, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button>Delete</button></a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1128, "\"", 1157, 2);
            WriteAttributeValue("", 1135, "/event/edit/", 1135, 12, true);
#nullable restore
#line 34 "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\Event\Dashboard.cshtml"
WriteAttributeValue("", 1147, e.EventId, 1147, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button>Edit Event</button></a>\r\n");
#nullable restore
#line 35 "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\Event\Dashboard.cshtml"

                                }
                                else if (e.Attendees.Any( a => a.UserId == UserID))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 1387, "\"", 1417, 2);
            WriteAttributeValue("", 1394, "/event/leave/", 1394, 13, true);
#nullable restore
#line 39 "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\Event\Dashboard.cshtml"
WriteAttributeValue("", 1407, e.EventId, 1407, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button>Leave</button></a>\r\n");
#nullable restore
#line 40 "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\Event\Dashboard.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 1593, "\"", 1622, 2);
            WriteAttributeValue("", 1600, "/event/join/", 1600, 12, true);
#nullable restore
#line 43 "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\Event\Dashboard.cshtml"
WriteAttributeValue("", 1612, e.EventId, 1612, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button>Join</button></a>\r\n");
#nullable restore
#line 44 "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\Event\Dashboard.cshtml"
                                }
                                // else if joined, unjoin, and vice versa
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 49 "C:\Users\Dalal Aljohani\Desktop\BootCamp\CSharp\EvantPlanner\Views\Event\Dashboard.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n<div>\r\n    <a href=\"/event/new\"><button>New Event</button></a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Event>> Html { get; private set; }
    }
}
#pragma warning restore 1591
