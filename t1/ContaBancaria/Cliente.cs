using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public int Idade { get; set; }
        public bool EhMaiorIdade
        {
            get
            {
                return this.Idade >= 18;
            }
        }

        public Cliente(string nomeCliente)
        {
            this.Nome = nomeCliente;
        }
        public Cliente()
        { }
    }
}
