using BlazorApp.Client.Static;
using BlazorApp.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BlazorApp.Client.Pages.Customers
{
    public partial class View
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }
        [Parameter] public string id { get; set; }

        Customer customer = new Customer();

        protected async override Task OnParametersSetAsync()
        {

            customer = await _client.GetFromJsonAsync<Customer>($"{Endpoint.CustomersEndpoint}{id}");
        }
    }
}
