using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Calculadora
{
    public class RaizQuadrada :IExpressao
    {
        public IExpressao Esquerda { get; private set; }

        public RaizQuadrada(IExpressao esquerda)
        {
            this.Esquerda = esquerda;
        }

        public double Avalia()
        {
            double resultadoDaEsquerda = Esquerda.Avalia();
            return Math.Sqrt(resultadoDaEsquerda);
        }

        public void Aceita(IVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
