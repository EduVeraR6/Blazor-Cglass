using PruebaBlazor.Models.Age.AdminParametros.AgeLicenciatario;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeArchivosMultimedia
{
    public class AgeArchivosMultimediaDAO
    {
        public AgeArchivosMultimediaPKDAO Id { get; set; }
        public string? Estado { get; set; } = null;
        public string? Descripcion { get; set; }
        public string Ruta { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string? Promocion { get; set; }

        public AgeLicenciatarioDAO Licenciatario { get; set; }
    }
}
