using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignePaterns.NotaFiscal
{
   public interface AcaoAposGerarNota
    {
      string Executa(NotaFiscal notaFiscal);
    }
}
