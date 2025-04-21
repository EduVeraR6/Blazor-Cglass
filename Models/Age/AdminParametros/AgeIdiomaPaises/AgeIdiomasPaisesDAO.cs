using PruebaBlazor.Models.Age.AdminParametros.AgeIdiomas;
using PruebaBlazor.Models.Age.AdminParametros.AgePaises;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeIdiomaPaises
{
    public class AgeIdiomasPaisesDAO
    {
        public AgeIdiomaPaisesPKDAO Id { get; set; }
        public AgeIdiomasDAO? idiomas { get; set; }

        public AgePaisesDAO? paises { get; set; }
        public string? Descripcion { get; set; }
        public string? TipoPrincipalSecundario { get; set; }
        public short? OrdenPrincipalSecundario { get; set; }
        public string? Estado { get; set; } = null!;
    }
}
