using PruebaBlazor.Models.Age.AdminParametros.AgePuntoEmision;
using PruebaBlazor.Models.Age.AdminRoles.AgeUsuarios;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeUsuarioPuntoEmision
{
    public class AgeUsuariosPuntoEmisionDAO
    {
        public string Estado { get; set; }
        public AgeUsuariosPuntoEmisionPKDAO? Id { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public AgePuntoEmisionDAO PuntoEmision { get; set; }

        public AgeUsuariosDAO AgeUsuari { get; set; }
    }
}
