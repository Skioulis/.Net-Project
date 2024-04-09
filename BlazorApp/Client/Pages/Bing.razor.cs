using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using BlazorApp.Shared.Keys;
using BlazorApp.Shared.Domain;

namespace BlazorApp.Client.Pages
{
    public partial class Bing
    {
        [Inject] HttpClient _client { get; set; }
        public string UserInput { get; set; }
        public string BingMapsKey { get; set; }
        BingResponseModel PlacesFound { get; set; }
        string errorString;


        protected async override Task OnInitializedAsync()
        {
            BingMapsKey = ApiKey.BingKey;

        }



        private async Task HandleSubmit2()
        {
            var url = $"https://dev.virtualearth.net/REST/v1/Autosuggest?key={BingMapsKey}&query={UserInput}";


            try
            {
                PlacesFound = await _client.GetFromJsonAsync<BingResponseModel>(url);
                errorString = null;
            }
            catch (Exception ex)
            {

                errorString = errorString = $"Error Getting the data {ex.Message}";
            }
        }

    }
}
