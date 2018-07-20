using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    static class StringUtils
    {
        public static string Pluralizer(this string palavra)
        {
            if (palavra.EndsWith("s"))
            {
                return palavra;
            }
            return palavra + "s";
        }
    }
}
