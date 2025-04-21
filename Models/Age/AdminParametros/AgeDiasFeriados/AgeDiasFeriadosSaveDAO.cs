
using PruebaBlazor.Models.AGE.AgeCamposGenerales;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeDiasFeriados
{
    public class AgeDiasFeriadosSaveDAO : AgeCamposGeneralesDAO
    {
        [JsonProperty("codigo")]
        public int Codigo { get; set; }

        [JsonProperty("descripcion")]

        public string? Descripcion { get; set; }

        [JsonProperty("fechaDesde")]

        public DateTime FechaDesde { get; set; }

        [JsonProperty("fechaHasta")]

        public DateTime FechaHasta { get; set; }

        [JsonProperty("horaDesde")]

        public DateTime HoraDesde { get; set; }

        [JsonProperty("horaHasta")]

        public DateTime HoraHasta { get; set; }
    }
}
