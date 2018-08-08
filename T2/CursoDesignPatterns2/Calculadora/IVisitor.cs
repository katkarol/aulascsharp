using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Calculadora
{
    public interface IVisitor
    {
        void ImprimeSoma(Soma soma);
        void ImprimeSubtracao(Subtracao subtracao);
        void ImprimeMultipliacacao(Multiplicacao multiplicacao);
        void ImprimeDivisao(Divisao divisao);
        void ImprimeNumero(Numero numero);
    }
}
