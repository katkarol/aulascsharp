using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Calculadora
{
    class RaizQuadrada :IExpressao
    {
        private IExpressao esquerda;

        public RaizQuadrada(IExpressao esquerda)
        {
            this.esquerda = esquerda;
        }

        public double Avalia()
        {
            double resultadoDaEsquerda = esquerda.Avalia();
            return Math.Sqrt(resultadoDaEsquerda);
        }
    }
}
