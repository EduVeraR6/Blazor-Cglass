using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeFeriadosLocalidades
{
    public class AgeFeriadosLocalidadesPKDAO
    {
        [JsonProperty("ageAgeTipLoAgePaisCodigo")]
        public int AgeAgeTipLoAgePaisCodigo { get; set; }


        [JsonProperty("ageLocaliAgeTipLoCodigo")]
        public int AgeLocaliAgeTipLoCodigo { get; set; }


        [JsonProperty("ageLocaliCodigo")]
        public int AgeLocaliCodigo { get; set; }


        [JsonProperty("ageDiaFeCodigo")]
        public int AgeDiaFeCodigo { get; set; }
    }
}
