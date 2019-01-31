//using ProyectoWeb.EmpleadosServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoWeb.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            //EMPLEADOS emp = new EMPLEADOS();
            //return View(emp);
            return View();
        }
        //[HttpPost]
        //public ActionResult Login(EMPLEADOS emp)
        //{
        //    return View(emp);
        //}
        public ActionResult PantallaInicial()
        {
            return View();
        }

        public ActionResult ListarEmpleados()
        {
            return View();
        }
    }
}