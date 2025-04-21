using PruebaBlazor.Models.Age.AdminParametros.AgeLicenciatarioAplicaciones;
using PruebaBlazor.Models.AGE.AgeCamposGenerales;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeSubAplicaciones
{
    public class AgeSubAplicacionesSaveDAO : AgeCamposGeneralesDAO
    {
        [JsonProperty("id")]
        public AgeSubAplicacionesPKDAO Id { get; set; }


        [JsonProperty("descripcion")]
        public string? Descripcion { get; set; }


        [JsonProperty("contabiliza")]
        public string? Contabiliza { get; set; }


        [JsonProperty("agageLicApAgeAplicaCodigo")]
        public int? AgageLicApAgeAplicaCodigo { get; set; }


        [JsonProperty("agageLicApAgeLicencCodigo")]
        public int? AgageLicApAgeLicencCodigo { get; set; }


        [JsonProperty("ageSubApCodigo")]
        public int? AgeSubApCodigo { get; set; } 
      
    }
}
 