

using PruebaBlazor.Models.AGE.AgeCamposGenerales;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeTiposLocalidades
{
    public class AgeTiposLocalidadeSaveDAO : AgeCamposGeneralesDAO
    {

        [JsonProperty("id")]
        public AgeTiposLocalidadePKDAO Id { get; set; }


        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }

        [JsonProperty("ageTipLoAgePaisCodigo")]
        public int? AgeTipLoAgePaisCodigo { get; set; }

        [JsonProperty("ageTipLoCodigo")]
        public int? AgeTipLoCodigo { get; set; }

    }
}

