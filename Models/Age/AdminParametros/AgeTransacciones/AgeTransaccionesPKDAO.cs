using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeTransacciones
{
    public class AgeTransaccionesPKDAO
    {
        [JsonProperty("ageAplicaCodigo")]
        public int ageAplicaCodigo { get; set; }

        [JsonProperty("codigo")]
        public int codigo { get; set; }

    }
}
