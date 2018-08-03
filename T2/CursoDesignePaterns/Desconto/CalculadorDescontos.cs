using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignePaterns
{
    public class CalculadorDescontos
    {
        

        public double Calcula(Orcamento orcamento)
        {
            Desconto d1 = new DescontoCincoItens();
            Desconto d2 = new DescontoMais500Reais();
            Desconto d3 = new DescontoVendaCasada();
            Desconto d4 = new DescontoNulo();


            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;
            return d1.Desconta(orcamento);

        }
    }
}
