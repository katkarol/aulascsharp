using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignePaterns
{
    public class Orcamento
    {
        public double Valor { get;  set; }
        public IList<Item> Itens { get; private set; }
        public EstadoOrcamento EstadoAtual { get; set; }

        public Orcamento(double valor)
        {
            this.EstadoAtual = new EmAprovacao();
            this.Valor = valor;
            this.Itens = new List<Item>();
        }

        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }
        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicarDescontoExtra(this);
        }

        public void Aprova()
        {
            EstadoAtual.Aprovar(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprovar(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finalizar(this);
        }
    }
}
