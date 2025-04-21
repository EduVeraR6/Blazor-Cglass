using PruebaBlazor.Models.AGE.AgeCamposGenerales;
using Newtonsoft.Json;
using System;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeFeriadosExcepciones
{
    public class AgeFeriadosExcepcionesSaveDAO : AgeCamposGeneralesDAO
    {

        public AgeFeriadosExcepcionesPKDAO? id { get; set; }

        public string? observacion { get; set; }

        public DateTime fechaDesde { get; set; }

        public DateTime fechaHasta { get; set; }

        public DateTime horaDesde { get; set; }

        public DateTime horaHasta { get; set; }

        public string? tipoExcepcion { get; set; }

    }
}
