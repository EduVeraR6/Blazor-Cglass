using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeParametrosGenerales
{
    public class AgeParametrosGeneralesDAO
    {
        [JsonProperty("codigo")]
        public int Codigo { get; set; }
        [JsonProperty("descripcion")]

        public string Descripcion { get; set; } = null!;
        [JsonProperty("tipoDatoParametro")]

        public string TipoDatoParametro { get; set; } = null!;
        [JsonProperty("estado")]

        public string Estado { get; set; }
    }
}
