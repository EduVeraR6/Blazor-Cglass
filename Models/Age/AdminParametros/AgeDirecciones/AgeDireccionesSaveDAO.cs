using PruebaBlazor.Models.AGE.AgeCamposGenerales;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeDirecciones
{
    public class AgeDireccionesSaveDAO : AgeCamposGeneralesDAO
    {
       

        public AgeDireccionesPKDAO id { get; set; }

        public int ageAgeTipLoAgePaisCodigo { get; set; }

        public int ageLocaliAgeTipLoCodigo { get; set; }

        public int ageLocaliCodigo { get; set; }

        public int ageTipDiCodigo { get; set; }

        public string? descripcion { get; set; }

        public string? telefono1 { get; set; }

        public string? telefono2 { get; set; }

        public string? nombreContacto { get; set; }

        public string? correoElectronicoContacto { get; set; }

        public string? celularContacto { get; set; }

        public string? latitud { get; set; }

        public string? longitud { get; set; }
    }
}
