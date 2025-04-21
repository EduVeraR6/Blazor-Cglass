using PruebaBlazor.Models.Age.AdminParametros.AgeAplicaciones;
using PruebaBlazor.Models.Age.AdminParametros.AgeLicenciatario;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeLicenciatarioAplicaciones
{
    public class AgeLicenciatariosAplicacionesDAO
    {
        [JsonProperty("id")]
        public AgeLicenciatariosAplicacionesPKDAO Id { get; set; }

        [JsonProperty("ageRutaAgeLicencCodigo")]
        public int? AgeRutaAgeLicencCodigo { get; set; }

        [JsonProperty("ageRutaCodigo")]
        public int? AgeRutaCodigo { get; set; }

        [JsonProperty("estado")]
        public string Estado { get; set; }

        [JsonProperty("licenciatario")]
        public AgeLicenciatarioDAO? Licenciatario { get; set; }

        [JsonProperty("aplicaciones")]
        public AgeAplicacionesDAO? Aplicaciones { get; set; }
    }
}
