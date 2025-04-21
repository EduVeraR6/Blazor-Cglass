using PruebaBlazor.Models.Age.AdminParametros.AgeLicenciatario;
using PruebaBlazor.Models.Age.AdminParametros.AgeLocalidades;
using PruebaBlazor.Models.Age.AdminParametros.AgeTiposIdentificaciones;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgePersonas
{
    public class AgePersonasDAO
    {
        [JsonProperty("id")]
        public AgePersonasPKDAO Id { get; set; }


        [JsonProperty("ageTipIdCodigo")]
        public int? AgeTipIdCodigo { get; set; }


        [JsonProperty("ageLocaliAgeTipLoCodigo")]
        public int? AgeLocaliAgeTipLoCodigo { get; set; }


        [JsonProperty("ageLocaliCodigo")]
        public int? AgeLocaliCodigo { get; set; }


        [JsonProperty("ageAgeTipLoAgePaisCodigo")]
        public int? AgeAgeTipLoAgePaisCodigo { get; set; }


        [JsonProperty("numeroIdentificacion")]
        public string? NumeroIdentificacion { get; set; }


        [JsonProperty("nombres")]
        public string? Nombres { get; set; }


        [JsonProperty("apellidos")]
        public string? Apellidos { get; set; }


        [JsonProperty("razonSocial")]
        public string? RazonSocial { get; set; }


        [JsonProperty("nombreComercial")]
        public string? NombreComercial { get; set; }


        [JsonProperty("telefonoCelular1")]
        public string? TelefonoCelular1 { get; set; }


        [JsonProperty("telefonoCelular2")]
        public string? TelefonoCelular2 { get; set; }


        [JsonProperty("fechaNacimiento")]
        public DateTime? FechaNacimiento { get; set; }


        [JsonProperty("direccionPrincipal")]
        public string? DireccionPrincipal { get; set; }


        [JsonProperty("correoElectronico")]
        public string? correoElectronico { get; set; }


        [JsonProperty("sexo")]
        public string? Sexo { get; set; }


        [JsonProperty("estadoCivil")]
        public string? EstadoCivil { get; set; }


        [JsonProperty("telefonoPrincipal")]
        public string? TelefonoPrincipal { get; set; }


        [JsonProperty("estado")]
        public string? Estado { get; set; }


        [JsonProperty("licenciatarios")]
        public AgeLicenciatarioDAO Licenciatario { get; set; }

        [JsonProperty("tipoIdentificacion")]
        public AgeTiposIdentificacionesDAO TipoIdentificacion { get; set; }

        [JsonProperty("localidad")]
        public AgeLocalidadesDAO Localidad { get; set; }

    }
}
