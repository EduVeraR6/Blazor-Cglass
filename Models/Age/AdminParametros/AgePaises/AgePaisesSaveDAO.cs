using PruebaBlazor.Models.AGE.AgeCamposGenerales;

namespace PruebaBlazor.Models.Age.AdminParametros.AgePaises

{
    public class AgePaisesSaveDAO : AgeCamposGeneralesDAO
    {
        public int Codigo { get; set; }

        public string Descripcion { get; set; } = null!;

    }
}
