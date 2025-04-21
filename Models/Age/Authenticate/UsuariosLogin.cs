using Newtonsoft.Json;

namespace PruebaBlazor.Models.AGE.Authenticate
{
    public class UsuariosLogin
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

    }
}
