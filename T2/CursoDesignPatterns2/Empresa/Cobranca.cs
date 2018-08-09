using System;

namespace CursoDesignPatterns2.Empresa
{
    public class Cobranca
    {
        private Tipo boleto;
        private Fatura fatura;

        public Cobranca(Tipo boleto, Fatura fatura)
        {
            this.boleto = boleto;
            this.fatura = fatura;
        }

        internal void Emite()
        {
            throw new NotImplementedException();
        }
    }
}