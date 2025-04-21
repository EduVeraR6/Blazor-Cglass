using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeMonedasCotizaciones
{
    public class UpdateAgeMonedasCotizacionesRequest
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string? Estado { get; set; }
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

        public AgeMonedasCotizacionesPKDAO Id { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public int? AgeMonedaCodigo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public int? AgeMonedaCodigoSerA { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public DateTime? FechaDesde { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public DateTime? FechaHasta { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public double? CotizacionMercado { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public double? CotizacionCompra { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public double? CotizacionVenta { get; set; }
    }
}
