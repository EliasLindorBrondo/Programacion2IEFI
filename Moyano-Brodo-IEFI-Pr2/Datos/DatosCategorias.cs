using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using System.Data.SqlClient;


namespace Datos
{
    public class DatosCategorias : DatosConexionBD
    {
        #region Metodos
        /* 
         abmCategorias que recibe dos parámetros, un string que llamamos accion que me va a indicar qué es lo que queremos hacer con el objeto Categoria enviado, si accion es 
        igual a “Agregar” lo agregaremos a la base de datos, si es igual a “Modificar”, lo modificaremos al existente y si es “Eliminar” lo eliminaremos de la tabla. 
        El método devuelve un entero, si devuelve -1 indica que no pudo realizar la acción solicitado.
         */

        public int abmCategorias(string accion, Categoria objCategoria)
        {
            int resultado = -1;
            string orden = string.Empty;
            //AGREGAR
            if (accion == "Agregar")
                orden = "insert into Categoria values ('" +  objCategoria.Categoria + "','" + objCategoria.Marca + "','" + objCategoria.Vigente + "');";
            //MODIFICAR
            if (accion == "Modificar")
                orden = "update Categoria set " +
                    "NombreCategoria ='" + objCategoria.Categoria +
                    "', marca ='" + objCategoria.Marca +
                    "', vigente ='" + objCategoria.Vigente + "' where IdCategoria = '" + objCategoria.Id + "'; ";
            //ELIMINAR
            if (accion == "Eliminar")
                orden = "DELETE FROM  Categoria where IdCategoria = '" + objCategoria.Id +"'; ";

            SqlCommand cmd = new SqlCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Errror al tratar de guardar,borrar o modificar ", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }
        /*
         Este método  listadoCategorias devuelve un DataSet con los registros solicitados, recibe un string que indica el código que deseo buscar, o si sesolicitan “Todos”.
         */

        public DataSet listadoCategorias(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from Categoria where NombreCategoria = " + cual + ";";
            else
                orden = "select * from Categoria;";

            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Categorias", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
        #endregion

    }
}
