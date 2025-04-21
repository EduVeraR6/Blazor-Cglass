using PruebaBlazor.Models.AGE.AgeCamposGenerales;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeUsuarioPuntoEmision
{
    public class AgeUsuariosPuntoEmisionSaveDAO : AgeCamposGeneralesDAO
    {
        public AgeUsuariosPuntoEmisionPKDAO id { get; set; }
        public DateTime fechaDesde { get; set; }
        public DateTime fechaHasta { get; set; }

    }
}
