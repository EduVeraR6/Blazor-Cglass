using System.Net.Http.Json;
using System.Text.Json;
using System.Net.Http.Headers;
using System.Text;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace PruebaBlazor.Services
{
    public interface ICrudService<TModel, TKey, TSaveModel > where TModel : class where TSaveModel : class
    {
        Task<List<TModel>> GetAllAsync(int page = 1, int size = 25);
        Task<List<TModel>> SearchAsync(string query, int page = 1, int size = 25);
        Task<TModel> GetByIdAsync(TKey id);
        Task<TModel> CreateAsync(TSaveModel model);
        Task<TModel> UpdateAsync(TSaveModel model);
        Task<bool> DeleteAsync(TKey id);
        Task<bool> BulkDeleteAsync(List<TSaveModel> models);
    }

    public class GenericCrudService<TModel, TKey, TSaveModel> : ICrudService<TModel, TKey, TSaveModel>
        where TModel : class
        where TSaveModel : class
    {
        private readonly HttpClient _httpClient;
        private readonly IJSRuntime _jsRuntime;
        private readonly string _baseEndpoint;
        private readonly JsonSerializerOptions _jsonOptions;

        public GenericCrudService(HttpClient httpClient, IJSRuntime jsRuntime, string baseEndpoint)
        {
            _httpClient = httpClient;
            _jsRuntime = jsRuntime;
            _baseEndpoint = baseEndpoint;
            _jsonOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }

        private async Task SetAuthHeader()
        {
            var token = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "jwt_token");
            if (!string.IsNullOrEmpty(token))
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
        }

        public async Task<List<TModel>> GetAllAsync(int page = 1, int size = 25)
        {
            await SetAuthHeader();

            var response = await _httpClient.GetAsync($"{_baseEndpoint}/{page}?size={size}");
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadFromJsonAsync<Page<TModel>>(_jsonOptions);
            return result?.Content ?? new List<TModel>();
        }

        public async Task<List<TModel>> SearchAsync(string query, int page = 1, int size = 25)
        {
            await SetAuthHeader();

            var response = await _httpClient.GetAsync($"{_baseEndpoint}/filtro/{page}?filtro={Uri.EscapeDataString(query)}&size={size}");
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadFromJsonAsync<Page<TModel>>(_jsonOptions);
            return result?.Content ?? new List<TModel>();
        }

        public async Task<TModel> GetByIdAsync(TKey id)
        {
            await SetAuthHeader();

            var response = await _httpClient.GetAsync($"{_baseEndpoint}/{id}");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<TModel>(_jsonOptions);
        }

        public async Task<TModel> CreateAsync(TSaveModel model)
        {
            await SetAuthHeader();

            var response = await _httpClient.PostAsJsonAsync(_baseEndpoint, model);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<TModel>(_jsonOptions);
        }

        public async Task<TModel> UpdateAsync(TSaveModel model)
        {
            await SetAuthHeader();

            var response = await _httpClient.PutAsJsonAsync(_baseEndpoint, model);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<TModel>(_jsonOptions);
        }

        public async Task<bool> DeleteAsync(TKey id)
        {
            await SetAuthHeader();

            var response = await _httpClient.DeleteAsync($"{_baseEndpoint}/{id}");
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> BulkDeleteAsync(List<TSaveModel> models)
        {
            await SetAuthHeader();

            var response = await _httpClient.PutAsJsonAsync($"{_baseEndpoint}/varios", models);
            return response.IsSuccessStatusCode;
        }

        // Clase interna para manejar la paginación genérica
        private class Page<T>
        {
            public List<T> Content { get; set; }
            public int PageNumber { get; set; }
            public int PageSize { get; set; }
            public int TotalElements { get; set; }
            public int TotalPages { get; set; }
        }
    }
}