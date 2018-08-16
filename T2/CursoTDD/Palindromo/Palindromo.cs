using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoTDD.Palindromo
{
    public class Palindromo
    {
        public  bool EhPalindromo(string frase)
        {
            string fraseFiltrada = frase
                    .ToUpper().Replace(" ", "").Replace("-", "");

            for (int i = 0; i < fraseFiltrada.Length; i++)
            {
                if (fraseFiltrada[i] != fraseFiltrada[fraseFiltrada.Length - i-1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
