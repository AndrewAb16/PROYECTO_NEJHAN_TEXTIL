using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    internal class D_Proveedores
    {
        public DataTable Listado_pv(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();

            SqlConnection sqlcon = new SqlConnection(Conexion.cadena);

            try 
            {
                SqlCommand comando = new SqlCommand("Listado_ma", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;

                sqlcon.Open();  // Abrimos la conexión
                Resultado = comando.ExecuteReader();
                tabla.Load(Resultado);  // Cargamos los resultados en el DataTable

                return tabla;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                throw ex;
            }
            finally
            {
                // Cerramos la conexión si está abierta
                if (sqlcon != null && sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }

        }
    }
}
