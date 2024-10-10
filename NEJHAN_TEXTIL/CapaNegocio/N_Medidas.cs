using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class N_Medidas
    {

        public static DataTable Listado_me(string cTexto)
        {

            D_Medidas Datos = new D_Medidas();

            return Datos.Listado_me(cTexto);



        }


        public static string Guardar_me(int nOpcion, E_Medidas oMe)
        {

            D_Medidas Datos = new D_Medidas();

            return Datos.Guardar_me(nOpcion, oMe);

        }


        public static string Eliminar_me(int IdMarcaProducto)
        {

            D_Medidas Datos = new D_Medidas();

            return Datos.Eliminar_me(IdMarcaProducto);

        }







    }
}

