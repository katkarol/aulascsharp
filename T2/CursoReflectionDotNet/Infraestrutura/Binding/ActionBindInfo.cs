using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Text;

namespace CursoReflectionDotNet.Infraestrutura.Binding
{
    public class ActionBindInfo
    {
        public MethodInfo MethodInfo { get; private set; }
        public IReadOnlyCollection<ArgumentoNomeValor> TuplasArgumentoNomeValor { get;  set; }

        public ActionBindInfo(MethodInfo methodInfo, IEnumerable<ArgumentoNomeValor> tuplasArgumentoNomeValor)
        {
            MethodInfo = methodInfo ?? throw new ArgumentNullException(nameof(MethodInfo));

            if (tuplasArgumentoNomeValor == null)
                throw new ArgumentNullException(nameof(tuplasArgumentoNomeValor));

            TuplasArgumentoNomeValor =
                new ReadOnlyCollection<ArgumentoNomeValor>(tuplasArgumentoNomeValor.ToList());
        }
        public object Invoke(object controller)
        {
            var countParametros = TuplasArgumentoNomeValor.Count;
            var possuiArgumentos = countParametros > 0;
            if (!possuiArgumentos)
            {

                return MethodInfo.Invoke(controller, new object[0]);

            }
            var parametrosMethodInfo = MethodInfo.GetParameters();
            var parametrosInvoke = new object[countParametros];
            for (int i = 0; i < countParametros; i++)
            {
                var parametro = parametrosMethodInfo[i];
                var parametroNome = parametro.Name;
                var argumento = TuplasArgumentoNomeValor(tupla => tupla.Nome == parametroNome);
                parametro[i] = Convert.ChangeType(argumento.Valor, parametro.ParameterType);
            }
            return MethodInfo.Invoke(controller, parametrosInvoke);
        }
    }
}


