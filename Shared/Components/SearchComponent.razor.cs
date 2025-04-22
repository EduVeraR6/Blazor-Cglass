using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using PruebaBlazor.Models;

namespace PruebaBlazor.Shared.Components
{
    public partial class SearchComponent : ComponentBase
    {
        [Parameter] public string InputType { get; set; } = "text"; 
        [Parameter] public string SearchValue { get; set; }
        [Parameter] public EventCallback<string> OnSearch { get; set; }

        [Parameter] public List<SelectOption>? Options { get; set; }

        private async Task HandleKeyUp(KeyboardEventArgs e)
        {
            if (e.Key == "Enter")
            {
                await OnSearch.InvokeAsync(SearchValue);
            }
        }

        private async Task HandleSelectChange(ChangeEventArgs e)
        {
            SearchValue = e.Value?.ToString();
            await OnSearch.InvokeAsync(SearchValue);
        }

      
    }
}
