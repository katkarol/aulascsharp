using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class TotalizadorTributos
    {
        public double Total { get; private set; }

        public void Acumula(Tributavel t)
        {
            this.Total += t.CalcularTributo();
        }
    }
}
