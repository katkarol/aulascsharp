using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Calculadora
{
    public interface IExpressao
    {
        double Avalia();
        void Aceita(IVisitor visitor);
    }
}
