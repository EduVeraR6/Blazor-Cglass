using PruebaBlazor.Models.AGE.AgeCamposGenerales;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminRoles.AgePerfilesTransacciones
{
    public class AgePerfilesTransaccioneSaveDAO : AgeCamposGeneralesDAO
    {
        [JsonProperty("id")]
        public AgePerfilesTransaccionesPKDAO Id { get; set; }

        [JsonProperty("ageTransaAgeAplicaCodigo")]
        public int AgeTransaAgeAplicaCodigo { get; set; }

        [JsonProperty("ageTransaCodigo")]
        public int AgeTransaCodigo { get; set; }



    }
}
