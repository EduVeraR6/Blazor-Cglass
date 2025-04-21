using Newtonsoft.Json;

namespace PruebaBlazor.Models.CLI.CliTiposCliente
{
    public class CliTiposClienteDAO
    {

        [JsonProperty("id")]
        public CliTiposClientePK Id { get; set; }

        [JsonProperty("estado")]
        public string Estado { get; set; } = null!;

        [JsonProperty("descripcion")]
        public string Descripcion { get; set; } = null!;

        [JsonProperty("observacionEstado")]
        public string ObservacionEstado { get; set; }
    }
}
