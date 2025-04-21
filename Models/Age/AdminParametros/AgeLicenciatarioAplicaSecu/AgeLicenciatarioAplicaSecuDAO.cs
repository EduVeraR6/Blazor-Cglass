using PruebaBlazor.Models.Age.AdminParametros.AgeLicenciatarioAplicaciones;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeLicenciatarioAplicaSecu
{
    public class AgeLicenciatarioAplicaSecuDAO
    {
        [JsonProperty("id")]
        public AgeLicenciatarioAplicaSecuPKDAO Id { get; set; }

        [JsonProperty("descripcion")]
        public string? Descripcion { get; set; }

        [JsonProperty("valorInicial")]
        public long ValorInicial { get; set; }

        [JsonProperty("incrementaEn")]
        public int IncrementaEn { get; set; }

        [JsonProperty("valorActual")]
        public long ValorActual { get; set; }

        [JsonProperty("ciclica")]
        public string? Ciclica { get; set; }

        [JsonProperty("estado")]
        public string? Estado { get; set; }

        public AgeLicenciatariosAplicacionesDAO? LicenciatarioAplicacion { get; set; }
    }
}
