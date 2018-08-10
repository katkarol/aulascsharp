using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoSolid.Conta
{
    class ContaEstudante : ContaComum
    {
        private ManipuladorSaldo manipulador;
        public int Milhas { get; private set; }

        public ContaEstudante()
        {
            manipulador = new ManipuladorSaldo();
        }
        public override void Deposita(double valor)
        {
            manipulador.Deposita(valor);
            this.Milhas += (int)valor;
        }
    }
}
