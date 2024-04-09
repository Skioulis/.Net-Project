using BlazorApp.Client.Static;
using BlazorApp.Shared.Domain;
using BlazorApp.Shared.Static;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Net.Http.Json;

namespace BlazorApp.Client.Pages.Customers
{
    public partial class Index
    {
        //It retrieves a list of customers from a backend API, displays them in a tabular format, and provides functionality to view, edit and delete customers.
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }
        [Inject] IJSRuntime js { get; set; }


        private List<Customer> Customers;
        protected async override Task OnInitializedAsync()
        {
            //This task retrieves the list of customers from the backend API when the component is initialized.
            Customers = await _client.GetFromJsonAsync<List<Customer>>(Endpoint.CustomersEndpoint);

            //countries = countries.First(q = c)
        }
        //Country country = CountryRepository.GetCountryByCountryName("greece");

        private string CountryPhone(Customer cus)
        {
            //this Fuction Gets the country code from a repository based on the country name and add it to phone if found
            var country = CountryRepository.GetCountryByCountryName(cus.Country);
            if (country == null) { return cus.Phone; }
            string wholePhone = $"+ {country.PhoneCode} {cus.Phone}";
            return wholePhone;
        }

        async Task Delete(Guid customerId)
        {
            //Clicking the delete button next to a customer triggers a confirmation dialog.
            //If confirmed, the component sends an HTTP DELETE request to remove the customer from the backend. The customer list is then refreshed.
            var customer = Customers.First(q => q.Id == customerId);


            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {customer.CompanyName}?");

            if (confirm)
            {

                await _client.DeleteAsync($"{Endpoint.CustomersEndpoint}{customerId}");

                await OnInitializedAsync();
            }
        }
    }
}
