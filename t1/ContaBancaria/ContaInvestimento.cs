using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class ContaInvestimento : Conta , Tributavel
    {
        public override void Sacar(double valorASacar)
        {
            if (valorASacar > 0 && valorASacar < this.Saldo)
            {
                this.Saldo += valorASacar;

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
                this.Saldo += ValorADepositar;
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

            return this.Saldo * 0.03;
        }
    }
}
