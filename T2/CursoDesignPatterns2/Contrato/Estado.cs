using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Contrato
{
    class Estado
    {
        public Estado(Contrato contrato)
        {
            this.contrato = contrato;
        }

        public Contrato contrato { get; set; }

    }
}
