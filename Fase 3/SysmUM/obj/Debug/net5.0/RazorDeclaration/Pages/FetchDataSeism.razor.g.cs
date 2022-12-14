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
#line 3 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\FetchDataSeism.razor"
using SysmUM.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\FetchDataSeism.razor"
using SysmumDataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\FetchDataSeism.razor"
using SysmumDataAccessLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdataseism")]
    public partial class FetchDataSeism : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\FetchDataSeism.razor"
       
    private List<SeismModel> seisms;

    protected override async Task OnInitializedAsync()
    {
        /*List<SeismModel> seismsdata = await Service.GetSeisms();
        foreach (var seism in seismsdata)
        {
            await _db.InsertSeism(seism);
        }
        seisms = await  _db.GetSeisms();
        await base.InvokeAsync(StateHasChanged);*/
        //SetTimer();
    }

    private async void SetTimer()
    {
        var startTimeSpan = TimeSpan.Zero;
        var periodTimeSpan = TimeSpan.FromMinutes(1);

        var timer = new System.Threading.Timer(async (e) =>
        {
            List<SeismModel> seismsdata = await Service.GetSeismsLastHour();
            foreach (var seism in seismsdata)
            {
                bool found = false;
                List<SeismModel> seismsindb = await _db.GetSeisms();
                foreach(var s in seismsindb)
                {
                    if (s.id == seism.id)
                        found = true;
                }
                if(!found)
                    await _db.InsertSeism(seism);
            }
            seisms = await _db.GetSeisms();
            await base.InvokeAsync(StateHasChanged);
        }, null, startTimeSpan, periodTimeSpan);
    }

    private async void updateListHour()
    {
        List<SeismModel> seismsdata = await Service.GetSeismsLastHour();
        foreach (var seism in seismsdata)
        {
            /*bool found = false;
            List<SeismModel> seismsindb = await _db.GetSeisms();
            foreach (var s in seismsindb)
            {
                if (s.id == seism.id)
                    found = true;
            }
            if (!found)*/
            await _db.InsertSeism(seism);
        }
        seisms = seismsdata;
        //seisms = await _db.GetSeisms();
        await base.InvokeAsync(StateHasChanged);
    }

    private async void updateListDay()
    {
        List<SeismModel> seismsdata = await Service.GetSeismsLastDay();
        foreach (var seism in seismsdata)
        {
            /*bool found = false;
            List<SeismModel> seismsindb = await _db.GetSeisms();
            foreach (var s in seismsindb)
            {
                if (s.id == seism.id)
                    found = true;
            }
            if (!found)*/
            await _db.InsertSeism(seism);
        }
        seisms = seismsdata;
        //seisms = await _db.GetSeisms();
        await base.InvokeAsync(StateHasChanged);
    }

    private async void updateListWeek()
    {
        List<SeismModel> seismsdata = await Service.GetSeismsLastWeek();
        foreach (var seism in seismsdata)
        {
            /*bool found = false;
            List<SeismModel> seismsindb = await _db.GetSeisms();
            foreach (var s in seismsindb)
            {
                if (s.id == seism.id)
                    found = true;
            }
            if (!found)*/
            await _db.InsertSeism(seism);
        }
        seisms = seismsdata;
        //seisms = await _db.GetSeisms();
        await base.InvokeAsync(StateHasChanged);
    }

    private async void updateListMonth()
    {
        List<SeismModel> seismsdata = await Service.GetSeisms();
        foreach (var seism in seismsdata)
        {
            /*bool found = false;
            List<SeismModel> seismsindb = await _db.GetSeisms();
            foreach (var s in seismsindb)
            {
                if (s.id == seism.id)
                    found = true;
            }
            if (!found)*/
            await _db.InsertSeism(seism);
        }
        seisms = seismsdata;
        //seisms = await _db.GetSeisms();
        await base.InvokeAsync(StateHasChanged);
    }

    private void removeList()
    {
        seisms = null;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPositionData _dbPos { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISeismData _db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SeismService Service { get; set; }
    }
}
#pragma warning restore 1591
