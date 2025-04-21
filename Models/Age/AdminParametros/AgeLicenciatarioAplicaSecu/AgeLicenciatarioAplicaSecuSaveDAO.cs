using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeLicenciatarioAplicaSecu
{
    public class AgeLicenciatarioAplicaSecuSaveDAO
    {
        [JsonProperty("estado")]
        public string? Estado { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public long usuarioIngreso { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]


        public long? usuarioModificacion { get; set; }

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

    }
}
