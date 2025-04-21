using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgePuntoEmision
{
    public class AgePuntoEmisionPKDAO
    {
        [JsonProperty("ageSucursAgeLicencCodigo")]
        public int ageSucursAgeLicencCodigo { get; set; }

        [JsonProperty("ageSucursCodigo")]
        public int ageSucursCodigo { get; set; }

        [JsonProperty("codigo")]
        public int codigo { get; set; }
    }
}
