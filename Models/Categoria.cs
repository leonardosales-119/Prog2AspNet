using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prog2.Models
{
    public class Categoria
    {
        public int Id  { get; set; }

        public string Definicao { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
