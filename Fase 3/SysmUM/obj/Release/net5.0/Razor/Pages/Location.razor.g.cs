#pragma checksum "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\Location.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1e2b41c8fcccf36a5a5e860b691ce40239f4e5e"
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
#nullable restore
#line 2 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\Location.razor"
using SysmumDataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\Location.razor"
using SysmumDataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\Location.razor"
using SysmUM.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/location")]
    public partial class Location : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "body");
            __builder.OpenElement(1, "div");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "full-height");
            __builder.AddAttribute(4, "style", "background-color:#E3E3E3; float: left; width: 20%; padding: 2%; text-align: center;");
            __builder.AddMarkupContent(5, "<div style=\"text-align: center; padding: 5%\"><img src=\"Images/profile.png\"></div>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(6);
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(8, "h3");
                __builder2.AddContent(9, 
#nullable restore
#line 19 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\Location.razor"
                     context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.AddMarkupContent(11, @"<div><a href=""profile"" class=""w3-button w3-black"" style=""margin-left: 10%; margin-right: 10%; margin-top: 10%; margin-bottom: 5%; width: 80%; font-weight: 600;"">Edit Profile</a>
                <a href=""location"" class=""w3-button w3-grey w3-hover-grey"" style=""margin-left: 10%; margin-right: 10%; margin-top: 5%; margin-bottom: 5%; width: 80%; font-weight: 600;"">Set Location</a>
                <a href=""alarmsettings"" class=""w3-button w3-black"" style=""margin-left: 10%; margin-right: 10%; margin-top: 5%; margin-bottom: 5%; width: 80%; font-weight: 600;"">Edit alarm settings</a></div>
            ");
            __builder.AddMarkupContent(12, "<div style=\"margin-top: 10%;\"><hr style=\"width: 90%; border-top: 1px solid #CFCFCF; margin: auto;\">\r\n                <p>v 1.0.0</p></div>\r\n            ");
            __builder.OpenElement(13, "a");
            __builder.AddAttribute(14, "href", "/");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\Location.razor"
                                   Logout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "class", "w3-button w3-black");
            __builder.AddAttribute(17, "style", "margin-left: 10%; margin-right: 10%; margin-top: 15%; margin-bottom: 5%; width: 80%; font-weight: 600;");
            __builder.AddContent(18, "Logout");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        \r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "full-height");
            __builder.AddAttribute(22, "style", "background-color:#FBFBFB; float: left; width: 60%; padding: 2%;");
            __builder.AddMarkupContent(23, "<h1 style=\"font-size: 400%; font-weight: 600\">Set Location</h1>\r\n\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(24);
            __builder.AddAttribute(25, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 36 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\Location.razor"
                              user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 36 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\Location.razor"
                                                    UpdateLocation

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(27, "action", "action_page.php");
            __builder.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "w3-container w3-row");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "w3-section w3-left");
                __builder2.AddAttribute(33, "style", "width: 40%");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "w3-container");
                __builder2.AddAttribute(36, "style", "width: 60%");
                __builder2.AddMarkupContent(37, "<label for=\"latitude\"><b>Latitude</b></label> <br>\r\n                            ");
                __builder2.OpenElement(38, "input");
                __builder2.AddAttribute(39, "class", "w3-input w3-border w3-margin-bottom w3-hover-border-dark-grey");
                __builder2.AddAttribute(40, "style", "width: 100%");
                __builder2.AddAttribute(41, "type", "text");
                __builder2.AddAttribute(42, "placeholder", "Latitude");
                __builder2.AddAttribute(43, "name", "latitude");
                __builder2.AddAttribute(44, "id", "latitude");
                __builder2.AddAttribute(45, "required");
                __builder2.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\Location.razor"
                                                                                                                                                user.latitude

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.latitude = __value, user.latitude));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n\r\n                        ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "w3-container");
                __builder2.AddAttribute(51, "style", "width: 60%");
                __builder2.AddMarkupContent(52, "<label for=\"longitude\"><b>Longitude</b></label> <br>\r\n                            ");
                __builder2.OpenElement(53, "input");
                __builder2.AddAttribute(54, "class", "w3-input w3-border w3-margin-bottom w3-hover-border-dark-grey");
                __builder2.AddAttribute(55, "style", "width: 100%");
                __builder2.AddAttribute(56, "type", "text");
                __builder2.AddAttribute(57, "placeholder", "Longitude");
                __builder2.AddAttribute(58, "name", "longitude");
                __builder2.AddAttribute(59, "id", "longitude");
                __builder2.AddAttribute(60, "required");
                __builder2.AddAttribute(61, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\Location.razor"
                                                                                                                                                user.longitude

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.longitude = __value, user.longitude));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n\r\n                        ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "popup3");
                __builder2.AddAttribute(66, "style", "width: 100%;");
                __builder2.AddMarkupContent(67, "<button type=\"submit\" class=\"w3-button w3-black\" style=\"margin-right: 10%; margin-top: 50%; margin-bottom: 5%; width: 50%; font-weight: 600;\">Set Location</button>\r\n                            ");
                __builder2.OpenElement(68, "span");
                __builder2.AddAttribute(69, "class", "popuptext");
                __builder2.AddAttribute(70, "id", "myPopup4");
                __builder2.AddContent(71, 
#nullable restore
#line 54 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\Location.razor"
                                                                   LoginMesssage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n\r\n                        ");
                __builder2.AddMarkupContent(73, "<div class=\"w3-section w3-right\" style=\"width: 60%\"><div style=\"text-align: center; padding: 5%\"><img src=\"Images/location.png\"></div></div>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n        \r\n        ");
            __builder.AddMarkupContent(75, "<div class=\"full-height\" style=\"background-color:#E3E3E3; float: left; width: 20%; padding-left: 1%; padding-right: 1%; padding-top: 1%; padding-bottom: 1%; text-align: center\"><h6 style=\"font-weight: 600; padding-bottom: 5%\">STAY SAFE DURING AN EARTHQUAKE</h6>\r\n            <div class=\"w3-white\" style=\"padding-left: 7%; padding-right: 7%; padding-top: 1%; padding-bottom: 1%; margin-bottom: 5%; border-style: solid; border-width: 3px; border-color: grey;\"><p style=\"text-align: justify; text-justify: inter-word;\"><b>DROP down onto your hands and knees</b> before the earthquake knocks you down. This position protects you from falling but allows you to still move if necessary.</p></div>\r\n            <div class=\"w3-white\" style=\"padding-left: 7%; padding-right: 7%; padding-top: 1%; padding-bottom: 1%; margin-bottom: 5%; border-style: solid; border-width: 3px; border-color: grey;\"><p style=\"text-align: justify; text-justify: inter-word;\"><b>COVER your head and neck</b>  (and your entire body if possible) underneath a sturdy table or desk. If there is no shelter nearby, get down near an interior wall or next to low-lying furniture that won’t fall on you, and cover your head and neck with your arms and hands.</p></div>\r\n            <div class=\"w3-white\" style=\"padding-left: 7%; padding-right: 7%; padding-top: 1%; padding-bottom: 1%; margin-bottom: 5%; border-style: solid; border-width: 3px; border-color: grey;\"><p style=\"text-align: justify; text-justify: inter-word;\"><b>HOLD ON to your shelter</b> (or to your head and neck) until the shaking stops. Be prepared to move with your shelter if the shaking shifts it around.</p></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\Location.razor"
      

    private UserSysmumModel user;
    private string LoginMesssage;

    protected override async Task OnInitializedAsync()
    {
        user = new UserSysmumModel();
        string username = await sessionStorage.GetItemAsync<string>("username");
        user.username = username;
        List<UserSysmumModel> newuser = await _db.getUser(user);
        UserSysmumModel loggedUser = newuser[0];

        user.latitude = loggedUser.latitude;
        user.longitude = loggedUser.longitude;

        StateHasChanged();

    }

    private async Task<bool> UpdateLocation()
    {
        string username = await sessionStorage.GetItemAsync<string>("username");
        user.username = username;
        List<UserSysmumModel> olduser = await _db.getUser(user);

        if ((user.latitude <= - 90 ) || (user.latitude >= 90))
        {
            LoginMesssage = "Latitude should be a value between -90 and +90";
        }

        else
        {
            if ((user.longitude <= -180 ) || (user.longitude >= 180))
            {
                LoginMesssage = "Longitude should be a value between -180 and +180";
            }

            else
            {
                LoginMesssage = "Profile Updated!";
                olduser[0].latitude = user.latitude;
                olduser[0].longitude = user.longitude;
                await _db.UpdateUser(olduser[0]);
            }
        }

        await JSRuntime.InvokeVoidAsync("popupLocal");
        return await Task.FromResult(true);
    }

    public async void Logout()
    {
        ((Auth)AuthenticationStateProvider).MarkUserAsLoggedOut();
        await JSRuntime.InvokeVoidAsync("reload");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserData _db { get; set; }
    }
}
#pragma warning restore 1591