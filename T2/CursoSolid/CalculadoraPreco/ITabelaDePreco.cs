using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoSolid.CalculadoraPreco
{
    public interface ITabelaDePreco
    {
        double DescontoPara(double valor);
    }
}
