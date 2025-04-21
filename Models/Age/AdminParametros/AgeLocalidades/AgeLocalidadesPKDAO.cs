
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeLocalidades
{
    public class AgeLocalidadesPKDAO
    {

        [JsonProperty("ageTipLoAgePaisCodigo")]
        public int AgeTipLoAgePaisCodigo { get; set; }


        [JsonProperty("ageTipLoCodigo")]
        public int AgeTipLoCodigo { get; set; }


        [JsonProperty("codigo")]
        public int Codigo { get; set; }
    }
}
