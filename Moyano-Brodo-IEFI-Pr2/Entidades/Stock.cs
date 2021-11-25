using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Stock
    {
        private string categoria;
        private string marca;

        public string Categoria { get => categoria; set => categoria = value; }
        public string Marca { get => marca; set => marca = value; }

        public Stock()
        {
            categoria = string.Empty;
            marca = string.Empty;
        }

        public Stock(string categ, string marc)
        {
            categoria = categ;
            marca = marc;
        }

    }

}
