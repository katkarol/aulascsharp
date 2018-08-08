using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignePaterns.NotaFiscal
{
    class ItemDaNotaBuilder
    {
        private double Valor;
        private string Nome;

        public ItemDaNota Construtor()
        {
            return new ItemDaNota(Nome, Valor);
        }

        public ItemDaNotaBuilder ParaNome(string nomeItem)
        {
            this.Nome = nomeItem;
            return this;
        }
        public ItemDaNotaBuilder ComValor(double valor)
        {
            this.Valor = valor;
            return this;
        }
    }
}
