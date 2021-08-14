using prjetolocal.Models;
using prjetolocal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjetolocal.Controllers
{
    public class ProducaoController : Controller
    {
        CrudProd crud = new CrudProd();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {  
            return View();
        }
        [HttpPost]
        public ActionResult Create(Producao model)
        {
            crud.Create(model);
            return RedirectToAction("Create");
        }
        public ActionResult List()
        {
            return View(crud.Read());
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(crud.Read(id));
        }
        [HttpPost]
        public ActionResult Edit(Producao model)
        {
            try
            {
                crud.Update(model);
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Delete(int id )
        {
            crud.Delete(id);
            return RedirectToAction("List");
        }
        public ActionResult Details(int id)
        {
            return View(crud.Read(id));
        }
    }
}