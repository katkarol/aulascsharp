using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class TotalizadorContas
    {
        public double SaldoTotal { get; private set; }
        public void Adicionar(Conta conta)
        {
            this.SaldoTotal += conta.Saldo;
        }
    }
}
