using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoSolid.CalculadoraPreco
{
    public class CalculadoraPrecos
    {
        public CalculadoraPrecos(ITabelaDePreco tabela, IServicoEntrega entrega)
        {
            this.Tabela = tabela;
            this.Entrega = entrega;
        }

        private ITabelaDePreco Tabela;
        private IServicoEntrega Entrega;

        public double Calcula(Compra produto)
        {

            double desconto = this.Tabela.DescontoPara(produto.Valor);
            double frete = this.Entrega.Para(produto.Cidade);

            return produto.Valor * (1 - desconto) + frete;
        }
    }
}
