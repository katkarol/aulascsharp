using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignePaterns.ContaBancaria
{
    public class Negativo : EstadoConta
    {
        public double Depositar(Conta conta, double valor)
        {
            valor *= 0.95;
            valor += conta.Saldo;
            return valor;
        }

        public double Sacar(Conta conta, double valor)
        {
            throw new Exception("Não há valor que possa ser sacado.");
        }

    }
}
