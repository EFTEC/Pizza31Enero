using ProyectoWS.datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWS.DAL
{
    public class EmpleadosDal
    {
        public static EMPLEADOS LeerEmpleado(String usuario)
        {
            var emp = new EMPLEADOS();
            using (var grupo = new Model2())
            {
                emp = grupo.EMPLEADOS.Where(e => e.USUARIO == usuario).First();
                return emp;
            }
        }
        public static void ListarEmpleado(EMPLEADOS empleado)
        {
            using (var model2 = new Model2())
            {
                model2.EMPLEADOS.Add(empleado);
                model2.SaveChanges();
            }
        }
    }
}