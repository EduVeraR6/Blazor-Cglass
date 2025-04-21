using System.Reflection;
using System.Text.Json.Serialization;

namespace PruebaBlazor.Utils.Paginacion
{
    public class Sort<TModel>
    {
        [JsonPropertyName("fieldName")]
        public string FieldName { get; set; }

        [JsonPropertyName("direction")]
        public string Direction { get; set; }

    }
}
