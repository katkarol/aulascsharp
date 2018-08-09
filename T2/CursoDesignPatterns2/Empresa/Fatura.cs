using CursoDesignPatterns2.XML;

namespace CursoDesignPatterns2.Empresa
{
    public class Fatura
    {
        private Cliente cliente;
        private double valor;

        public Fatura(Cliente cliente, double valor)
        {
            this.cliente = cliente;
            this.valor = valor;
        }
    }
}