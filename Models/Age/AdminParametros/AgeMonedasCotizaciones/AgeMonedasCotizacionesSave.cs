using PruebaBlazor.Models.AGE.AgeCamposGenerales;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeMonedasCotizaciones
{
    public class AgeMonedasCotizacionesSave: AgeCamposGeneralesDAO
    {
        [JsonProperty("id")]
        public AgeMonedasCotizacionesPKDAO Id { get; set; }

        [JsonProperty("ageMonedaCodigo")]
        public int AgeMonedaCodigo { get; set; }

        [JsonProperty("ageMonedaCodigoSerA")]
        public int AgeMonedaCodigoSerA { get; set; }

        [JsonProperty("fechaDesde")]
        public DateTime FechaDesde { get; set; }

        [JsonProperty("fechaHasta")]
        public DateTime FechaHasta { get; set; }

        [JsonProperty("cotizacionMercado")]
        public decimal CotizacionMercado { get; set; }

        [JsonProperty("cotizacionCompra")]
        public decimal CotizacionCompra { get; set; }

        [JsonProperty("cotizacionVenta")]
        public decimal CotizacionVenta { get; set; }
    }

  
}
