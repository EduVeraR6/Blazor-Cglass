using PruebaBlazor.Models.Age.AdminParametros.AgeLicenciatario;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeFormasPagos
{
    public class AgeFormasPagosDAO
    {
        public AgeFormasPagosPKDAO Id { get; set; }


        public int CodigoInstitucionControl { get; set; }


        public string Descripcion { get; set; } = null!;


        public string Retiene { get; set; } = null!;


        public string? PresentaCajaBancos { get; set; }


        public string Estado { get; set; } = null!;

        public AgeLicenciatarioDAO Licenciatario { get; set; }
    }
}
