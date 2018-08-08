using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Calculadora
{
    public class Impressora : IVisitor
    {
        public void ImprimeNumero(Numero numero)
        {
            Console.Write(numero.Valor);
        }

        public void ImprimeSoma(Soma soma)
        {
            Console.Write("(");
            soma.Esquerda.Aceita(this);
            Console.Write(" + ");
            soma.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            subtracao.Esquerda.Aceita(this);
            Console.Write(" - ");
            subtracao.Direita.Aceita(this);
            Console.Write(")");
        }
        public void ImprimeMultipliacacao(Multiplicacao multiplicacao)
        {
            Console.Write("(");
            multiplicacao.Esquerda.Aceita(this);
            Console.Write(" * ");
            multiplicacao.Direita.Aceita(this);
            Console.Write(")");
        }
        public void ImprimeDivisao(Divisao divisao)
        {
            Console.Write("(");
            divisao.Esquerda.Aceita(this);
            Console.Write(" / ");
            divisao.Direita.Aceita(this);
            Console.Write(")");
        }

        
    }
}
