using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Calculadora
{
    public class Numero :IExpressao
    {
        public double Valor { get; private set; }
        public Numero(double numero)
        {
            this.Valor = numero;
        }
        public double Avalia()
        {
            return Valor;
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeNumero(this);
        }
    }
}
