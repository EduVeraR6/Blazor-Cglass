using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminRoles.AgeUsuarios
{
    public class UpdateAgeUsuariosRequest
    {
        public AgeUsuarioIdDAO Id { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string? Estado { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string MailPrincipal { get; set; }
        public string TelefonoCelular { get; set; }

        [JsonProperty("agePersonAgeLicencCodigo")]
        public int? AgePersonAgeLicencCodigo { get; set; }

        [JsonProperty("agePersonCodigo")]
        public long? AgePersonCodigo { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string? Direccion { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public int? AgeLocaliCodigo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public int? AgeLocaliAgeTipLoCodigo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public int? AgeAgeTipLoAgePaisCodigo { get; set; }
        public int UsuarioModificacion { get; set; }
        public string CodigoExterno { get; set; }



        public class AgeUsuarioIdDAO
        {
            public int ageLicencCodigo { get; set; }
            public int codigo { get; set; }
        }


    }
}

