using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoSolid.Conta
{
    public class ContaComum
    {

        private ManipuladorSaldo manipulador;
        public ContaComum()
        {
            this.manipulador = new ManipuladorSaldo();
        }
        public virtual void SomaInvestimento()
        {
            this.manipulador.SomaInvestimento(1.1);
        }
        public virtual void Saca(double valor)
        {
            manipulador.Saca(valor);
        }
        public virtual void Deposita(double valor)
        {
            manipulador.Deposita(valor);
        }
    }
}
