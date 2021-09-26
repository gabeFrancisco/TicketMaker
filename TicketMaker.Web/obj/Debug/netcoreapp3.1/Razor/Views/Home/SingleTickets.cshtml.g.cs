#pragma checksum "/mnt/76AAE8F7AAE8B531/ASP.Net Core/TicketMaker/TicketMaker.Web/Views/Home/SingleTickets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "691cfed87c480a39f74f065a770e9463e6643cb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SingleTickets), @"mvc.1.0.view", @"/Views/Home/SingleTickets.cshtml")]
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
#line 1 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/TicketMaker/TicketMaker.Web/Views/_ViewImports.cshtml"
using TicketMaker.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/TicketMaker/TicketMaker.Web/Views/_ViewImports.cshtml"
using TicketMaker.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"691cfed87c480a39f74f065a770e9463e6643cb9", @"/Views/Home/SingleTickets.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e74e49a84bc1b6a555736fa2b67fe81a772753c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SingleTickets : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TicketMaker.Web.Models.TicketIssuer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"ticket-area\">\n");
#nullable restore
#line 4 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/TicketMaker/TicketMaker.Web/Views/Home/SingleTickets.cshtml"
     foreach (var ticket in Model.Tickets)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""ticket"">
            <div class=""title bg-success"">
                Rifa do Seu Madruga!
                Valendo 14 meses de aluguel!
            </div>
            <div class=""content"">
                <div class=""dollar text-success"">
                    $
                </div>
                <div class=""disclaimer"">
                    O prêmio só terá validade até as 08h00 da manhã do dia seguinte pagável ao portador. Após esse horário o
                    bilhete não terá mais validade e o prêmio acumulará!
                </div>
                <div class=""dollar text-success"">
                    $
                </div>
            </div>
            <div class=""ticket-number-area bg-success"">
                <div class=""ticket-number"">
                    #");
#nullable restore
#line 25 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/TicketMaker/TicketMaker.Web/Views/Home/SingleTickets.cshtml"
                Write(ticket.NumberSet[0].ToString("d4"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 29 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/TicketMaker/TicketMaker.Web/Views/Home/SingleTickets.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TicketMaker.Web.Models.TicketIssuer> Html { get; private set; }
    }
}
#pragma warning restore 1591