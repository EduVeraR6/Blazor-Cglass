
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeArchivosMultimedia
{
    public class AgeArchivosMultimediaPKDAO
    {
        [Required(ErrorMessage = "El código de licenciatario no puede ser nulo.")]
        [RegularExpression("^[1-9]\\d*$", ErrorMessage = "El código de licenciatario debe ser un número entero mayor a cero.")]
        [FromRoute(Name = "codigoLicenciatario")]
        public int ageLicencCodigo { get; set; }

        [Required(ErrorMessage = "El código de la ruta no puede ser nulo.")]
        [RegularExpression("^[1-9]\\d*$", ErrorMessage = "El código de la ruta debe ser un número entero mayor a cero.")]
        [FromRoute(Name = "id")]
        public long codigo { get; set; }
    }
}
