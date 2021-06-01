using FE.Data.Services;
using FE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FE.Business
{
    public class AfiliadosBiz
    {
        public List<Afiliados> Listar()
        {
            var db = new BaseDataServices<Afiliados>();
            var lista = db.Get();
            return lista;
        }

        public Afiliados Get(int id)
        {
            var db = new BaseDataServices<Afiliados>();
            return db.GetById(id);
        }

        public void Agregar(Afiliados afiliado)
        {
            var db = new BaseDataServices<Afiliados>();
            db.Create(afiliado);
        }

        public void Updatear(Afiliados afiliado)
        {
            var db = new BaseDataServices<Afiliados>();
            db.Update(afiliado);
        }

        public void Eliminar(Afiliados afiliado)
        {
            var db = new BaseDataServices<Afiliados>();
            db.Delete(afiliado);
        }
    }
}