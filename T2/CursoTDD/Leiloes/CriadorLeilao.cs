using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoTDD.Leiloes
{
    public class CriadorLeilao
    {
        private Leilao leilao;

        public CriadorLeilao() { }

        public CriadorLeilao Para(String descricao)
        {
            this.leilao = new Leilao(descricao);
            return this;
        }

        public CriadorLeilao Lance(Usuario usuario, double valor)
        {
            leilao.Propoe(new Lance(usuario, valor));
            return this;
        }

        public Leilao Constroi()
        {
            return leilao;
        }
    }
}

