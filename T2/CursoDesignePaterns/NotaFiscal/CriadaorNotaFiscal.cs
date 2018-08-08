using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignePaterns.NotaFiscal
{
    class CriadorDeNotaFiscal
    {
        private String RazaoSocial;
        private String Cnpj;
        private double ValorTotal;
        private double Impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();
        private string Observacoes;

        private DateTime Data;
        public NotaFiscal Contrutor()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal, Impostos, todosItens, Observacoes);
        }

        public void ParaEmpresa(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
        }

        public void ComCnpj(String cnpj)
        {
            this.Cnpj = cnpj;
        }
        public void ComObservacoes(String observacoes)
        {
            this.Observacoes = observacoes;
        }

        public void NaDataAtual()
        {
            this.Data = DateTime.Now;
        }


        public void comItem(ItemDaNota item)
        {
            todosItens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.05;
        }
    }
}
