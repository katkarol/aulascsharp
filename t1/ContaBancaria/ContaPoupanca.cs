using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class ContaPoupanca : Conta ,Tributavel
    {
        public override void Sacar(double valorASacar)
        {
            if (valorASacar > 0 && valorASacar < this.Saldo )
            {
                this.Saldo += valorASacar + 0.1;

            }
            else
            {
                throw new SaldoInsuficienteException();
            }
        }

        public override void Depositar(double ValorADepositar)
        {
            if (ValorADepositar > 0)
            {
                this.Saldo += ValorADepositar + 0.1;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public override void Transferir(double valor, Conta destino)
        {
            this.Sacar(valor);
            destino.Depositar(valor);
        }
        public double CalcularTributo()
        {

            return this.Saldo * 0.02;
        }

    }
}
