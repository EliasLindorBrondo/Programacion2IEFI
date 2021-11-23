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
    class DatosArticulo : DatosConexionBD
    {
        public int abmalumno(string accion, Articulo  objarticulo)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Alta")
            {

                orden = "Set dateformat dmy; Insert into Articulo values ('" + objarticulo.Nombre + "'," + objalumno.Dni + ",'" + objalumno.Carrera + "'," + objalumno.Legajo + ",'" + objalumno.Sexo + "','" + objalumno.FechN1.ToShortDateString() + "');";
            }
            if (accion == "Modificar")
            {
                orden = "Set dateformat dmy; update Articulo set Nombre='" + objarticulo.Nombre + "',Carrera ='" + objalumno.Carrera + "',Legajo = " + objalumno.Legajo + ",Sexo ='" + objalumno.Sexo + "',FechaNacimiento ='" + objalumno.FechN1 + "' where Dni = " + objalumno.Dni + "; ";
            }
            if (accion == "Borrar")
            {
                orden = "delete from  Articulo where Nombre='" + objalumno.Nombre + "' and Dni = " + objalumno.Dni + "; ";
            }

            SqlCommand cmd = new SqlCommand(orden, Conexion);

            try
            {
                AbrirConex();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar,borrar o modificar Alumno", e);
            }
            finally
            {
                CerrarConex();
                cmd.Dispose();
            }
            return resultado;

        }

        public DataSet ListadoAlu(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
            {
                orden = "select * from Alumno where Dni = " + int.Parse(cual) + ";";
            }
            else
            {
                orden = "select * from Alumno;";
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

                throw new Exception("Error al listar Alumno", e);
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
