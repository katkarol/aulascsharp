using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Mensagem
{
    public class MensagemAdministrativa : IMensagem
    {
        private string nome;
        public IEnviador Enviador { get ; set; }

        public MensagemAdministrativa(string nome)
        {
            this.nome = nome;
        }
        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return String.Format("Mensagem administrativa para {0}", nome);

        }
    }
}
