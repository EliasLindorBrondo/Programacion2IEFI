using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria: Stock
    {
        #region Atributos        
        private char vigente;
        private int id;
        #endregion

        #region Propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public char Vigente
        {
            get { return vigente; }
            set { vigente = value; }
        }
        #endregion

        #region Constructores
        public Categoria() { }

        public Categoria(int id, string categ, string marc, char vig) : base(categ, marc)
        {
            Vigente = vig;
            Id = id;
        }
        #endregion
    
    }
}
