using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignePaterns
{
    public class CalcularImpostos
    {
        public double RealizarCalculo(Orcamento orcamento, Imposto imposto)
        {
            return  imposto.Calcular(orcamento);
        } 
    }
}
