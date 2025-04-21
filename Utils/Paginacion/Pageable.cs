using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PruebaBlazor.Utils.Paginacion
{
    public class Pageable
    {
        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("size")]
        public int Size { get; set; }

        [JsonPropertyName("sort")]
        public List<string>? Sort { get; set; }

        public Pageable()
        {
            Page = 0;
            Size = 5;
            Sort = new List<string> { };
        }

    }
}
