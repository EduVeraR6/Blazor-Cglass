using PruebaBlazor.Models.AGE.AgeCamposGenerales;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgePuntoEmision
{
    public class AgePuntoEmisionSaveDAO 
    {
        public AgePuntoEmisionPKDAO Id { get; set; }
        public string Descripcion { get; set; } = null!;

        [JsonProperty("estado", NullValueHandling = NullValueHandling.Ignore)]

        public string Estado { get; set; }

        [JsonProperty("fechaEstado", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime FechaEstado { get; set; }


        [JsonProperty("observacionEstado", NullValueHandling = NullValueHandling.Ignore)]
        public string? ObservacionEstado { get; set; }

        [JsonProperty("usuarioIngreso", NullValueHandling = NullValueHandling.Ignore)]
        public long UsuarioIngreso { get; set; }

        [JsonProperty("fechaIngreso", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime FechaIngreso { get; set; }

        [JsonProperty("ubicacionIngreso", NullValueHandling = NullValueHandling.Ignore)]
        public string? UbicacionIngreso { get; set; }

        [JsonProperty("usuarioModificacion", NullValueHandling = NullValueHandling.Ignore)]
        public long? UsuarioModificacion { get; set; }

        [JsonProperty("fechaModificacion", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FechaModificacion { get; set; }

        [JsonProperty("ubicacionModificacion", NullValueHandling = NullValueHandling.Ignore)]
        public string? UbicacionModificacion { get; set; }
    }
}
