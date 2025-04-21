using PruebaBlazor.Models.Age.AdminRoles.AgeUsuarios;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PruebaBlazor.Models.Age.AdminRoles.AgePerfiles
{
    public class AgePerfilesSaveDAO
    {
        public AgePerfilesIdDAO Id { get; set; }

        [JsonProperty("estado")]
        public string? Estado { get; set; }

        [JsonProperty("fechaEstado")]
        public DateTime FechaEstado { get; set; }

        [JsonProperty("observacionEstado")]
        public string? ObservacionEstado { get; set; }

        [JsonProperty("usuarioIngreso")]
        [JsonRequired]
        [RegularExpression("^[1-9]\\d*$")]
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

        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }

        public AgePerfilesSaveDAO(AgePerfilesIdDAO id)
        {
            Id = id;
            AsignarUsuarioModificacionDesdeId();
            LimpiarValoresNoEstablecidosComoNull();
        }

        public class AgePerfilesIdDAO
        {
            public int ageLicencCodigo { get; set; }
            public int codigo { get; set; }
        }

        public void LimpiarValoresNoEstablecidosComoNull()
        {
            if (string.IsNullOrEmpty(Estado)) Estado = null;
            if (string.IsNullOrEmpty(Estado)) Descripcion = null;
        }
        private void AsignarUsuarioModificacionDesdeId()
        {
            if (Id != null)
            {
                UsuarioModificacion = Id.ageLicencCodigo;
            }

        }
    }
}
