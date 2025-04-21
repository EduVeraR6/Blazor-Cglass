using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.AGE.AgeCamposGenerales
{
    public class AgeCamposGeneralesDAO
    {
        [JsonProperty("estado")]
        public string Estado { get; set; }

        [JsonProperty("fechaEstado")]
        public DateTime FechaEstado { get; set; }


        [JsonProperty("observacionEstado")]
        public string? ObservacionEstado { get; set; }

        [JsonProperty("usuarioIngreso")]
        public long UsuarioIngreso { get; set; }

        [JsonProperty("fechaIngreso")]
        public DateTime FechaIngreso { get; set; }

        [JsonProperty("ubicacionIngreso")]
        public string? UbicacionIngreso { get; set; }

        [JsonProperty("usuarioModificacion")]
        public long? UsuarioModificacion { get; set; }

        [JsonProperty("fechaModificacion")]
        public DateTime? FechaModificacion { get; set; }

        [JsonProperty("ubicacionModificacion")]
        public string? UbicacionModificacion { get; set; }
    }
}
