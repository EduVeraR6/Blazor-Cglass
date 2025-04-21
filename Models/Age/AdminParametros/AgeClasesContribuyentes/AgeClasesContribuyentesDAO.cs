using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeClasesContribuyentes
{
    public class AgeClasesContribuyentesDAO
    {
        [JsonProperty("codigo")]
        public int? Codigo { get; set; }

        [JsonProperty("descripcion")]
        public string? Descripcion { get; set; }

        [JsonProperty("estado")]
        public string Estado { get; set; } = null!;
    }
}
