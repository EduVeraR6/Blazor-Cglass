
using PruebaBlazor.Models.Age.AdminParametros.AgePaises;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeTiposLocalidades
{
    public class AgeTiposLocalidadeDAO
    {

        [JsonProperty("id")]
        public AgeTiposLocalidadePKDAO Id { get; set; }

        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }

        [JsonProperty("ageTipLoAgePaisCodigo")]
        public int? AgeTipLoAgePaisCodigo { get; set; }

        [JsonProperty("ageTipLoCodigo")]
        public int? AgeTipLoCodigo { get; set; }

        [JsonProperty("estado")]
        public string Estado { get; set; }

        [JsonProperty("paises")]
        public AgePaisesDAO Paises { get; set; }

        [JsonProperty("ageTiposLocalidade")]
        public AgeTiposLocalidadeDAO AgeTiposLocalidades { get; set; }


    }
}