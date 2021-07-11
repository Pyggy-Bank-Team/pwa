#pragma checksum "C:\Repos\pwa\src\Nexus\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77cc9c30b4678adc0706cdb8e7370d946fd54709"
// <auto-generated/>
#pragma warning disable 1591
namespace Nexus.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Repos\pwa\src\Nexus\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Repos\pwa\src\Nexus\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Repos\pwa\src\Nexus\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Repos\pwa\src\Nexus\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Repos\pwa\src\Nexus\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Repos\pwa\src\Nexus\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Repos\pwa\src\Nexus\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Repos\pwa\src\Nexus\_Imports.razor"
using Nexus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Repos\pwa\src\Nexus\_Imports.razor"
using Nexus.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Repos\pwa\src\Nexus\_Imports.razor"
using Nexus.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Repos\pwa\src\Nexus\Pages\Counter.razor"
using Nexus.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Repos\pwa\src\Nexus\Pages\Counter.razor"
using Nexus.Contracts.Requests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Repos\pwa\src\Nexus\Pages\Counter.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Repos\pwa\src\Nexus\Pages\Counter.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 11 "C:\Repos\pwa\src\Nexus\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Repos\pwa\src\Nexus\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "span");
            __builder.AddContent(11, 
#nullable restore
#line 15 "C:\Repos\pwa\src\Nexus\Pages\Counter.razor"
       token

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Repos\pwa\src\Nexus\Pages\Counter.razor"
       
    private int currentCount = 0;
    private string token;

    protected override async Task OnInitializedAsync()
    {
        var request = new GetTokenRequest
        {
            Password = "dTrest22~",
            UserName = "denis"
        };
        //
        // var response = await HttpClient.GetAsync("https://dev.piggybank.pro/api/Currencies");
        //
        // token = response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync(): "oppps";

        // var response = UserService.GetAccessToken(request, CancellationToken.None);
        // token = response.IsSuccess ? response.Ok.AccessToken: "oppps";


        var response = await HttpClient.PostAsJsonAsync("https://dev.piggybank.pro/api/Tokens/Connect", request);
        token = response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync(): "oppps";

        HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6ImJjMGU2NzcyLTI2MWEtNDg3ZS1hZGY4LTliZjQyMjllZWYwZiIsImN1cnJlbmN5IjoiUlVCIiwibmJmIjoxNjI2MDA2NDY1LCJleHAiOjE2MjYwMDY0NjYsImlzcyI6Iklzc3VlciIsImF1ZCI6IkF1ZGllbmNlIn0.jVvlzC8c7iHwAmzFCOURZom0dSlWveLXRyrVFRk8wis");

        response = await HttpClient.GetAsync("https://dev.piggybank.pro/api/Operations");
        token = response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync(): "oppps";
    }

    private void IncrementCount()
    {
        currentCount++;


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
    }
}
#pragma warning restore 1591
