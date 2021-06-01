using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace FE.Models
{
    public class Afiliados : IdentityBase
    {
        [DisplayName("Nombre")]
        public string nombre { get; set; }
        [DisplayName("Apellido")]
        public string apellido { get; set; }
        [DisplayName("Email")]
        public string email { get; set; }
        [DisplayName("Telefono")]
        public string telefono { get; set; }
        [DisplayName("CUIT")]
        public long cuit { get; set; }
        [DisplayName("Nombre y Apellido")]
        public string nombreapellido
        {
            get
            {
                return this.nombre + " " +this.apellido;
            }
        }

        [DisplayName("CUIT")]
        public string cuitString
        {
            get
            {
                return this.cuit.ToString().Substring(0,2) + "-" + this.cuit.ToString().Substring(2, 8) + "-" + this.cuit.ToString().Substring(10, 1);
            }
        }
    }
}