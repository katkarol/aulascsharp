using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoTDD.Leiloes
{
    public class Usuario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }

        

        public Usuario( string nome)
        {
            this.Nome = nome;
        }
        public override bool Equals(Object obj)
        {
            if (this == obj)
                return true;
            if (obj == null)
                return false;
            if (GetType() != obj.GetType())
                return false;
            Usuario other = (Usuario)obj;
            if (Id != other.Id)
                return false;
            if (Nome == null)
            {
                if (other.Nome != null)
                    return false;
            }
            else if (!Nome.Equals(other.Nome))
                return false;
            return true;
        }

        public override int GetHashCode()
        {
            var hashCode = -1643562096;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            return hashCode;
        }
    }
}
