using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public abstract class Conta
    {
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }
        public int Numero { get; set; }
        
        public int Agencia { get; set; }


        public abstract void Sacar(double valorASacar);
            
        public abstract void Depositar(double ValorADepositar);

        public abstract void Transferir(double valor, Conta destino);
        
    }
}
