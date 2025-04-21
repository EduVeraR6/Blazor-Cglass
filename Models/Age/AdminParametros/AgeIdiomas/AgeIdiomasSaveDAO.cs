using PruebaBlazor.Models.AGE.AgeCamposGenerales;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeIdiomas
{
    public class AgeIdiomasSaveDAO : AgeCamposGeneralesDAO
    {
        [JsonProperty("codigo")]
        public int Codigo { get; set; }
        [JsonProperty("descripcion")]
        public string Descripcion { get; set; } = null!;
    }
}
