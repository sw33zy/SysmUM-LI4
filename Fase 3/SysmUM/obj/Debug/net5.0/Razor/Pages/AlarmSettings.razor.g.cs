#pragma checksum "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\AlarmSettings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3c98a9ee8173c81c5c1370b87d6391222cfcccc"
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
#line 2 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\AlarmSettings.razor"
using SysmumDataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\AlarmSettings.razor"
using SysmumDataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\AlarmSettings.razor"
using SysmUM.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/alarmsettings")]
    public partial class AlarmSettings : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "full-height");
            __builder.AddAttribute(3, "style", "background-color:#E3E3E3; float: left; width: 20%; padding: 2%; text-align: center;");
            __builder.AddMarkupContent(4, "<div style=\"text-align: center; padding: 5%\"><img src=\"Images/profile.png\"></div>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(5);
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(7, "h3");
                __builder2.AddContent(8, 
#nullable restore
#line 20 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\AlarmSettings.razor"
                     context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, @"<div><a href=""profile"" class=""w3-button w3-black"" style=""margin-left: 10%; margin-right: 10%; margin-top: 10%; margin-bottom: 5%; width: 80%; font-weight: 600;"">Edit Profile</a>
                <a href=""location"" class=""w3-button w3-black"" style=""margin-left: 10%; margin-right: 10%; margin-top: 5%; margin-bottom: 5%; width: 80%; font-weight: 600;"">Set Location</a>
                <a href=""alarmsettings"" class=""w3-button w3-grey w3-hover-grey"" style=""margin-left: 10%; margin-right: 10%; margin-top: 5%; margin-bottom: 5%; width: 80%; font-weight: 600;"">Edit alarm settings</a></div>
            ");
            __builder.AddMarkupContent(11, "<div style=\"margin-top: 10%;\"><hr style=\"width: 90%; border-top: 1px solid #CFCFCF; margin: auto;\">\r\n                <p>v 1.0.0</p></div>\r\n            ");
            __builder.OpenElement(12, "a");
            __builder.AddAttribute(13, "href", "/");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\AlarmSettings.razor"
                                   Logout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "class", "w3-button w3-black");
            __builder.AddAttribute(16, "style", "margin-left: 10%; margin-right: 10%; margin-top: 15%; margin-bottom: 5%; width: 80%; font-weight: 600;");
            __builder.AddContent(17, "Logout");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        \r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "full-height");
            __builder.AddAttribute(21, "style", "background-color:#FBFBFB; float: left; width: 60%; padding: 2%;");
            __builder.AddMarkupContent(22, "<h1 style=\"font-size: 400%; font-weight: 600\"> Alarm Filter</h1>\r\n\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(23);
            __builder.AddAttribute(24, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 37 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\AlarmSettings.razor"
                              user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 37 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\AlarmSettings.razor"
                                                    UpdateConfig

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(26, "action", "action_page.php");
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "w3-container w3-row");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "w3-section w3-left");
                __builder2.AddAttribute(32, "style", "width: 40%");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "w3-container");
                __builder2.AddAttribute(35, "style", "width: 60%");
                __builder2.AddMarkupContent(36, "<label for=\"magnitude\"><b>Magnitude</b></label> <br>\r\n                            ");
                __builder2.OpenElement(37, "input");
                __builder2.AddAttribute(38, "class", "w3-input w3-border w3-margin-bottom w3-hover-border-dark-grey");
                __builder2.AddAttribute(39, "style", "width: 100%");
                __builder2.AddAttribute(40, "type", "text");
                __builder2.AddAttribute(41, "placeholder", "Magnitude (0-10)");
                __builder2.AddAttribute(42, "name", "magnitude");
                __builder2.AddAttribute(43, "id", "magnitude");
                __builder2.AddAttribute(44, "required");
                __builder2.AddAttribute(45, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\AlarmSettings.razor"
                                                                                                                                    user.alarmMagnitude

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.alarmMagnitude = __value, user.alarmMagnitude));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n\r\n                        ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "w3-container");
                __builder2.AddAttribute(50, "style", "width: 60%");
                __builder2.AddMarkupContent(51, "<label for=\"radius\"><b>Radius</b></label> <br>\r\n                            ");
                __builder2.OpenElement(52, "input");
                __builder2.AddAttribute(53, "class", "w3-input w3-border w3-margin-bottom w3-hover-border-dark-grey");
                __builder2.AddAttribute(54, "style", "width: 100%");
                __builder2.AddAttribute(55, "type", "text");
                __builder2.AddAttribute(56, "placeholder", "Radius(km)");
                __builder2.AddAttribute(57, "name", "radius");
                __builder2.AddAttribute(58, "id", "longitude");
                __builder2.AddAttribute(59, "radius");
                __builder2.AddAttribute(60, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 50 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\AlarmSettings.razor"
                                                                                                                                    user.alarmRadius

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.alarmRadius = __value, user.alarmRadius));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n                        ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "popup3");
                __builder2.AddAttribute(65, "style", "width: 100%;");
                __builder2.AddMarkupContent(66, "<button type=\"submit\" class=\"w3-button w3-black\" style=\"margin-right: 10%; margin-top: 50%; margin-bottom: 5%; width: 50%; font-weight: 600;\">Set Filters</button>\r\n                            ");
                __builder2.OpenElement(67, "span");
                __builder2.AddAttribute(68, "class", "popuptext");
                __builder2.AddAttribute(69, "id", "myPopup5");
                __builder2.AddContent(70, 
#nullable restore
#line 54 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\AlarmSettings.razor"
                                                                   LoginMesssage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n\r\n                        ");
                __builder2.AddMarkupContent(72, "<div class=\"w3-section w3-right\" style=\"width: 60%\"><div style=\"text-align: center; padding: 5%\"><img src=\"Images/alarm.png\" style=\"height:450px\"></div></div>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n        \r\n        ");
            __builder.AddMarkupContent(74, "<div class=\"full-height\" style=\"background-color:#E3E3E3; float: left; width: 20%; padding-left: 1%; padding-right: 1%; padding-top: 1%; padding-bottom: 1%; text-align: center\"><h6 style=\"font-weight: 600; padding-bottom: 5%\">STAY SAFE DURING AN EARTHQUAKE</h6>\r\n            <div class=\"w3-white\" style=\"padding-left: 7%; padding-right: 7%; padding-top: 1%; padding-bottom: 1%; margin-bottom: 5%; border-style: solid; border-width: 3px; border-color: grey;\"><p style=\"text-align: justify; text-justify: inter-word;\"><b>DROP down onto your hands and knees</b> before the earthquake knocks you down. This position protects you from falling but allows you to still move if necessary.</p></div>\r\n            <div class=\"w3-white\" style=\"padding-left: 7%; padding-right: 7%; padding-top: 1%; padding-bottom: 1%; margin-bottom: 5%; border-style: solid; border-width: 3px; border-color: grey;\"><p style=\"text-align: justify; text-justify: inter-word;\"><b>COVER your head and neck</b>  (and your entire body if possible) underneath a sturdy table or desk. If there is no shelter nearby, get down near an interior wall or next to low-lying furniture that won???t fall on you, and cover your head and neck with your arms and hands.</p></div>\r\n            <div class=\"w3-white\" style=\"padding-left: 7%; padding-right: 7%; padding-top: 1%; padding-bottom: 1%; margin-bottom: 5%; border-style: solid; border-width: 3px; border-color: grey;\"><p style=\"text-align: justify; text-justify: inter-word;\"><b>HOLD ON to your shelter</b> (or to your head and neck) until the shaking stops. Be prepared to move with your shelter if the shaking shifts it around.</p></div></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\AlarmSettings.razor"
      
    private UserSysmumModel user;
    private string LoginMesssage;

    protected override async Task OnInitializedAsync()
    {
        user = new UserSysmumModel();
        string username = await sessionStorage.GetItemAsync<string>("username");
        user.username = username;
        List<UserSysmumModel> newuser = await _db.getUser(user);
        UserSysmumModel loggedUser = newuser[0];

        user.alarmMagnitude = loggedUser.alarmMagnitude;
        user.alarmRadius = loggedUser.alarmRadius;

        StateHasChanged();

    }

    private async Task<bool> UpdateConfig()
    {
        string username = await sessionStorage.GetItemAsync<string>("username");
        user.username = username;
        List<UserSysmumModel> olduser = await _db.getUser(user);

        if ((user.alarmMagnitude < 0) || (user.alarmMagnitude > 10))
        {
            LoginMesssage = "Magnitude is a value between 0 and 10";
        }

        else
        {
            if ((user.alarmRadius < 0))
            {
                LoginMesssage = "Radius must be a number above 0";
            }

            else
            {
                LoginMesssage = "Profile Updated!";
                olduser[0].alarmMagnitude = user.alarmMagnitude;
                olduser[0].alarmRadius = user.alarmRadius;
                await _db.UpdateUser(olduser[0]);
            }
        }

        await JSRuntime.InvokeVoidAsync("popupConfig");
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
