using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Calculadora
{
    class Numero :IExpressao
    {
        private double numero;
        public Numero(double numero)
        {
            this.numero = numero;
        }
        public double Avalia()
        {
            return numero;
        }
    }
}
