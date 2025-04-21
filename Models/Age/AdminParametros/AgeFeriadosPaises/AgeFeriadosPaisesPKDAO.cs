using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeFeriadoPais
{
    public class AgeFeriadosPaisesPKDAO
    {
        [Required(ErrorMessage = "El código del país no puede ser nulo.")]
        [RegularExpression("^[1-9]\\d*$", ErrorMessage = "El código del país debe ser un número entero mayor a cero.")]
        [FromRoute(Name = "codigoPais")]
        public int AgePaisCodigo { get; set; }


        [Required(ErrorMessage = "El código del día feriado no puede ser nulo.")]
        [RegularExpression("^[1-9]\\d*$", ErrorMessage = "El código del día feriado debe ser un número entero mayor a cero.")]
        [FromRoute(Name = "codigoDiaFeriado")]
        public int AgeDiaFeCodigo { get; set; }
    }
}
