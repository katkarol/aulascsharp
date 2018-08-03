using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignePaterns
{
    public class ICCC : Imposto
    {
        public double Calcular(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000)
            {
                return orcamento.Valor * 0.05;

            }
            else if (orcamento.Valor < 3000)
            {
                return orcamento.Valor * 0.07;
            }
            return (orcamento.Valor * 0.08) - 30;
        }
    }
}
