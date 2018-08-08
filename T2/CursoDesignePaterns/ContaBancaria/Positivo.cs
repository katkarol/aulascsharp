using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignePaterns.ContaBancaria
{
    public class Positivo : EstadoConta
    {
        
        public double Depositar(Conta conta, double valor)
        {
            valor *= 0.98;
            valor += conta.Saldo;
            return valor;
        }

        
        public double Sacar(Conta conta, double valor)
        {
            valor = conta.Saldo - valor;
            return valor;
        }
    }
}
