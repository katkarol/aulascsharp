using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignePaterns.NotaFiscal
{
    public class Multiplicador : AcaoAposGerarNota
    {
        public double Fator { get; private set; }

        public Multiplicador(double fator)
        {
            this.Fator = fator;
        }
        public string Executa(NotaFiscal notaFiscal)
        {
            double multiplicado = notaFiscal.ValorBruto* Fator;
            return multiplicado.ToString();
        }
    }
}
