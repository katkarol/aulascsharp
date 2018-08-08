using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignePaterns
{
    public class Finalizado : EstadoOrcamento
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem descontos extras!");
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new Exception("Orçamento está em estado finalizado e não pode ser aprovado");
        }

        public void Finalizar(Orcamento orcamento)
        {
            throw new Exception("Orçamento está em estado finalizado e não pode ser reprovado");
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em estado finalizado");
        }
    }
}
