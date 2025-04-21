using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminRoles.AgeUsuariosPerfiles
{
    public class AgeUsuariosPerfilePKDAO
    {
        [JsonProperty("ageUsuariAgeLicencCodigo")]
        public int AgeUsuariAgeLicencCodigo { get; set; }

        [JsonProperty("ageUsuariCodigo")]
        public int AgeUsuariCodigo { get; set; }

        [JsonProperty("codigo")]
        public int Codigo { get; set; }
    }
}
