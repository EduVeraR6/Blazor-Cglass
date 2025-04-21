using PruebaBlazor.Models.Age.AdminRoles.AgePerfiles;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminRoles.AgeUsuarios
{
    public class AgeUsuariosDAO
    {
        [JsonProperty("estado")]
        public string Estado { get; set; } = null!;

        [JsonProperty("id")]
        public AgeUsuariosPKDAO Id { get; set; }

        [JsonProperty("agePersonAgeLicencCodigo")]
        public int? AgePersonAgeLicencCodigo { get; set; }

        [JsonProperty("agePersonCodigo")]
        public long? AgePersonCodigo { get; set; }

        [JsonProperty("ageSucursAgeLicencCodigo")]
        public int AgeSucursAgeLicencCodigo { get; set; }

        [JsonProperty("ageSucursCodigo")]
        public int AgeSucursCodigo { get; set; }

        [JsonProperty("ageTipIdCodigo")]
        public int AgeTipIdCodigo { get; set; }

        [JsonProperty("archivoFoto")]
        public string? ArchivoFoto { get; set; }

        [JsonProperty("codigoExterno")]
        public string CodigoExterno { get; set; } = null!;

        [JsonProperty("clave")]
        public string Clave { get; set; } = null!;

        [JsonProperty("numeroIdentificacion")]
        public string NumeroIdentificacion { get; set; } = null!;

        [JsonProperty("nombres")]
        public string Nombres { get; set; } = null!;

        [JsonProperty("apellidos")]
        public string Apellidos { get; set; } = null!;

        [JsonProperty("mailPrincipal")]
        public string MailPrincipal { get; set; } = null!;

        [JsonProperty("telefonoCelular")]
        public string TelefonoCelular { get; set; } = null!;

        [JsonProperty("tipoUsuario")]
        public string TipoUsuario { get; set; } = null!;

        [JsonProperty("primerIngreso")]
        public string PrimerIngreso { get; set; } = null!;

        [JsonProperty("tipoRegistro")]
        public string? TipoRegistro { get; set; }

        [JsonProperty("direccion")]
        public string? Direccion { get; set; } = null!;

        [JsonProperty("ageLocaliCodigo")]
        public int? AgeLocaliCodigo { get; set; }

        [JsonProperty("ageLocaliAgeTipLoCodigo")]
        public int? AgeLocaliAgeTipLoCodigo { get; set; }

        [JsonProperty("ageAgeTipLoAgePaisCodigo")]
        public int? AgeAgeTipLoAgePaisCodigo { get; set; }

        [JsonProperty("estadoCivil")]
        public string? EstadoCivil { get; set; }

        [JsonProperty("fechaNacimiento")]
        public DateTime? FechaNacimiento { get; set; }

        [JsonProperty("genero")]
        public string? Genero { get; set; }

        [JsonProperty("tokenFirebase")]
        public string? TokenFirebase { get; set; }

        [JsonProperty("agePerfilList")]
        public List<AgePerfilesDAO>? AgePerfilList { get; set; }

    }
}
