using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Entidades;

namespace Negocios
{
    public class NegCategorias
    {
        #region Atributos
        DatosCategorias objDatosCategorias = new DatosCategorias();
        #endregion
        #region Metodos
        //para Categorias
        public int ambCategorias(string accion, Categoria objCategorias)
        {
            return objDatosCategorias.abmCategorias(accion, objCategorias);
        }
        //para Categorias
        public DataSet listadoCategorias(string cual)
        {
            return objDatosCategorias.listadoCategorias(cual);
        }
        #endregion
    }
}
