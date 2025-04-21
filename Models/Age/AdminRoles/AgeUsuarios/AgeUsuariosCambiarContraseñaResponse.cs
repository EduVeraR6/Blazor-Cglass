using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminRoles.AgeUsuarios
{
    public class AgeUsuariosCambiarContraseñaResponse
    {
        [JsonProperty("codigo")]
        public string Codigo { get; set; }

        [JsonProperty("mensaje")]
        public string Mensaje { get; set; }

        [JsonProperty("exception")]
        public string Exception { get; set; }
    }
}
