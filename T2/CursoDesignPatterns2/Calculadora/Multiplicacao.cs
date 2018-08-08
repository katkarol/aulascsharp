using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Calculadora
{
    public class Multiplicacao : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Multiplicacao(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public double Avalia()
        {
            double resultadoDaEsquerda = Esquerda.Avalia();
            double resultadoDaDireita = Direita.Avalia();
            return resultadoDaEsquerda * resultadoDaDireita;
        }
        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeMultipliacacao(this);
        }
    }
}
