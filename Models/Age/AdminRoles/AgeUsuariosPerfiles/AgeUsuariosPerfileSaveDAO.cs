using PruebaBlazor.Models.AGE.AgeCamposGenerales;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminRoles.AgeUsuariosPerfiles
{
    public class AgeUsuariosPerfileSaveDAO : AgeCamposGeneralesDAO
    {
        [JsonProperty("id")]
        public AgeUsuariosPerfilePKDAO Id { get; set; }

        [JsonProperty("agePerfilAgeLicencCodigo")]
        public int AgePerfilAgeLicencCodigo { get; set; }

        [JsonProperty("agePerfilCodigo")]
        public int AgePerfilCodigo { get; set; }

        [JsonProperty("fechaDesde")]
        public DateTime FechaDesde { get; set; }

        [JsonProperty("fechaHasta")]
        public DateTime? FechaHasta { get; set; }

    }
}
