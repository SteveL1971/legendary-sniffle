#pragma checksum "C:\inl_backend\inl1\BlazorApp\Shared\OrdersList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81622fef613ccf3e3d6966bf5e201ac187c87e56"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\inl_backend\inl1\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\inl_backend\inl1\BlazorApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inl_backend\inl1\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\inl_backend\inl1\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\inl_backend\inl1\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inl_backend\inl1\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\inl_backend\inl1\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\inl_backend\inl1\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\inl_backend\inl1\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\inl_backend\inl1\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\inl_backend\inl1\BlazorApp\_Imports.razor"
using SharedLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\inl_backend\inl1\BlazorApp\_Imports.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\inl_backend\inl1\BlazorApp\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    public partial class OrdersList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container mt-5");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
#nullable restore
#line 5 "C:\inl_backend\inl1\BlazorApp\Shared\OrdersList.razor"
             if (orders == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<div class=\"d-flex justify-content-center align-items-center vh-100\"><div class=\"spinner-border\" role=\"status\"><span class=\"visually-hidden\">Loading products</span></div></div>");
#nullable restore
#line 12 "C:\inl_backend\inl1\BlazorApp\Shared\OrdersList.razor"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\inl_backend\inl1\BlazorApp\Shared\OrdersList.razor"
                 foreach (var order in orders.Where(n => n.UserId == 1))
                {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorApp.Shared.OrderItem>(7);
            __builder.AddAttribute(8, "Oitem", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SharedLibrary.Models.OrderCreate>(
#nullable restore
#line 17 "C:\inl_backend\inl1\BlazorApp\Shared\OrdersList.razor"
                                       order

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 18 "C:\inl_backend\inl1\BlazorApp\Shared\OrdersList.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\inl_backend\inl1\BlazorApp\Shared\OrdersList.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\inl_backend\inl1\BlazorApp\Shared\OrdersList.razor"
       
    private OrderCreate[] orders;
    
    private async Task GetOrdersAsync()
    {
        orders = await Http.GetFromJsonAsync<OrderCreate[]>("https://localhost:44367/api/Orders");
    }

    protected override void OnInitialized()
    {
        var timer = new Timer(new TimerCallback(_ => InvokeAsync(() => StateHasChanged())), null, 1000, 1000);

    }


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await GetOrdersAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStore { get; set; }
    }
}
#pragma warning restore 1591
