using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoSolid.Salario
{
    public class Desenvolvedor : Cargo
    {
        public Desenvolvedor(IRegraCalculo regra) : base(regra)
        {
        }
    }
}
