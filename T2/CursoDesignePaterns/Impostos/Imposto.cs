using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignePaterns
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }
        public Imposto( Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;

        }

        public Imposto()
        {
            this.OutroImposto = null;
        }

        public abstract double Calcular(Orcamento orcamento);
        protected double CalcularOutroImposto(Orcamento orcamento)
        {
            return this.OutroImposto.Calcular(orcamento);
        }

    }
}
