using BlazorApp.Client.Static;
using BlazorApp.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BlazorApp.Client.Pages.Customers
{
    public partial class Edit
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }
        [Parameter] public string id { get; set; }

        Customer customer = new Customer();

        protected async override Task OnParametersSetAsync()
        {
            //Overridden method triggered automatically when the component's parameters are set. It performs the following:
            //Fetches customer data from the server using _client.GetFromJsonAsync based on the provided id.
            //Deserializes the fetched JSON data into the customer object.
            customer = await _client.GetFromJsonAsync<Customer>($"{Endpoint.CustomersEndpoint}{id}");
        }

        async Task EditCustomer()
        {
            //Executed upon form submission or when editing is complete.It performs the following:
            //Serializes the updated customer object into JSON format.
            //Sends a PUT request to the server's Endpoints.CustomersEndpoint URL with the updated customer data.
            //Upon successful update, redirects the user to the Customers list page using
            await _client.PutAsJsonAsync($"{Endpoint.CustomersEndpoint}{id}", customer);
            _navManager.NavigateTo(Endpoint.CustomersPage);
        }
    }
}
