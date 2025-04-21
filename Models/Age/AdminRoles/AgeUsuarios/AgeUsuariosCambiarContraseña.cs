using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminRoles.AgeUsuarios
{
    public class AgeUsuariosCambiarContraseña
    {
        [JsonProperty("codigoExterno")]
        public string CodigoExterno { get; set; }

        [JsonProperty("claveAnterior")]
        public string ClaveAnterior { get; set; }

        [JsonProperty("claveNueva")]
        public string ClaveNueva { get; set; }

    }
}
