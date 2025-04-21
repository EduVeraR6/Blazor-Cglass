using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgePuntoEmision
{
    public class AgePuntoEmisionDAO
    {

        [JsonProperty("id")]
        public AgePuntoEmisionPKDAO Id { get; set; }


        [JsonProperty("descripcion")]
        public string Descripcion { get; set; } = null!;


        [JsonProperty("estado")]
        public string Estado { get; set; } = null!;
    }
}
