using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeTiposIdentificaciones
{
    public class AgeTiposIdentificacionesDAO
    {
        [JsonProperty("codigo")]
        public int Codigo { get; set; }


        [JsonProperty("codigoInstitucionControl")]
        public int? CodigoInstitucionControl { get; set; }


        [JsonProperty("siglas")]
        public string? Siglas { get; set; }


        [JsonProperty("descripcion")]
        public string? Descripcion { get; set; }


        [JsonProperty("estado")]
        public string? Estado { get; set; }
    }
}
