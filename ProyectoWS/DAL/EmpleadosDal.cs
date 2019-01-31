using ProyectoWS.datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWS.DAL
{
    public class EmpleadosDal
    {
        public static List<EMPLEADOS> listar()
        {
            using (var model2 = new Model2())
            {
                return model2.EMPLEADOS.ToList();
            }
        }
        public static void Insertar(EMPLEADOS empleado)
        {
            using (var model2 = new Model2())
            {
                model2.EMPLEADOS.Add(empleado);
                model2.SaveChanges();
            }
        }
    }
}