using PruebaBlazor.Models.Age.AdminRoles.AgePerfiles;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeTiposSucursales
{
    public class AgeTiposSucursalesDAO
    {

        [JsonProperty("id")]
        public AgeTiposSucursalesPKDAO Id { get; set; }

        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }

        [JsonProperty("estado")]
        public string Estado { get; set; }

    }
}
