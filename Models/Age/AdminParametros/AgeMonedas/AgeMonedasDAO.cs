using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeMonedas
{
    public class AgeMonedasDAO
    {


        [JsonProperty("codigo")]
        public int Codigo { get; set; }

        [JsonProperty("codigoExterno")]
        public string CodigoExterno { get; set; } = null!;

        [JsonProperty("descripcion")]
        public string Descripcion { get; set; } = null!;

        [JsonProperty("monedaSimbolo")]
        public string MonedaSimbolo { get; set; } = null!;

        [JsonProperty("monedaSeparadorDecimal")]
        public string MonedaSeparadorDecimal { get; set; } = null!;

        [JsonProperty("estado")]
        public string Estado { get; set; } = null!;
    }
}
