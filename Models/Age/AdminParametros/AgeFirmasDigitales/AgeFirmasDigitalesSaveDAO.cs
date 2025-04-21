using PruebaBlazor.Models.AGE.AgeCamposGenerales;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AgeFirmasDigitales
{
    public class AgeFirmasDigitalesSaveDAO : AgeCamposGeneralesDAO
    {
        [JsonProperty("id")]
        public AgeFirmasDigitalesPKDAO Id { get; set; }

        [JsonProperty("nombres")]
        public string Nombres { get; set; } = null!;

        [JsonProperty("apellidos")]
        public string Apellidos { get; set; } = null!;

        [JsonProperty("fechaDesde")]
        public DateTime FechaDesde { get; set; }

        [JsonProperty("fechaHasta")]
        public DateTime? FechaHasta { get; set; }

        [JsonProperty("tipoFirmaDigital")]
        public string TipoFirmaDigital { get; set; } = null!;

        [JsonProperty("clave")]
        public string Clave { get; set; } = null!;

        [JsonProperty("nombreArchivo")]
        public string? NombreArchivo { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("fechaUltimaNotificacion")]
        public DateTime? FechaUltimaNotificacion { get; set; }
    }
}