using static PruebaBlazor.Models.CLI.CliContacto.CliContactosDAO;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using PruebaBlazor.Models.CLI.CliClient;

namespace PruebaBlazor.Models.CLI.CliContacto
{
    public class CliContactosDAO
    {

        [JsonProperty("estado")]
        public string Estado { get; set; }

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

        [JsonProperty("cliente")]
        public CliClienteDAO Cliente { get; set; }
    }
}
