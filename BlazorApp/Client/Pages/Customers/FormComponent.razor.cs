using BlazorApp.Shared;
using BlazorApp.Shared.Domain;
using Microsoft.AspNetCore.Components;

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;



namespace BlazorApp.Client.Pages.Customers
{
    public partial class FormComponent
    {
        private List<Country> _countries = BlazorApp.Shared.Static.CountryRepository.countries;
        [Parameter] public bool Disabled { get; set; } = false;
        [Parameter] public Customer customer { get; set; }
        [Parameter] public string ButtonText { get; set; } = "Save";
        [Parameter] public EventCallback OnValidSubmit { get; set; }
    }
}
