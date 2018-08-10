using System.Collections.Generic;
using CursoSolid.Boleto;

namespace CursoSolid.NotaFiscal
{
    public class Fatura
    {
        public Fatura(string cliente, double valorMensal, List<Pagamento> pagamentos, bool pago)
        {
            Cliente = cliente;
            ValorMensal = valorMensal;
            Pagamentos = pagamentos;
            Pago = pago;
        }

        public string Cliente { get; set; }
        public double ValorMensal { get; private set; }
        private List<Pagamento> Pagamentos;
        private double ValorTotalPagamento()
        {
            double total =  0;
            foreach (var pag in Pagamentos)
            {
                total += pag.Valor;
            }
            return total;
        }

        public bool Pago { get; private  set; }

        public void AdicionaPagamento(Pagamento pagamento)
        {
            this.Pagamentos.Add(pagamento);
            if (ValorTotalPagamento() >= ValorMensal)
            {
                this.Pago = true;
            }
        }
    }
}