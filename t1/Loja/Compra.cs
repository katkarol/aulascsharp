using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
     public class Compra
    {
        public int ID { get; set; }
        public int Quantidade { get; set; }
        public int ProdutoID { get; set; }
        public Produto Produto { get; set; }
        public double Preco { get; set; }
    }
}
