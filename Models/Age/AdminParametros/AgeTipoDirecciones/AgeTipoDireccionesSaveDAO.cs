using PruebaBlazor.Models.AGE.AgeCamposGenerales;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeTipoDirecciones
{
    public class AgeTipoDireccionesSaveDAO: AgeCamposGeneralesDAO
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; } = null!;

    }
}
