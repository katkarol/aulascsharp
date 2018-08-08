using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignePaterns.NotaFiscal
{
    public class NotaFiscalDAO : AcaoAposGerarNota
    {
        public string Executa(NotaFiscal notaFiscal)
        {
            return "Salvo no banco";
        }
    }
}
