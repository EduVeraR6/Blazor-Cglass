using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeUsuarioParamVigencias
{
    public class AgeUsuarioParamVigenciaPKDAO
    {

        [JsonProperty("ageParGeCodigo")]
        public int ageParGeCodigo { get; set; }


        [JsonProperty("ageUsuariAgeLicencCodigo")]
        public int ageUsuariAgeLicencCodigo { get; set; }


        [JsonProperty("ageUsuariCodigo")]
        public long ageUsuariCodigo { get; set; }


        [JsonProperty("codigo")]
        public long codigo { get; set; }
    }
}
