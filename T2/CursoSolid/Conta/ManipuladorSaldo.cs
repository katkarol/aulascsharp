using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoSolid.Conta
{
    public class ManipuladorSaldo
    {
        public double Saldo { get; private set; }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Saca(double valor)
        {
            if (valor <= this.Saldo)
            {
                this.Saldo -= valor;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public void SomaInvestimento(double taxa)
        {
            this.Saldo *= taxa;
        }
    }
}
