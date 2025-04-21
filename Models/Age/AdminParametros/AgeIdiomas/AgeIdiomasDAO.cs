using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeIdiomas
{
    public class AgeIdiomasDAO
    {
        [JsonProperty("codigo")]
        public int Codigo { get; set; }

        [JsonProperty("descripcion")]
        public string Descripcion { get; set; } = null!;

        [JsonProperty("estado")]
        public string Estado { get; set; } = null!;
    }
}
