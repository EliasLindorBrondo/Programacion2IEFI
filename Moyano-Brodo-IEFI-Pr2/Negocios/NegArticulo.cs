using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using Datos;

namespace Negocios
{
    public class NegArticulo
    {
        DatosArticulo objDatosArt = new DatosArticulo();

        public int abmarticulo(string accion, Articulo objarticulo)
        {
            return objDatosArt.abmalumno(accion, objarticulo);
        }

        public DataSet ListadoArt(string cual)
        {
            return objDatosArt.ListadoArt(cual);
        }

    }
}
