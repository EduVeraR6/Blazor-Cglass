using PruebaBlazor.Models.Age.AdminParametros.AgeParametrosGenerales;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeLicenciatParamVigencias
{
    public class AgeLicenciatParamVigenciasDAO
    {
        [JsonProperty("id")]
        public AgeLicenciatParamVigenciasPKDAO Id { get; set; }
      
        [JsonProperty("observacion")]
        public string? Observacion { get; set; }
      
        [JsonProperty("fechaDesde")]
        public DateTime? FechaDesde { get; set; }

        [JsonProperty("fechaHasta")]
        public DateTime? FechaHasta { get; set; }

        [JsonProperty("valorParametro")]
        public string? ValorParametro { get; set; }

        [JsonProperty("estado")]
        public string? Estado { get; set; }

        public AgeParametrosGeneralesDAO? parametrosGenerales { get; set; }
    }
}
