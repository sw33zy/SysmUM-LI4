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
#line 2 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\Query.razor"
using SysmumDataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\Query.razor"
using SysmumDataAccessLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/queries")]
    public partial class Query : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\Leonardo\Documents\GitHub\SysmUM\Fase 3\SysmUM\Pages\Query.razor"
           
        private float latitude = 0.0f;
        private float longitude = 0.0f;
        private float radius = 180.0f;
        private float minmagnitude = 0.0f;
        private List<SeismModel> seisms;
        private DateTime startTime = new DateTime(2021 - 01 - 01);
        private DateTime endTime = DateTime.Now;

        async void SearchSeisms()
        {
            seisms = new List<SeismModel>();
            List<SeismModel> allSeisms;
            allSeisms = await _db.GetSeisms();
            foreach (var Seism in allSeisms)
            {
                float lat = Seism.latitude;
                float lon = Seism.longitude;
                float mag = 0;
                DateTime dt = Seism.dateSeism;
                if (Seism.magnitude.HasValue)
                {
                    mag = Seism.magnitude.Value;
                }
                if ((lat <= (latitude + radius) && lat >= (latitude - radius)) &&
                    (lon <= (longitude + radius) && lon >= (longitude - radius))
                    && mag >= minmagnitude && (dt <= endTime && dt >= startTime))
                    seisms.Add(Seism);
            }
            StateHasChanged();
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISeismData _db { get; set; }
    }
}
#pragma warning restore 1591
