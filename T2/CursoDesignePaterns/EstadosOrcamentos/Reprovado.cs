using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignePaterns
{
    public class Reprovado : EstadoOrcamento
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não recebem descontos extras!");
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new Exception("Orçamento está em estado de reprovação e não pode ser aprovado");

        }

        public void Finalizar(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();

        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em estado de reprovação");

        }
    }
}
