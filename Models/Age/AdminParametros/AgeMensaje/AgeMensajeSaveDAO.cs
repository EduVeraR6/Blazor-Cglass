using PruebaBlazor.Models.AGE.AgeCamposGenerales;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeMensaje
{
    public class AgeMensajeSaveDAO : AgeCamposGeneralesDAO
    {
        [JsonProperty("codigo")]
        public long Codigo { get; set; }

        [JsonProperty("accionMsg")]
        public string AccionMsg { get; set; } = null!;

    }
}
