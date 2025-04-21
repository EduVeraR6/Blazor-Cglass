using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeMensajesIdiomas
{
    public class AgeMensajesIdiomaSaveDAO
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string? Estado { get; set; }
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
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public AgeMensajesIdiomaPKDAO? Id { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string? DescripcionMsg { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string? SolucionMsg { get; set; }
    }
}
