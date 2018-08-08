using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignePaterns
{
    public class EmAprovacao : EstadoOrcamento
    {
        bool descontoAplicado = false;
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            if (!this.descontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.05;
                descontoAplicado = true;
            }
            else
            {
                throw new Exception("O desconto já foi aplicado.");
            }
        }

        public void Aprovar(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Finalizar(Orcamento orcamento)
        {
            throw new Exception("Orçamento em aprovação não pode ir para finalizado diretamente");
        }

        public void Reprovar(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }
    }
}
