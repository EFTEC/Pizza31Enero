using ProyectoWeb.EmpleadosServiceReference;
using ProyectoWS.datos;
using ProyectoWS.ws;
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
            EMPLEADOS emp = new EMPLEADOS();
            return View(emp);
        }
        [HttpPost]
        public ActionResult Login(EMPLEADOS emp)
        {
            using (var clientesws = new EmpleadosWS.EmpleadosWSSoapClient())
            { 
                EMPLEADOS leer = clientesws.Leer(emp.USUARIO);
            if(leer.CLAVE==emp.CLAVE)
            {
                //redirecciona
            }
            else
            {
                //mensaje
            }
            }
            return View(emp);
        }
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