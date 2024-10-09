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
    public class D_Categorias
    {

        public DataTable Listado_ca(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();

            // Usamos la cadena de conexión directamente desde la clase Conexion
            SqlConnection sqlcon = new SqlConnection(Conexion.cadena);

            try
            {
                SqlCommand comando = new SqlCommand("Listado_ca", sqlcon);
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


        public string Guardar_ca(int nOpcion, E_Categorias oCa)
        {

            string rpta = "";

            // Usams la cadena de conexión directamente desde la clase Conexion
            SqlConnection sqlcon = new SqlConnection(Conexion.cadena);

            try
            {

               
                SqlCommand comando = new SqlCommand("Guardar_ca", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                comando.Parameters.Add("@IdCategoriaProducto", SqlDbType.Int).Value = oCa.IdCategoriaProducto;
                comando.Parameters.Add("@cDescripcion_ca", SqlDbType.VarChar).Value = oCa.Descripcion_ca;
                sqlcon.Open();
                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo registrar los datos";




            }
            catch (Exception ex)
            {
                rpta = ex.Message;

            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();

                }


            }
            return rpta;



        }


        public string Eliminar_ca(int Codigo_ca)
        {

            string rpta = "";

            // Usams la cadena de conexión directamente desde la clase Conexion
            SqlConnection sqlcon = new SqlConnection(Conexion.cadena);

            try
            {

                
                SqlCommand comando = new SqlCommand("Eliminar_ca", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@nCodigo_ca", SqlDbType.Int).Value = Codigo_ca;

                sqlcon.Open();
                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Eliminar los datos";




            }
            catch (Exception ex)
            {
                rpta = ex.Message;

            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();

                }


            }
            return rpta;



        }









    }
}
