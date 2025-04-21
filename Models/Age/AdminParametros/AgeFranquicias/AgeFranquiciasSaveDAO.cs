using PruebaBlazor.Models.AGE.AgeCamposGenerales;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeFranquicias
{
    public class AgeFranquiciasSaveDAO : AgeCamposGeneralesDAO
    {
        public int Codigo { get; set; }

        public string Descripcion { get; set; } = null!;
    }
}
