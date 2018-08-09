using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Pedidos
{
    public class FilaPedido
    {
        private IList<IComando> comandos = new List<IComando>();

        public void Adiciona(IComando comando)
        {
            comandos.Add(comando);
        }

        public void Processa()
        {
            foreach (IComando comando in comandos)
            {
                comando.Executa();
            }
        }
    }
}
