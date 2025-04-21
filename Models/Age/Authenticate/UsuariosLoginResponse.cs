using System.Text.Json.Serialization;

namespace PruebaBlazor.Models.AGE.Authenticate
{
    public class UsuariosLoginResponse
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
