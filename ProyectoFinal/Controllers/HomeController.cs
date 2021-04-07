using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinal.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        // POST: Home/Index
        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            MantenimientoUsuario mantenimiento = new MantenimientoUsuario();
            Usuario usu = new Usuario
            {
                Nombre = collection["Nombre"].ToString(),
                Edad = int.Parse(collection["Edad"].ToString()),
                Email = collection["Email"].ToString(),
                Telefono = int.Parse(collection["Telefono"].ToString()),
                Ciudad = collection["Ciudad"].ToString(),
                Interes = Boolean.Parse(collection["Interes"].ToString())
            };
            mantenimiento.Crear(usu);
            return RedirectToAction("Index");
        }

        // GET: Home/List
        public ActionResult List()
        {
            MantenimientoUsuario mantenimiento = new MantenimientoUsuario();
            return View(mantenimiento.ListarTodos());
        }

        /*
        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            MantenimientoUsuario mantenimiento = new MantenimientoUsuario();
            Usuario usu = new Usuario
            {
                Nombre = collection["Nombre"].ToString(),
                Edad = int.Parse(collection["Edad"].ToString()),
                Email = collection["Email"].ToString(),
                Telefono = int.Parse(collection["Telefono"].ToString()),
                Ciudad = collection["Ciudad"].ToString(),
                Interes = Boolean.Parse(collection["Interes"].ToString())
            };
            mantenimiento.Crear(usu);
            return RedirectToAction("Index");
        }
        */
        
    }
}
