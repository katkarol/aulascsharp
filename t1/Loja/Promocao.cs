
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    public class Promocao
    {
        public Promocao()
        {
            this.Produtos = new List<PromocaoProduto>();
        }
            public int ID { get; set; }
            public string Descricao { get; set; }
            public DateTime DataInicio { get; set; }
            public DateTime DataTermino { get; set; }
            public IList<PromocaoProduto> Produtos { get; set; }

        public void IncluirProduto(Produto produto)
        {
            this.Produtos.Add(new PromocaoProduto() { Produto = produto });
        }
    }

}
