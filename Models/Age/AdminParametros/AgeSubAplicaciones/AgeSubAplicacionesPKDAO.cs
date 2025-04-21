    using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeSubAplicaciones
{
    public class AgeSubAplicacionesPKDAO
    {
        [JsonProperty("ageLicApAgeAplicaCodigo")]
        public int AgeLicApAgeAplicaCodigo {  get; set; }


        [JsonProperty("ageLicApAgeLicencCodigo")]
        public int AgeLicApAgeLicencCodigo { get; set; }


        [JsonProperty("codigo")]
        public int Codigo {  get; set; }
    }
}
