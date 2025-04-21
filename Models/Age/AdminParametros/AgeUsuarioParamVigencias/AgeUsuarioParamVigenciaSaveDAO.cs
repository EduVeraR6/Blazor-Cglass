using PruebaBlazor.Models.AGE.AgeCamposGenerales;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeUsuarioParamVigencias
{
    public class AgeUsuarioParamVigenciaSaveDAO 
    {
        [JsonProperty("id")]
        public AgeUsuarioParamVigenciaPKDAO? id { get; set; } = null!;

        [JsonProperty("observacion")]
        public string? observacion { get; set; }

        [JsonProperty("fechaDesde")]
        public DateTime? fechaDesde { get; set; }

        [JsonProperty("fechaHasta")]
        public DateTime? fechaHasta { get; set; }

        [JsonProperty("valorParametro")]
        public string valorParametro { get; set; } = null!;

        [JsonProperty("estado")]
        public string Estado { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public DateTime? FechaEstado { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string? ObservacionEstado { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public long? UsuarioIngreso { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FechaIngreso { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? UbicacionIngreso { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? UsuarioModificacion { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FechaModificacion { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? UbicacionModificacion { get; set; }
    }
}
