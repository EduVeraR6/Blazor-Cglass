using PruebaBlazor.Models.Age.AdminRoles.AgePerfiles;
using PruebaBlazor.Models.Age.AdminRoles.AgeUsuarios;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminRoles.AgeUsuariosPerfiles
{
    public class UsuarioPerfilDAO
    {
        [JsonProperty("estado")]
        public string Estado { get; set; }

        [JsonProperty("id")]
        public AgeUsuariosPerfilePKDAO Id { get; set; }

        [JsonProperty("agePerfilAgeLicencCodigo")]
        public int AgePerfilAgeLicencCodigo { get; set; }

        [JsonProperty("agePerfilCodigo")]
        public int AgePerfilCodigo { get; set; }

        [JsonProperty("fechaDesde")]
        public DateTime? FechaDesde { get; set; }

        [JsonProperty("fechaHasta")]
        public DateTime? FechaHasta { get; set; }

        [JsonProperty("ageUsuarios")]
        public AgeUsuariosDAO AgeUsuarios { get; set; }

        [JsonProperty("perfil")]
        public AgePerfilesDAO Perfil { get; set; }

    }
}
