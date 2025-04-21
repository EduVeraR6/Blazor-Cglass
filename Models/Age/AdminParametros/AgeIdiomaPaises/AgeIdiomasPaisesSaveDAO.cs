using PruebaBlazor.Models.AGE.AgeCamposGenerales;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeIdiomaPaises
{
    public class AgeIdiomasPaisesSaveDAO : AgeCamposGeneralesDAO
    {
        public AgeIdiomaPaisesPKDAO Id { get; set; }
        public string? Descripcion { get; set; }
        public string TipoPrincipalSecundario { get; set; } = null!;
        public short? OrdenPrincipalSecundario { get; set; }
    }
}
