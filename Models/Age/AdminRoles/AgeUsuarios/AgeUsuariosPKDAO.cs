using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminRoles.AgeUsuarios
{
    public class AgeUsuariosPKDAO
    {
        [JsonProperty("ageLicencCodigo")]
        public int ageLicencCodigo { get; set; }

        [JsonProperty("codigo")]
        public long codigo { get; set; }
    }
}
