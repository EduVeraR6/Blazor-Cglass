using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PruebaBlazor.Models.Age.AdminRoles.AgePerfilesTransacciones
{
    public class AgePerfilesTransaccionesPKDAO
    {

        [JsonProperty("agePerfilAgeLicencCodigo")]
        public int agePerfilAgeLicencCodigo { get; set; }

        [JsonProperty("agePerfilCodigo")]
        public int agePerfilCodigo { get; set; }

        [JsonProperty("codigo")]
        public long codigo { get; set; }

    }
}
