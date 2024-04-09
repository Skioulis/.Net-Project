using BlazorApp.Client.Static;
using BlazorApp.Shared.Domain.Name;
using BlazorApp.Shared.Domain.Name;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorApp.Client.Pages.Name
{
    public partial class GetName
    {
        [Inject] IJSRuntime js { get; set; }
        private IList<Employee> _employees;
        private IList<Manager> _managers;


        int managerCount = 0;
        int employeeCount = 0;
        protected async override Task OnInitializedAsync()
        {

            _employees = PersonRepository.employees;
            _managers = PersonRepository.managers;


        }
        async Task HandleSelectionChange(ChangeEventArgs e)
        {
            var selection = e.Value;
            await js.InvokeAsync<bool>("confirm", $"The name is {e.Value}");
            managerCount = 0;
            employeeCount = 0;
            // Perform additional actions based on the selected value
        }
    }
}
