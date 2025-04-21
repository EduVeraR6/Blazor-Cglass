using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeUsuarioParametroGeneral
{
    public class AgeUsuarioParametroGeneralPKDAO
    {
        [JsonProperty("ageParGeCodigo")]
        public int AgeParGeCodigo { get; set; }

        [JsonProperty("ageUsuariAgeLicencCodigo")]
        public int AgeUsuariAgeLicencCodigo { get; set; }

        [JsonProperty("ageUsuariCodigo")]
        public int AgeUsuariCodigo { get; set; }

        [JsonProperty("codigo")]
        public int Codigo {  get; set; }
    }
}
