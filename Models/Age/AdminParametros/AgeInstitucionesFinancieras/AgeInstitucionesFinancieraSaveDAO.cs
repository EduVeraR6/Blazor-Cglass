using PruebaBlazor.Models.AGE.AgeCamposGenerales;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeInstitucionesFinancieras
{
    public class AgeInstitucionesFinancieraSaveDAO : AgeCamposGeneralesDAO
    {
        public AgeInstitucionesFinancieraPKDAO Id { get; set; }


        public string Descripcion { get; set; } = null!;


        public string? CodigoSegunBanco { get; set; }


        public string? SiglasBanco { get; set; }
    }
}
