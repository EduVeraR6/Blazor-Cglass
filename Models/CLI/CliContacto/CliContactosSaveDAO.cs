using PruebaBlazor.Models.AGE.AgeCamposGenerales;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.CLI.CliContacto
{
    public class CliContactosSaveDAO : AgeCamposGeneralesDAO
    {

        [JsonProperty("id")]
        public CliContactosPK Id { get; set; }

        [JsonProperty("numeroIdentificacion")]
        public string NumeroIdentificacion { get; set; }

        [JsonProperty("nombres")]
        public string Nombres { get; set; }

        [JsonProperty("apellidos")]
        public string Apellidos { get; set; }

        [JsonProperty("telefonoCelular")]
        public string TelefonoCelular { get; set; }

        [JsonProperty("correoElectronico")]
        public string CorreoElectronico { get; set; }

        [JsonProperty("valorParametro")]
        public string ValorParametro { get; set; }

    }
}
