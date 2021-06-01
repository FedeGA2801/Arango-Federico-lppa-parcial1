using FE.Business;
using FE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FE.Controllers
{
    public class AfiliadosController : Controller
    {
        // GET: Afiliados
        public ActionResult Index()
        {
            var bll = new AfiliadosBiz();
            var model = bll.Listar();
            return View(model);
        }

        // GET: Afiliados/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Afiliados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Afiliados/Create
        [HttpPost]
        public ActionResult Create(Afiliados afiliado)
        {
            if (!ModelState.IsValid)
                return View();

            try
            {
                var bll = new AfiliadosBiz();
                bll.Agregar(afiliado);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                /// Que pasa con el error -> Bitacoras
                Console.WriteLine(e);
                return View(afiliado);
            }
        }

        // GET: Afiliados/Edit/5
        public ActionResult Edit(int id)
        {
            var bll = new AfiliadosBiz();
            var model = bll.Get(id);
            return View(model);
        }

        // POST: Afiliados/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Afiliados afiliado)
        {
            try
            {
                // TODO: Add update logic here
                var bll = new AfiliadosBiz();
                bll.Updatear(afiliado);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var bll = new AfiliadosBiz();
            var model = bll.Get(id);
            return View(model);
        }

        // POST: Afiliados/Delete/5
        [HttpPost]
        public ActionResult Delete(Afiliados afiliado)
        {
            var bll = new AfiliadosBiz();
            bll.Eliminar(afiliado);
            return RedirectToAction("Index");
        }
    }
}
