using ProyectoWS.datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWS.dal
{
    public class ClientesDal
    {
        public static List<CLIENTES> Listar()
        {
            using(var model2=new Model2())
            {
                return model2.CLIENTES.ToList();
            }
        }
        public static void Insertar(CLIENTES cliente)
        {
            using(var model2=new Model2())
            {
                 model2.CLIENTES.Add(cliente);
                model2.SaveChanges();
            }
        }
    }
}