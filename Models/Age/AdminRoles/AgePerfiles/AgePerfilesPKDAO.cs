using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PruebaBlazor.Models.Age.AdminRoles.AgePerfiles
{
    public class AgePerfilesPKDAO
    {
        [JsonProperty("ageLicencCodigo")]
        public int ageLicencCodigo { get; set; }

        [JsonProperty("codigo")]
        public int codigo { get; set; }
    }
}
