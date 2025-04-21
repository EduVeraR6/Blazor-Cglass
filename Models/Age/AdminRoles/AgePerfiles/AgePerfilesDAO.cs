using PruebaBlazor.Models.Age.AdminParametros.AgeLicenciatario;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminRoles.AgePerfiles
{
    public class AgePerfilesDAO
    {
        [JsonProperty("id")]
        public AgePerfilesPKDAO Id { get; set; }

        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }

        [JsonProperty("estado")]
        public string Estado { get; set; }
        public AgeLicenciatarioDAO Licenciatario { get; set; }

    }
}
