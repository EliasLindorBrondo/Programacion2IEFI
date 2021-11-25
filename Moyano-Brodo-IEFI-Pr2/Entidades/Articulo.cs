using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Articulo : Stock
    {
        public string CodArt;
        public string Nombre;
        public DateTime FechaVto = DateTime.Now.Date;

        public Articulo()
        {
            CodArt = string.Empty;
            Nombre = string.Empty;
        }


        public Articulo(string categ, string marc)
        {
            Categoria = categ;
            Marca = marc;
        }

        public Articulo(string codA, string Nom, DateTime FechVt, string categ, string marc) : base(categ, marc)
        {
            CodArt = codA;
            Nombre = Nom;
            FechaVto = FechVt;
            Categoria = categ;
            Marca = marc;
        }
    }
}
