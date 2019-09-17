using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCrud.Models;
using MVCrud.Models.ViewModels;

namespace MVCrud.Controllers

{
    public class TablaController : Controller
    {
        // GET: Tabla
        public ActionResult Index()
        {
            List<ListTablaViewModel> lst;
            using (CrudEntities db = new CrudEntities())
            {
                lst = (from d in db.Tablas
                           select new ListTablaViewModel
                           {
                               Id = d.id,
                               Nombre = d.nombre,
                               Correo = d.correo
                           
                           }).ToList();
            }

            return View(lst);
        }

        [HttpPost]
        public ActionResult Nuevo(TablaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (CrudEntities db = new CrudEntities())
                    {
                        var oTabla = new Tabla();
                        oTabla.nombre = model.Nombre;
                        oTabla.correo = model.Correo;
                        oTabla.fecha_nacimiento = model.Fecha_nacimiento;

                        db.Tablas.Add(oTabla);
                        db.SaveChanges();
                    }
                    return Redirect("/Tabla");
                }

                return View(model);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            //return View();
        }

        public ActionResult Nuevo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Editar(TablaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (CrudEntities db = new CrudEntities())
                    {
                        var oTabla = db.Tablas.Find(model.Id);
                        oTabla.nombre = model.Nombre;
                        oTabla.correo = model.Correo;
                        oTabla.fecha_nacimiento = model.Fecha_nacimiento;

                        db.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    return Redirect("~/Tabla/");
                }

                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            //return View();
        }

        public ActionResult Editar(int ID)
        {
            TablaViewModel model = new TablaViewModel();

            using (CrudEntities db = new CrudEntities())
            {
                var oTabla = db.Tablas.Find(ID);
                model.Nombre = oTabla.nombre;
                model.Correo = oTabla.correo;
                model.Fecha_nacimiento = oTabla.fecha_nacimiento;
                model.Id = oTabla.id;
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Eliminar(int ID)
        {
            TablaViewModel model = new TablaViewModel();
 
            using (CrudEntities db = new CrudEntities())
            {
                var oTabla = db.Tablas.Find(ID);
                db.Tablas.Remove(oTabla);
                db.SaveChanges();
            }
            return Redirect("~/Tabla/");
        }
    }
}