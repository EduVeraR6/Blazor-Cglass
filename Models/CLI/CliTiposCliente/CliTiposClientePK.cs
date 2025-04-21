using Newtonsoft.Json;

namespace PruebaBlazor.Models.CLI.CliTiposCliente
{
    public class CliTiposClientePK
    {

        [JsonProperty("ageLicencCodigo")]
        public int ageLicencCodigo { get; set; }

        [JsonProperty("codigo")]
        public long codigo { get; set; }

    }
}
