using CursoSolid.NotaFiscal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoSolid.Boleto
{
    class ProcessadorBoletos
    {
        public void Processa(List<Boleto> boletos, Fatura fatura)
        {

            double total = 0;

            foreach (Boleto boleto in boletos)
            {
                Pagamento pagamento = new Pagamento(boleto.Valor, MeioDePagamento.Boleto);
                fatura.AdicionaPagamento(pagamento);

                total += boleto.Valor;
            }

        }
    }
}

    public enum MeioDePagamento
    {
        Boleto
    }