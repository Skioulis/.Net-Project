using BlazorApp.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using BlazorApp.Client.Static;

namespace BlazorApp.Client.Pages.Customers
{
    public partial class Create
    {
        //(HttpClient): Injected HttpClient instance used for making HTTP requests to the server.
        [Inject] HttpClient _client { get; set; }
        // Injected NavigationManager instance for navigating to different pages within the application.
        [Inject] NavigationManager _navManager { get; set; }
        //A Customer object instance used for data binding within the form.
        Customer customer = new Customer();

        private async Task CreateCustomer()
        {
            // An asynchronous task triggered upon form submission.
            await _client.PostAsJsonAsync(Endpoint.CustomersEndpoint, customer);
            _navManager.NavigateTo(Endpoint.CustomersPage);
        }
    }
}
