using PruebaBlazor.Models.AGE.AgeCamposGenerales;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.CLI.CliTiposCliente
{
    public class CliTiposClienteSaveDAO : AgeCamposGeneralesDAO
    {
        [JsonProperty("id")]
        public CliTiposClientePK Id { get; set; }

        [JsonProperty("descripcion")]
        public string Descripcion { get; set; } = null!;
    }
}
