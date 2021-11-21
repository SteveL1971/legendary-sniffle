#pragma checksum "C:\inl_backend\inl1\BlazorApp\Shared\BasketList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efa847c1130131f74c4c5a33de5a0c46cc242cf1"
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
    public partial class BasketList : Microsoft.AspNetCore.Components.ComponentBase
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
#line 5 "C:\inl_backend\inl1\BlazorApp\Shared\BasketList.razor"
             if (basket == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<div class=\"d-flex justify-content-center align-items-center vh-100\"><div class=\"spinner-border\" role=\"status\"><span class=\"visually-hidden\">Loading products</span></div></div>");
#nullable restore
#line 12 "C:\inl_backend\inl1\BlazorApp\Shared\BasketList.razor"
            }
            else
            {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "container d-flex flex-column mb-4");
            __builder.OpenElement(9, "div");
            __builder.AddContent(10, "Number of item rows: ");
            __builder.AddContent(11, 
#nullable restore
#line 17 "C:\inl_backend\inl1\BlazorApp\Shared\BasketList.razor"
                                               totalRows

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "div");
            __builder.AddContent(14, "Total number of items: ");
            __builder.AddContent(15, 
#nullable restore
#line 18 "C:\inl_backend\inl1\BlazorApp\Shared\BasketList.razor"
                                                 totalItems

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "div");
            __builder.AddContent(18, "Total Price: ");
            __builder.AddContent(19, 
#nullable restore
#line 19 "C:\inl_backend\inl1\BlazorApp\Shared\BasketList.razor"
                                       totalPrice

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(20, " kr");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "C:\inl_backend\inl1\BlazorApp\Shared\BasketList.razor"
                 foreach (var product in basket)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorApp.Shared.BasketItem>(21);
            __builder.AddAttribute(22, "Item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SharedLibrary.Models.Product>(
#nullable restore
#line 24 "C:\inl_backend\inl1\BlazorApp\Shared\BasketList.razor"
                                       product

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 25 "C:\inl_backend\inl1\BlazorApp\Shared\BasketList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "class", "w-25 mt-4 btn btn-secondary btn-small");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\inl_backend\inl1\BlazorApp\Shared\BasketList.razor"
                                                                                SubmitOrder

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Place order");
            __builder.CloseElement();
#nullable restore
#line 28 "C:\inl_backend\inl1\BlazorApp\Shared\BasketList.razor"

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
#line 36 "C:\inl_backend\inl1\BlazorApp\Shared\BasketList.razor"
       
    private Product[] products;

    private OrderCreate order;
    private OrderLineCreate orderLine;

    public Product Item { get; set; }

    List<Product> basket = new List<Product>();

    private int totalRows;
    private int totalItems;
    private decimal _totalPrice;
    public string totalPrice;



    private async Task GetProductsAsync()
    {
        basket = await localStore.GetItemAsync<List<Product>>("basket");
        totalRows = 0;
        totalItems = 0;
        _totalPrice = 0;
        if (basket != null)
        {
            foreach (Product i in basket)
            {
                totalRows++;
                totalItems += i.Amount;
                _totalPrice += (i.Amount * i.ProductDetail.Price);
            }
            totalPrice = _totalPrice.ToString("#.##");
        }
    }

    protected override void OnInitialized()
    {
        var timer = new Timer(new TimerCallback(_ => InvokeAsync(() => StateHasChanged())), null, 1000, 1000);
    }


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await GetProductsAsync();
    }

    private async Task SubmitOrder()
    {

        if (basket != null)
        {

            var order = new OrderCreate
            {
                Id=Guid.NewGuid(),
                UserId = 1,
                Status = "Order placed",
                OrderDate = DateTimeOffset.Now,
                DeliveryTypeId = 2
            };

            await Http.PostAsJsonAsync("https://localhost:44367/api/Orders", order);


            foreach (Product i in basket)
            {
                var orderLine = new OrderLineCreate
                {
                    OrderId = order.Id,
                    UnitPrice = i.ProductDetail.Price,
                    Quantity = i.Amount,
                    ProductId = i.Id
                };
                await Http.PostAsJsonAsync("https://localhost:44367/api/Orderlines", orderLine);
            }

            await localStore.ClearAsync();


            //product = new();

            //StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStore { get; set; }
    }
}
#pragma warning restore 1591
