using Microsoft.JSInterop;
using PruebaBlazor.Utils.Paginacion;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace PruebaBlazor.Services
{
    public class PaginacionService
    {
        private readonly HttpClient _httpClient;
        private readonly IJSRuntime _jsRuntime;

        public PaginacionService(HttpClient httpClient, IJSRuntime jsRuntime)
        {
            _httpClient = httpClient;
            _jsRuntime = jsRuntime;
        }

        public async Task<Page<T>> CargarPagina<T>(string endpoint, int paginaActual, int tamanioPagina)
        {
            var token = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "jwt_token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            try
            {
                var response = await _httpClient.GetAsync($"{endpoint}Page={paginaActual}&Size={tamanioPagina}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Page<T>>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error cargando datos: {ex.Message}");
            }

            return new Page<T>();
        }
    }
}
