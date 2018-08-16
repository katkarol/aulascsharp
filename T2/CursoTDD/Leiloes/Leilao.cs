using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoTDD.Leiloes
{
    public class Leilao
    {
        public string Descricao { get; set; }
        public IList<Lance> Lances { get; set; }

        public Leilao(string descricao)
        {
            this.Descricao = descricao;
            this.Lances = new List<Lance>();
        }

        public void Propoe(Lance lance)
        {
            if (Lances.Count == 0 || PodeDarLance(lance.Usuario))
            {
                Lances.Add(lance);
            }
        }
        private Lance UltimoLanceDado()
        {
            return Lances[Lances.Count - 1];
        }
        private int QtdDelancesDo(Usuario usuario)
        {
            int total = 0;
            foreach (Lance lance in Lances)
            {
                if (lance.Usuario.Equals(usuario)) total++;
            }
            return total;
        }

        private bool PodeDarLance(Usuario usuario)
        {
            return !UltimoLanceDado().Usuario.Equals(usuario)
                && QtdDelancesDo(usuario) < 5;
        }
        public void DobraLance(Usuario usuario)
        {
            Lance ultimoLance = UltimoLanceDo(usuario);
            if (ultimoLance != null)
            {
                Propoe(new Lance(usuario, ultimoLance.Valor * 2));
            }
        }

        private Lance UltimoLanceDo(Usuario usuario)
        {
            Lance ultimo = null;
            foreach (Lance lance in Lances)
            {
                if (lance.Usuario.Equals(usuario)) ultimo = lance;
            }

            return ultimo;
        }
    }
}
