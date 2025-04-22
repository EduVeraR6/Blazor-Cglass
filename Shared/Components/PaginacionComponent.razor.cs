using Microsoft.AspNetCore.Components;
using PruebaBlazor.Utils.Paginacion;

namespace PruebaBlazor.Shared.Components
{
    public partial class PaginacionComponent<TModel> : ComponentBase
    {
        [Parameter]
        public Page<TModel> Page { get; set; }

        [Parameter]
        public bool Deshabilitado { get; set; } = false;

        [Parameter]
        public EventCallback<int> OnPaginaCambiada { get; set; }

        [Parameter]
        public EventCallback<int> OnTamanioPaginaCambiado { get; set; }

        private async Task CambiarPagina(int numeroPagina)
        {
            if (numeroPagina < 0 || numeroPagina >= Page.TotalPages)
                return;

            await OnPaginaCambiada.InvokeAsync(numeroPagina);
        }

        private async Task CambiarTamanioPagina(ChangeEventArgs e)
        {
            if (int.TryParse(e.Value?.ToString(), out int nuevoTamanio))
            {
                await OnTamanioPaginaCambiado.InvokeAsync(nuevoTamanio);
            }
        }
    }
}