using PruebaBlazor.Models.Age.AdminParametros.AgeTiposLocalidades;
using PruebaBlazor.Models.AGE.AgeCamposGenerales;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeTiposSucursales
{
    public class AgeTiposSucursalesSaveDAO: AgeCamposGeneralesDAO
    {

        [JsonProperty("id")]
        public AgeTiposSucursalesPKDAO Id { get; set; }


        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }

    }
}
