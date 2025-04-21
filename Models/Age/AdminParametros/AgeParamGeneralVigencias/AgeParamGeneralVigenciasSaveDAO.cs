using PruebaBlazor.Models.AGE.AgeCamposGenerales;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeParamGeneralVigencias
{
    public class AgeParamGeneralVigenciasSaveDAO : AgeCamposGeneralesDAO
    {

        [JsonProperty("id")]
        public AgeParamGeneralVigenciasPKDAO Id { get; set; }

        [JsonProperty("observacion")]
        public string? Observacion { get; set; }

        [JsonProperty("fechaDesde")]
        public DateTime FechaDesde { get; set; }


        [JsonProperty("fechaHasta")]
        public DateTime? FechaHasta { get; set; }

        [JsonProperty("valorParametro")]
        public string ValorParametro { get; set; } = null!;
    }
}
