using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Afiliados : IdentityBase
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public long cuit { get; set; }
    }
}
