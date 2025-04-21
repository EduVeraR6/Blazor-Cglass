using PruebaBlazor.Models.Age.AdminParametros.AgeFormasPagos;
using PruebaBlazor.Models.Age.AdminParametros.AgeFranquicias;
using PruebaBlazor.Models.Age.AdminParametros.AgeInstitucionesFinancieras;
using PruebaBlazor.Models.Age.AdminParametros.AgeLicenciatario;
using PruebaBlazor.Models.AGE.AgeCamposGenerales;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeFormasPagoInstFinan
{
    public class AgeFormasPagosInstFinaSaveDAO : AgeCamposGeneralesDAO
    {
        public AgeFormasPagosInstFinaPKDAO Id { get; set; }

        public string Descripcion { get; set; } = null!;

        public int AgeForPaAgeLicencCodigo { get; set; }

        public int AgeForPaCodigo { get; set; }
        public int? AgeFranquCodigo { get; set; }

        public int? AgeInsFiAgeLicencCodigo { get; set; }

        public int? AgeInsFiCodigo { get; set; }
       

    }
}
