
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeTipoDirecciones
{
    public class UpdateAgeTipoDireccionesRequest
    {
        public int Codigo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string? Descripcion { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string? Estado { get; set; }
        public long? UsuarioModificacion { get; set; }

        

    }
}
