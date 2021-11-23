using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosConexionBD
    {


        public SqlConnection Conexion;
        public string CadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=IEFIP2;Integrated Security=True";

        public DatosConexionBD()
        {
            Conexion = new SqlConnection(CadenaConexion);
        }

        public void AbrirConex()
        {
            try
            {
                if (Conexion.State == ConnectionState.Broken || Conexion.State == ConnectionState.Closed)
                {
                    Conexion.Open();
                }
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de abrir la conexion", e);
            }
        }

        public void CerrarConex()
        {
            try
            {
                if (Conexion.State == ConnectionState.Open)
                {
                    Conexion.Close();
                }
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }


    }
}
