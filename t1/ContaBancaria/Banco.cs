using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class Banco
    {
        Conta[] conta = new Conta[10];
        public int Quantidade { get; set; }

        public void Adicionar(Conta conta)
        {
            this.conta[Quantidade] = conta;
            this.Quantidade++;
          
        }
    }
}
