using Caelum.Leilao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoTDD
{
    public class Avaliador
    {
        private double maiorTodos = Double.MinValue;
        private double menorTodos = Double.MaxValue;

        public void Avalia(Leilao leilao)
        {
            foreach (var lance in leilao.Lances)
            {
                if (lance.Valor > maiorTodos)
                {
                    maiorTodos = lance.Valor;
                }
                if (lance.Valor < menorTodos)
                {
                    menorTodos = lance.Valor;
                }
            }
        }

        public double MaiorLance { get { return maiorTodos; } }
        public double MenorLance { get { return menorTodos; } }
    }
}
