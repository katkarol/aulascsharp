using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoSolid.Salario
{
    public class CalculadorSalario
    {
        public double Calcula(Funcionario funcionario)
        {
            return funcionario.CalcularSalario();
        }
    }
}
