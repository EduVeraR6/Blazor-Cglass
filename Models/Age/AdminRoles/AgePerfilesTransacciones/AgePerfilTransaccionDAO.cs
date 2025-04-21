using PruebaBlazor.Models.Age.AdminParametros.AgeTransacciones;
using PruebaBlazor.Models.Age.AdminRoles.AgePerfiles;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminRoles.AgePerfilesTransacciones
{
    public class AgePerfilTransaccionDAO
    {
        [JsonProperty("agePerfiles")]
        public AgePerfilesDAO AgePerfiles { get; set; }

        [JsonProperty("ageTransaccionesList")]
        public List<AgeTransaccionesDAO> AgeTransaccionesList { get; set; }
    }
}
