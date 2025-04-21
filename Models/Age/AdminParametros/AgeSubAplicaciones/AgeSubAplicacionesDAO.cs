using PruebaBlazor.Models.Age.AdminParametros.AgeLicenciatarioAplicaciones;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeSubAplicaciones
{
    public class AgeSubAplicacionesDAO
    {
        [JsonProperty("id")]
        public AgeSubAplicacionesPKDAO Id {  get; set; }

        
        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }

        
        [JsonProperty("contabiliza")]
        public string Contabiliza { get; set; }


        [JsonProperty("agageLicApAgeAplicaCodigo")]
        public int? AgageLicApAgeAplicaCodigo {  get; set; }


        [JsonProperty("agageLicApAgeLicencCodigo")]
        public int? AgageLicApAgeLicencCodigo { get; set; }


        [JsonProperty("ageSubApCodigo")]
        public int? AgeSubApCodigo { get; set; }


        [JsonProperty("estado")]
        public string Estado {  get; set; }

        public AgeLicenciatariosAplicacionesDAO? licenciatarioAplicacion { get; set; }

        public AgeSubAplicacionesDAO? subAplicacion { get; set; }
    }
}
