using PruebaBlazor.Models.Age.AdminParametros.AgeLocalidades;
using PruebaBlazor.Models.Age.AdminParametros.AgePersonas;
using PruebaBlazor.Models.Age.AdminParametros.AgeTipoDirecciones;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeDirecciones
{
    public class AgeDireccionesDAO
    {
        [JsonProperty("id")]
        public AgeDireccionesPKDAO Id { get; set; }
        [JsonProperty("ageAgeTipLoAgePaisCodigo")]
        public int? AgeAgeTipLoAgePaisCodigo { get; set; }

        [JsonProperty("ageLocaliAgeTipLoCodigo")]
        public int? AgeLocaliAgeTipLoCodigo { get; set; }

        [JsonProperty("ageLocaliCodigo")]
        public int? AgeLocaliCodigo { get; set; }

        [JsonProperty("ageTipDiCodigo")]
        public int? AgeTipDiCodigo { get; set; }

        [JsonProperty("descripcion")]
        public string? Descripcion { get; set; }

        [JsonProperty("telefono1")]
        public string? Telefono1 { get; set; }

        [JsonProperty("telefono2")]
        public string? Telefono2 { get; set; }

        [JsonProperty("nombreContacto")]
        public string? NombreContacto { get; set; }

        [JsonProperty("correoElectronicoContacto")]
        public string? CorreoElectronicoContacto { get; set; }

        [JsonProperty("celularContacto")]
        public string? CelularContacto { get; set; }

        [JsonProperty("latitud")]
        public string? Latitud { get; set; }

        [JsonProperty("longitud")]
        public string? Longitud { get; set; }

        [JsonProperty("estado")]
        public string? Estado { get; set; }

        public AgePersonasDAO? persona { get; set; }

        public AgeLocalidadesDAO? localidades { get; set; }

        public AgeTipoDireccionesDAO? tiposDirecciones { get; set; }
    }
}
