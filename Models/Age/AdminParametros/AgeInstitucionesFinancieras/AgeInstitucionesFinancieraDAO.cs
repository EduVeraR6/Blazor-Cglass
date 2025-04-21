namespace PruebaBlazor.Models.Age.AdminParametros.AgeInstitucionesFinancieras
{
    public class AgeInstitucionesFinancieraDAO
    {
        public AgeInstitucionesFinancieraPKDAO Id { get; set; }


        public string Descripcion { get; set; } = null!;


        public string? CodigoSegunBanco { get; set; }


        public string? SiglasBanco { get; set; }


        public string Estado { get; set; } = null!;
    }
}
