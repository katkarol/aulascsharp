using CursoDesignPatterns2.XML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Empresa
{
    public class Servico
    {
        public Cliente BuscaCliente(String cpf)
        {
            return new ClienteDao().BuscaPorCpf(cpf);
        }

        public Fatura CriaFatura(Cliente cliente, double valor)
        {
            Fatura fatura = new Fatura(cliente, valor);
            return fatura;
        }

        public Cobranca GeraCobranca(Fatura fatura)
        {
            Cobranca cobranca = new Cobranca(Tipo.Boleto, fatura);
            cobranca.Emite();
            return cobranca;
        }

        public ContatoCliente FazContato(Cliente cliente, Cobranca cobranca)
        {
            ContatoCliente contato = new ContatoCliente(cliente, cobranca);
            contato.Dispara();
            return contato;
        }
    }

    enum Tipo
    {
        Boleto
    }
}
