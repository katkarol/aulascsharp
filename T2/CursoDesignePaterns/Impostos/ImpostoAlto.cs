using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignePaterns
{
    public class ImpostoAlto : Imposto
    {
        public ImpostoAlto(Imposto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.20 + CalcularOutroImposto(orcamento);
        }
    }
}
