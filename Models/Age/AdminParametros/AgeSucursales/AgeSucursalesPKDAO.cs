using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeSucursales
{
    public class AgeSucursalesPKDAO
    {
        [JsonProperty("ageLicencCodigo")]
        public int ageLicencCodigo { get; set; }

        [JsonProperty("codigo")]
        public int codigo { get; set; }
    }
}