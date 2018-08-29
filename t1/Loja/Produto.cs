using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public double PrecoUnitario { get; set; }
        public string Categoria { get; set; }
        public string Unidade { get; set; }
        public IList<PromocaoProduto> Promocao { get; set; }
        public IList<Compra> Compra { get; set; }




    }
}
