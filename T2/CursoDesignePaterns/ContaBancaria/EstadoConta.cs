using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignePaterns.ContaBancaria
{
    public interface EstadoConta
    {
        double Sacar(Conta conta, double valor);
        double Depositar(Conta conta, double valor);
    }
}
