using PruebaBlazor.Models.Age.AdminParametros.AgeLicenciatarioAplicaciones;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeLogErrores
{
    public class AgeLogErroresDAO
    {
        public string estado { get; set; }
        public AgeLogErroresPKDAO id { get; set; }
        public string? mensaje { get; set; }
        public DateTime? fecha { get; set; }
        public AgeLicenciatariosAplicacionesDAO? licenciatarioAplicacion { get; set; }

    }
}
