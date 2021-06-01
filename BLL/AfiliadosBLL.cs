using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AfiliadosBLL
    {
        public List<Afiliados> Listar()
        {
            var db = new BaseDataServices<Afiliados>();
            var lista = db.Get();
            return lista;
        }
    }
}
