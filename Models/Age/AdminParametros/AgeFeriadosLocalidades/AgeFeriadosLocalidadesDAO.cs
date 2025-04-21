using PruebaBlazor.Models.Age.AdminParametros.AgeDiasFeriados;
using PruebaBlazor.Models.Age.AdminParametros.AgeLocalidades;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeFeriadosLocalidades
{
    public class AgeFeriadosLocalidadesDAO
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


        [JsonProperty("estado")]
        public string Estado { get; set; }

        public AgeLocalidadesDAO Localidades { get; set; }

        public AgeDiasFeriadosDAO Feriados { get; set; }
    }
}
