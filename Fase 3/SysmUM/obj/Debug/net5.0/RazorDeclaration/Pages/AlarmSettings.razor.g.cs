// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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