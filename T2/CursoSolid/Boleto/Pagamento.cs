namespace CursoSolid.Boleto
{
    public class Pagamento
    {
        public double Valor { get; private set; }
        private MeioDePagamento Boleto;

        public Pagamento(double valor, MeioDePagamento Boleto)
        {
            this.Valor = valor;
            this.Boleto = Boleto;
        }
    }
}