using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoSolid.Salario
{


    public abstract class Cargo
    {
        protected Cargo(IRegraCalculo regra)
        {
            Regra = regra;
        }

        public IRegraCalculo Regra { get; private set; }
        
    }
    
}
