#pragma checksum "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8329a640e5f105a6234997a7b7878e9cc290a495"
// <auto-generated/>
#pragma warning disable 1591
namespace SysmUM.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\_Imports.razor"
using SysmUM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\_Imports.razor"
using SysmUM.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "w3-container w3-light-grey w3-padding");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "style", "padding-top:1% ; padding-bottom: 1%; width: 50%");
            __builder.AddAttribute(4, "class", "w3-left");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "style", "padding-left: 20%");
            __builder.AddMarkupContent(7, "<h1 class=\"w3-xxxlarge\">What are we?</h1>\r\n            ");
            __builder.AddMarkupContent(8, "<h4 style=\"color: #7F7F7F\">SysmUM is a real time earthquake monitoring <br>system that notifies you every time you are in the <br>vicinity of an earthquake. </h4>\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "w3-padding-32");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(11);
            __builder.AddAttribute(12, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(13, "<a onclick=\"document.getElementById(\'id01\').style.display=\'block\'\" href=\"#\" class=\"w3-btn w3-xlarge w3-dark-grey w3-hover-light-grey w3-animate-bottom\" style=\"font-weight:600; border-radius: 5px; animation-duration: 0.5s;\">Register</a>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.AddMarkupContent(15, "<div class=\"w3-right\" style=\"padding-right: 25%\"><img src=\"Images/landing1.png\" style=\"margin: 10px; height: 260px\"></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n");
            __builder.OpenComponent<SysmUM.Shared.Register>(17);
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.OpenComponent<SysmUM.Shared.Login>(19);
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n\r\n\r\n\r\n");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "w3-row-padding w3-center w3-margin-top");
            __builder.AddMarkupContent(23, "<div class=\"w3-col\" style=\"width:37%; padding-left:20px\"><img src=\"Images/map.png\" style=\"height: 340px\"></div>\r\n\r\n    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "w3-col w3-animate-bottom");
            __builder.AddAttribute(26, "style", "width:21%; animation-duration: 0.5s;");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "w3-card");
            __builder.AddAttribute(29, "style", "min-height:350px");
            __builder.AddMarkupContent(30, "<div class=\"w3-dark-grey\" style=\"padding-top:5% ; padding-bottom: 5%\"><img src=\"Images/card1.png\" style=\"height: 60px\"></div>\r\n            ");
            __builder.AddMarkupContent(31, @"<div style=""padding-left: 35px; padding-right: 35px; padding-top: 35px; padding-bottom: 5px""><p style=""font-weight:600; font-size:20px; text-align: left;"">Check seismic activity</p>
                <p style=""text-align: left;"">Allows you to inspect current seismic activity at your location or others desired. You can also check previous earthquakes within a  given time interval. </p></div>
            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(32);
            __builder.AddAttribute(33, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(34, @"<button onclick=""document.getElementById('id02').style.display='block'"" class=""w3-btn w3-small w3-dark-grey w3-hover-light-grey"" style=""width: 180px; font-weight:600; border-radius: 5px; height:32px""><i class="" w3-large material-icons"">arrow_forward</i></button>");
            }
            ));
            __builder.AddAttribute(35, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(36, "<a href=\"current\" class=\"w3-btn w3-small w3-dark-grey w3-hover-light-grey\" style=\"width: 180px; font-weight:600; border-radius: 5px; height:32px\"><i class=\" w3-large material-icons\">arrow_forward</i></a>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "w3-col w3-animate-bottom");
            __builder.AddAttribute(40, "style", "width:21%; animation-duration: 1s;");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "w3-card");
            __builder.AddAttribute(43, "style", "min-height:350px");
            __builder.AddMarkupContent(44, "<div class=\"w3-dark-grey\" style=\"padding-top:5% ; padding-bottom: 5%\"><img src=\"Images/card2.png\" style=\"height: 60px\"></div>\r\n            ");
            __builder.AddMarkupContent(45, @"<div style=""padding-left: 35px; padding-right: 35px; padding-top: 35px; padding-bottom: 5px""><p style=""font-weight:600; font-size:20px; text-align: left;"">Be safe</p>
                <p style=""text-align: left;"">
                    Every time you are within radius of an earthquake, recieve a warning. You are allowed to filter these warnings based on radius and magnitude.
                </p></div>
            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(46);
            __builder.AddAttribute(47, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(48, @"<button onclick=""document.getElementById('id02').style.display='block'"" class=""w3-btn w3-small w3-dark-grey w3-hover-light-grey"" style=""width: 180px; font-weight:600; border-radius: 5px; height:32px""><i class="" w3-large material-icons"">arrow_forward</i></button>");
            }
            ));
            __builder.AddAttribute(49, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(50, "<a href=\"queries\" class=\"w3-btn w3-small w3-dark-grey w3-hover-light-grey\" style=\"width: 180px; font-weight:600; border-radius: 5px; height:32px\"><i class=\" w3-large material-icons\">arrow_forward</i></a>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\r\n    ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "w3-col w3-animate-bottom");
            __builder.AddAttribute(54, "style", "width:21%; animation-duration: 1.5s;");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "w3-card");
            __builder.AddAttribute(57, "style", "min-height:350px");
            __builder.AddMarkupContent(58, "<div class=\"w3-dark-grey\" style=\"padding-top:5% ; padding-bottom: 5%\"><img src=\"Images/card3.png\" style=\"height: 60px\"></div>\r\n            ");
            __builder.AddMarkupContent(59, @"<div style=""padding-left: 35px; padding-right: 35px; padding-top: 35px; padding-bottom: 50px;""><p style=""font-weight:600; font-size:20px; text-align: left;"">Protection prevision</p>
                <p style=""text-align: left;"">Based on your current location's seismic history, estimates your safety level. </p></div>
            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(60);
            __builder.AddAttribute(61, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(62, @"<button onclick=""document.getElementById('id02').style.display='block'"" class=""w3-btn w3-small w3-dark-grey w3-hover-light-grey"" style=""width: 180px; font-weight:600; border-radius: 5px; height:32px""><i class="" w3-large material-icons"">arrow_forward</i></button>");
            }
            ));
            __builder.AddAttribute(63, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(64, "<a href=\"queries\" class=\"w3-btn w3-small w3-dark-grey w3-hover-light-grey\" style=\"width: 180px; font-weight:600; border-radius: 5px; height:32px\"><i class=\" w3-large material-icons\">arrow_forward</i></a>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591