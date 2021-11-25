using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosArticulo : DatosConexionBD
    {
        public int abmarticulo(string accion, Articulo  objarticulo)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Alta")
            {

                orden = "Set dateformat dmy; Insert into Articulo values ('" + objarticulo.CodArt + "','" + objarticulo.Nombre + "','" + objarticulo.FechaVto.ToShortDateString() + "','" + objarticulo.Categoria + "','" + objarticulo.Marca + "');";
            }
            if (accion == "Modificar")
            {
                orden = "Set dateformat dmy; update Articulo set nombre='" + objarticulo.Nombre + "',fechaVto ='" + objarticulo.FechaVto + "',NombreCategoria =' " + objarticulo.Categoria + "',marca ='" + objarticulo.Marca + "';";
            }
            if (accion == "Borrar")
            {
                orden = "delete from  Articulo where codArt='" + objarticulo.CodArt + "'; ";
            }

            SqlCommand cmd = new SqlCommand(orden, Conexion);

            try
            {
                AbrirConex();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar,borrar o modificar Articulo", e);
            }
            finally
            {
                CerrarConex();
                cmd.Dispose();
            }
            return resultado;

        }

        public DataSet ListadoArt(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
            {
                
            }
            else
            {
                orden = "select * from Articulo;";
            }

            SqlCommand cmd = new SqlCommand(orden, Conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter Da = new SqlDataAdapter();

            try
            {
                AbrirConex();
                cmd.ExecuteNonQuery();

                Da.SelectCommand = cmd;
                Da.Fill(ds);
            }
            catch (Exception e)
            {

                throw new Exception("Error al listar Articulo", e);
            }
            finally
            {
                CerrarConex();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
