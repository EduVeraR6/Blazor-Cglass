using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace PruebaBlazor.Utils.Paginacion
{
    public class Page<TModel>
    {
        [JsonPropertyName("content")]
        public List<TModel> Content { get; set; }

        [JsonPropertyName("pageable")]
        public Pageable Pageable { get; set; }
        [JsonPropertyName("totalElements")]
        public int TotalElements { get; set; }
        [JsonPropertyName("totalPages")]
        public int TotalPages { get; set; }
        [JsonPropertyName("numberOfElements")]
        public int NumberOfElements { get; set; }
        [JsonPropertyName("empty")]
        public bool Empty { get { return NumberOfElements == 0; } }

        public Page()
        {
            Content = new List<TModel>();
        }

        public Page(Pageable pageable, List<TModel> data, int totalElements)
        {
            Content = data;
            Pageable = pageable;
            TotalElements = totalElements;
            TotalPages = (int)Math.Ceiling(totalElements / (double)pageable.Size);
            NumberOfElements = data.Count;
        }
    }
}
