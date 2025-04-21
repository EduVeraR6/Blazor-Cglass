using PruebaBlazor.Models.Age.AdminParametros.AgeLicenciatario;
using PruebaBlazor.Models.Age.AdminParametros.AgeLicenciatarioAplicaciones;
using PruebaBlazor.Models.Age.AdminParametros.AgeMonedas;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeMonedasCotizaciones
{
    public class AgeMonedasCotizacionesDAO
    {
        [JsonProperty("estado")]
        public string? Estado { get; set; }

        [JsonProperty("id")]
        public AgeMonedasCotizacionesPKDAO? Id { get; set; }

        [JsonProperty("ageMonedaCodigo")]
        public int AgeMonedaCodigo { get; set; }

        [JsonProperty("ageMonedaCodigoSerA")]
        public int AgeMonedaCodigoSerA { get; set; }

        [JsonProperty("fechaDesde")]
        public DateTime? FechaDesde { get; set; }

        [JsonProperty("fechaHasta")]
        public DateTime? FechaHasta { get; set; }

        [JsonProperty("cotizacionMercado")]
        public double CotizacionMercado { get; set; }

        [JsonProperty("cotizacionCompra")]
        public double CotizacionCompra { get; set; }

        [JsonProperty("cotizacionVenta")]
        public double CotizacionVenta { get; set; }

        [JsonProperty("licenciatario")]
        public AgeLicenciatarioDAO Licenciatario { get; set; }

        [JsonProperty("monedas")]
        public AgeMonedasDAO Monedas { get; set; }

        [JsonProperty("monedasSerA")]
        public AgeMonedasDAO MonedasSerA { get; set; }

    }


}
