using PruebaBlazor.Models.AGE.AgeCamposGenerales;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeFeriadosLocalidades
{
    public class AgeFeriadosLocalidadesSaveDAO: AgeCamposGeneralesDAO
    {
        [JsonProperty("id")]
        public AgeFeriadosLocalidadesPKDAO Id { get; set; }


        [JsonProperty("fechaEjecucionDesde")]
        public DateTime FechaEjecucionDesde { get; set; }


        [JsonProperty("fechaEjecucionHasta")]
        public DateTime FechaEjecucionHasta { get; set; }


        [JsonProperty("horaEjecucionDesde")]
        public DateTime HoraEjecucionDesde { get; set; }


        [JsonProperty("horaEjecucionHasta")]
        public DateTime HoraEjecucionHasta { get; set; }
    }
}
