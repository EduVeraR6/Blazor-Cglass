using PruebaBlazor.Models.AGE.AgeCamposGenerales;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeLogErrores
{
    public class AgeLogErroresSaveDAO : AgeCamposGeneralesDAO
    {
        public AgeLogErroresPKDAO id { get; set; }
        public string?  mensaje { get; set; }
        public DateTime fecha { get; set; }
    }
}
