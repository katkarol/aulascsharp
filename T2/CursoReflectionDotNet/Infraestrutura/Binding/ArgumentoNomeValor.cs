using System;
using System.Collections.Generic;
using System.Text;

namespace CursoReflectionDotNet.Infraestrutura.Binding
{
    public class ArgumentoNomeValor
    {
        public string Nome { get; private set; }
        public string Valor { get; private set; }

        public ArgumentoNomeValor(string nome, string valor)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Valor = valor ?? throw new ArgumentNullException(nameof(valor));
        }
    }
}
