using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignePaterns
{
    public class ICMS : Imposto
    {
        public override double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalcularOutroImposto(orcamento); 
        }

        
    }
}
